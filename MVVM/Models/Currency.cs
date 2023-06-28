using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models
{
	public class Currency
	{
		[JsonProperty("market_cap_rank")]
		public int Rank { get; set; }
		[JsonProperty("id")]
		public string Id { get; set; }
		[JsonProperty("symbol")]
		public string Symbol { get; set; }
		[JsonProperty("name")]
		public string Name { get; set; }
		[JsonProperty("image")]
		public string Image { get; set; }

		[JsonProperty("current_price")]
		public decimal Price { get; set; }
		public override string ToString()
		{
			return Symbol.ToUpper();
		}
	}
}
