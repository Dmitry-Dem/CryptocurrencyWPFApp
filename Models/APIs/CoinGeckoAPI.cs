using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.Models.APIs
{
	public class CoinGeckoAPI
	{
		HttpClient _httpClient = new HttpClient();
        public CoinGeckoAPI() => _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0");
		public async Task<List<Currency>> GetAllCurrenciesAsync()
		{
			string url = "https://api.coingecko.com/api/v3/coins/list";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				if (response.IsSuccessStatusCode)
				{
					string jsonResponse = await response.Content.ReadAsStringAsync();
					var allCurrencies = JsonConvert.DeserializeObject<List<Currency>>(jsonResponse);
					
					return allCurrencies;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			return new List<Currency>();
		}
		public async Task<List<TopCurrency>> GetTopNCurrenciesAsync(int n)
		{
			string url = $"https://api.coingecko.com/api/v3/coins/markets?vs_currency=usd&order=market_cap_desc&per_page={(n < 0 ? "0" : $"{n}")}&page=1";

            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    var topNCurrencies = JsonConvert.DeserializeObject<List<TopCurrency>>(jsonResponse);
					
					return topNCurrencies;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return new List<TopCurrency>();
		}
		public async Task<Currency> GetCurrencyByNameAsync(string currencyName)
		{
			string url = $"https://api.coingecko.com/api/v3/coins/{currencyName}";

			try
			{
				HttpResponseMessage response = await _httpClient.GetAsync(url);

				if (response.IsSuccessStatusCode)
				{
					string jsonResponse = await response.Content.ReadAsStringAsync();
					var currency = JsonConvert.DeserializeObject<Currency>(jsonResponse);

					return currency;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}

			return new Currency();
		}
	}
}
