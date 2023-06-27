using Caliburn.Micro;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class CoinsViewModel : Screen
	{
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();

		private BindableCollection<Currency> _currencies;
		public BindableCollection<Currency> Currencies
		{
			get { return _currencies; }
			set { _currencies = value; NotifyOfPropertyChange(() => Currencies); }
		}
        public CoinsViewModel()
        {
			Currencies = new BindableCollection<Currency>(_APIImitation.GetAllCurrenciesAsync());
        }
    }
}
