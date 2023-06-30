using CryptocurrencyWPFApp.MVVM.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models.Interfaces
{
	public interface ICurrencyService
	{
		Task<List<string>> GetSupportedCurrenciesAsync();
		Task<List<Ticker>> GetTickersByCurrencieIdAsync(string id);
		Task<List<Currency>> GetTopNCurrenciesAsync(int topN, int pageNum);
		Task<decimal> GetCurrencyPriceByIdAsync(string id, string targetCurrencyId);
		Task<CoinPriceChartData> GetCurrencyHistorycalMarketDataAsync(string id, string days);
		Task<CurrencyDetails> GetCurrencyDetailsByIdAsync(string id, string targetCurrencyId);
	}
}