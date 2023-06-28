using Caliburn.Micro;
using CryptocurrencyWPFApp.Commands;
using CryptocurrencyWPFApp.MVVM.Models;
using CryptocurrencyWPFApp.MVVM.Models.APIs;
using CryptocurrencyWPFApp.MVVM.Models.Interfaces;
using CryptocurrencyWPFApp.MVVM.Models.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrencyWPFApp.MVVM.ViewModels
{
	public class MainViewModel : Screen
	{
		private ICommand _openPageCommand;
		public ICommand OpenPageCommand
		{
			get { return _openPageCommand; }
			set { _openPageCommand = value; NotifyOfPropertyChange(() => OpenPageCommand); }
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
		}
		private void OpenPage(string pageName)
		{
			PagePath = GetPagePathByPageName(pageName);
		}
		private static string GetPagePathByPageName(string pageName)
		{
			return $"\\MVVM\\Views\\{pageName}View.xaml";
		}
    }
}
