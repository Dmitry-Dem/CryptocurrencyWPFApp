using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CryptocurrencyWPFApp.MVVM.Models.APIs
{
	public class CoinGeckoAPIImitation
	{
		public List<Currency> GetAllCurrenciesAsync() 
		{
			string jsonResponse = @"[
                {
                    ""id"": ""01coin"",
                    ""symbol"": ""zoc"",
                    ""name"": ""01coin""
                },
                {
                    ""id"": ""0chain"",
                    ""symbol"": ""zcn"",
                    ""name"": ""Zus""
                },
                {
                    ""id"": ""0vix-protocol"",
                    ""symbol"": ""vix"",
                    ""name"": ""0VIX Protocol""
                },
                {
                    ""id"": ""0x"",
                    ""symbol"": ""zrx"",
                    ""name"": ""0x Protocol""
                },
                {
                    ""id"": ""0x0-ai-ai-smart-contract"",
                    ""symbol"": ""0x0"",
                    ""name"": ""0x0.ai: AI Smart Contract""
                },
                {
                    ""id"": ""0xauto-io-contract-auto-deployer"",
                    ""symbol"": ""0xa"",
                    ""name"": ""0xAuto.io : Contract Auto Deployer""
                },
                {
                    ""id"": ""0xdao"",
                    ""symbol"": ""oxd"",
                    ""name"": ""0xDAO""
                },
                {
                    ""id"": ""0xdao-v2"",
                    ""symbol"": ""oxd v2"",
                    ""name"": ""0xDAO V2""
                },
                {
                    ""id"": ""0xmonero"",
                    ""symbol"": ""0xmr"",
                    ""name"": ""0xMonero""
                },
                {
                    ""id"": ""0xshield"",
                    ""symbol"": ""shield"",
                    ""name"": ""0xShield""
                },
                {
                    ""id"": ""12ships"",
                    ""symbol"": ""tshp"",
                    ""name"": ""12Ships""
                },
                {
                    ""id"": ""1337"",
                    ""symbol"": ""1337"",
                    ""name"": ""Elite""
                },
                {
                    ""id"": ""14066-santa-rosa"",
                    ""symbol"": ""realt-s-14066-santa-rosa-dr-detroit-mi"",
                    ""name"": ""RealT - 14066 Santa Rosa Dr, Detroit, MI 48238""
                },
                {
                    ""id"": ""1617-s-avers"",
                    ""symbol"": ""realt-s-1617-s.avers-ave-chicago-il"",
                    ""name"": ""RealT - 1617 S Avers Ave, Chicago, IL 60623""
                },
                {
                    ""id"": ""1art"",
                    ""symbol"": ""1art"",
                    ""name"": ""OneArt""
                },
                {
                    ""id"": ""1bch"",
                    ""symbol"": ""1bch"",
                    ""name"": ""1BCH""
                },
                {
                    ""id"": ""1doge"",
                    ""symbol"": ""1doge"",
                    ""name"": ""1Doge""
                },
                {
                    ""id"": ""1eco"",
                    ""symbol"": ""1eco"",
                    ""name"": ""1eco""
                },
                {
                    ""id"": ""1hive-water"",
                    ""symbol"": ""water"",
                    ""name"": ""1Hive Water""
                }
            ]";

			try
			{
				var allCurrencies = JsonConvert.DeserializeObject<List<Currency>>(jsonResponse);

				return allCurrencies;
			}
			catch (Exception)
			{

				throw;
			}
		}
		public List<TopCurrency> GetTopNCurrenciesAsync(int n)
		{
			string jsonResponse = @"[
                {
                    ""id"": ""bitcoin"",
                    ""symbol"": ""btc"",
                    ""name"": ""Bitcoin"",
                    ""image"": ""https://assets.coingecko.com/coins/images/1/large/bitcoin.png?1547033579"",
                    ""current_price"": 30653,
                    ""market_cap"": 594714095450,
                    ""market_cap_rank"": 1,
                    ""fully_diluted_valuation"": 643380466216,
                    ""total_volume"": 9965585309,
                    ""high_24h"": 30984,
                    ""low_24h"": 30352,
                    ""price_change_24h"": -48.7645774168559,
                    ""price_change_percentage_24h"": -0.15883,
                    ""market_cap_change_24h"": -997756440.7813721,
                    ""market_cap_change_percentage_24h"": -0.16749,
                    ""circulating_supply"": 19411525.0,
                    ""total_supply"": 21000000.0,
                    ""max_supply"": 21000000.0,
                    ""ath"": 69045,
                    ""ath_change_percentage"": -55.62697,
                    ""ath_date"": ""2021-11-10T14:24:11.849Z"",
                    ""atl"": 67.81,
                    ""atl_change_percentage"": 45081.69126,
                    ""atl_date"": ""2013-07-06T00:00:00.000Z"",
                    ""roi"": null,
                    ""last_updated"": ""2023-06-25T11:51:02.955Z""
                },
                {
                    ""id"": ""ethereum"",
                    ""symbol"": ""eth"",
                    ""name"": ""Ethereum"",
                    ""image"": ""https://assets.coingecko.com/coins/images/279/large/ethereum.png?1595348880"",
                    ""current_price"": 1917.81,
                    ""market_cap"": 230418648749,
                    ""market_cap_rank"": 2,
                    ""fully_diluted_valuation"": 230418648749,
                    ""total_volume"": 6287838132,
                    ""high_24h"": 1925.7,
                    ""low_24h"": 1872.13,
                    ""price_change_24h"": 25.74,
                    ""price_change_percentage_24h"": 1.36024,
                    ""market_cap_change_24h"": 3067359550,
                    ""market_cap_change_percentage_24h"": 1.34917,
                    ""circulating_supply"": 120191632.878828,
                    ""total_supply"": 120191632.878828,
                    ""max_supply"": null,
                    ""ath"": 4878.26,
                    ""ath_change_percentage"": -60.72581,
                    ""ath_date"": ""2021-11-10T14:24:19.604Z"",
                    ""atl"": 0.432979,
                    ""atl_change_percentage"": 442392.05628,
                    ""atl_date"": ""2015-10-20T00:00:00.000Z"",
                    ""roi"": {
                        ""times"": 82.66201174159725,
                        ""currency"": ""btc"",
                        ""percentage"": 8266.201174159725
                    },
                    ""last_updated"": ""2023-06-25T11:51:08.553Z""
                },
                {
                    ""id"": ""tether"",
                    ""symbol"": ""usdt"",
                    ""name"": ""Tether"",
                    ""image"": ""https://assets.coingecko.com/coins/images/325/large/Tether.png?1668148663"",
                    ""current_price"": 1.0,
                    ""market_cap"": 83234624386,
                    ""market_cap_rank"": 3,
                    ""fully_diluted_valuation"": 83234624386,
                    ""total_volume"": 18858726698,
                    ""high_24h"": 1.003,
                    ""low_24h"": 0.998842,
                    ""price_change_24h"": -0.000622357435573262,
                    ""price_change_percentage_24h"": -0.06218,
                    ""market_cap_change_24h"": -33861149.12963867,
                    ""market_cap_change_percentage_24h"": -0.04067,
                    ""circulating_supply"": 83212018333.0169,
                    ""total_supply"": 83212018333.0169,
                    ""max_supply"": null,
                    ""ath"": 1.32,
                    ""ath_change_percentage"": -24.38776,
                    ""ath_date"": ""2018-07-24T00:00:00.000Z"",
                    ""atl"": 0.572521,
                    ""atl_change_percentage"": 74.73978,
                    ""atl_date"": ""2015-03-02T00:00:00.000Z"",
                    ""roi"": null,
                    ""last_updated"": ""2023-06-25T11:50:00.485Z""
                },
                {
                    ""id"": ""binancecoin"",
                    ""symbol"": ""bnb"",
                    ""name"": ""BNB"",
                    ""image"": ""https://assets.coingecko.com/coins/images/825/large/bnb-icon2_2x.png?1644979850"",
                    ""current_price"": 239.77,
                    ""market_cap"": 37350249343,
                    ""market_cap_rank"": 4,
                    ""fully_diluted_valuation"": 47929424622,
                    ""total_volume"": 772936882,
                    ""high_24h"": 245.91,
                    ""low_24h"": 232.36,
                    ""price_change_24h"": -5.426927715396744,
                    ""price_change_percentage_24h"": -2.21328,
                    ""market_cap_change_24h"": -859426794.8578186,
                    ""market_cap_change_percentage_24h"": -2.24924,
                    ""circulating_supply"": 155855196.0,
                    ""total_supply"": 157900174.0,
                    ""max_supply"": 200000000.0,
                    ""ath"": 686.31,
                    ""ath_change_percentage"": -65.09064,
                    ""ath_date"": ""2021-05-10T07:24:17.097Z"",
                    ""atl"": 0.0398177,
                    ""atl_change_percentage"": 601605.41933,
                    ""atl_date"": ""2017-10-19T00:00:00.000Z"",
                    ""roi"": null,
                    ""last_updated"": ""2023-06-25T11:51:07.455Z""
                },
                {
                    ""id"": ""usd-coin"",
                    ""symbol"": ""usdc"",
                    ""name"": ""USD Coin"",
                    ""image"": ""https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389"",
                    ""current_price"": 1.001,
                    ""market_cap"": 28487811443,
                    ""market_cap_rank"": 5,
                    ""fully_diluted_valuation"": 28487811443,
                    ""total_volume"": 2753665500,
                    ""high_24h"": 1.002,
                    ""low_24h"": 0.998344,
                    ""price_change_24h"": -0.000166759182765652,
                    ""price_change_percentage_24h"": -0.01666,
                    ""market_cap_change_24h"": 25411597,
                    ""market_cap_change_percentage_24h"": 0.08928,
                    ""circulating_supply"": 28471794219.6511,
                    ""total_supply"": 28471794219.6511,
                    ""max_supply"": null,
                    ""ath"": 1.17,
                    ""ath_change_percentage"": -14.6803,
                    ""ath_date"": ""2019-05-08T00:40:28.300Z"",
                    ""atl"": 0.877647,
                    ""atl_change_percentage"": 14.00368,
                    ""atl_date"": ""2023-03-11T08:02:13.981Z"",
                    ""roi"": null,
                    ""last_updated"": ""2023-06-25T11:51:03.047Z""
                }
            ]";

			try
			{
				var topNCurrencies = JsonConvert.DeserializeObject<List<TopCurrency>>(jsonResponse);

				return topNCurrencies;
			}
			catch (Exception)
			{

				throw;
			}
		}
		public Currency GetCurrencyByNameAsync(string currencyName)
		{
            string jsonResponse = @"{
                ""id"":""bitcoin"",
                ""symbol"":""btc"",
                ""name"":""Bitcoin""
                }";

			try
			{
				var currency = JsonConvert.DeserializeObject<Currency>(jsonResponse);

				return currency;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
