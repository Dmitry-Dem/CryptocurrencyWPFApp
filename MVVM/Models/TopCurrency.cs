using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models
{
	public class TopCurrency : Currency
	{
		[JsonProperty("total_volume")]
		public decimal TotalVolume { get; set; }
		[JsonProperty("total_supply")]
		public decimal TotalSupply { get; set; }
    }
}
