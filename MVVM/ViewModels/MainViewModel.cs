using Caliburn.Micro;
using CryptocurrencyWPFApp.Commands;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Views;
using CryptocurrencyWPFApp.Resources.Localization;
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

		private string _searchBox;
		private string _searchCharacter;
		private string _selectedLanguage;
		private string _navigationMainPageButton;
		private string _navigationCoinsPageButton;
		private string _navigationConverterPageButton;
		private string _navigationSearchPlaceHolderText;

		private string _imagePath = "\\Resources\\Images\\moon_icon.png";
		private string _pagePath = GetPagePathByPageName("TopCurrencies");

		private bool _isLightTheme = true;

		private ICommand _openPageCommand;
		private ICommand _changeThemeCommand;
		private ICommand _searchCurrencyDetailsPageCommand;

		private List<string> _languages;
		private Currency _selectedCurreny;
		private ObservableCollection<Currency> _currencies;
		private ObservableCollection<Currency> _filteredCurrencies;
		public string SelectedLanguage
		{
			get { return _selectedLanguage; }
			set 
			{ 
				_selectedLanguage = value; 
				NotifyOfPropertyChange(() => SelectedLanguage); 
				LoadLocalizationChange(); 
			}
		}
		public string PagePath
		{
			get { return _pagePath; }
			set { _pagePath = value; NotifyOfPropertyChange(() => PagePath); }
		}
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
		public string NavigationMainPageButton
		{
			get { return _navigationMainPageButton; }
			set { _navigationMainPageButton = value; NotifyOfPropertyChange(() => NavigationMainPageButton); }
		}
		public string NavigationCoinsPageButton
		{
			get { return _navigationCoinsPageButton; }
			set { _navigationCoinsPageButton = value; NotifyOfPropertyChange(() => NavigationCoinsPageButton); }
		}
		public string NavigationConverterPageButton
		{
			get { return _navigationConverterPageButton; }
			set { _navigationConverterPageButton = value; NotifyOfPropertyChange(() => NavigationConverterPageButton); }
		}
		public string NavigationSearchPlaceHolderText
		{
			get { return _navigationSearchPlaceHolderText; }
			set { _navigationSearchPlaceHolderText = value; NotifyOfPropertyChange(() => NavigationSearchPlaceHolderText); }
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
		public List<string> Languages
		{
			get { return _languages; }
			set { _languages = value; NotifyOfPropertyChange(() => Languages); }
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
        public MainViewModel()
        {
			OpenPageCommand = new RelayCommand<string>(OpenPage);
			ChangeThemeCommand = new RelayCommand(ChangeTheme);
			SearchCurrencyDetailsPageCommand = new RelayCommand<Currency>(SearchCurrencyDetailsPageAndOpenIfExist);
		}
		private void LoadData()
		{
			Currencies = new ObservableCollection<Currency>(_APIImitation.GetTopNCurrenciesAsync<Currency>(250, 1));

			FilteredCurrencies = Currencies;

			Languages = AppLocalization.GetSupportedLanguages();
			SelectedLanguage = Languages[0];
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
		private void LoadLocalizationChange()
		{
			AppLocalization.ChangeLanguage(SelectedLanguage);

			NavigationSearchPlaceHolderText = Properties.Resources.ResourceManager.GetString("Navigation_SearchPlaceHolder");
			NavigationMainPageButton = Properties.Resources.ResourceManager.GetString("Navigation_MainPage");
			NavigationCoinsPageButton = Properties.Resources.ResourceManager.GetString("Navigation_CoinsPage");
			NavigationConverterPageButton = Properties.Resources.ResourceManager.GetString("Navigation_ConverterPage");


			Frame frame = (Frame)Application.Current.MainWindow.FindName("mainFrame");

			if (frame != null)
			{
				frame.Navigate(new TopCurrenciesView());
			}
		}
		private void OpenPage(string pageName)
		{
			PagePath = GetPagePathByPageName(pageName);
		}
		protected override void OnViewLoaded(object view)
		{
			base.OnViewLoaded(view);

			LoadData();
			LoadLocalizationChange();
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
