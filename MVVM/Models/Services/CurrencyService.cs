using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Models.Interfaces;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models.Services
{
	public class CurrencyService : ICurrencyService
	{
		private CoinGeckoAPI _geckoAPI = new CoinGeckoAPI();
		public async Task<List<string>> GetSupportedCurrenciesAsync() => await _geckoAPI.GetSupportedCurrenciesAsync();
		public async Task<List<Ticker>> GetTickersByCurrencieIdAsync(string id) => await _geckoAPI.GetTickersByCurrencieIdAsync(id);
		public async Task<List<Currency>> GetTopNCurrenciesAsync(int topN, int pageNum) => await _geckoAPI.GetTopNCurrenciesAsync(topN, pageNum);
		public async Task<decimal> GetCurrencyPriceByIdAsync(string id, string targetCurrencyId) => await _geckoAPI.GetCurrencyPriceByIdAsync(id, targetCurrencyId);
		public async Task<CoinPriceChartData> GetCurrencyHistorycalMarketDataAsync(string id, string days) => await _geckoAPI.GetCurrencyHistorycalMarketDataAsync(id, days);
		public async Task<CurrencyDetails> GetCurrencyDetailsByIdAsync(string id, string targetCurrencyId) => await _geckoAPI.GetCurrencyDetailsByIdAsync(id, targetCurrencyId);
	}
}
