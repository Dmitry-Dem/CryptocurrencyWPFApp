using Caliburn.Micro;
using CryptocurrencyWPFApp.Commands;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Views;
using CryptocurrencyWPFApp.Resources.Themes;
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
using System.Windows.Media;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class MainViewModel : Screen
	{
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();

		private string _imagePath = "\\Resources\\Images\\moon_icon.png";
		private string _searchBox;
		private string _searchCharacter;

		private bool _isLightTheme = true;

		private ICommand _openPageCommand;
		private ICommand _changeThemeCommand;
		private ICommand _searchCurrencyDetailsPageCommand;

		private Currency _selectedCurreny;
		private ObservableCollection<Currency> _currencies;
		private ObservableCollection<Currency> _filteredCurrencies;
		public string ImagePath
		{
			get { return _imagePath; }
			set { _imagePath = value; NotifyOfPropertyChange(() => ImagePath); }
		}
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
		public ICommand ChangeThemeCommand
		{
			get { return _changeThemeCommand; }
			set { _changeThemeCommand = value; NotifyOfPropertyChange(() => ChangeThemeCommand); }
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
			ChangeThemeCommand = new RelayCommand(ChangeTheme);
			SearchCurrencyDetailsPageCommand = new RelayCommand<Currency>(SearchCurrencyDetailsPageAndOpenIfExist);

			LoadData();
		}
		private void LoadData()
		{
			Currencies = new ObservableCollection<Currency>(_APIImitation.GetTopNCurrenciesAsync<Currency>(250, 1));

			FilteredCurrencies = Currencies;
		}
		private void ChangeTheme()
		{
			AppTheme.SwitchThemeBetweenLightAndDark();

			ChangeThemeImage();
		}
		private void ChangeThemeImage()
		{
			string lightThemeImagePath = "\\Resources\\Images\\sun_icon.png";
			string darckThemeImagePath = "\\Resources\\Images\\moon_icon.png";

			ImagePath = (_isLightTheme) ? lightThemeImagePath : darckThemeImagePath;

			_isLightTheme = !_isLightTheme;
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
		private static string GetPagePathByPageName(string pageName)
		{
			return $"\\MVVM\\Views\\{pageName}View.xaml";
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
    }
}
