using Caliburn.Micro;
using CryptocurrencyWPFApp.Commands;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class MainViewModel : Screen
	{
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();

		private string _searchBox;
		private string _searchCharacter;

		private ICommand _openPageCommand;
		private ICommand _searchCurrencyDetailsPageCommand;
		private Currency _selectedCurreny;
		private ObservableCollection<Currency> _filteredCurrencies;
		private ObservableCollection<Currency> _currencies;

		public string SearchBox
		{
			get { return _searchBox; }
			set { _searchBox = value; NotifyOfPropertyChange(() => SearchBox); }
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
		public ICommand OpenPageCommand
		{
			get { return _openPageCommand; }
			set { _openPageCommand = value; NotifyOfPropertyChange(() => OpenPageCommand); }
		}
		public ICommand SearchCurrencyDetailsPageCommand
		{
			get { return _searchCurrencyDetailsPageCommand; }
			set { _searchCurrencyDetailsPageCommand = value; NotifyOfPropertyChange(() => SearchCurrencyDetailsPageCommand); }
		}
		public Currency SelectedCurrency
		{
			get { return _selectedCurreny; }
			set { _selectedCurreny = value; NotifyOfPropertyChange(() => SelectedCurrency); }
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
		public ObservableCollection<Currency> FilteredCurrencies
		{
			get { return _filteredCurrencies; }
			set
			{
				_filteredCurrencies = value;
				NotifyOfPropertyChange(() => FilteredCurrencies);
			}
		}

		private string pagePath = GetPagePathByPageName("TopCurrencies");
		public string PagePath
		{
			get { return pagePath; }
			set { pagePath = value; NotifyOfPropertyChange(() => PagePath); }
		}
        public MainViewModel()
        {
			OpenPageCommand = new RelayCommand<string>(OpenPage);
			SearchCurrencyDetailsPageCommand = new RelayCommand<Currency>(SearchCurrencyDetailsPageAndOpenIfExist);

			LoadData();
		}
		private void LoadData()
		{
			Currencies = new ObservableCollection<Currency>(_APIImitation.GetTopNCurrenciesAsync<Currency>(250, 1));

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
		private void OpenPage(string pageName)
		{
			PagePath = GetPagePathByPageName(pageName);
		}
		private void SearchCurrencyDetailsPageAndOpenIfExist(Currency currency)
		{
			if (currency != null)
			{
				Frame frame = (Frame)Application.Current.MainWindow.FindName("mainFrame");

				if (frame != null)
				{
					Application.Current.Properties["CoinDetailsId"] = currency.Id;

					frame.Navigate(new CoinDetailsView());

					SelectedCurrency = null;
				}
			}
		}
		private static string GetPagePathByPageName(string pageName)
		{
			return $"\\MVVM\\Views\\{pageName}View.xaml";
		}
    }
}
