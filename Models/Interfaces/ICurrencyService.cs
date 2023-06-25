using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.Models.Interfaces
{
	public interface ICurrencyService
	{
		Task<List<Currency>> GetAllCurrenciesAsync();
		Task<List<TopCurrency>> GetTopNCurrenciesAsync(int n);
		Task<Currency> GetCurrencyByNameAsync(string currencyName);
	}
}