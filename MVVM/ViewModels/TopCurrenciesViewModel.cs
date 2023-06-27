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

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class TopCurrenciesViewModel : Screen
	{
		private CoinGeckoAPIImitation aPIImitation = new CoinGeckoAPIImitation();

		private BindableCollection<TopCurrency> topCurrencies;
		public BindableCollection<TopCurrency> TopCurrencies
		{
			get { return topCurrencies; }
			set { topCurrencies = value; NotifyOfPropertyChange(() => TopCurrencies); }
		}
		public TopCurrenciesViewModel()
        {
			TopCurrencies = new BindableCollection<TopCurrency>(aPIImitation.GetTopNCurrenciesAsync(100));
		}
	}
}
