using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CryptocurrencyWPFApp.Resources.Themes
{
	public class AppTheme
	{
		public readonly static Uri DarckThemeUri = new Uri("Resources/Themes/DarckTheme.xaml", UriKind.Relative);
		public readonly static Uri LightThemeUri = new Uri("Resources/Themes/LightTheme.xaml", UriKind.Relative);

		private static Uri _lastUri = LightThemeUri;
		public static void ChangeTheme(Uri themeUri)
		{
			ResourceDictionary Theme = new ResourceDictionary() { Source = themeUri };

			//delete last theme
			var resDict = App.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == _lastUri);
			App.Current.Resources.MergedDictionaries.Remove(resDict);

			//add new theme
			App.Current.Resources.MergedDictionaries.Add(Theme);
		}
		public static void SwitchThemeBetweenLightAndDark()
		{
			var resourceToDelete = App.Current.Resources.MergedDictionaries.FirstOrDefault(x => x.Source == _lastUri);
			App.Current.Resources.MergedDictionaries.Remove(resourceToDelete);

			if (_lastUri == LightThemeUri)
			{
				App.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = DarckThemeUri });
				_lastUri = DarckThemeUri;
			}
			else
			{ 
				App.Current.Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = LightThemeUri });
				_lastUri = LightThemeUri;
			}
		}
	}
}
