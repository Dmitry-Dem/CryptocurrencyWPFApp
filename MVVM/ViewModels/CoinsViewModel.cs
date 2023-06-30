using Caliburn.Micro;
using CryptocurrencyWPFApp.Commands;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class CoinsViewModel : Screen
	{
		private CoinGeckoAPI _coinGeckoAPI = new CoinGeckoAPI();

		private BindableCollection<Currency> _currencies;
		public BindableCollection<Currency> Currencies
		{
			get { return _currencies; }
			set { _currencies = value; NotifyOfPropertyChange(() => Currencies); }
		}

		private ICommand openCurrencyDetailsPageByIdCommand;
		public ICommand OpenCurrencyDetailsPageByIdCommand
		{
			get { return openCurrencyDetailsPageByIdCommand; }
			set { openCurrencyDetailsPageByIdCommand = value; }
		}
		public CoinsViewModel()
        {
			openCurrencyDetailsPageByIdCommand = new RelayCommand<string>(OpenCurrencyDetailsPageById);

			LoadData();
		}
		private async void LoadData()
		{
			Currencies = new BindableCollection<Currency>(await _coinGeckoAPI.GetTopNCurrenciesAsync(250, 1));
		}
		public async void OpenCurrencyDetailsPageById(string Id)
		{
			Frame frame = (Frame)Application.Current.MainWindow.FindName("mainFrame");

			if (frame != null)
			{
				var chartData = await _coinGeckoAPI.GetCurrencyHistorycalMarketDataAsync(Id, "5");

				var coinDetails = await _coinGeckoAPI.GetCurrencyDetailsByIdAsync(Id, "usd");

				frame.Navigate(new CoinDetailsView() { DataContext = new CoinDetailsViewModel(coinDetails, chartData) });
			}
		}
	}
}
