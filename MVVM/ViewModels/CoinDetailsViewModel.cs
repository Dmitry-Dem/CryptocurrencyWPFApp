using Caliburn.Micro;
using CryptocurrencyWPFApp.Commands;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class CoinDetailsViewModel : Screen
	{
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();

		private CurrencyDetails _currency;
		public CurrencyDetails Currency
		{
			get { return _currency; }
			set { _currency = value; NotifyOfPropertyChange(() => Currency); }
		}

		private BindableCollection<Ticker> tickers;
		public BindableCollection<Ticker> Tickers
		{
			get { return tickers; }
			set { tickers = value; NotifyOfPropertyChange(() => Tickers); }
		}

		private ICommand openMarketCommand;
		public ICommand OpenMarketCommand
		{
			get { return openMarketCommand; }
			set { openMarketCommand = value; NotifyOfPropertyChange(() => OpenMarketCommand); }
		}
		public ChartValues<decimal> PriceData { get; set; } = new ChartValues<decimal>();
		public ChartValues<string> DateTimeData { get; set; } = new ChartValues<string>();
		public CoinDetailsViewModel()
        {
			string id = (string)Application.Current.Properties["CoinDetailsId"];

			_currency = _APIImitation.GetCurrencyDetailsById(id);

			Tickers = new BindableCollection<Ticker>(_APIImitation.GetTickersByCurrencieId("bitcoin"));

			openMarketCommand = new RelayCommand<string>(OpenExchanger);

			LoadChartData();
		}
		private void LoadChartData()
		{
			PriceData = new ChartValues<decimal>();

			var chartData = _APIImitation.GetCurrencyHistorycalMarketData("bitcoin", "30");

			foreach (var dataPoint in chartData.Prices)
			{
				DateTimeData.Add(DateTimeOffset.FromUnixTimeMilliseconds(dataPoint[0]).DateTime.ToString());
				PriceData.Add(dataPoint[1]);
			}
		}
		private void OpenExchanger(string link)
		{
			System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(link));
		}
	}
	
}
