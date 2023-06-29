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
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();

		private decimal _amount = 1;

		private string searchCharacter;
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
			get { return searchCharacter; }
			set
			{
				searchCharacter = value; 
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
		private void LoadData()
		{
			Currencies = new ObservableCollection<Currency>(_APIImitation.GetTopNCurrenciesAsync<Currency>(250, 1));

			SupportedCurrencies = new ObservableCollection<string>(_APIImitation.GetSupportedCurrencies());

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
		private void UpdateConvertedAmount()
		{
			if (!string.IsNullOrEmpty(SourceCurrency) && !string.IsNullOrEmpty(TargetCurrency))
			{
				try
				{
					decimal currencyPrice = _APIImitation.GetCurrencyPriceById(SourceCurrency, TargetCurrency);

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
