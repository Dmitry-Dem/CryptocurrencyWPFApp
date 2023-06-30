using CryptocurrencyWPFApp.MVVM.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models.APIs
{
	public class CoinGeckoAPI
	{
		HttpClient _httpClient = new HttpClient();
        public CoinGeckoAPI() => _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
		public async Task<List<string>> GetSupportedCurrenciesAsync()
		{
			string url = $"https://api.coingecko.com/api/v3/simple/supported_vs_currencies";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				string jsonResponse = "";

				if (response.IsSuccessStatusCode)
					jsonResponse = await response.Content.ReadAsStringAsync();
				else
					jsonResponse = APIResponceImitation.GetSupportedCurrenciesAsync();

				List<string> supportedCurrencySymbols = JsonConvert.DeserializeObject<List<string>>(jsonResponse);

				return supportedCurrencySymbols;
			}
			catch (Exception)
			{

			}

			return new List<string>();
		}
		public async Task<List<Ticker>> GetTickersByCurrencieIdAsync(string id)
		{
			string url = $"https://api.coingecko.com/api/v3/coins/{id}/tickers";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				string jsonResponse = "";

				if (response.IsSuccessStatusCode)
					jsonResponse = await response.Content.ReadAsStringAsync();
				else
					jsonResponse = APIResponceImitation.GetTickersByCurrencieIdAsync();

				JObject jsonObject = JObject.Parse(jsonResponse);

				var jsonArray = (JArray)jsonObject["tickers"];

				var tickers = new List<Ticker>();

				foreach (var jsonObj in jsonArray)
				{
					tickers.Add(new Ticker()
					{
						Base = (string)jsonObj["base"],
						Target = (string)jsonObj["target"],
						MarketName = (string)jsonObj["market"]["name"],
						TradeUrl = (string)jsonObj["trade_url"],
						PriceInUSD = (string)jsonObj["converted_last"]["usd"]
					});
				}

				return tickers;
			}
			catch (Exception)
			{

			}

			return new List<Ticker>();
		}
		public async Task<List<Currency>> GetTopNCurrenciesAsync(int topN, int pageNum)
		{
			string validatedTopN = topN > 250 ? "250" : (topN < 0 ? "1" : topN.ToString());
			string validatedpageNum = pageNum < 0 ? "1" : pageNum.ToString();

			string url = $"https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page={validatedTopN}&page={validatedpageNum}&sparkline=false&locale=en";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				string jsonResponse = "";

				if (response.IsSuccessStatusCode)
					jsonResponse = await response.Content.ReadAsStringAsync();
				else
					jsonResponse = APIResponceImitation.GetTopNCurrenciesAsync();

				var topNCurrencies = JsonConvert.DeserializeObject<List<Currency>>(jsonResponse);

				return topNCurrencies;
			}
			catch (Exception)
			{
				
			}

			return new List<Currency>();
		}
		public async Task<decimal> GetCurrencyPriceByIdAsync(string id, string targetCurrencyId)
		{
			string url = $"https://api.coingecko.com/api/v3/simple/price?ids={id}&vs_currencies={targetCurrencyId}&include_market_cap=false&include_24hr_vol=false&include_24hr_change=false&include_last_updated_at=false";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				string jsonResponse = "";

				if (response.IsSuccessStatusCode)
					jsonResponse = await response.Content.ReadAsStringAsync();
				else
					jsonResponse = APIResponceImitation.GetCurrencyPriceByIdAsync();

				CurrencyDetails currencyDetails = await GetCurrencyDetailsByIdAsync(id, targetCurrencyId);

				decimal price = currencyDetails.Price;

				return price;
			}
			catch (Exception)
			{

			}

			return -1;
		}
		public async Task<CoinPriceChartData> GetCurrencyHistorycalMarketDataAsync(string id, string days)
		{
			string url = $"https://api.coingecko.com/api/v3/coins/{id}/market_chart?vs_currency=usd&days={days}&interval=5";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				string jsonResponse = "";

				if (response.IsSuccessStatusCode)
					jsonResponse = await response.Content.ReadAsStringAsync();
				else
					jsonResponse = APIResponceImitation.GetCurrencyHistorycalMarketDataAsync();

				CoinPriceChartData chartData = JsonConvert.DeserializeObject<CoinPriceChartData>(jsonResponse);

				return chartData;
			}
			catch (Exception)
			{

			}

			return new CoinPriceChartData();
		}
		public async Task<CurrencyDetails> GetCurrencyDetailsByIdAsync(string id, string targetCurrencyId)
		{
			string url = $"https://api.coingecko.com/api/v3/coins/{id}?localization=false&tickers=false&market_data=true&community_data=false&developer_data=false&sparkline=false";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				string jsonResponse = "";

				if (response.IsSuccessStatusCode)
					jsonResponse = await response.Content.ReadAsStringAsync();
				else
					jsonResponse = APIResponceImitation.GetCurrencyDetailsByIdAsync();

				JObject jsonObject = JObject.Parse(jsonResponse);

				CurrencyDetails currency = new CurrencyDetails();
				currency.Id = (string)jsonObject["id"];
				currency.Symbol = (string)jsonObject["symbol"];
				currency.Name = (string)jsonObject["name"];
				currency.Image = (string)jsonObject["image"]["large"];
				currency.MarketCap = (decimal)jsonObject["market_data"]["market_cap"][targetCurrencyId];
				currency.Rank = (int)jsonObject["market_data"]["market_cap_rank"];
				currency.Price = (decimal)jsonObject["market_data"]["current_price"][targetCurrencyId];
				currency.FullyDilutedValuation = (decimal)jsonObject["market_data"]["fully_diluted_valuation"][targetCurrencyId];
				currency.TotalVolume = (decimal)jsonObject["market_data"]["total_volume"][targetCurrencyId];
				currency.TotalSupply = (decimal)jsonObject["market_data"]["total_supply"];
				currency.CirculatingSupply = (decimal)jsonObject["market_data"]["circulating_supply"];

				return currency;
			}
			catch (Exception)
			{

			}

			return new CurrencyDetails();
		}
	}
}
