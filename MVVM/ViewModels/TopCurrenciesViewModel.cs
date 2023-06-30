using Caliburn.Micro;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CryptocurrencyWPFApp.Commands;
using System.Windows.Controls;
using System.Windows;
using CryptocurrencyWPFApp.MVVM.Views;
using System.Windows.Markup;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class TopCurrenciesViewModel : Screen
	{
		private CoinGeckoAPI _coinGeckoAPI = new CoinGeckoAPI();

		private ICommand openCurrencyDetailsPageByIdCommand;
		public ICommand OpenCurrencyDetailsPageByIdCommand
		{
			get { return openCurrencyDetailsPageByIdCommand; }
			set { openCurrencyDetailsPageByIdCommand = value; }
		}

		private BindableCollection<Currency> topCurrencies;
		public BindableCollection<Currency> TopCurrencies
		{
			get { return topCurrencies; }
			set { topCurrencies = value; NotifyOfPropertyChange(() => TopCurrencies); }
		}
		public TopCurrenciesViewModel()
        {
			openCurrencyDetailsPageByIdCommand = new RelayCommand<string>(OpenCurrencyDetailsPageById);

			LoadData();
		}
		private async void LoadData()
		{
			TopCurrencies = new BindableCollection<Currency>(await _coinGeckoAPI.GetTopNCurrenciesAsync(100, 1));
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
