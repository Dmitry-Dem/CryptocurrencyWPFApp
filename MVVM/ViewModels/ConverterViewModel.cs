using Caliburn.Micro;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class ConverterViewModel : Screen
	{
		private CoinGeckoAPI _coinGeckoAPI = new CoinGeckoAPI();

		private decimal _amount = 1;

		private string _searchCharacter;
		private string _convertedAmountLabel;
		private string _sourceCurrency;
		private string _targetCurrency;

		private ObservableCollection<string> _supportedCurrencies;
		private ObservableCollection<Currency> _filteredCurrencies;
		private ObservableCollection<Currency> _currencies;
		public decimal Amount
		{
			get { return _amount; }
			set 
			{ 
				_amount = value; 
				NotifyOfPropertyChange(() => Amount);
				UpdateConvertedAmount();
			}
		}
		public string SearchCharacter
		{
			get { return _searchCharacter; }
			set
			{
				_searchCharacter = value; 
				NotifyOfPropertyChange(() => SearchCharacter);
				ApplySearchFilter();
			}
		}
		public string SourceCurrency
		{
			get { return _sourceCurrency; }
			set 
			{ 
				_sourceCurrency = value; 
				NotifyOfPropertyChange(() => SourceCurrency);
				UpdateConvertedAmount();
			}
		}
		public string TargetCurrency
		{
			get { return _targetCurrency; }
			set 
			{ 
				_targetCurrency = value; 
				NotifyOfPropertyChange(() => TargetCurrency);
				UpdateConvertedAmount();
			}
		}
		public string ConvertedAmountLabel
		{
			get { return _convertedAmountLabel; }
			set 
			{ 
				_convertedAmountLabel = value; 
				NotifyOfPropertyChange(() => ConvertedAmountLabel);
			}
		}
		public ObservableCollection<string> SupportedCurrencies
		{
			get { return _supportedCurrencies; }
			set { _supportedCurrencies = value; }
		}
		public ObservableCollection<Currency> FilteredCurrencies
		{
			get { return _filteredCurrencies; }
			set
			{
				_filteredCurrencies = value;
				NotifyOfPropertyChange(() => FilteredCurrencies);
			}
		}
		public ObservableCollection<Currency> Currencies
		{
			get { return _currencies; }
			set 
			{
				_currencies = value; 
				NotifyOfPropertyChange(() => Currencies);
				ApplySearchFilter();
			}
		}
        public ConverterViewModel()
        {
			LoadData();
		}
		private async void LoadData()
		{
			Currencies = new ObservableCollection<Currency>(await _coinGeckoAPI.GetTopNCurrenciesAsync(250, 1));

			SupportedCurrencies = new ObservableCollection<string>(await _coinGeckoAPI.GetSupportedCurrenciesAsync());

			NotifyOfPropertyChange(() => Currencies);
			NotifyOfPropertyChange(() => SupportedCurrencies);

			FilteredCurrencies = Currencies;
		}
		private void ApplySearchFilter()
		{
			if (string.IsNullOrEmpty(SearchCharacter))
			{
				FilteredCurrencies = Currencies;
			}
			else
			{
				FilteredCurrencies = new ObservableCollection<Currency>(Currencies.Where(c => c.Symbol.StartsWith(SearchCharacter)));
			}
		}
		private async void UpdateConvertedAmount()
		{
			if (!string.IsNullOrEmpty(SourceCurrency) && !string.IsNullOrEmpty(TargetCurrency))
			{
				try
				{
					decimal currencyPrice = await _coinGeckoAPI.GetCurrencyPriceByIdAsync(SourceCurrency, TargetCurrency);

					decimal totalAmount = Amount * currencyPrice;

					ConvertedAmountLabel = $"{SourceCurrency} {Amount} = {TargetCurrency.ToUpper()} {totalAmount}";
				}
				catch (Exception)
				{

				}
			}
			else
			{
				ConvertedAmountLabel = "uncknown";
			}
		}
	}
}
