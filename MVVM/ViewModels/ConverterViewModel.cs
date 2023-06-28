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

		private string searchCharacter;
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

		private ObservableCollection<Currency> _currencies;
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

		private ObservableCollection<Currency> filteredCurrencies;
		public ObservableCollection<Currency> FilteredCurrencies
		{
			get { return filteredCurrencies; }
			set
			{
				filteredCurrencies = value;
				NotifyOfPropertyChange(() => FilteredCurrencies);
			}
		}

		private Currency _selectedCoin;
		public Currency SelectedCoin
		{
			get { return _selectedCoin; }
			set { _selectedCoin = value; NotifyOfPropertyChange(() => SelectedCoin); }
		}
		public ConverterViewModel()
        {
			Currencies = new BindableCollection<Currency>(_APIImitation.GetAllCurrenciesAsync());
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
	}
}
