using CryptocurrencyWPFApp.Models.APIs;
using CryptocurrencyWPFApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.Models.Services
{
	public class CurrencyService : ICurrencyService
	{
		private CoinGeckoAPI _geckoAPI = new CoinGeckoAPI();
		public async Task<List<Currency>> GetAllCurrenciesAsync() => await _geckoAPI.GetAllCurrenciesAsync();
		public async Task<List<TopCurrency>> GetTopNCurrenciesAsync(int n = 10) => await _geckoAPI.GetTopNCurrenciesAsync(n);
		public async Task<Currency> GetCurrencyByNameAsync(string currencyName) => await _geckoAPI.GetCurrencyByNameAsync(currencyName);
	}
}
