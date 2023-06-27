using CryptocurrencyWPFApp.MVVM.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models.Interfaces
{
	public interface ICurrencyService
	{
		Task<List<Currency>> GetAllCurrenciesAsync();
		Task<List<TopCurrency>> GetTopNCurrenciesAsync(int n);
		Task<Currency> GetCurrencyByNameAsync(string currencyName);
	}
}