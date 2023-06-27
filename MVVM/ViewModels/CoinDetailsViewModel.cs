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
	public class CoinDetailsViewModel : Screen
	{
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();
		private BindableCollection<Ticker> tickers;
		public BindableCollection<Ticker> Tickers
		{
			get { return tickers; }
			set { tickers = value; NotifyOfPropertyChange(() => Tickers); }
		}
		public CoinDetailsViewModel()
        {
           Tickers = new BindableCollection<Ticker>(_APIImitation.GetTickersByCurrencieId("bitcoin"));
        }
    }
}
