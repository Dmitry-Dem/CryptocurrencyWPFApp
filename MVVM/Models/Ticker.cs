using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptocurrencyWPFApp.MVVM.Models
{
	public class Ticker
	{
		[JsonProperty("base")]
		public string Base { get; set; }

		[JsonProperty("target")]
		public string Target { get; set; }

		[JsonProperty("market.name")]
		public string MarketName { get; set; }
		[JsonProperty("trade_url")]
		public string TradeUrl { get; set; }
		[JsonProperty("converted_last.usd")]
		public string PriceInUSD { get; set; }
	}
}
