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
		private CoinGeckoAPIImitation _APIImitation = new CoinGeckoAPIImitation();

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
			Currencies = new BindableCollection<Currency>(_APIImitation.GetTopNCurrenciesAsync<Currency>(250, 1));

			openCurrencyDetailsPageByIdCommand = new RelayCommand<string>(OpenCurrencyDetailsPageById);
		}
		public void OpenCurrencyDetailsPageById(string Id)
		{
			Frame frame = (Frame)Application.Current.MainWindow.FindName("mainFrame");

			if (frame != null)
			{
				Application.Current.Properties["CoinDetailsId"] = Id;

				frame.Navigate(new CoinDetailsView());
			}
		}
	}
}
