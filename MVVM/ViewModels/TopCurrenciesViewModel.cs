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

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class TopCurrenciesViewModel : Screen
	{
		private CoinGeckoAPIImitation aPIImitation = new CoinGeckoAPIImitation();

		private ICommand openCurrencyDetailsPageByIdCommand;
		public ICommand OpenCurrencyDetailsPageByIdCommand
		{
			get { return openCurrencyDetailsPageByIdCommand; }
			set { openCurrencyDetailsPageByIdCommand = value; }
		}

		private BindableCollection<TopCurrency> topCurrencies;
		public BindableCollection<TopCurrency> TopCurrencies
		{
			get { return topCurrencies; }
			set { topCurrencies = value; NotifyOfPropertyChange(() => TopCurrencies); }
		}
		public TopCurrenciesViewModel()
        {
			TopCurrencies = new BindableCollection<TopCurrency>(aPIImitation.GetTopNCurrenciesAsync<TopCurrency>(100, 1));

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
