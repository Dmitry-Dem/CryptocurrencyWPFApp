using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptocurrencyWPFApp.Resources.Localization
{
	public static class AppLocalization
	{
		private static Dictionary<string, string> Languages = new Dictionary<string, string>()
		{
			{ "en", "" },
			{ "ua", "uk-UA" },
		};

		public static string CurrentAppLanguage = DefaultLanguageCode;
		public static readonly string DefaultLanguageCode = Languages["en"];
		public static void ChangeLanguage(string languageCode)
		{
			if (languageCode != CurrentAppLanguage)
			{
				if (Languages.ContainsKey(languageCode))
				{
					System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(Languages[languageCode]);
					CurrentAppLanguage = languageCode;
				}
			}
		}
		public static List<string> GetSupportedLanguages() 
		{
			return Languages.Keys.ToList();
		}
	}
}
