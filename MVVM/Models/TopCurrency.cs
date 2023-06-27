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
		[JsonProperty("market_cap_rank")]
		public int Rank { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("current_price")]
		public decimal Price { get; set; }
		[JsonProperty("total_volume")]
		public decimal TotalVolume { get; set; }
		[JsonProperty("total_supply")]
		public decimal TotalSupply { get; set; }
    }
}
