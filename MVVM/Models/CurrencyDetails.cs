using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models
{
	public class CurrencyDetails : TopCurrency
	{
		[JsonProperty("fully_diluted_valuation")]
		public decimal FullyDilutedValuation { get; set; }

		[JsonProperty("circulating_supply")]
		public decimal CirculatingSupply { get; set; }
	}
}
