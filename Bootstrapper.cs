using Caliburn.Micro;
using CryptocurrencyWPFApp.MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CryptocurrencyWPFApp
{
	public class Bootstrapper : BootstrapperBase
	{
        public Bootstrapper()
        {
            Initialize();
        }
		protected override void OnStartup(object sender, StartupEventArgs e)
		{
			DisplayRootViewForAsync<MainViewModel>();
		}
	}
}
