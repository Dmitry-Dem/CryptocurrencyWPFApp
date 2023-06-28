﻿using CryptocurrencyWPFApp.MVVM.ViewModels;
using CryptocurrencyWPFApp.MVVM.Views;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
    ""id"": ""bitcoin"",
    ""symbol"": ""btc"",
    ""name"": ""Bitcoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/1/large/bitcoin.png?1547033579"",
    ""current_price"": 30701,
    ""market_cap"": 595963281379,
    ""market_cap_rank"": 1,
    ""fully_diluted_valuation"": 644660904725,
    ""total_volume"": 10746058041,
    ""high_24h"": 30834,
    ""low_24h"": 30076,
    ""price_change_24h"": 596.33,
    ""price_change_percentage_24h"": 1.98089,
    ""market_cap_change_24h"": 11674979734,
    ""market_cap_change_percentage_24h"": 1.99815,
    ""circulating_supply"": 19413662,
    ""total_supply"": 21000000,
    ""max_supply"": 21000000,
    ""ath"": 69045,
    ""ath_change_percentage"": -55.53499,
    ""ath_date"": ""2021-11-10T14:24:11.849Z"",
    ""atl"": 67.81,
    ""atl_change_percentage"": 45175.34791,
    ""atl_date"": ""2013-07-06T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.213Z""
  },
  {
    ""id"": ""ethereum"",
    ""symbol"": ""eth"",
    ""name"": ""Ethereum"",
    ""image"": ""https://assets.coingecko.com/coins/images/279/large/ethereum.png?1595348880"",
    ""current_price"": 1898.64,
    ""market_cap"": 228071367374,
    ""market_cap_rank"": 2,
    ""fully_diluted_valuation"": 228071367374,
    ""total_volume"": 9327567682,
    ""high_24h"": 1908.47,
    ""low_24h"": 1843.72,
    ""price_change_24h"": 49.78,
    ""price_change_percentage_24h"": 2.69226,
    ""market_cap_change_24h"": 5689348936,
    ""market_cap_change_percentage_24h"": 2.55837,
    ""circulating_supply"": 120186524.966059,
    ""total_supply"": 120186524.966059,
    ""max_supply"": null,
    ""ath"": 4878.26,
    ""ath_change_percentage"": -61.12569,
    ""ath_date"": ""2021-11-10T14:24:19.604Z"",
    ""atl"": 0.432979,
    ""atl_change_percentage"": 437886.80775,
    ""atl_date"": ""2015-10-20T00:00:00.000Z"",
    ""roi"": {
      ""times"": 81.69066798183027,
      ""currency"": ""btc"",
      ""percentage"": 8169.066798183028
    },
    ""last_updated"": ""2023-06-27T17:54:27.189Z""
  },
  {
    ""id"": ""tether"",
    ""symbol"": ""usdt"",
    ""name"": ""Tether"",
    ""image"": ""https://assets.coingecko.com/coins/images/325/large/Tether.png?1668148663"",
    ""current_price"": 1,
    ""market_cap"": 83249548440,
    ""market_cap_rank"": 3,
    ""fully_diluted_valuation"": 83249548440,
    ""total_volume"": 20879086074,
    ""high_24h"": 1.003,
    ""low_24h"": 0.995923,
    ""price_change_24h"": 0.00010477,
    ""price_change_percentage_24h"": 0.01048,
    ""market_cap_change_24h"": 57091401,
    ""market_cap_change_percentage_24h"": 0.06863,
    ""circulating_supply"": 83234106505.6384,
    ""total_supply"": 83234106505.6384,
    ""max_supply"": null,
    ""ath"": 1.32,
    ""ath_change_percentage"": -24.3841,
    ""ath_date"": ""2018-07-24T00:00:00.000Z"",
    ""atl"": 0.572521,
    ""atl_change_percentage"": 74.74824,
    ""atl_date"": ""2015-03-02T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:50:01.746Z""
  },
  {
    ""id"": ""binancecoin"",
    ""symbol"": ""bnb"",
    ""name"": ""BNB"",
    ""image"": ""https://assets.coingecko.com/coins/images/825/large/bnb-icon2_2x.png?1644979850"",
    ""current_price"": 239.15,
    ""market_cap"": 37308589282,
    ""market_cap_rank"": 4,
    ""fully_diluted_valuation"": 47875964664,
    ""total_volume"": 403431312,
    ""high_24h"": 240.38,
    ""low_24h"": 234.41,
    ""price_change_24h"": 4.1,
    ""price_change_percentage_24h"": 1.74222,
    ""market_cap_change_24h"": 664430564,
    ""market_cap_change_percentage_24h"": 1.8132,
    ""circulating_supply"": 155855196,
    ""total_supply"": 157900174,
    ""max_supply"": 200000000,
    ""ath"": 686.31,
    ""ath_change_percentage"": -65.11872,
    ""ath_date"": ""2021-05-10T07:24:17.097Z"",
    ""atl"": 0.0398177,
    ""atl_change_percentage"": 601121.45434,
    ""atl_date"": ""2017-10-19T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:25.590Z""
  },
  {
    ""id"": ""usd-coin"",
    ""symbol"": ""usdc"",
    ""name"": ""USD Coin"",
    ""image"": ""https://assets.coingecko.com/coins/images/6319/large/USD_Coin_icon.png?1547042389"",
    ""current_price"": 0.999736,
    ""market_cap"": 28187230758,
    ""market_cap_rank"": 5,
    ""fully_diluted_valuation"": 28187017598,
    ""total_volume"": 3912134830,
    ""high_24h"": 1.004,
    ""low_24h"": 0.996145,
    ""price_change_24h"": -0.000289506590702704,
    ""price_change_percentage_24h"": -0.02895,
    ""market_cap_change_24h"": -155541028.67263794,
    ""market_cap_change_percentage_24h"": -0.54879,
    ""circulating_supply"": 28193959163.6642,
    ""total_supply"": 28193745952.6642,
    ""max_supply"": null,
    ""ath"": 1.17,
    ""ath_change_percentage"": -14.67145,
    ""ath_date"": ""2019-05-08T00:40:28.300Z"",
    ""atl"": 0.877647,
    ""atl_change_percentage"": 14.01549,
    ""atl_date"": ""2023-03-11T08:02:13.981Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.349Z""
  },
  {
    ""id"": ""ripple"",
    ""symbol"": ""xrp"",
    ""name"": ""XRP"",
    ""image"": ""https://assets.coingecko.com/coins/images/44/large/xrp-symbol-white-128.png?1605778731"",
    ""current_price"": 0.480525,
    ""market_cap"": 25110603275,
    ""market_cap_rank"": 6,
    ""fully_diluted_valuation"": 48054625645,
    ""total_volume"": 712930855,
    ""high_24h"": 0.484611,
    ""low_24h"": 0.474022,
    ""price_change_24h"": 0.00545481,
    ""price_change_percentage_24h"": 1.14821,
    ""market_cap_change_24h"": 277928805,
    ""market_cap_change_percentage_24h"": 1.11921,
    ""circulating_supply"": 52254289650,
    ""total_supply"": 99988655562,
    ""max_supply"": 100000000000,
    ""ath"": 3.4,
    ""ath_change_percentage"": -85.88276,
    ""ath_date"": ""2018-01-07T00:00:00.000Z"",
    ""atl"": 0.00268621,
    ""atl_change_percentage"": 17760.40131,
    ""atl_date"": ""2014-05-22T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:28.963Z""
  },
  {
    ""id"": ""staked-ether"",
    ""symbol"": ""steth"",
    ""name"": ""Lido Staked Ether"",
    ""image"": ""https://assets.coingecko.com/coins/images/13442/large/steth_logo.png?1608607546"",
    ""current_price"": 1898.76,
    ""market_cap"": 14083211463,
    ""market_cap_rank"": 7,
    ""fully_diluted_valuation"": 14083482412,
    ""total_volume"": 5754333,
    ""high_24h"": 1907.7,
    ""low_24h"": 1843.5,
    ""price_change_24h"": 50.08,
    ""price_change_percentage_24h"": 2.70912,
    ""market_cap_change_24h"": 377014075,
    ""market_cap_change_percentage_24h"": 2.75068,
    ""circulating_supply"": 7424314.60724481,
    ""total_supply"": 7424457.44438732,
    ""max_supply"": 7424457.44438732,
    ""ath"": 4829.57,
    ""ath_change_percentage"": -60.75632,
    ""ath_date"": ""2021-11-10T14:40:47.256Z"",
    ""atl"": 482.9,
    ""atl_change_percentage"": 292.4863,
    ""atl_date"": ""2020-12-22T04:08:21.854Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:22.391Z""
  },
  {
    ""id"": ""cardano"",
    ""symbol"": ""ada"",
    ""name"": ""Cardano"",
    ""image"": ""https://assets.coingecko.com/coins/images/975/large/cardano.png?1547034860"",
    ""current_price"": 0.283895,
    ""market_cap"": 9944305142,
    ""market_cap_rank"": 8,
    ""fully_diluted_valuation"": 12769110156,
    ""total_volume"": 169346443,
    ""high_24h"": 0.285804,
    ""low_24h"": 0.2783,
    ""price_change_24h"": 0.00392193,
    ""price_change_percentage_24h"": 1.40082,
    ""market_cap_change_24h"": 119085149,
    ""market_cap_change_percentage_24h"": 1.21204,
    ""circulating_supply"": 35045020830.3234,
    ""total_supply"": 45000000000,
    ""max_supply"": 45000000000,
    ""ath"": 3.09,
    ""ath_change_percentage"": -90.8292,
    ""ath_date"": ""2021-09-02T06:00:10.474Z"",
    ""atl"": 0.01925275,
    ""atl_change_percentage"": 1370.41099,
    ""atl_date"": ""2020-03-13T02:22:55.044Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.747Z""
  },
  {
    ""id"": ""dogecoin"",
    ""symbol"": ""doge"",
    ""name"": ""Dogecoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/5/large/dogecoin.png?1547792256"",
    ""current_price"": 0.065479,
    ""market_cap"": 9163516971,
    ""market_cap_rank"": 9,
    ""fully_diluted_valuation"": 9163526793,
    ""total_volume"": 256277670,
    ""high_24h"": 0.065781,
    ""low_24h"": 0.063747,
    ""price_change_24h"": 0.00065114,
    ""price_change_percentage_24h"": 1.00441,
    ""market_cap_change_24h"": 81403455,
    ""market_cap_change_percentage_24h"": 0.89631,
    ""circulating_supply"": 139942226383.705,
    ""total_supply"": 139942376383.705,
    ""max_supply"": null,
    ""ath"": 0.731578,
    ""ath_change_percentage"": -91.06107,
    ""ath_date"": ""2021-05-08T05:08:23.458Z"",
    ""atl"": 0.0000869,
    ""atl_change_percentage"": 75150.22311,
    ""atl_date"": ""2015-05-06T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.915Z""
  },
  {
    ""id"": ""tron"",
    ""symbol"": ""trx"",
    ""name"": ""TRON"",
    ""image"": ""https://assets.coingecko.com/coins/images/1094/large/tron-logo.png?1547035066"",
    ""current_price"": 0.074696,
    ""market_cap"": 6721782677,
    ""market_cap_rank"": 10,
    ""fully_diluted_valuation"": 6721783851,
    ""total_volume"": 221160856,
    ""high_24h"": 0.075118,
    ""low_24h"": 0.072629,
    ""price_change_24h"": 0.00148271,
    ""price_change_percentage_24h"": 2.0252,
    ""market_cap_change_24h"": 134202537,
    ""market_cap_change_percentage_24h"": 2.03721,
    ""circulating_supply"": 89955654903.2478,
    ""total_supply"": 89955670619.7243,
    ""max_supply"": null,
    ""ath"": 0.231673,
    ""ath_change_percentage"": -67.73171,
    ""ath_date"": ""2018-01-05T00:00:00.000Z"",
    ""atl"": 0.00180434,
    ""atl_change_percentage"": 4043.16431,
    ""atl_date"": ""2017-11-12T00:00:00.000Z"",
    ""roi"": {
      ""times"": 38.313460679937776,
      ""currency"": ""usd"",
      ""percentage"": 3831.3460679937775
    },
    ""last_updated"": ""2023-06-27T17:54:24.217Z""
  },
  {
    ""id"": ""solana"",
    ""symbol"": ""sol"",
    ""name"": ""Solana"",
    ""image"": ""https://assets.coingecko.com/coins/images/4128/large/solana.png?1640133422"",
    ""current_price"": 16.64,
    ""market_cap"": 6659427521,
    ""market_cap_rank"": 11,
    ""fully_diluted_valuation"": 9175261499,
    ""total_volume"": 248272923,
    ""high_24h"": 16.77,
    ""low_24h"": 16.03,
    ""price_change_24h"": 0.374688,
    ""price_change_percentage_24h"": 2.30338,
    ""market_cap_change_24h"": 148457722,
    ""market_cap_change_percentage_24h"": 2.28012,
    ""circulating_supply"": 399923061.257922,
    ""total_supply"": 551008124.205857,
    ""max_supply"": null,
    ""ath"": 259.96,
    ""ath_change_percentage"": -93.59212,
    ""ath_date"": ""2021-11-06T21:54:35.825Z"",
    ""atl"": 0.500801,
    ""atl_change_percentage"": 3226.24499,
    ""atl_date"": ""2020-05-11T19:35:23.449Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.967Z""
  },
  {
    ""id"": ""litecoin"",
    ""symbol"": ""ltc"",
    ""name"": ""Litecoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/2/large/litecoin.png?1547033580"",
    ""current_price"": 88.16,
    ""market_cap"": 6455541876,
    ""market_cap_rank"": 12,
    ""fully_diluted_valuation"": 7404026722,
    ""total_volume"": 437119799,
    ""high_24h"": 89.25,
    ""low_24h"": 86.24,
    ""price_change_24h"": 1.25,
    ""price_change_percentage_24h"": 1.43314,
    ""market_cap_change_24h"": 84880221,
    ""market_cap_change_percentage_24h"": 1.33236,
    ""circulating_supply"": 73239270.7334713,
    ""total_supply"": 84000000,
    ""max_supply"": 84000000,
    ""ath"": 410.26,
    ""ath_change_percentage"": -78.55305,
    ""ath_date"": ""2021-05-10T03:13:07.904Z"",
    ""atl"": 1.15,
    ""atl_change_percentage"": 7558.85981,
    ""atl_date"": ""2015-01-14T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:29.009Z""
  },
  {
    ""id"": ""polkadot"",
    ""symbol"": ""dot"",
    ""name"": ""Polkadot"",
    ""image"": ""https://assets.coingecko.com/coins/images/12171/large/polkadot.png?1639712644"",
    ""current_price"": 5.11,
    ""market_cap"": 6374462350,
    ""market_cap_rank"": 13,
    ""fully_diluted_valuation"": 6788067251,
    ""total_volume"": 112771199,
    ""high_24h"": 5.14,
    ""low_24h"": 5.01,
    ""price_change_24h"": -0.005177689067139113,
    ""price_change_percentage_24h"": -0.1012,
    ""market_cap_change_24h"": -19991852.52550316,
    ""market_cap_change_percentage_24h"": -0.31264,
    ""circulating_supply"": 1247640478.89955,
    ""total_supply"": 1328593222.58123,
    ""max_supply"": null,
    ""ath"": 54.98,
    ""ath_change_percentage"": -90.72515,
    ""ath_date"": ""2021-11-04T14:10:09.301Z"",
    ""atl"": 2.7,
    ""atl_change_percentage"": 89.04462,
    ""atl_date"": ""2020-08-20T05:48:11.359Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:29.396Z""
  },
  {
    ""id"": ""matic-network"",
    ""symbol"": ""matic"",
    ""name"": ""Polygon"",
    ""image"": ""https://assets.coingecko.com/coins/images/4713/large/matic-token-icon.png?1624446912"",
    ""current_price"": 0.668085,
    ""market_cap"": 6228868454,
    ""market_cap_rank"": 14,
    ""fully_diluted_valuation"": 6683716001,
    ""total_volume"": 190512457,
    ""high_24h"": 0.670725,
    ""low_24h"": 0.639302,
    ""price_change_24h"": 0.02596093,
    ""price_change_percentage_24h"": 4.04298,
    ""market_cap_change_24h"": 257614971,
    ""market_cap_change_percentage_24h"": 4.31425,
    ""circulating_supply"": 9319469069.28493,
    ""total_supply"": 10000000000,
    ""max_supply"": 10000000000,
    ""ath"": 2.92,
    ""ath_change_percentage"": -77.11016,
    ""ath_date"": ""2021-12-27T02:08:34.307Z"",
    ""atl"": 0.00314376,
    ""atl_change_percentage"": 21133.42321,
    ""atl_date"": ""2019-05-10T00:00:00.000Z"",
    ""roi"": {
      ""times"": 253.024620706838,
      ""currency"": ""usd"",
      ""percentage"": 25302.4620706838
    },
    ""last_updated"": ""2023-06-27T17:54:27.797Z""
  },
  {
    ""id"": ""wrapped-bitcoin"",
    ""symbol"": ""wbtc"",
    ""name"": ""Wrapped Bitcoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/7598/large/wrapped_bitcoin_wbtc.png?1548822744"",
    ""current_price"": 30687,
    ""market_cap"": 4825903887,
    ""market_cap_rank"": 15,
    ""fully_diluted_valuation"": 4825903887,
    ""total_volume"": 173230341,
    ""high_24h"": 30799,
    ""low_24h"": 30003,
    ""price_change_24h"": 646.88,
    ""price_change_percentage_24h"": 2.15335,
    ""market_cap_change_24h"": 98560496,
    ""market_cap_change_percentage_24h"": 2.0849,
    ""circulating_supply"": 157326.56582586,
    ""total_supply"": 157326.56582586,
    ""max_supply"": 157326.56582586,
    ""ath"": 70643,
    ""ath_change_percentage"": -56.61327,
    ""ath_date"": ""2021-11-10T14:40:19.650Z"",
    ""atl"": 3139.17,
    ""atl_change_percentage"": 876.36737,
    ""atl_date"": ""2019-04-02T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:25.418Z""
  },
  {
    ""id"": ""avalanche-2"",
    ""symbol"": ""avax"",
    ""name"": ""Avalanche"",
    ""image"": ""https://assets.coingecko.com/coins/images/12559/large/Avalanche_Circle_RedWhite_Trans.png?1670992574"",
    ""current_price"": 13.32,
    ""market_cap"": 4595876351,
    ""market_cap_rank"": 16,
    ""fully_diluted_valuation"": 9585544890,
    ""total_volume"": 119026711,
    ""high_24h"": 13.41,
    ""low_24h"": 13.01,
    ""price_change_24h"": 0.12739,
    ""price_change_percentage_24h"": 0.9658,
    ""market_cap_change_24h"": 36102230,
    ""market_cap_change_percentage_24h"": 0.79175,
    ""circulating_supply"": 345210523.876502,
    ""total_supply"": 431929984.655869,
    ""max_supply"": 720000000,
    ""ath"": 144.96,
    ""ath_change_percentage"": -90.82583,
    ""ath_date"": ""2021-11-21T14:18:56.538Z"",
    ""atl"": 2.8,
    ""atl_change_percentage"": 374.78332,
    ""atl_date"": ""2020-12-31T13:15:21.540Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:30.662Z""
  },
  {
    ""id"": ""shiba-inu"",
    ""symbol"": ""shib"",
    ""name"": ""Shiba Inu"",
    ""image"": ""https://assets.coingecko.com/coins/images/11939/large/shiba.png?1622619446"",
    ""current_price"": 0.0000076,
    ""market_cap"": 4479266003,
    ""market_cap_rank"": 17,
    ""fully_diluted_valuation"": 7600404106,
    ""total_volume"": 84063702,
    ""high_24h"": 0.00000765,
    ""low_24h"": 0.00000747,
    ""price_change_24h"": 7.5893e-11,
    ""price_change_percentage_24h"": 0.001,
    ""market_cap_change_24h"": 1501777,
    ""market_cap_change_percentage_24h"": 0.03354,
    ""circulating_supply"": 589339252835651.4,
    ""total_supply"": 999988943225431,
    ""max_supply"": null,
    ""ath"": 0.00008616,
    ""ath_change_percentage"": -91.18355,
    ""ath_date"": ""2021-10-28T03:54:55.568Z"",
    ""atl"": 5.6366e-11,
    ""atl_change_percentage"": 13476273.85806,
    ""atl_date"": ""2020-11-28T11:26:25.838Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.470Z""
  },
  {
    ""id"": ""bitcoin-cash"",
    ""symbol"": ""bch"",
    ""name"": ""Bitcoin Cash"",
    ""image"": ""https://assets.coingecko.com/coins/images/780/large/bitcoin-cash-circle.png?1594689492"",
    ""current_price"": 229.3,
    ""market_cap"": 4447950857,
    ""market_cap_rank"": 18,
    ""fully_diluted_valuation"": 4806659273,
    ""total_volume"": 983319076,
    ""high_24h"": 236.18,
    ""low_24h"": 216,
    ""price_change_24h"": 10.86,
    ""price_change_percentage_24h"": 4.97126,
    ""market_cap_change_24h"": 220979164,
    ""market_cap_change_percentage_24h"": 5.22784,
    ""circulating_supply"": 19432824.8966508,
    ""total_supply"": 21000000,
    ""max_supply"": 21000000,
    ""ath"": 3785.82,
    ""ath_change_percentage"": -93.96251,
    ""ath_date"": ""2017-12-20T00:00:00.000Z"",
    ""atl"": 76.93,
    ""atl_change_percentage"": 197.09382,
    ""atl_date"": ""2018-12-16T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:25.058Z""
  },
  {
    ""id"": ""dai"",
    ""symbol"": ""dai"",
    ""name"": ""Dai"",
    ""image"": ""https://assets.coingecko.com/coins/images/9956/large/Badge_Dai.png?1687143508"",
    ""current_price"": 1,
    ""market_cap"": 4421217204,
    ""market_cap_rank"": 19,
    ""fully_diluted_valuation"": 4421118249,
    ""total_volume"": 158984670,
    ""high_24h"": 1.003,
    ""low_24h"": 0.997476,
    ""price_change_24h"": 0.00114138,
    ""price_change_percentage_24h"": 0.11424,
    ""market_cap_change_24h"": -2310976.2035455704,
    ""market_cap_change_percentage_24h"": -0.05224,
    ""circulating_supply"": 4419937013.83252,
    ""total_supply"": 4419838087.15901,
    ""max_supply"": 4419838087.15901,
    ""ath"": 1.22,
    ""ath_change_percentage"": -17.93594,
    ""ath_date"": ""2020-03-13T03:02:50.373Z"",
    ""atl"": 0.88196,
    ""atl_change_percentage"": 13.41829,
    ""atl_date"": ""2023-03-11T07:50:50.514Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:50:01.637Z""
  },
  {
    ""id"": ""binance-usd"",
    ""symbol"": ""busd"",
    ""name"": ""Binance USD"",
    ""image"": ""https://assets.coingecko.com/coins/images/9576/large/BUSD.png?1568947766"",
    ""current_price"": 0.999567,
    ""market_cap"": 4186902139,
    ""market_cap_rank"": 20,
    ""fully_diluted_valuation"": 4186902139,
    ""total_volume"": 2316244997,
    ""high_24h"": 1.008,
    ""low_24h"": 0.996374,
    ""price_change_24h"": -0.000555637864648295,
    ""price_change_percentage_24h"": -0.05556,
    ""market_cap_change_24h"": -40069416.8632431,
    ""market_cap_change_percentage_24h"": -0.94795,
    ""circulating_supply"": 4188534283.66,
    ""total_supply"": 4188534283.66,
    ""max_supply"": null,
    ""ath"": 1.15,
    ""ath_change_percentage"": -13.38238,
    ""ath_date"": ""2020-03-13T02:35:42.953Z"",
    ""atl"": 0.901127,
    ""atl_change_percentage"": 10.94372,
    ""atl_date"": ""2021-05-19T13:04:37.445Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.814Z""
  },
  {
    ""id"": ""uniswap"",
    ""symbol"": ""uni"",
    ""name"": ""Uniswap"",
    ""image"": ""https://assets.coingecko.com/coins/images/12504/large/uni.jpg?1687143398"",
    ""current_price"": 5.31,
    ""market_cap"": 4002982770,
    ""market_cap_rank"": 21,
    ""fully_diluted_valuation"": 5310639148,
    ""total_volume"": 47184394,
    ""high_24h"": 5.36,
    ""low_24h"": 5.23,
    ""price_change_24h"": 0.076062,
    ""price_change_percentage_24h"": 1.45402,
    ""market_cap_change_24h"": 48400282,
    ""market_cap_change_percentage_24h"": 1.2239,
    ""circulating_supply"": 753766667,
    ""total_supply"": 1000000000,
    ""max_supply"": 1000000000,
    ""ath"": 44.92,
    ""ath_change_percentage"": -88.17714,
    ""ath_date"": ""2021-05-03T05:25:04.822Z"",
    ""atl"": 1.03,
    ""atl_change_percentage"": 415.50686,
    ""atl_date"": ""2020-09-17T01:20:38.214Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.870Z""
  },
  {
    ""id"": ""leo-token"",
    ""symbol"": ""leo"",
    ""name"": ""LEO Token"",
    ""image"": ""https://assets.coingecko.com/coins/images/8418/large/leo-token.png?1558326215"",
    ""current_price"": 3.81,
    ""market_cap"": 3538247196,
    ""market_cap_rank"": 22,
    ""fully_diluted_valuation"": 3748534644,
    ""total_volume"": 1017708,
    ""high_24h"": 3.98,
    ""low_24h"": 3.8,
    ""price_change_24h"": -0.08960076177574328,
    ""price_change_percentage_24h"": -2.2993,
    ""market_cap_change_24h"": -83382953.0765047,
    ""market_cap_change_percentage_24h"": -2.30236,
    ""circulating_supply"": 929968972.9,
    ""total_supply"": 985239504,
    ""max_supply"": null,
    ""ath"": 8.14,
    ""ath_change_percentage"": -53.2344,
    ""ath_date"": ""2022-02-08T17:40:10.285Z"",
    ""atl"": 0.799859,
    ""atl_change_percentage"": 375.65157,
    ""atl_date"": ""2019-12-24T15:14:35.376Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:18.111Z""
  },
  {
    ""id"": ""chainlink"",
    ""symbol"": ""link"",
    ""name"": ""Chainlink"",
    ""image"": ""https://assets.coingecko.com/coins/images/877/large/chainlink-new-logo.png?1547034700"",
    ""current_price"": 6.23,
    ""market_cap"": 3217828227,
    ""market_cap_rank"": 23,
    ""fully_diluted_valuation"": 6222835814,
    ""total_volume"": 157831871,
    ""high_24h"": 6.24,
    ""low_24h"": 6.03,
    ""price_change_24h"": 0.146623,
    ""price_change_percentage_24h"": 2.411,
    ""market_cap_change_24h"": 67845605,
    ""market_cap_change_percentage_24h"": 2.15384,
    ""circulating_supply"": 517099972.2305644,
    ""total_supply"": 1000000000,
    ""max_supply"": 1000000000,
    ""ath"": 52.7,
    ""ath_change_percentage"": -88.20311,
    ""ath_date"": ""2021-05-10T00:13:57.214Z"",
    ""atl"": 0.148183,
    ""atl_change_percentage"": 4095.18443,
    ""atl_date"": ""2017-11-29T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:23.506Z""
  },
  {
    ""id"": ""true-usd"",
    ""symbol"": ""tusd"",
    ""name"": ""TrueUSD"",
    ""image"": ""https://assets.coingecko.com/coins/images/3449/large/tusd.png?1618395665"",
    ""current_price"": 0.999119,
    ""market_cap"": 3136691408,
    ""market_cap_rank"": 24,
    ""fully_diluted_valuation"": 3136691408,
    ""total_volume"": 266715163,
    ""high_24h"": 1.006,
    ""low_24h"": 0.995914,
    ""price_change_24h"": -0.000275395931602973,
    ""price_change_percentage_24h"": -0.02756,
    ""market_cap_change_24h"": -1211081.3382024765,
    ""market_cap_change_percentage_24h"": -0.0386,
    ""circulating_supply"": 3139448995.87,
    ""total_supply"": 3139448995.87,
    ""max_supply"": null,
    ""ath"": 1.62,
    ""ath_change_percentage"": -38.25301,
    ""ath_date"": ""2018-08-26T20:41:09.375Z"",
    ""atl"": 0.88355,
    ""atl_change_percentage"": 13.10996,
    ""atl_date"": ""2020-03-12T10:47:51.380Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:29.133Z""
  },
  {
    ""id"": ""monero"",
    ""symbol"": ""xmr"",
    ""name"": ""Monero"",
    ""image"": ""https://assets.coingecko.com/coins/images/69/large/monero_logo.png?1547033729"",
    ""current_price"": 169.84,
    ""market_cap"": 3084647067,
    ""market_cap_rank"": 25,
    ""fully_diluted_valuation"": null,
    ""total_volume"": 83741286,
    ""high_24h"": 169.93,
    ""low_24h"": 162.23,
    ""price_change_24h"": 5.43,
    ""price_change_percentage_24h"": 3.30036,
    ""market_cap_change_24h"": 89690482,
    ""market_cap_change_percentage_24h"": 2.99472,
    ""circulating_supply"": 18147820.3764146,
    ""total_supply"": null,
    ""max_supply"": null,
    ""ath"": 542.33,
    ""ath_change_percentage"": -68.82643,
    ""ath_date"": ""2018-01-09T00:00:00.000Z"",
    ""atl"": 0.216177,
    ""atl_change_percentage"": 78105.58253,
    ""atl_date"": ""2015-01-14T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:29.116Z""
  },
  {
    ""id"": ""cosmos"",
    ""symbol"": ""atom"",
    ""name"": ""Cosmos Hub"",
    ""image"": ""https://assets.coingecko.com/coins/images/1481/large/cosmos_hub.png?1555657960"",
    ""current_price"": 9.27,
    ""market_cap"": 2712545802,
    ""market_cap_rank"": 26,
    ""fully_diluted_valuation"": null,
    ""total_volume"": 56854605,
    ""high_24h"": 9.4,
    ""low_24h"": 9.12,
    ""price_change_24h"": 0.01009442,
    ""price_change_percentage_24h"": 0.10899,
    ""market_cap_change_24h"": 1446429,
    ""market_cap_change_percentage_24h"": 0.05335,
    ""circulating_supply"": 292586163.827428,
    ""total_supply"": null,
    ""max_supply"": null,
    ""ath"": 44.45,
    ""ath_change_percentage"": -79.15191,
    ""ath_date"": ""2022-01-17T00:34:41.497Z"",
    ""atl"": 1.16,
    ""atl_change_percentage"": 698.80133,
    ""atl_date"": ""2020-03-13T02:27:44.591Z"",
    ""roi"": {
      ""times"": 91.72264673133368,
      ""currency"": ""usd"",
      ""percentage"": 9172.264673133368
    },
    ""last_updated"": ""2023-06-27T17:54:31.989Z""
  },
  {
    ""id"": ""stellar"",
    ""symbol"": ""xlm"",
    ""name"": ""Stellar"",
    ""image"": ""https://assets.coingecko.com/coins/images/100/large/Stellar_symbol_black_RGB.png?1552356157"",
    ""current_price"": 0.100436,
    ""market_cap"": 2711400654,
    ""market_cap_rank"": 27,
    ""fully_diluted_valuation"": 5033733729,
    ""total_volume"": 75928410,
    ""high_24h"": 0.100748,
    ""low_24h"": 0.091129,
    ""price_change_24h"": 0.00920836,
    ""price_change_percentage_24h"": 10.09386,
    ""market_cap_change_24h"": 254628267,
    ""market_cap_change_percentage_24h"": 10.36434,
    ""circulating_supply"": 26933263872.6068,
    ""total_supply"": 50001787300.4738,
    ""max_supply"": 50001787300.4738,
    ""ath"": 0.875563,
    ""ath_change_percentage"": -88.58743,
    ""ath_date"": ""2018-01-03T00:00:00.000Z"",
    ""atl"": 0.00047612,
    ""atl_change_percentage"": 20887.05426,
    ""atl_date"": ""2015-03-05T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.190Z""
  },
  {
    ""id"": ""okb"",
    ""symbol"": ""okb"",
    ""name"": ""OKB"",
    ""image"": ""https://assets.coingecko.com/coins/images/4463/large/WeChat_Image_20220118095654.png?1642471050"",
    ""current_price"": 44.41,
    ""market_cap"": 2667534678,
    ""market_cap_rank"": 28,
    ""fully_diluted_valuation"": 13337673392,
    ""total_volume"": 3798574,
    ""high_24h"": 44.57,
    ""low_24h"": 44.01,
    ""price_change_24h"": 0.182084,
    ""price_change_percentage_24h"": 0.4117,
    ""market_cap_change_24h"": 12889872,
    ""market_cap_change_percentage_24h"": 0.48556,
    ""circulating_supply"": 60000000,
    ""total_supply"": 235957685.3,
    ""max_supply"": 300000000,
    ""ath"": 58.66,
    ""ath_change_percentage"": -24.24836,
    ""ath_date"": ""2023-02-18T01:21:37.582Z"",
    ""atl"": 0.580608,
    ""atl_change_percentage"": 7553.16237,
    ""atl_date"": ""2019-01-14T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:08.350Z""
  },
  {
    ""id"": ""ethereum-classic"",
    ""symbol"": ""etc"",
    ""name"": ""Ethereum Classic"",
    ""image"": ""https://assets.coingecko.com/coins/images/453/large/ethereum-classic-logo.png?1547034169"",
    ""current_price"": 18.66,
    ""market_cap"": 2643749220,
    ""market_cap_rank"": 29,
    ""fully_diluted_valuation"": 3933646122,
    ""total_volume"": 129094617,
    ""high_24h"": 18.85,
    ""low_24h"": 18.18,
    ""price_change_24h"": 0.217699,
    ""price_change_percentage_24h"": 1.18028,
    ""market_cap_change_24h"": 26991781,
    ""market_cap_change_percentage_24h"": 1.0315,
    ""circulating_supply"": 141608559.445193,
    ""total_supply"": 210700000,
    ""max_supply"": 210700000,
    ""ath"": 167.09,
    ""ath_change_percentage"": -88.86045,
    ""ath_date"": ""2021-05-06T18:34:22.133Z"",
    ""atl"": 0.615038,
    ""atl_change_percentage"": 2926.24647,
    ""atl_date"": ""2016-07-25T00:00:00.000Z"",
    ""roi"": {
      ""times"": 40.4719840528164,
      ""currency"": ""usd"",
      ""percentage"": 4047.19840528164
    },
    ""last_updated"": ""2023-06-27T17:54:31.822Z""
  },
  {
    ""id"": ""the-open-network"",
    ""symbol"": ""ton"",
    ""name"": ""Toncoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/17980/large/ton_symbol.png?1670498136"",
    ""current_price"": 1.4,
    ""market_cap"": 2068572935,
    ""market_cap_rank"": 30,
    ""fully_diluted_valuation"": 7099338174,
    ""total_volume"": 9152237,
    ""high_24h"": 1.46,
    ""low_24h"": 1.4,
    ""price_change_24h"": -0.020816839611934587,
    ""price_change_percentage_24h"": -1.46097,
    ""market_cap_change_24h"": -32097952.86903,
    ""market_cap_change_percentage_24h"": -1.52799,
    ""circulating_supply"": 1473591410.74313,
    ""total_supply"": 5057362773.99687,
    ""max_supply"": null,
    ""ath"": 5.29,
    ""ath_change_percentage"": -73.4564,
    ""ath_date"": ""2021-11-12T06:50:02.476Z"",
    ""atl"": 0.519364,
    ""atl_change_percentage"": 170.40156,
    ""atl_date"": ""2021-09-21T00:33:11.092Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:23.589Z""
  },
  {
    ""id"": ""internet-computer"",
    ""symbol"": ""icp"",
    ""name"": ""Internet Computer"",
    ""image"": ""https://assets.coingecko.com/coins/images/14495/large/Internet_Computer_logo.png?1620703073"",
    ""current_price"": 4.36,
    ""market_cap"": 1908908205,
    ""market_cap_rank"": 31,
    ""fully_diluted_valuation"": 2047042050,
    ""total_volume"": 14037748,
    ""high_24h"": 4.39,
    ""low_24h"": 4.17,
    ""price_change_24h"": 0.126749,
    ""price_change_percentage_24h"": 2.99602,
    ""market_cap_change_24h"": 52886855,
    ""market_cap_change_percentage_24h"": 2.84947,
    ""circulating_supply"": 437551295.61447,
    ""total_supply"": 500021035.092445,
    ""max_supply"": 469213710,
    ""ath"": 700.65,
    ""ath_change_percentage"": -99.37719,
    ""ath_date"": ""2021-05-10T16:05:53.653Z"",
    ""atl"": 3.4,
    ""atl_change_percentage"": 28.38178,
    ""atl_date"": ""2022-12-19T22:45:01.729Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:31.689Z""
  },
  {
    ""id"": ""filecoin"",
    ""symbol"": ""fil"",
    ""name"": ""Filecoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/12817/large/filecoin.png?1602753933"",
    ""current_price"": 4.03,
    ""market_cap"": 1745231898,
    ""market_cap_rank"": 32,
    ""fully_diluted_valuation"": 7914246536,
    ""total_volume"": 61716134,
    ""high_24h"": 4.07,
    ""low_24h"": 3.91,
    ""price_change_24h"": 0.081872,
    ""price_change_percentage_24h"": 2.07259,
    ""market_cap_change_24h"": 30759309,
    ""market_cap_change_percentage_24h"": 1.7941,
    ""circulating_supply"": 432723836,
    ""total_supply"": 1962308347,
    ""max_supply"": 1962308347,
    ""ath"": 236.84,
    ""ath_change_percentage"": -98.30164,
    ""ath_date"": ""2021-04-01T13:29:41.564Z"",
    ""atl"": 2.64,
    ""atl_change_percentage"": 52.30772,
    ""atl_date"": ""2022-12-16T22:45:28.552Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.883Z""
  },
  {
    ""id"": ""lido-dao"",
    ""symbol"": ""ldo"",
    ""name"": ""Lido DAO"",
    ""image"": ""https://assets.coingecko.com/coins/images/13573/large/Lido_DAO.png?1609873644"",
    ""current_price"": 1.95,
    ""market_cap"": 1719640703,
    ""market_cap_rank"": 33,
    ""fully_diluted_valuation"": 1955112592,
    ""total_volume"": 28664160,
    ""high_24h"": 1.99,
    ""low_24h"": 1.9,
    ""price_change_24h"": 0.053883,
    ""price_change_percentage_24h"": 2.83458,
    ""market_cap_change_24h"": 45778145,
    ""market_cap_change_percentage_24h"": 2.73488,
    ""circulating_supply"": 879560957.085178,
    ""total_supply"": 1000000000,
    ""max_supply"": 1000000000,
    ""ath"": 7.3,
    ""ath_change_percentage"": -73.29632,
    ""ath_date"": ""2021-08-20T08:35:20.158Z"",
    ""atl"": 0.40615,
    ""atl_change_percentage"": 380.1519,
    ""atl_date"": ""2022-06-18T20:55:12.035Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:31.179Z""
  },
  {
    ""id"": ""hedera-hashgraph"",
    ""symbol"": ""hbar"",
    ""name"": ""Hedera"",
    ""image"": ""https://assets.coingecko.com/coins/images/3688/large/hbar.png?1637045634"",
    ""current_price"": 0.050704,
    ""market_cap"": 1610568696,
    ""market_cap_rank"": 34,
    ""fully_diluted_valuation"": 2535917104,
    ""total_volume"": 15586885,
    ""high_24h"": 0.05087,
    ""low_24h"": 0.04926661,
    ""price_change_24h"": 0.00064369,
    ""price_change_percentage_24h"": 1.28582,
    ""market_cap_change_24h"": 19588772,
    ""market_cap_change_percentage_24h"": 1.23124,
    ""circulating_supply"": 31755152663.6501,
    ""total_supply"": 50000000000,
    ""max_supply"": 50000000000,
    ""ath"": 0.569229,
    ""ath_change_percentage"": -91.10938,
    ""ath_date"": ""2021-09-15T10:40:28.318Z"",
    ""atl"": 0.00986111,
    ""atl_change_percentage"": 413.20781,
    ""atl_date"": ""2020-01-02T17:30:24.852Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.535Z""
  },
  {
    ""id"": ""arbitrum"",
    ""symbol"": ""arb"",
    ""name"": ""Arbitrum"",
    ""image"": ""https://assets.coingecko.com/coins/images/16547/large/photo_2023-03-29_21.47.00.jpeg?1680097630"",
    ""current_price"": 1.22,
    ""market_cap"": 1560587922,
    ""market_cap_rank"": 35,
    ""fully_diluted_valuation"": 12239905272,
    ""total_volume"": 357299074,
    ""high_24h"": 1.24,
    ""low_24h"": 1.13,
    ""price_change_24h"": 0.088175,
    ""price_change_percentage_24h"": 7.76868,
    ""market_cap_change_24h"": 112029741,
    ""market_cap_change_percentage_24h"": 7.73388,
    ""circulating_supply"": 1275000000,
    ""total_supply"": 10000000000,
    ""max_supply"": 10000000000,
    ""ath"": 8.67,
    ""ath_change_percentage"": -85.90619,
    ""ath_date"": ""2023-03-23T13:10:03.106Z"",
    ""atl"": 0.912886,
    ""atl_change_percentage"": 33.90426,
    ""atl_date"": ""2023-06-15T07:25:14.752Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.684Z""
  },
  {
    ""id"": ""quant-network"",
    ""symbol"": ""qnt"",
    ""name"": ""Quant"",
    ""image"": ""https://assets.coingecko.com/coins/images/3370/large/5ZOu7brX_400x400.jpg?1612437252"",
    ""current_price"": 106.94,
    ""market_cap"": 1556150556,
    ""market_cap_rank"": 36,
    ""fully_diluted_valuation"": 1563460100,
    ""total_volume"": 12186852,
    ""high_24h"": 107.22,
    ""low_24h"": 104.92,
    ""price_change_24h"": 0.855065,
    ""price_change_percentage_24h"": 0.80604,
    ""market_cap_change_24h"": 9026264,
    ""market_cap_change_percentage_24h"": 0.58342,
    ""circulating_supply"": 14544176.164091088,
    ""total_supply"": 14612493,
    ""max_supply"": 14612493,
    ""ath"": 427.42,
    ""ath_change_percentage"": -74.99947,
    ""ath_date"": ""2021-09-11T09:15:00.668Z"",
    ""atl"": 0.215773,
    ""atl_change_percentage"": 49423.19777,
    ""atl_date"": ""2018-08-23T00:00:00.000Z"",
    ""roi"": {
      ""times"": 23.219562262208285,
      ""currency"": ""eth"",
      ""percentage"": 2321.9562262208287
    },
    ""last_updated"": ""2023-06-27T17:54:26.338Z""
  },
  {
    ""id"": ""aptos"",
    ""symbol"": ""apt"",
    ""name"": ""Aptos"",
    ""image"": ""https://assets.coingecko.com/coins/images/26455/large/aptos_round.png?1666839629"",
    ""current_price"": 7.4,
    ""market_cap"": 1541766489,
    ""market_cap_rank"": 37,
    ""fully_diluted_valuation"": 7719073964,
    ""total_volume"": 63011511,
    ""high_24h"": 7.51,
    ""low_24h"": 7.24,
    ""price_change_24h"": 0.00726466,
    ""price_change_percentage_24h"": 0.09823,
    ""market_cap_change_24h"": -893273.590749979,
    ""market_cap_change_percentage_24h"": -0.0579,
    ""circulating_supply"": 208067510.38858,
    ""total_supply"": 1041719685.3775,
    ""max_supply"": null,
    ""ath"": 19.92,
    ""ath_change_percentage"": -62.84919,
    ""ath_date"": ""2023-01-26T14:25:17.390Z"",
    ""atl"": 3.08,
    ""atl_change_percentage"": 140.29485,
    ""atl_date"": ""2022-12-29T21:35:14.796Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.953Z""
  },
  {
    ""id"": ""crypto-com-chain"",
    ""symbol"": ""cro"",
    ""name"": ""Cronos"",
    ""image"": ""https://assets.coingecko.com/coins/images/7310/large/cro_token_logo.png?1669699773"",
    ""current_price"": 0.056581,
    ""market_cap"": 1478648551,
    ""market_cap_rank"": 38,
    ""fully_diluted_valuation"": 1697569782,
    ""total_volume"": 4267087,
    ""high_24h"": 0.056969,
    ""low_24h"": 0.056128,
    ""price_change_24h"": -0.000346169938280377,
    ""price_change_percentage_24h"": -0.6081,
    ""market_cap_change_24h"": -7974887.12523818,
    ""market_cap_change_percentage_24h"": -0.53644,
    ""circulating_supply"": 26131153484.3267,
    ""total_supply"": 30000000000,
    ""max_supply"": null,
    ""ath"": 0.965407,
    ""ath_change_percentage"": -94.13881,
    ""ath_date"": ""2021-11-24T15:53:54.855Z"",
    ""atl"": 0.0121196,
    ""atl_change_percentage"": 366.88305,
    ""atl_date"": ""2019-02-08T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.095Z""
  },
  {
    ""id"": ""near"",
    ""symbol"": ""near"",
    ""name"": ""NEAR Protocol"",
    ""image"": ""https://assets.coingecko.com/coins/images/10365/large/near.jpg?1683515160"",
    ""current_price"": 1.49,
    ""market_cap"": 1377207749,
    ""market_cap_rank"": 39,
    ""fully_diluted_valuation"": 1487493404,
    ""total_volume"": 72355872,
    ""high_24h"": 1.56,
    ""low_24h"": 1.46,
    ""price_change_24h"": -0.0644514955245652,
    ""price_change_percentage_24h"": -4.15681,
    ""market_cap_change_24h"": -61870449.75614977,
    ""market_cap_change_percentage_24h"": -4.29931,
    ""circulating_supply"": 925858054.475804,
    ""total_supply"": 1000000000,
    ""max_supply"": null,
    ""ath"": 20.44,
    ""ath_change_percentage"": -92.73769,
    ""ath_date"": ""2022-01-16T22:09:45.873Z"",
    ""atl"": 0.526762,
    ""atl_change_percentage"": 181.77408,
    ""atl_date"": ""2020-11-04T16:09:15.137Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:23.369Z""
  },
  {
    ""id"": ""vechain"",
    ""symbol"": ""vet"",
    ""name"": ""VeChain"",
    ""image"": ""https://assets.coingecko.com/coins/images/1167/large/VET_Token_Icon.png?1680067517"",
    ""current_price"": 0.01881038,
    ""market_cap"": 1368537860,
    ""market_cap_rank"": 40,
    ""fully_diluted_valuation"": 1631992185,
    ""total_volume"": 43471660,
    ""high_24h"": 0.0188356,
    ""low_24h"": 0.01805574,
    ""price_change_24h"": 0.00069046,
    ""price_change_percentage_24h"": 3.81051,
    ""market_cap_change_24h"": 48984607,
    ""market_cap_change_percentage_24h"": 3.71221,
    ""circulating_supply"": 72714516834,
    ""total_supply"": 85985041177,
    ""max_supply"": 86712634466,
    ""ath"": 0.280991,
    ""ath_change_percentage"": -93.31746,
    ""ath_date"": ""2021-04-19T01:08:21.675Z"",
    ""atl"": 0.00191713,
    ""atl_change_percentage"": 879.44873,
    ""atl_date"": ""2020-03-13T02:29:59.652Z"",
    ""roi"": {
      ""times"": 2.4676234837704047,
      ""currency"": ""eth"",
      ""percentage"": 246.76234837704047
    },
    ""last_updated"": ""2023-06-27T17:54:15.928Z""
  },
  {
    ""id"": ""frax"",
    ""symbol"": ""frax"",
    ""name"": ""Frax"",
    ""image"": ""https://assets.coingecko.com/coins/images/13422/large/FRAX_icon.png?1679886922"",
    ""current_price"": 0.998653,
    ""market_cap"": 1002650180,
    ""market_cap_rank"": 41,
    ""fully_diluted_valuation"": 1002650180,
    ""total_volume"": 8141381,
    ""high_24h"": 1.002,
    ""low_24h"": 0.995311,
    ""price_change_24h"": 0.00044707,
    ""price_change_percentage_24h"": 0.04479,
    ""market_cap_change_24h"": 443617,
    ""market_cap_change_percentage_24h"": 0.04426,
    ""circulating_supply"": 1004141409.40878,
    ""total_supply"": 1004141409.40878,
    ""max_supply"": 1004141409.40878,
    ""ath"": 1.14,
    ""ath_change_percentage"": -12.4216,
    ""ath_date"": ""2021-02-07T12:55:35.766Z"",
    ""atl"": 0.874536,
    ""atl_change_percentage"": 14.20782,
    ""atl_date"": ""2023-03-11T07:50:39.316Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:31.747Z""
  },
  {
    ""id"": ""paxos-standard"",
    ""symbol"": ""usdp"",
    ""name"": ""Pax Dollar"",
    ""image"": ""https://assets.coingecko.com/coins/images/6013/large/Pax_Dollar.png?1629877204"",
    ""current_price"": 1.001,
    ""market_cap"": 995196664,
    ""market_cap_rank"": 42,
    ""fully_diluted_valuation"": 995196664,
    ""total_volume"": 2124688,
    ""high_24h"": 1.006,
    ""low_24h"": 0.991624,
    ""price_change_24h"": 0.00090047,
    ""price_change_percentage_24h"": 0.09007,
    ""market_cap_change_24h"": 1158866,
    ""market_cap_change_percentage_24h"": 0.11658,
    ""circulating_supply"": 995140452.730683,
    ""total_supply"": 995140452.730683,
    ""max_supply"": null,
    ""ath"": 1.13,
    ""ath_change_percentage"": -11.33329,
    ""ath_date"": ""2018-10-15T07:09:12.459Z"",
    ""atl"": 0.863529,
    ""atl_change_percentage"": 15.78906,
    ""atl_date"": ""2021-05-19T13:14:42.046Z"",
    ""roi"": {
      ""times"": 0.000672802094613,
      ""currency"": ""usd"",
      ""percentage"": 0.0672802094613
    },
    ""last_updated"": ""2023-06-27T17:54:19.860Z""
  },
  {
    ""id"": ""the-graph"",
    ""symbol"": ""grt"",
    ""name"": ""The Graph"",
    ""image"": ""https://assets.coingecko.com/coins/images/13397/large/Graph_Token.png?1608145566"",
    ""current_price"": 0.109325,
    ""market_cap"": 990378901,
    ""market_cap_rank"": 44,
    ""fully_diluted_valuation"": 1093521057,
    ""total_volume"": 20032921,
    ""high_24h"": 0.110816,
    ""low_24h"": 0.106688,
    ""price_change_24h"": 0.00092232,
    ""price_change_percentage_24h"": 0.85083,
    ""market_cap_change_24h"": 6834874,
    ""market_cap_change_percentage_24h"": 0.69492,
    ""circulating_supply"": 9056788570.31374,
    ""total_supply"": 10000000000,
    ""max_supply"": null,
    ""ath"": 2.84,
    ""ath_change_percentage"": -96.15684,
    ""ath_date"": ""2021-02-12T07:28:45.775Z"",
    ""atl"": 0.052051,
    ""atl_change_percentage"": 109.80079,
    ""atl_date"": ""2022-11-22T10:05:03.503Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.097Z""
  },
  {
    ""id"": ""blockstack"",
    ""symbol"": ""stx"",
    ""name"": ""Stacks"",
    ""image"": ""https://assets.coingecko.com/coins/images/2069/large/Stacks_logo_full.png?1604112510"",
    ""current_price"": 0.712266,
    ""market_cap"": 989872247,
    ""market_cap_rank"": 43,
    ""fully_diluted_valuation"": 1295637754,
    ""total_volume"": 36373137,
    ""high_24h"": 0.749676,
    ""low_24h"": 0.701463,
    ""price_change_24h"": -0.011404773650459556,
    ""price_change_percentage_24h"": -1.57596,
    ""market_cap_change_24h"": -16191443.829396248,
    ""market_cap_change_percentage_24h"": -1.60939,
    ""circulating_supply"": 1388959020.08197,
    ""total_supply"": 1818000000,
    ""max_supply"": 1818000000,
    ""ath"": 3.39,
    ""ath_change_percentage"": -78.98687,
    ""ath_date"": ""2021-12-01T01:32:34.725Z"",
    ""atl"": 0.04559639,
    ""atl_change_percentage"": 1462.11615,
    ""atl_date"": ""2020-03-13T02:29:26.415Z"",
    ""roi"": {
      ""times"": 4.9355497040735665,
      ""currency"": ""usd"",
      ""percentage"": 493.5549704073567
    },
    ""last_updated"": ""2023-06-27T17:54:22.628Z""
  },
  {
    ""id"": ""rocket-pool-eth"",
    ""symbol"": ""reth"",
    ""name"": ""Rocket Pool ETH"",
    ""image"": ""https://assets.coingecko.com/coins/images/20764/large/reth.png?1637652366"",
    ""current_price"": 2041.91,
    ""market_cap"": 939950528,
    ""market_cap_rank"": 45,
    ""fully_diluted_valuation"": 939950528,
    ""total_volume"": 1591796,
    ""high_24h"": 2053.41,
    ""low_24h"": 1982.32,
    ""price_change_24h"": 55.44,
    ""price_change_percentage_24h"": 2.79106,
    ""market_cap_change_24h"": 26776925,
    ""market_cap_change_percentage_24h"": 2.93229,
    ""circulating_supply"": 460722.991097199,
    ""total_supply"": 460722.991097199,
    ""max_supply"": null,
    ""ath"": 4814.31,
    ""ath_change_percentage"": -57.66885,
    ""ath_date"": ""2021-12-01T08:03:50.749Z"",
    ""atl"": 887.26,
    ""atl_change_percentage"": 129.68972,
    ""atl_date"": ""2022-06-18T20:55:45.957Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:22.450Z""
  },
  {
    ""id"": ""aave"",
    ""symbol"": ""aave"",
    ""name"": ""Aave"",
    ""image"": ""https://assets.coingecko.com/coins/images/12645/large/AAVE.png?1601374110"",
    ""current_price"": 64.38,
    ""market_cap"": 930168311,
    ""market_cap_rank"": 46,
    ""fully_diluted_valuation"": 1030743665,
    ""total_volume"": 112433846,
    ""high_24h"": 66.53,
    ""low_24h"": 62.85,
    ""price_change_24h"": 0.689253,
    ""price_change_percentage_24h"": 1.08211,
    ""market_cap_change_24h"": 6519699,
    ""market_cap_change_percentage_24h"": 0.70586,
    ""circulating_supply"": 14438791.597233003,
    ""total_supply"": 16000000,
    ""max_supply"": 16000000,
    ""ath"": 661.69,
    ""ath_change_percentage"": -90.27605,
    ""ath_date"": ""2021-05-18T21:19:59.514Z"",
    ""atl"": 26.02,
    ""atl_change_percentage"": 147.2506,
    ""atl_date"": ""2020-11-05T09:20:11.928Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:31.218Z""
  },
  {
    ""id"": ""algorand"",
    ""symbol"": ""algo"",
    ""name"": ""Algorand"",
    ""image"": ""https://assets.coingecko.com/coins/images/4380/large/download.png?1547039725"",
    ""current_price"": 0.127222,
    ""market_cap"": 929349943,
    ""market_cap_rank"": 47,
    ""fully_diluted_valuation"": 1272993926,
    ""total_volume"": 33772250,
    ""high_24h"": 0.132461,
    ""low_24h"": 0.126893,
    ""price_change_24h"": -0.003282184588597942,
    ""price_change_percentage_24h"": -2.515,
    ""market_cap_change_24h"": -21562317.20618272,
    ""market_cap_change_percentage_24h"": -2.26754,
    ""circulating_supply"": 7300505710.54721,
    ""total_supply"": 7300505705.95521,
    ""max_supply"": 10000000000,
    ""ath"": 3.56,
    ""ath_change_percentage"": -96.42911,
    ""ath_date"": ""2019-06-20T14:51:19.480Z"",
    ""atl"": 0.098399,
    ""atl_change_percentage"": 29.23426,
    ""atl_date"": ""2023-06-10T04:31:46.997Z"",
    ""roi"": {
      ""times"": -0.9469907998429513,
      ""currency"": ""usd"",
      ""percentage"": -94.69907998429514
    },
    ""last_updated"": ""2023-06-27T17:54:32.200Z""
  },
  {
    ""id"": ""fantom"",
    ""symbol"": ""ftm"",
    ""name"": ""Fantom"",
    ""image"": ""https://assets.coingecko.com/coins/images/4001/large/Fantom_round.png?1669652346"",
    ""current_price"": 0.31177,
    ""market_cap"": 872249765,
    ""market_cap_rank"": 48,
    ""fully_diluted_valuation"": 989910027,
    ""total_volume"": 94916019,
    ""high_24h"": 0.319502,
    ""low_24h"": 0.302372,
    ""price_change_24h"": -0.00224554337141436,
    ""price_change_percentage_24h"": -0.71511,
    ""market_cap_change_24h"": -11548339.376089692,
    ""market_cap_change_percentage_24h"": -1.30667,
    ""circulating_supply"": 2797620923.2223,
    ""total_supply"": 3175000000,
    ""max_supply"": 3175000000,
    ""ath"": 3.46,
    ""ath_change_percentage"": -91.01538,
    ""ath_date"": ""2021-10-28T05:19:39.845Z"",
    ""atl"": 0.00190227,
    ""atl_change_percentage"": 16235.19936,
    ""atl_date"": ""2020-03-13T02:25:38.280Z"",
    ""roi"": {
      ""times"": 9.392329693449133,
      ""currency"": ""usd"",
      ""percentage"": 939.2329693449134
    },
    ""last_updated"": ""2023-06-27T17:54:27.541Z""
  },
  {
    ""id"": ""elrond-erd-2"",
    ""symbol"": ""egld"",
    ""name"": ""MultiversX"",
    ""image"": ""https://assets.coingecko.com/coins/images/12335/large/egld-token-logo.png?1673490885"",
    ""current_price"": 33.97,
    ""market_cap"": 870038259,
    ""market_cap_rank"": 49,
    ""fully_diluted_valuation"": 1066822725,
    ""total_volume"": 9707749,
    ""high_24h"": 34.34,
    ""low_24h"": 33.36,
    ""price_change_24h"": -0.07196055518362954,
    ""price_change_percentage_24h"": -0.21136,
    ""market_cap_change_24h"": -5364197.301845908,
    ""market_cap_change_percentage_24h"": -0.61277,
    ""circulating_supply"": 25620993,
    ""total_supply"": 25626145,
    ""max_supply"": 31415926,
    ""ath"": 545.64,
    ""ath_change_percentage"": -93.78071,
    ""ath_date"": ""2021-11-23T10:33:26.737Z"",
    ""atl"": 6.51,
    ""atl_change_percentage"": 421.54068,
    ""atl_date"": ""2020-10-07T01:44:53.554Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:23.482Z""
  },
  {
    ""id"": ""optimism"",
    ""symbol"": ""op"",
    ""name"": ""Optimism"",
    ""image"": ""https://assets.coingecko.com/coins/images/25244/large/Optimism.png?1660904599"",
    ""current_price"": 1.33,
    ""market_cap"": 858526261,
    ""market_cap_rank"": 50,
    ""fully_diluted_valuation"": 5720403447,
    ""total_volume"": 93643296,
    ""high_24h"": 1.35,
    ""low_24h"": 1.27,
    ""price_change_24h"": 0.04606898,
    ""price_change_percentage_24h"": 3.5826,
    ""market_cap_change_24h"": 28062635,
    ""market_cap_change_percentage_24h"": 3.37915,
    ""circulating_supply"": 644594782,
    ""total_supply"": 4294967296,
    ""max_supply"": 4294967296,
    ""ath"": 3.22,
    ""ath_change_percentage"": -58.65795,
    ""ath_date"": ""2023-02-24T20:20:00.509Z"",
    ""atl"": 0.402159,
    ""atl_change_percentage"": 231.34446,
    ""atl_date"": ""2022-06-18T20:54:52.178Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:30.068Z""
  },
  {
    ""id"": ""apecoin"",
    ""symbol"": ""ape"",
    ""name"": ""ApeCoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/24383/large/apecoin.jpg?1647476455"",
    ""current_price"": 2.32,
    ""market_cap"": 854756645,
    ""market_cap_rank"": 52,
    ""fully_diluted_valuation"": 2318966736,
    ""total_volume"": 80536500,
    ""high_24h"": 2.37,
    ""low_24h"": 2.29,
    ""price_change_24h"": -0.009004048504902329,
    ""price_change_percentage_24h"": -0.387,
    ""market_cap_change_24h"": -5565571.671682358,
    ""market_cap_change_percentage_24h"": -0.64692,
    ""circulating_supply"": 368593750,
    ""total_supply"": 1000000000,
    ""max_supply"": 1000000000,
    ""ath"": 26.7,
    ""ath_change_percentage"": -91.3182,
    ""ath_date"": ""2022-04-28T21:44:21.164Z"",
    ""atl"": 1.96,
    ""atl_change_percentage"": 18.15763,
    ""atl_date"": ""2023-06-19T04:02:16.512Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:28.600Z""
  },
  {
    ""id"": ""radix"",
    ""symbol"": ""xrd"",
    ""name"": ""Radix"",
    ""image"": ""https://assets.coingecko.com/coins/images/4374/large/Radix.png?1629701658"",
    ""current_price"": 0.083558,
    ""market_cap"": 852798012,
    ""market_cap_rank"": 51,
    ""fully_diluted_valuation"": 2006529272,
    ""total_volume"": 3974167,
    ""high_24h"": 0.086257,
    ""low_24h"": 0.080006,
    ""price_change_24h"": 0.00342292,
    ""price_change_percentage_24h"": 4.27141,
    ""market_cap_change_24h"": 36368952,
    ""market_cap_change_percentage_24h"": 4.45464,
    ""circulating_supply"": 10200275960.9862,
    ""total_supply"": 12600275957.7811,
    ""max_supply"": 24000000000,
    ""ath"": 0.651264,
    ""ath_change_percentage"": -87.11972,
    ""ath_date"": ""2021-11-14T16:09:27.130Z"",
    ""atl"": 0.03145312,
    ""atl_change_percentage"": 166.69709,
    ""atl_date"": ""2022-11-29T23:20:09.754Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:53:59.147Z""
  },
  {
    ""id"": ""the-sandbox"",
    ""symbol"": ""sand"",
    ""name"": ""The Sandbox"",
    ""image"": ""https://assets.coingecko.com/coins/images/12129/large/sandbox_logo.jpg?1597397942"",
    ""current_price"": 0.429524,
    ""market_cap"": 802854177,
    ""market_cap_rank"": 53,
    ""fully_diluted_valuation"": 1288186021,
    ""total_volume"": 39848430,
    ""high_24h"": 0.431112,
    ""low_24h"": 0.420375,
    ""price_change_24h"": 0.0070624,
    ""price_change_percentage_24h"": 1.67172,
    ""market_cap_change_24h"": 11854159,
    ""market_cap_change_percentage_24h"": 1.49863,
    ""circulating_supply"": 1869731926.2233226,
    ""total_supply"": 3000000000,
    ""max_supply"": 3000000000,
    ""ath"": 8.4,
    ""ath_change_percentage"": -94.89029,
    ""ath_date"": ""2021-11-25T06:04:40.957Z"",
    ""atl"": 0.02897764,
    ""atl_change_percentage"": 1380.62969,
    ""atl_date"": ""2020-11-04T15:59:14.441Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:21.834Z""
  },
  {
    ""id"": ""eos"",
    ""symbol"": ""eos"",
    ""name"": ""EOS"",
    ""image"": ""https://assets.coingecko.com/coins/images/738/large/eos-eos-logo.png?1547034481"",
    ""current_price"": 0.719216,
    ""market_cap"": 798991145,
    ""market_cap_rank"": 54,
    ""fully_diluted_valuation"": null,
    ""total_volume"": 86238289,
    ""high_24h"": 0.732106,
    ""low_24h"": 0.703984,
    ""price_change_24h"": 0.00060388,
    ""price_change_percentage_24h"": 0.08403,
    ""market_cap_change_24h"": -294388.65988755226,
    ""market_cap_change_percentage_24h"": -0.03683,
    ""circulating_supply"": 1110735445.2465,
    ""total_supply"": null,
    ""max_supply"": null,
    ""ath"": 22.71,
    ""ath_change_percentage"": -96.83976,
    ""ath_date"": ""2018-04-29T07:50:33.540Z"",
    ""atl"": 0.5024,
    ""atl_change_percentage"": 42.86064,
    ""atl_date"": ""2017-10-23T00:00:00.000Z"",
    ""roi"": {
      ""times"": -0.27351964283828506,
      ""currency"": ""usd"",
      ""percentage"": -27.351964283828504
    },
    ""last_updated"": ""2023-06-27T17:54:24.975Z""
  },
  {
    ""id"": ""immutable-x"",
    ""symbol"": ""imx"",
    ""name"": ""ImmutableX"",
    ""image"": ""https://assets.coingecko.com/coins/images/17233/large/immutableX-symbol-BLK-RGB.png?1665110648"",
    ""current_price"": 0.753405,
    ""market_cap"": 783751225,
    ""market_cap_rank"": 55,
    ""fully_diluted_valuation"": 1506655398,
    ""total_volume"": 17453021,
    ""high_24h"": 0.759051,
    ""low_24h"": 0.716727,
    ""price_change_24h"": 0.01587863,
    ""price_change_percentage_24h"": 2.15296,
    ""market_cap_change_24h"": 13141394,
    ""market_cap_change_percentage_24h"": 1.70532,
    ""circulating_supply"": 1040385513.4100242,
    ""total_supply"": 2000000000,
    ""max_supply"": 2000000000,
    ""ath"": 9.52,
    ""ath_change_percentage"": -92.08713,
    ""ath_date"": ""2021-11-26T01:03:01.536Z"",
    ""atl"": 0.378055,
    ""atl_change_percentage"": 99.2568,
    ""atl_date"": ""2022-12-31T07:36:37.649Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:32.394Z""
  },
  {
    ""id"": ""render-token"",
    ""symbol"": ""rndr"",
    ""name"": ""Render"",
    ""image"": ""https://assets.coingecko.com/coins/images/11636/large/rndr.png?1638840934"",
    ""current_price"": 2.08,
    ""market_cap"": 768255429,
    ""market_cap_rank"": 56,
    ""fully_diluted_valuation"": 1106029755,
    ""total_volume"": 35020705,
    ""high_24h"": 2.11,
    ""low_24h"": 2.01,
    ""price_change_24h"": 0.04993144,
    ""price_change_percentage_24h"": 2.45533,
    ""market_cap_change_24h"": 17318147,
    ""market_cap_change_percentage_24h"": 2.3062,
    ""circulating_supply"": 368852897.108796,
    ""total_supply"": 531024271.388796,
    ""max_supply"": 531024271.388796,
    ""ath"": 8.78,
    ""ath_change_percentage"": -76.29863,
    ""ath_date"": ""2021-11-21T10:03:19.097Z"",
    ""atl"": 0.03665669,
    ""atl_change_percentage"": 5578.89175,
    ""atl_date"": ""2020-06-16T13:22:25.900Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:31.486Z""
  },
  {
    ""id"": ""tezos"",
    ""symbol"": ""xtz"",
    ""name"": ""Tezos"",
    ""image"": ""https://assets.coingecko.com/coins/images/976/large/Tezos-logo.png?1547034862"",
    ""current_price"": 0.805507,
    ""market_cap"": 753016624,
    ""market_cap_rank"": 57,
    ""fully_diluted_valuation"": null,
    ""total_volume"": 14338769,
    ""high_24h"": 0.808293,
    ""low_24h"": 0.790602,
    ""price_change_24h"": 0.00702382,
    ""price_change_percentage_24h"": 0.87965,
    ""market_cap_change_24h"": 6616589,
    ""market_cap_change_percentage_24h"": 0.88647,
    ""circulating_supply"": 934972912.641193,
    ""total_supply"": null,
    ""max_supply"": null,
    ""ath"": 9.12,
    ""ath_change_percentage"": -91.17752,
    ""ath_date"": ""2021-10-04T00:41:18.025Z"",
    ""atl"": 0.350476,
    ""atl_change_percentage"": 129.4773,
    ""atl_date"": ""2018-12-07T00:00:00.000Z"",
    ""roi"": {
      ""times"": 0.7138446350408817,
      ""currency"": ""usd"",
      ""percentage"": 71.38446350408817
    },
    ""last_updated"": ""2023-06-27T17:54:20.160Z""
  },
  {
    ""id"": ""theta-token"",
    ""symbol"": ""theta"",
    ""name"": ""Theta Network"",
    ""image"": ""https://assets.coingecko.com/coins/images/2538/large/theta-token-logo.png?1548387191"",
    ""current_price"": 0.747894,
    ""market_cap"": 748436046,
    ""market_cap_rank"": 58,
    ""fully_diluted_valuation"": 748436046,
    ""total_volume"": 8045439,
    ""high_24h"": 0.756411,
    ""low_24h"": 0.725908,
    ""price_change_24h"": 0.01684627,
    ""price_change_percentage_24h"": 2.3044,
    ""market_cap_change_24h"": 16427478,
    ""market_cap_change_percentage_24h"": 2.24416,
    ""circulating_supply"": 1000000000,
    ""total_supply"": 1000000000,
    ""max_supply"": 1000000000,
    ""ath"": 15.72,
    ""ath_change_percentage"": -95.24296,
    ""ath_date"": ""2021-04-16T13:15:11.190Z"",
    ""atl"": 0.04039979,
    ""atl_change_percentage"": 1750.98218,
    ""atl_date"": ""2020-03-13T02:24:16.483Z"",
    ""roi"": {
      ""times"": 3.9859580425935173,
      ""currency"": ""usd"",
      ""percentage"": 398.5958042593517
    },
    ""last_updated"": ""2023-06-27T17:54:24.087Z""
  },
  {
    ""id"": ""rocket-pool"",
    ""symbol"": ""rpl"",
    ""name"": ""Rocket Pool"",
    ""image"": ""https://assets.coingecko.com/coins/images/2090/large/rocket_pool_%28RPL%29.png?1637662441"",
    ""current_price"": 38.1,
    ""market_cap"": 741780108,
    ""market_cap_rank"": 59,
    ""fully_diluted_valuation"": 741780108,
    ""total_volume"": 4906489,
    ""high_24h"": 38.33,
    ""low_24h"": 37.28,
    ""price_change_24h"": 0.05288,
    ""price_change_percentage_24h"": 0.13899,
    ""market_cap_change_24h"": 566917,
    ""market_cap_change_percentage_24h"": 0.07649,
    ""circulating_supply"": 19474470.0383936,
    ""total_supply"": 19474470.0383936,
    ""max_supply"": null,
    ""ath"": 61.9,
    ""ath_change_percentage"": -38.50965,
    ""ath_date"": ""2023-04-16T19:20:19.534Z"",
    ""atl"": 0.00884718,
    ""atl_change_percentage"": 430107.7926,
    ""atl_date"": ""2018-08-28T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:30.212Z""
  },
  {
    ""id"": ""usdd"",
    ""symbol"": ""usdd"",
    ""name"": ""USDD"",
    ""image"": ""https://assets.coingecko.com/coins/images/25380/large/UUSD.jpg?1651823371"",
    ""current_price"": 0.998326,
    ""market_cap"": 738089313,
    ""market_cap_rank"": 60,
    ""fully_diluted_valuation"": null,
    ""total_volume"": 11063548,
    ""high_24h"": 1.003,
    ""low_24h"": 0.99495,
    ""price_change_24h"": -0.00144593637123891,
    ""price_change_percentage_24h"": -0.14463,
    ""market_cap_change_24h"": 313031,
    ""market_cap_change_percentage_24h"": 0.04243,
    ""circulating_supply"": 738866059.844833,
    ""total_supply"": null,
    ""max_supply"": null,
    ""ath"": 1.044,
    ""ath_change_percentage"": -4.40626,
    ""ath_date"": ""2022-11-09T09:56:06.131Z"",
    ""atl"": 0.928067,
    ""atl_change_percentage"": 7.5261,
    ""atl_date"": ""2022-06-19T16:15:11.558Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:22.026Z""
  },
  {
    ""id"": ""whitebit"",
    ""symbol"": ""wbt"",
    ""name"": ""WhiteBIT Token"",
    ""image"": ""https://assets.coingecko.com/coins/images/27045/large/wbt_token.png?1667923752"",
    ""current_price"": 5.03,
    ""market_cap"": 724914492,
    ""market_cap_rank"": 61,
    ""fully_diluted_valuation"": 2011995424,
    ""total_volume"": 718960,
    ""high_24h"": 5.05,
    ""low_24h"": 4.97,
    ""price_change_24h"": 0.01962861,
    ""price_change_percentage_24h"": 0.39165,
    ""market_cap_change_24h"": 3217921,
    ""market_cap_change_percentage_24h"": 0.44588,
    ""circulating_supply"": 144118517.10815412,
    ""total_supply"": 371187858,
    ""max_supply"": 400000000,
    ""ath"": 14.64,
    ""ath_change_percentage"": -65.66852,
    ""ath_date"": ""2022-10-28T12:32:18.119Z"",
    ""atl"": 3.06,
    ""atl_change_percentage"": 64.21226,
    ""atl_date"": ""2023-02-13T19:01:21.899Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:14.635Z""
  },
  {
    ""id"": ""bitcoin-cash-sv"",
    ""symbol"": ""bsv"",
    ""name"": ""Bitcoin SV"",
    ""image"": ""https://assets.coingecko.com/coins/images/6799/large/BSV.png?1558947902"",
    ""current_price"": 37.18,
    ""market_cap"": 716503912,
    ""market_cap_rank"": 62,
    ""fully_diluted_valuation"": 780988389,
    ""total_volume"": 32332113,
    ""high_24h"": 39.86,
    ""low_24h"": 36.43,
    ""price_change_24h"": 0.321388,
    ""price_change_percentage_24h"": 0.87185,
    ""market_cap_change_24h"": 5494229,
    ""market_cap_change_percentage_24h"": 0.77274,
    ""circulating_supply"": 19266076.644239,
    ""total_supply"": 21000000,
    ""max_supply"": 21000000,
    ""ath"": 489.75,
    ""ath_change_percentage"": -92.4097,
    ""ath_date"": ""2021-04-16T17:09:04.630Z"",
    ""atl"": 21.43,
    ""atl_change_percentage"": 73.42581,
    ""atl_date"": ""2023-06-10T04:32:12.266Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.610Z""
  },
  {
    ""id"": ""decentraland"",
    ""symbol"": ""mana"",
    ""name"": ""Decentraland"",
    ""image"": ""https://assets.coingecko.com/coins/images/878/large/decentraland-mana.png?1550108745"",
    ""current_price"": 0.387644,
    ""market_cap"": 712855389,
    ""market_cap_rank"": 63,
    ""fully_diluted_valuation"": 850079465,
    ""total_volume"": 42243574,
    ""high_24h"": 0.392774,
    ""low_24h"": 0.373704,
    ""price_change_24h"": 0.01163081,
    ""price_change_percentage_24h"": 3.09319,
    ""market_cap_change_24h"": 19929685,
    ""market_cap_change_percentage_24h"": 2.87616,
    ""circulating_supply"": 1839145358.56432,
    ""total_supply"": 2193179327.32015,
    ""max_supply"": 2193179327.32015,
    ""ath"": 5.85,
    ""ath_change_percentage"": -93.38044,
    ""ath_date"": ""2021-11-25T10:04:18.534Z"",
    ""atl"": 0.00923681,
    ""atl_change_percentage"": 4092.99166,
    ""atl_date"": ""2017-10-31T00:00:00.000Z"",
    ""roi"": {
      ""times"": 18.38222426782556,
      ""currency"": ""usd"",
      ""percentage"": 1838.222426782556
    },
    ""last_updated"": ""2023-06-27T17:54:27.068Z""
  },
  {
    ""id"": ""pepe"",
    ""symbol"": ""pepe"",
    ""name"": ""Pepe"",
    ""image"": ""https://assets.coingecko.com/coins/images/29850/large/pepe-token.jpeg?1682922725"",
    ""current_price"": 0.00000162,
    ""market_cap"": 682523649,
    ""market_cap_rank"": 65,
    ""fully_diluted_valuation"": 682523649,
    ""total_volume"": 197916767,
    ""high_24h"": 0.00000166,
    ""low_24h"": 0.0000015,
    ""price_change_24h"": 9.155e-8,
    ""price_change_percentage_24h"": 5.97977,
    ""market_cap_change_24h"": 38209942,
    ""market_cap_change_percentage_24h"": 5.93033,
    ""circulating_supply"": 420690000000000,
    ""total_supply"": 420690000000000,
    ""max_supply"": 420690000000000,
    ""ath"": 0.00000431,
    ""ath_change_percentage"": -62.30778,
    ""ath_date"": ""2023-05-05T16:50:45.302Z"",
    ""atl"": 5.5142e-8,
    ""atl_change_percentage"": 2844.08415,
    ""atl_date"": ""2023-04-18T02:14:41.591Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:32.013Z""
  },
  {
    ""id"": ""havven"",
    ""symbol"": ""snx"",
    ""name"": ""Synthetix Network"",
    ""image"": ""https://assets.coingecko.com/coins/images/3406/large/SNX.png?1598631139"",
    ""current_price"": 2.13,
    ""market_cap"": 682102910,
    ""market_cap_rank"": 64,
    ""fully_diluted_valuation"": 683648250,
    ""total_volume"": 28247043,
    ""high_24h"": 2.17,
    ""low_24h"": 2.07,
    ""price_change_24h"": 0.02396572,
    ""price_change_percentage_24h"": 1.13626,
    ""market_cap_change_24h"": 6133109,
    ""market_cap_change_percentage_24h"": 0.90731,
    ""circulating_supply"": 319528338.13952357,
    ""total_supply"": 320252246.088774,
    ""max_supply"": 320252246.088774,
    ""ath"": 28.53,
    ""ath_change_percentage"": -92.50992,
    ""ath_date"": ""2021-02-14T01:12:38.505Z"",
    ""atl"": 0.0347864,
    ""atl_change_percentage"": 6043.4689,
    ""atl_date"": ""2019-01-06T00:00:00.000Z"",
    ""roi"": {
      ""times"": 3.266285602906094,
      ""currency"": ""usd"",
      ""percentage"": 326.6285602906094
    },
    ""last_updated"": ""2023-06-27T17:54:32.053Z""
  },
  {
    ""id"": ""axie-infinity"",
    ""symbol"": ""axs"",
    ""name"": ""Axie Infinity"",
    ""image"": ""https://assets.coingecko.com/coins/images/13029/large/axie_infinity_logo.png?1604471082"",
    ""current_price"": 5.88,
    ""market_cap"": 680512753,
    ""market_cap_rank"": 66,
    ""fully_diluted_valuation"": 1588589703,
    ""total_volume"": 44196102,
    ""high_24h"": 5.98,
    ""low_24h"": 5.63,
    ""price_change_24h"": 0.206219,
    ""price_change_percentage_24h"": 3.63158,
    ""market_cap_change_24h"": 23299661,
    ""market_cap_change_percentage_24h"": 3.54522,
    ""circulating_supply"": 115661358.61362292,
    ""total_supply"": 270000000,
    ""max_supply"": 270000000,
    ""ath"": 164.9,
    ""ath_change_percentage"": -96.43342,
    ""ath_date"": ""2021-11-06T19:29:29.482Z"",
    ""atl"": 0.123718,
    ""atl_change_percentage"": 4653.71366,
    ""atl_date"": ""2020-11-06T08:05:43.662Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:32.121Z""
  },
  {
    ""id"": ""bitget-token"",
    ""symbol"": ""bgb"",
    ""name"": ""Bitget Token"",
    ""image"": ""https://assets.coingecko.com/coins/images/11610/large/photo_2022-01-24_14-08-03.jpg?1643019457"",
    ""current_price"": 0.482093,
    ""market_cap"": 674428037,
    ""market_cap_rank"": 67,
    ""fully_diluted_valuation"": 963467936,
    ""total_volume"": 17006877,
    ""high_24h"": 0.4864,
    ""low_24h"": 0.477963,
    ""price_change_24h"": -0.00046934754800404,
    ""price_change_percentage_24h"": -0.09726,
    ""market_cap_change_24h"": -1037694.2404649258,
    ""market_cap_change_percentage_24h"": -0.15363,
    ""circulating_supply"": 1400001000,
    ""total_supply"": 2000000000,
    ""max_supply"": 2000000000,
    ""ath"": 0.515471,
    ""ath_change_percentage"": -6.4042,
    ""ath_date"": ""2023-02-16T08:52:49.445Z"",
    ""atl"": 0.0142795,
    ""atl_change_percentage"": 3278.68501,
    ""atl_date"": ""2020-06-25T04:17:05.895Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:10.158Z""
  },
  {
    ""id"": ""neo"",
    ""symbol"": ""neo"",
    ""name"": ""NEO"",
    ""image"": ""https://assets.coingecko.com/coins/images/480/large/NEO_512_512.png?1594357361"",
    ""current_price"": 9.15,
    ""market_cap"": 646041412,
    ""market_cap_rank"": 68,
    ""fully_diluted_valuation"": 915981018,
    ""total_volume"": 27660031,
    ""high_24h"": 9.24,
    ""low_24h"": 8.71,
    ""price_change_24h"": 0.263976,
    ""price_change_percentage_24h"": 2.97023,
    ""market_cap_change_24h"": 18202999,
    ""market_cap_change_percentage_24h"": 2.89931,
    ""circulating_supply"": 70530000,
    ""total_supply"": 100000000,
    ""max_supply"": null,
    ""ath"": 198.38,
    ""ath_change_percentage"": -95.38421,
    ""ath_date"": ""2018-01-15T00:00:00.000Z"",
    ""atl"": 0.078349,
    ""atl_change_percentage"": 11587.21346,
    ""atl_date"": ""2016-10-21T00:00:00.000Z"",
    ""roi"": {
      ""times"": 253.2048484207097,
      ""currency"": ""usd"",
      ""percentage"": 25320.48484207097
    },
    ""last_updated"": ""2023-06-27T17:54:25.777Z""
  },
  {
    ""id"": ""kucoin-shares"",
    ""symbol"": ""kcs"",
    ""name"": ""KuCoin"",
    ""image"": ""https://assets.coingecko.com/coins/images/1047/large/sa9z79.png?1610678720"",
    ""current_price"": 6.56,
    ""market_cap"": 635348908,
    ""market_cap_rank"": 69,
    ""fully_diluted_valuation"": 947134889,
    ""total_volume"": 1151354,
    ""high_24h"": 6.59,
    ""low_24h"": 6.51,
    ""price_change_24h"": 0.01709492,
    ""price_change_percentage_24h"": 0.26137,
    ""market_cap_change_24h"": 2336579,
    ""market_cap_change_percentage_24h"": 0.36912,
    ""circulating_supply"": 96794195.4569757,
    ""total_supply"": 144294195.456892,
    ""max_supply"": null,
    ""ath"": 28.83,
    ""ath_change_percentage"": -77.19633,
    ""ath_date"": ""2021-12-01T15:09:35.541Z"",
    ""atl"": 0.342863,
    ""atl_change_percentage"": 1817.46328,
    ""atl_date"": ""2019-02-07T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:53:09.501Z""
  },
  {
    ""id"": ""gala"",
    ""symbol"": ""gala"",
    ""name"": ""GALA"",
    ""image"": ""https://assets.coingecko.com/coins/images/12493/large/GALA-COINGECKO.png?1600233435"",
    ""current_price"": 0.025698,
    ""market_cap"": 624759588,
    ""market_cap_rank"": 70,
    ""fully_diluted_valuation"": 1285294418,
    ""total_volume"": 40025423,
    ""high_24h"": 0.02608943,
    ""low_24h"": 0.02525039,
    ""price_change_24h"": 0.00002579,
    ""price_change_percentage_24h"": 0.10046,
    ""market_cap_change_24h"": 610747,
    ""market_cap_change_percentage_24h"": 0.09785,
    ""circulating_supply"": 24304143058.054,
    ""total_supply"": 24304143058.054,
    ""max_supply"": 50000000000,
    ""ath"": 0.824837,
    ""ath_change_percentage"": -96.88929,
    ""ath_date"": ""2021-11-26T01:03:48.731Z"",
    ""atl"": 0.00013475,
    ""atl_change_percentage"": 18941.48648,
    ""atl_date"": ""2020-12-28T08:46:48.367Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:32.212Z""
  },
  {
    ""id"": ""maker"",
    ""symbol"": ""mkr"",
    ""name"": ""Maker"",
    ""image"": ""https://assets.coingecko.com/coins/images/1364/large/Mark_Maker.png?1585191826"",
    ""current_price"": 683.73,
    ""market_cap"": 616685708,
    ""market_cap_rank"": 71,
    ""fully_diluted_valuation"": 688025554,
    ""total_volume"": 21264557,
    ""high_24h"": 706.29,
    ""low_24h"": 677.93,
    ""price_change_24h"": 2.32,
    ""price_change_percentage_24h"": 0.34109,
    ""market_cap_change_24h"": 1865713,
    ""market_cap_change_percentage_24h"": 0.30346,
    ""circulating_supply"": 901310.9472893132,
    ""total_supply"": 977631.036950888,
    ""max_supply"": 1005577,
    ""ath"": 6292.31,
    ""ath_change_percentage"": -89.13064,
    ""ath_date"": ""2021-05-03T21:54:29.333Z"",
    ""atl"": 168.36,
    ""atl_change_percentage"": 306.23911,
    ""atl_date"": ""2020-03-16T20:52:36.527Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:25.204Z""
  },
  {
    ""id"": ""injective-protocol"",
    ""symbol"": ""inj"",
    ""name"": ""Injective"",
    ""image"": ""https://assets.coingecko.com/coins/images/12882/large/Secondary_Symbol.png?1628233237"",
    ""current_price"": 7.71,
    ""market_cap"": 616034275,
    ""market_cap_rank"": 72,
    ""fully_diluted_valuation"": 769989374,
    ""total_volume"": 54447364,
    ""high_24h"": 7.79,
    ""low_24h"": 7.27,
    ""price_change_24h"": 0.305702,
    ""price_change_percentage_24h"": 4.13073,
    ""market_cap_change_24h"": 23216198,
    ""market_cap_change_percentage_24h"": 3.91624,
    ""circulating_supply"": 80005555.33,
    ""total_supply"": 100000000,
    ""max_supply"": 100000000,
    ""ath"": 24.89,
    ""ath_change_percentage"": -69.03372,
    ""ath_date"": ""2021-04-30T00:33:02.969Z"",
    ""atl"": 0.657401,
    ""atl_change_percentage"": 1072.41514,
    ""atl_date"": ""2020-11-03T16:19:30.576Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.683Z""
  },
  {
    ""id"": ""curve-dao-token"",
    ""symbol"": ""crv"",
    ""name"": ""Curve DAO"",
    ""image"": ""https://assets.coingecko.com/coins/images/12124/large/Curve.png?1597369484"",
    ""current_price"": 0.698901,
    ""market_cap"": 599851996,
    ""market_cap_rank"": 73,
    ""fully_diluted_valuation"": 2306393264,
    ""total_volume"": 36340139,
    ""high_24h"": 0.698623,
    ""low_24h"": 0.667724,
    ""price_change_24h"": 0.02845841,
    ""price_change_percentage_24h"": 4.24472,
    ""market_cap_change_24h"": 22828973,
    ""market_cap_change_percentage_24h"": 3.95634,
    ""circulating_supply"": 859059619,
    ""total_supply"": 1971259457.4353,
    ""max_supply"": 3303030299,
    ""ath"": 15.37,
    ""ath_change_percentage"": -95.4575,
    ""ath_date"": ""2020-08-14T00:00:00.000Z"",
    ""atl"": 0.331577,
    ""atl_change_percentage"": 110.59261,
    ""atl_date"": ""2020-11-05T13:09:50.181Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.409Z""
  },
  {
    ""id"": ""gatechain-token"",
    ""symbol"": ""gt"",
    ""name"": ""Gate"",
    ""image"": ""https://assets.coingecko.com/coins/images/8183/large/gate.png?1687143308"",
    ""current_price"": 4.25,
    ""market_cap"": 590540914,
    ""market_cap_rank"": 74,
    ""fully_diluted_valuation"": 1274375409,
    ""total_volume"": 400144,
    ""high_24h"": 4.26,
    ""low_24h"": 4.21,
    ""price_change_24h"": 0.01951796,
    ""price_change_percentage_24h"": 0.46135,
    ""market_cap_change_24h"": 2448747,
    ""market_cap_change_percentage_24h"": 0.41639,
    ""circulating_supply"": 139018905.1789118,
    ""total_supply"": 300000000,
    ""max_supply"": null,
    ""ath"": 12.94,
    ""ath_change_percentage"": -67.22279,
    ""ath_date"": ""2021-05-12T11:39:16.531Z"",
    ""atl"": 0.25754,
    ""atl_change_percentage"": 1547.11403,
    ""atl_date"": ""2020-03-13T02:18:02.481Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:28.312Z""
  },
  {
    ""id"": ""kava"",
    ""symbol"": ""kava"",
    ""name"": ""Kava"",
    ""image"": ""https://assets.coingecko.com/coins/images/9761/large/kava.png?1663638871"",
    ""current_price"": 0.984314,
    ""market_cap"": 586696194,
    ""market_cap_rank"": 75,
    ""fully_diluted_valuation"": 586710243,
    ""total_volume"": 23656000,
    ""high_24h"": 1.028,
    ""low_24h"": 0.970777,
    ""price_change_24h"": -0.033657652921466163,
    ""price_change_percentage_24h"": -3.30635,
    ""market_cap_change_24h"": -19716258.866668582,
    ""market_cap_change_percentage_24h"": -3.2513,
    ""circulating_supply"": 595266315,
    ""total_supply"": 595280570,
    ""max_supply"": null,
    ""ath"": 9.12,
    ""ath_change_percentage"": -89.21929,
    ""ath_date"": ""2021-08-30T11:10:02.948Z"",
    ""atl"": 0.287137,
    ""atl_change_percentage"": 242.42417,
    ""atl_date"": ""2020-03-13T02:24:16.835Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:15.917Z""
  },
  {
    ""id"": ""gemini-dollar"",
    ""symbol"": ""gusd"",
    ""name"": ""Gemini Dollar"",
    ""image"": ""https://assets.coingecko.com/coins/images/5992/large/gemini-dollar-gusd.png?1536745278"",
    ""current_price"": 0.999979,
    ""market_cap"": 565682809,
    ""market_cap_rank"": 76,
    ""fully_diluted_valuation"": 565682809,
    ""total_volume"": 1802440,
    ""high_24h"": 1.004,
    ""low_24h"": 0.996206,
    ""price_change_24h"": 0.0031263,
    ""price_change_percentage_24h"": 0.31362,
    ""market_cap_change_24h"": 956932,
    ""market_cap_change_percentage_24h"": 0.16945,
    ""circulating_supply"": 565746198,
    ""total_supply"": 565746198,
    ""max_supply"": null,
    ""ath"": 3.3,
    ""ath_change_percentage"": -69.74414,
    ""ath_date"": ""2018-10-11T17:36:21.529Z"",
    ""atl"": 0.78261,
    ""atl_change_percentage"": 27.72808,
    ""atl_date"": ""2018-09-29T00:00:00.000Z"",
    ""roi"": {
      ""times"": -0.0000214130809216,
      ""currency"": ""usd"",
      ""percentage"": -0.00214130809216
    },
    ""last_updated"": ""2023-06-27T17:53:40.498Z""
  },
  {
    ""id"": ""flow"",
    ""symbol"": ""flow"",
    ""name"": ""Flow"",
    ""image"": ""https://assets.coingecko.com/coins/images/13446/large/5f6294c0c7a8cda55cb1c936_Flow_Wordmark.png?1631696776"",
    ""current_price"": 0.539975,
    ""market_cap"": 559340240,
    ""market_cap_rank"": 77,
    ""fully_diluted_valuation"": 776523116,
    ""total_volume"": 14075120,
    ""high_24h"": 0.552943,
    ""low_24h"": 0.533979,
    ""price_change_24h"": -0.001451118234696125,
    ""price_change_percentage_24h"": -0.26802,
    ""market_cap_change_24h"": -3296874.9604917765,
    ""market_cap_change_percentage_24h"": -0.58597,
    ""circulating_supply"": 1036200000,
    ""total_supply"": 1438539899.44975,
    ""max_supply"": 1438539899.44975,
    ""ath"": 42.4,
    ""ath_change_percentage"": -98.72789,
    ""ath_date"": ""2021-04-05T13:49:10.098Z"",
    ""atl"": 0.441327,
    ""atl_change_percentage"": 22.20817,
    ""atl_date"": ""2023-06-15T11:15:32.710Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.071Z""
  },
  {
    ""id"": ""terra-luna"",
    ""symbol"": ""lunc"",
    ""name"": ""Terra Luna Classic"",
    ""image"": ""https://assets.coingecko.com/coins/images/8284/large/01_LunaClassic_color.png?1653547790"",
    ""current_price"": 0.00009164,
    ""market_cap"": 533346529,
    ""market_cap_rank"": 78,
    ""fully_diluted_valuation"": 627260202,
    ""total_volume"": 32443904,
    ""high_24h"": 0.00009272,
    ""low_24h"": 0.00009058,
    ""price_change_24h"": 1.26288e-7,
    ""price_change_percentage_24h"": 0.138,
    ""market_cap_change_24h"": -1998886.1729311347,
    ""market_cap_change_percentage_24h"": -0.37338,
    ""circulating_supply"": 5821009711193.38,
    ""total_supply"": 6845995098783.06,
    ""max_supply"": null,
    ""ath"": 119.18,
    ""ath_change_percentage"": -99.99992,
    ""ath_date"": ""2022-04-05T12:24:58.854Z"",
    ""atl"": 9.99967e-7,
    ""atl_change_percentage"": 9053.8289,
    ""atl_date"": ""2022-05-13T02:34:40.340Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:30.264Z""
  },
  {
    ""id"": ""bitdao"",
    ""symbol"": ""bit"",
    ""name"": ""BitDAO"",
    ""image"": ""https://assets.coingecko.com/coins/images/17627/large/rI_YptK8.png?1653983088"",
    ""current_price"": 0.367004,
    ""market_cap"": 531787914,
    ""market_cap_rank"": 79,
    ""fully_diluted_valuation"": 3515081109,
    ""total_volume"": 19667462,
    ""high_24h"": 0.40669,
    ""low_24h"": 0.36039,
    ""price_change_24h"": -0.030894077660569397,
    ""price_change_percentage_24h"": -7.76432,
    ""market_cap_change_24h"": -46814796.96019769,
    ""market_cap_change_percentage_24h"": -8.09101,
    ""circulating_supply"": 1453909315.2107098,
    ""total_supply"": 9610239403,
    ""max_supply"": 9610239403,
    ""ath"": 3.1,
    ""ath_change_percentage"": -88.21218,
    ""ath_date"": ""2021-11-12T04:54:56.433Z"",
    ""atl"": 0.270167,
    ""atl_change_percentage"": 35.35348,
    ""atl_date"": ""2022-11-22T08:40:21.230Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:29.516Z""
  },
  {
    ""id"": ""klay-token"",
    ""symbol"": ""klay"",
    ""name"": ""Klaytn"",
    ""image"": ""https://assets.coingecko.com/coins/images/9672/large/klaytn.png?1660288824"",
    ""current_price"": 0.168709,
    ""market_cap"": 528941849,
    ""market_cap_rank"": 80,
    ""fully_diluted_valuation"": null,
    ""total_volume"": 7521740,
    ""high_24h"": 0.170003,
    ""low_24h"": 0.166389,
    ""price_change_24h"": -0.000543306507880398,
    ""price_change_percentage_24h"": -0.321,
    ""market_cap_change_24h"": -1939240.8395228982,
    ""market_cap_change_percentage_24h"": -0.36529,
    ""circulating_supply"": 3133821306.08309,
    ""total_supply"": null,
    ""max_supply"": null,
    ""ath"": 4.34,
    ""ath_change_percentage"": -96.11218,
    ""ath_date"": ""2021-03-30T03:44:28.828Z"",
    ""atl"": 0.06044,
    ""atl_change_percentage"": 179.10337,
    ""atl_date"": ""2020-04-29T08:19:34.574Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:14.691Z""
  },
  {
    ""id"": ""iota"",
    ""symbol"": ""miota"",
    ""name"": ""IOTA"",
    ""image"": ""https://assets.coingecko.com/coins/images/692/large/IOTA_Swirl.png?1604238557"",
    ""current_price"": 0.183922,
    ""market_cap"": 510978198,
    ""market_cap_rank"": 81,
    ""fully_diluted_valuation"": 510978198,
    ""total_volume"": 16826553,
    ""high_24h"": 0.198266,
    ""low_24h"": 0.177699,
    ""price_change_24h"": 0.00370589,
    ""price_change_percentage_24h"": 2.05637,
    ""market_cap_change_24h"": 9880314,
    ""market_cap_change_percentage_24h"": 1.97173,
    ""circulating_supply"": 2779530283.277761,
    ""total_supply"": 2779530283,
    ""max_supply"": null,
    ""ath"": 5.25,
    ""ath_change_percentage"": -96.50023,
    ""ath_date"": ""2017-12-19T00:00:00.000Z"",
    ""atl"": 0.081637,
    ""atl_change_percentage"": 125.01361,
    ""atl_date"": ""2020-03-13T02:22:41.168Z"",
    ""roi"": {
      ""times"": 3.471039047859722,
      ""currency"": ""btc"",
      ""percentage"": 347.10390478597225
    },
    ""last_updated"": ""2023-06-27T17:54:28.174Z""
  },
  {
    ""id"": ""kaspa"",
    ""symbol"": ""kas"",
    ""name"": ""Kaspa"",
    ""image"": ""https://assets.coingecko.com/coins/images/25751/large/kaspa-icon-exchanges.png?1653891958"",
    ""current_price"": 0.02641323,
    ""market_cap"": 505654397,
    ""market_cap_rank"": 82,
    ""fully_diluted_valuation"": 750665744,
    ""total_volume"": 10674123,
    ""high_24h"": 0.02615169,
    ""low_24h"": 0.02429469,
    ""price_change_24h"": 0.00122172,
    ""price_change_percentage_24h"": 4.84974,
    ""market_cap_change_24h"": 19197338,
    ""market_cap_change_percentage_24h"": 3.94636,
    ""circulating_supply"": 19335259918.7346,
    ""total_supply"": 19335397176.9372,
    ""max_supply"": 28704026601,
    ""ath"": 0.04279457,
    ""ath_change_percentage"": -39.02981,
    ""ath_date"": ""2023-04-02T12:55:39.616Z"",
    ""atl"": 0.00017105,
    ""atl_change_percentage"": 15154.01452,
    ""atl_date"": ""2022-05-26T14:42:59.316Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:53:55.019Z""
  },
  {
    ""id"": ""compound-ether"",
    ""symbol"": ""ceth"",
    ""name"": ""cETH"",
    ""image"": ""https://assets.coingecko.com/coins/images/10643/large/ceth.png?1687143191"",
    ""current_price"": 38.29,
    ""market_cap"": 496474137,
    ""market_cap_rank"": 83,
    ""fully_diluted_valuation"": 496479131,
    ""total_volume"": 347.38,
    ""high_24h"": 38.29,
    ""low_24h"": 37.12,
    ""price_change_24h"": 1.089,
    ""price_change_percentage_24h"": 2.92673,
    ""market_cap_change_24h"": 16055843,
    ""market_cap_change_percentage_24h"": 3.34205,
    ""circulating_supply"": 12966498.6450344,
    ""total_supply"": 12966629.0771745,
    ""max_supply"": null,
    ""ath"": 97.75,
    ""ath_change_percentage"": -60.8299,
    ""ath_date"": ""2021-11-21T12:39:57.508Z"",
    ""atl"": 1.89,
    ""atl_change_percentage"": 1929.859,
    ""atl_date"": ""2020-03-13T02:22:33.711Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:52:34.123Z""
  },
  {
    ""id"": ""gmx"",
    ""symbol"": ""gmx"",
    ""name"": ""GMX"",
    ""image"": ""https://assets.coingecko.com/coins/images/18323/large/arbit.png?1631532468"",
    ""current_price"": 55.02,
    ""market_cap"": 485870322,
    ""market_cap_rank"": 84,
    ""fully_diluted_valuation"": 728923115,
    ""total_volume"": 11594068,
    ""high_24h"": 55.01,
    ""low_24h"": 52.58,
    ""price_change_24h"": 2.19,
    ""price_change_percentage_24h"": 4.14389,
    ""market_cap_change_24h"": 19136202,
    ""market_cap_change_percentage_24h"": 4.10002,
    ""circulating_supply"": 8831907.82939855,
    ""total_supply"": 8832053.19460699,
    ""max_supply"": 13250000,
    ""ath"": 91.07,
    ""ath_change_percentage"": -39.64384,
    ""ath_date"": ""2023-04-18T10:00:25.680Z"",
    ""atl"": 11.53,
    ""atl_change_percentage"": 376.57274,
    ""atl_date"": ""2022-06-15T09:30:22.146Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:30.621Z""
  },
  {
    ""id"": ""pax-gold"",
    ""symbol"": ""paxg"",
    ""name"": ""PAX Gold"",
    ""image"": ""https://assets.coingecko.com/coins/images/9519/large/paxgold.png?1687143101"",
    ""current_price"": 1903.58,
    ""market_cap"": 483960279,
    ""market_cap_rank"": 85,
    ""fully_diluted_valuation"": 483960279,
    ""total_volume"": 4306466,
    ""high_24h"": 1914.42,
    ""low_24h"": 1898.93,
    ""price_change_24h"": -0.37117669633698824,
    ""price_change_percentage_24h"": -0.0195,
    ""market_cap_change_24h"": -729177.8352344036,
    ""market_cap_change_percentage_24h"": -0.15044,
    ""circulating_supply"": 254217.924,
    ""total_supply"": 254217.924,
    ""max_supply"": null,
    ""ath"": 2241.37,
    ""ath_change_percentage"": -15.05369,
    ""ath_date"": ""2021-05-17T19:02:29.657Z"",
    ""atl"": 1399.64,
    ""atl_change_percentage"": 36.03202,
    ""atl_date"": ""2019-11-18T03:09:35.959Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:20.059Z""
  },
  {
    ""id"": ""conflux-token"",
    ""symbol"": ""cfx"",
    ""name"": ""Conflux"",
    ""image"": ""https://assets.coingecko.com/coins/images/13079/large/3vuYMbjN.png?1631512305"",
    ""current_price"": 0.226907,
    ""market_cap"": 476196944,
    ""market_cap_rank"": 86,
    ""fully_diluted_valuation"": 1199829637,
    ""total_volume"": 64826827,
    ""high_24h"": 0.231425,
    ""low_24h"": 0.221059,
    ""price_change_24h"": -0.00140537778107519,
    ""price_change_percentage_24h"": -0.61555,
    ""market_cap_change_24h"": -4533676.950748384,
    ""market_cap_change_percentage_24h"": -0.94308,
    ""circulating_supply"": 2097547687.26523,
    ""total_supply"": 5284997962.62513,
    ""max_supply"": null,
    ""ath"": 1.7,
    ""ath_change_percentage"": -86.64792,
    ""ath_date"": ""2021-03-27T03:43:35.178Z"",
    ""atl"": 0.02199898,
    ""atl_change_percentage"": 932.31306,
    ""atl_date"": ""2022-12-30T08:16:30.345Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.738Z""
  },
  {
    ""id"": ""tether-gold"",
    ""symbol"": ""xaut"",
    ""name"": ""Tether Gold"",
    ""image"": ""https://assets.coingecko.com/coins/images/10481/large/Tether_Gold.png?1668148656"",
    ""current_price"": 1914.52,
    ""market_cap"": 471969383,
    ""market_cap_rank"": 87,
    ""fully_diluted_valuation"": 471969383,
    ""total_volume"": 6614000,
    ""high_24h"": 1931.02,
    ""low_24h"": 1907.6,
    ""price_change_24h"": -7.339017280951566,
    ""price_change_percentage_24h"": -0.38187,
    ""market_cap_change_24h"": -1710098.0563927293,
    ""market_cap_change_percentage_24h"": -0.36102,
    ""circulating_supply"": 246524.33,
    ""total_supply"": 246524.33,
    ""max_supply"": null,
    ""ath"": 2169.74,
    ""ath_change_percentage"": -11.7606,
    ""ath_date"": ""2023-03-15T20:36:21.941Z"",
    ""atl"": 1447.84,
    ""atl_change_percentage"": 32.23592,
    ""atl_date"": ""2020-03-19T13:45:41.821Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.609Z""
  },
  {
    ""id"": ""tokenize-xchange"",
    ""symbol"": ""tkx"",
    ""name"": ""Tokenize Xchange"",
    ""image"": ""https://assets.coingecko.com/coins/images/4984/large/TKX_-_Logo_-_RGB-15.png?1672912391"",
    ""current_price"": 5.9,
    ""market_cap"": 471929373,
    ""market_cap_rank"": 88,
    ""fully_diluted_valuation"": 589941214,
    ""total_volume"": 8089317,
    ""high_24h"": 5.91,
    ""low_24h"": 5.7,
    ""price_change_24h"": 0.183978,
    ""price_change_percentage_24h"": 3.21649,
    ""market_cap_change_24h"": 13451887,
    ""market_cap_change_percentage_24h"": 2.93403,
    ""circulating_supply"": 79995999.94518414,
    ""total_supply"": 100000000,
    ""max_supply"": 100000000,
    ""ath"": 22.3,
    ""ath_change_percentage"": -73.54481,
    ""ath_date"": ""2022-10-31T10:23:59.455Z"",
    ""atl"": 0.111255,
    ""atl_change_percentage"": 5201.80947,
    ""atl_date"": ""2019-04-28T00:00:00.000Z"",
    ""roi"": {
      ""times"": 19.322980359781102,
      ""currency"": ""usd"",
      ""percentage"": 1932.2980359781102
    },
    ""last_updated"": ""2023-06-27T17:54:09.923Z""
  },
  {
    ""id"": ""ecash"",
    ""symbol"": ""xec"",
    ""name"": ""eCash"",
    ""image"": ""https://assets.coingecko.com/coins/images/16646/large/Logo_final-22.png?1628239446"",
    ""current_price"": 0.00002385,
    ""market_cap"": 465984382,
    ""market_cap_rank"": 89,
    ""fully_diluted_valuation"": 503726422,
    ""total_volume"": 1637550,
    ""high_24h"": 0.00002442,
    ""low_24h"": 0.00002333,
    ""price_change_24h"": 8.412e-9,
    ""price_change_percentage_24h"": 0.03528,
    ""market_cap_change_24h"": 1497631,
    ""market_cap_change_percentage_24h"": 0.32243,
    ""circulating_supply"": 19426560923293,
    ""total_supply"": 21000000000000,
    ""max_supply"": 21000000000000,
    ""ath"": 0.00038001,
    ""ath_change_percentage"": -93.68121,
    ""ath_date"": ""2021-09-04T17:09:31.137Z"",
    ""atl"": 0.00001847,
    ""atl_change_percentage"": 30.00742,
    ""atl_date"": ""2021-07-20T20:49:46.212Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:08.259Z""
  },
  {
    ""id"": ""mina-protocol"",
    ""symbol"": ""mina"",
    ""name"": ""Mina Protocol"",
    ""image"": ""https://assets.coingecko.com/coins/images/15628/large/JM4_vQ34_400x400.png?1621394004"",
    ""current_price"": 0.49596,
    ""market_cap"": 459425004,
    ""market_cap_rank"": 90,
    ""fully_diluted_valuation"": 520377107,
    ""total_volume"": 13455460,
    ""high_24h"": 0.517782,
    ""low_24h"": 0.484504,
    ""price_change_24h"": -0.000907160515479566,
    ""price_change_percentage_24h"": -0.18258,
    ""market_cap_change_24h"": -303028.0544117689,
    ""market_cap_change_percentage_24h"": -0.06591,
    ""circulating_supply"": 924290847.840039,
    ""total_supply"": 1046916892.84004,
    ""max_supply"": null,
    ""ath"": 9.09,
    ""ath_change_percentage"": -94.54715,
    ""ath_date"": ""2021-06-01T01:42:37.064Z"",
    ""atl"": 0.380741,
    ""atl_change_percentage"": 30.18888,
    ""atl_date"": ""2023-06-10T06:00:03.859Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:27.521Z""
  },
  {
    ""id"": ""bittorrent"",
    ""symbol"": ""btt"",
    ""name"": ""BitTorrent"",
    ""image"": ""https://assets.coingecko.com/coins/images/22457/large/btt_logo.png?1643857231"",
    ""current_price"": 4.7566e-7,
    ""market_cap"": 452553633,
    ""market_cap_rank"": 91,
    ""fully_diluted_valuation"": 470903796,
    ""total_volume"": 13618877,
    ""high_24h"": 4.8463e-7,
    ""low_24h"": 4.74147e-7,
    ""price_change_24h"": -7.226295613e-9,
    ""price_change_percentage_24h"": -1.49648,
    ""market_cap_change_24h"": -6617786.680614948,
    ""market_cap_change_percentage_24h"": -1.44125,
    ""circulating_supply"": 951421714286000,
    ""total_supply"": 990000000000000,
    ""max_supply"": 990000000000000,
    ""ath"": 0.00000343,
    ""ath_change_percentage"": -86.14104,
    ""ath_date"": ""2022-01-21T04:00:31.909Z"",
    ""atl"": 4.5532e-7,
    ""atl_change_percentage"": 4.44252,
    ""atl_date"": ""2023-06-20T15:46:26.171Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:24.129Z""
  },
  {
    ""id"": ""casper-network"",
    ""symbol"": ""cspr"",
    ""name"": ""Casper Network"",
    ""image"": ""https://assets.coingecko.com/coins/images/15279/large/casper.PNG?1620341020"",
    ""current_price"": 0.04020237,
    ""market_cap"": 447682907,
    ""market_cap_rank"": 92,
    ""fully_diluted_valuation"": 475327242,
    ""total_volume"": 2700784,
    ""high_24h"": 0.04085969,
    ""low_24h"": 0.03928379,
    ""price_change_24h"": 0.00090204,
    ""price_change_percentage_24h"": 2.29525,
    ""market_cap_change_24h"": 10741523,
    ""market_cap_change_percentage_24h"": 2.45834,
    ""circulating_supply"": 11131596098,
    ""total_supply"": 11818970074,
    ""max_supply"": null,
    ""ath"": 1.33,
    ""ath_change_percentage"": -96.97008,
    ""ath_date"": ""2021-05-12T00:00:00.000Z"",
    ""atl"": 0.02241297,
    ""atl_change_percentage"": 79.1815,
    ""atl_date"": ""2022-06-18T20:14:44.694Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:10.085Z""
  },
  {
    ""id"": ""huobi-token"",
    ""symbol"": ""ht"",
    ""name"": ""Huobi"",
    ""image"": ""https://assets.coingecko.com/coins/images/2822/large/huobi-token-logo.png?1547036992"",
    ""current_price"": 2.71,
    ""market_cap"": 440641509,
    ""market_cap_rank"": 93,
    ""fully_diluted_valuation"": 553678556,
    ""total_volume"": 10260834,
    ""high_24h"": 2.72,
    ""low_24h"": 2.68,
    ""price_change_24h"": 0.0272789,
    ""price_change_percentage_24h"": 1.01602,
    ""market_cap_change_24h"": 4761318,
    ""market_cap_change_percentage_24h"": 1.09235,
    ""circulating_supply"": 162336522.3,
    ""total_supply"": 203980445.3,
    ""max_supply"": 203980445.3,
    ""ath"": 39.66,
    ""ath_change_percentage"": -93.16332,
    ""ath_date"": ""2021-05-12T14:42:21.586Z"",
    ""atl"": 0.3138,
    ""atl_change_percentage"": 764.07889,
    ""atl_date"": ""2023-03-10T05:05:00+08:00"",
    ""roi"": {
      ""times"": 1.7395536222685253,
      ""currency"": ""usd"",
      ""percentage"": 173.95536222685251
    },
    ""last_updated"": ""2023-06-27T17:54:23.641Z""
  },
  {
    ""id"": ""frax-ether"",
    ""symbol"": ""frxeth"",
    ""name"": ""Frax Ether"",
    ""image"": ""https://assets.coingecko.com/coins/images/28284/large/frxETH_icon.png?1679886981"",
    ""current_price"": 1896.44,
    ""market_cap"": 440043971,
    ""market_cap_rank"": 94,
    ""fully_diluted_valuation"": 440076947,
    ""total_volume"": 3351850,
    ""high_24h"": 1906.94,
    ""low_24h"": 1841.93,
    ""price_change_24h"": 49.21,
    ""price_change_percentage_24h"": 2.66417,
    ""market_cap_change_24h"": 11414862,
    ""market_cap_change_percentage_24h"": 2.66311,
    ""circulating_supply"": 232191.402209473,
    ""total_supply"": 232208.802209473,
    ""max_supply"": null,
    ""ath"": 2134.61,
    ""ath_change_percentage"": -11.3008,
    ""ath_date"": ""2023-04-16T19:24:52.171Z"",
    ""atl"": 1137.25,
    ""atl_change_percentage"": 66.48821,
    ""atl_date"": ""2022-11-23T02:25:33.267Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:30.909Z""
  },
  {
    ""id"": ""xdce-crowd-sale"",
    ""symbol"": ""xdc"",
    ""name"": ""XDC Network"",
    ""image"": ""https://assets.coingecko.com/coins/images/2912/large/xdc-icon.png?1633700890"",
    ""current_price"": 0.03163972,
    ""market_cap"": 437685401,
    ""market_cap_rank"": 95,
    ""fully_diluted_valuation"": 1196355132,
    ""total_volume"": 1959582,
    ""high_24h"": 0.03259876,
    ""low_24h"": 0.03146331,
    ""price_change_24h"": -0.000361227495035935,
    ""price_change_percentage_24h"": -1.1288,
    ""market_cap_change_24h"": -3885791.9745045304,
    ""market_cap_change_percentage_24h"": -0.87999,
    ""circulating_supply"": 13845880201.35,
    ""total_supply"": 37845881500.05,
    ""max_supply"": null,
    ""ath"": 0.192754,
    ""ath_change_percentage"": -83.61397,
    ""ath_date"": ""2021-08-21T04:39:48.324Z"",
    ""atl"": 0.00039532,
    ""atl_change_percentage"": 7889.70644,
    ""atl_date"": ""2019-07-22T00:00:00.000Z"",
    ""roi"": {
      ""times"": 1.2160574360597234,
      ""currency"": ""eth"",
      ""percentage"": 121.60574360597234
    },
    ""last_updated"": ""2023-06-27T17:54:30.394Z""
  },
  {
    ""id"": ""frax-share"",
    ""symbol"": ""fxs"",
    ""name"": ""Frax Share"",
    ""image"": ""https://assets.coingecko.com/coins/images/13423/large/Frax_Shares_icon.png?1679886947"",
    ""current_price"": 5.83,
    ""market_cap"": 424334117,
    ""market_cap_rank"": 96,
    ""fully_diluted_valuation"": 581933075,
    ""total_volume"": 12171255,
    ""high_24h"": 5.98,
    ""low_24h"": 5.73,
    ""price_change_24h"": -0.07208131033073162,
    ""price_change_percentage_24h"": -1.22116,
    ""market_cap_change_24h"": -5124945.979553282,
    ""market_cap_change_percentage_24h"": -1.19335,
    ""circulating_supply"": 72704926.2219243,
    ""total_supply"": 99707752.7128909,
    ""max_supply"": 99707752.7128909,
    ""ath"": 42.8,
    ""ath_change_percentage"": -86.36703,
    ""ath_date"": ""2022-01-12T15:22:27.465Z"",
    ""atl"": 1.5,
    ""atl_change_percentage"": 288.17432,
    ""atl_date"": ""2021-06-25T16:50:51.447Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:26.717Z""
  },
  {
    ""id"": ""chiliz"",
    ""symbol"": ""chz"",
    ""name"": ""Chiliz"",
    ""image"": ""https://assets.coingecko.com/coins/images/8834/large/CHZ_Token_updated.png?1675848257"",
    ""current_price"": 0.077368,
    ""market_cap"": 414912086,
    ""market_cap_rank"": 97,
    ""fully_diluted_valuation"": 690131523,
    ""total_volume"": 19127968,
    ""high_24h"": 0.078497,
    ""low_24h"": 0.076439,
    ""price_change_24h"": 0.00021904,
    ""price_change_percentage_24h"": 0.28392,
    ""market_cap_change_24h"": 1882775,
    ""market_cap_change_percentage_24h"": 0.45585,
    ""circulating_supply"": 5344064580,
    ""total_supply"": 8888888888,
    ""max_supply"": 8888888888,
    ""ath"": 0.878633,
    ""ath_change_percentage"": -91.19755,
    ""ath_date"": ""2021-03-13T08:04:21.200Z"",
    ""atl"": 0.00410887,
    ""atl_change_percentage"": 1782.29809,
    ""atl_date"": ""2019-09-28T00:00:00.000Z"",
    ""roi"": {
      ""times"": 2.516737410151108,
      ""currency"": ""usd"",
      ""percentage"": 251.6737410151108
    },
    ""last_updated"": ""2023-06-27T17:54:27.012Z""
  },
  {
    ""id"": ""dash"",
    ""symbol"": ""dash"",
    ""name"": ""Dash"",
    ""image"": ""https://assets.coingecko.com/coins/images/19/large/dash-logo.png?1548385930"",
    ""current_price"": 35.9,
    ""market_cap"": 407089696,
    ""market_cap_rank"": 98,
    ""fully_diluted_valuation"": 678977770,
    ""total_volume"": 78040970,
    ""high_24h"": 36.97,
    ""low_24h"": 34.48,
    ""price_change_24h"": 1.27,
    ""price_change_percentage_24h"": 3.66424,
    ""market_cap_change_24h"": 13644125,
    ""market_cap_change_percentage_24h"": 3.46786,
    ""circulating_supply"": 11343724.9285943,
    ""total_supply"": 18920000,
    ""max_supply"": null,
    ""ath"": 1493.59,
    ""ath_change_percentage"": -97.5965,
    ""ath_date"": ""2017-12-20T00:00:00.000Z"",
    ""atl"": 0.213899,
    ""atl_change_percentage"": 16682.92333,
    ""atl_date"": ""2014-02-14T00:00:00.000Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:31.336Z""
  },
  {
    ""id"": ""flex-coin"",
    ""symbol"": ""flex"",
    ""name"": ""FLEX Coin"",
    ""image"": ""https://assets.coingecko.com/coins/images/9108/large/coinflex_logo.png?1628750583"",
    ""current_price"": 4.08,
    ""market_cap"": 401105604,
    ""market_cap_rank"": 99,
    ""fully_diluted_valuation"": 401393517,
    ""total_volume"": 506544,
    ""high_24h"": 4.44,
    ""low_24h"": 3.28,
    ""price_change_24h"": 0.769513,
    ""price_change_percentage_24h"": 23.21853,
    ""market_cap_change_24h"": 64027709,
    ""market_cap_change_percentage_24h"": 18.99493,
    ""circulating_supply"": 98664943.4492696,
    ""total_supply"": 98735764.894,
    ""max_supply"": 98735764.894,
    ""ath"": 7.56,
    ""ath_change_percentage"": -46.35514,
    ""ath_date"": ""2021-12-22T02:44:42.437Z"",
    ""atl"": 0.00047299,
    ""atl_change_percentage"": 857762.0065,
    ""atl_date"": ""2020-08-04T11:18:39.614Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:29.037Z""
  },
  {
    ""id"": ""woo-network"",
    ""symbol"": ""woo"",
    ""name"": ""WOO Network"",
    ""image"": ""https://assets.coingecko.com/coins/images/12921/large/w2UiemF__400x400.jpg?1603670367"",
    ""current_price"": 0.224416,
    ""market_cap"": 384321435,
    ""market_cap_rank"": 101,
    ""fully_diluted_valuation"": 504937438,
    ""total_volume"": 23670372,
    ""high_24h"": 0.224751,
    ""low_24h"": 0.205883,
    ""price_change_24h"": 0.01036975,
    ""price_change_percentage_24h"": 4.84463,
    ""market_cap_change_24h"": 16910810,
    ""market_cap_change_percentage_24h"": 4.6027,
    ""circulating_supply"": 1713036857.12031,
    ""total_supply"": 2250658857.90186,
    ""max_supply"": 2250658857.90186,
    ""ath"": 1.78,
    ""ath_change_percentage"": -87.41241,
    ""ath_date"": ""2021-11-15T13:44:18.437Z"",
    ""atl"": 0.02211546,
    ""atl_change_percentage"": 912.16198,
    ""atl_date"": ""2021-01-04T10:19:13.803Z"",
    ""roi"": null,
    ""last_updated"": ""2023-06-27T17:54:23.694Z""
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
        public List<Ticker> GetTickersByCurrencieId(string id)
        {
            string jsonResponse = "{\"name\":\"Bitcoin\",\"tickers\":[{\"base\":\"BTC\",\"target\":\"USDT\",\"market\":{\"name\":\"Binance\",\"identifier\":\"binance\",\"has_trading_incentive\":false},\"last\":30619.57,\"volume\":44282.944018793685,\"converted_last\":{\"btc\":1.000203,\"eth\":16.343658,\"usd\":30607},\"converted_volume\":{\"btc\":44292,\"eth\":723745,\"usd\":1355351463},\"trust_score\":\"green\",\"bid_ask_spread_percentage\":0.010033,\"timestamp\":\"2023-06-27T15:36:01+00:00\",\"last_traded_at\":\"2023-06-27T15:36:01+00:00\",\"last_fetch_at\":\"2023-06-27T15:36:01+00:00\",\"is_anomaly\":false,\"is_stale\":false,\"trade_url\":\"https://www.binance.com/en/trade/BTC_USDT?ref=37754157\",\"token_info_url\":null,\"coin_id\":\"bitcoin\",\"target_coin_id\":\"tether\"},{\"base\":\"BTC\",\"target\":\"USDT\",\"market\":{\"name\":\"BTCEX\",\"identifier\":\"btcex\",\"has_trading_incentive\":false},\"last\":30538.064,\"volume\":10072.4195,\"converted_last\":{\"btc\":1.000317,\"eth\":16.326153,\"usd\":30597},\"converted_volume\":{\"btc\":10040,\"eth\":163862,\"usd\":307091499},\"trust_score\":\"green\",\"bid_ask_spread_percentage\":0.010193,\"timestamp\":\"2023-06-27T15:49:09+00:00\",\"last_traded_at\":\"2023-06-27T15:49:09+00:00\",\"last_fetch_at\":\"2023-06-27T15:49:09+00:00\",\"is_anomaly\":false,\"is_stale\":false,\"trade_url\":\"https://www.btcex.com/spot?target=BTC-USDT\",\"token_info_url\":null,\"coin_id\":\"bitcoin\",\"target_coin_id\":\"tether\"}]}";

			try
			{
				JObject jsonObject = JObject.Parse(jsonResponse);

				var jsonArray = (JArray)jsonObject["tickers"];

                var tickers = new List<Ticker>();

				foreach (var jsonObj in jsonArray)
				{
                    tickers.Add(new Ticker()
                    {
                        Base = (string)jsonObj["base"],
                        Target = (string)jsonObj["target"],
                        MarketName = (string)jsonObj["market"]["name"],
                        TradeUrl = (string)jsonObj["trade_url"],
                        PriceInUSD = (string)jsonObj["converted_last"]["usd"]
					});
				}

				return tickers;
			}
			catch (Exception)
			{
				throw;
			}
		}
        public CurrencyDetails GetCurrencyDetailsById(string id)
		{
            /*https://api.coingecko.com/api/v3/coins/bitcoin?localization=false&tickers=false&market_data=true&community_data=false&developer_data=false&sparkline=false*/
			
            string jsonResponse = @"{
  ""id"": ""bitcoin"",
  ""symbol"": ""btc"",
  ""name"": ""Bitcoin"",
  ""image"": {
    ""thumb"": ""https://assets.coingecko.com/coins/images/1/thumb/bitcoin.png?1547033579"",
    ""small"": ""https://assets.coingecko.com/coins/images/1/small/bitcoin.png?1547033579"",
    ""large"": ""https://assets.coingecko.com/coins/images/1/large/bitcoin.png?1547033579""
  },
  ""market_data"": {
    ""current_price"": {
      ""aed"": 111604,
      ""ars"": 7773628,
      ""aud"": 45944,
      ""bch"": 129.576,
      ""bdt"": 3289058,
      ""bhd"": 11456.82,
      ""bmd"": 30385,
      ""bnb"": 129.868,
      ""brl"": 147443,
      ""btc"": 1,
      ""cad"": 40293,
      ""chf"": 27250,
      ""clp"": 24272998,
      ""cny"": 220351,
      ""czk"": 659869,
      ""dkk"": 207262,
      ""dot"": 6053,
      ""eos"": 43537,
      ""eth"": 16.289385,
      ""eur"": 27833,
      ""gbp"": 24073,
      ""hkd"": 238027,
      ""huf"": 10329558,
      ""idr"": 455811880,
      ""ils"": 111619,
      ""inr"": 2493195,
      ""jpy"": 4390681,
      ""krw"": 39874739,
      ""kwd"": 9341.54,
      ""lkr"": 9333794,
      ""ltc"": 354.28,
      ""mmk"": 63838468,
      ""mxn"": 519130,
      ""myr"": 141943,
      ""ngn"": 23247203,
      ""nok"": 328725,
      ""nzd"": 49956,
      ""php"": 1680074,
      ""pkr"": 8712921,
      ""pln"": 124943,
      ""rub"": 2628454,
      ""sar"": 113963,
      ""sek"": 328329,
      ""sgd"": 41136,
      ""thb"": 1083040,
      ""try"": 791878,
      ""twd"": 942495,
      ""uah"": 1122584,
      ""usd"": 30385,
      ""vef"": 3042.44,
      ""vnd"": 715613002,
      ""xag"": 1335.95,
      ""xau"": 15.92,
      ""xdr"": 22800,
      ""xlm"": 292712,
      ""xrp"": 64195,
      ""yfi"": 4.869105,
      ""zar"": 569244,
      ""bits"": 1000871,
      ""link"": 5038,
      ""sats"": 100087076
    },
    ""market_cap"": {
      ""aed"": 2157892188725,
      ""ars"": 150313552855225,
      ""aud"": 888551618168,
      ""bch"": 2529378840,
      ""bdt"": 63594876443114,
      ""bhd"": 221520881326,
      ""bmd"": 587501276538,
      ""bnb"": 2522250642,
      ""brl"": 2852553698103,
      ""btc"": 19414306,
      ""cad"": 779375080947,
      ""chf"": 527227758074,
      ""clp"": 469331269775278,
      ""cny"": 4260500507327,
      ""czk"": 12762883606528,
      ""dkk"": 4007688720511,
      ""dot"": 117622859300,
      ""eos"": 847805349879,
      ""eth"": 316106432,
      ""eur"": 538208156933,
      ""gbp"": 465508398969,
      ""hkd"": 4601919236671,
      ""huf"": 199736316367300,
      ""idr"": 8814526811484772,
      ""ils"": 2155841221768,
      ""inr"": 48201041682486,
      ""jpy"": 84912641740037,
      ""krw"": 771100996143446,
      ""kwd"": 180621392459,
      ""lkr"": 180471596083412,
      ""ltc"": 6877128748,
      ""mmk"": 1234335118920683,
      ""mxn"": 10037382934489,
      ""myr"": 2744512213348,
      ""ngn"": 449491351666584,
      ""nok"": 6362530724673,
      ""nzd"": 967088201315,
      ""php"": 32470018789208,
      ""pkr"": 168466837636658,
      ""pln"": 2415995599539,
      ""rub"": 50788309179169,
      ""sar"": 2203499325321,
      ""sek"": 6348886007526,
      ""sgd"": 795526078540,
      ""thb"": 20942824267617,
      ""try"": 15311029980707,
      ""twd"": 18223115183162,
      ""uah"": 21705476124727,
      ""usd"": 587501276538,
      ""vef"": 58826502820,
      ""vnd"": 13836582880914760,
      ""xag"": 25816856471,
      ""xau"": 307715544,
      ""xdr"": 440849795390,
      ""xlm"": 5735881935214,
      ""xrp"": 1244844723664,
      ""yfi"": 94532301,
      ""zar"": 10998238334760,
      ""bits"": 19416320509231,
      ""link"": 97920062914,
      ""sats"": 1941632050923061
    },
    ""market_cap_rank"": 1,
    ""fully_diluted_valuation"": {
      ""aed"": 2334141429687,
      ""ars"": 162590648873039,
      ""aud"": 961125470132,
      ""bch"": 2735969838,
      ""bdt"": 68789088072753,
      ""bhd"": 239613947975,
      ""bmd"": 635486368006,
      ""bnb"": 2728259433,
      ""brl"": 3085540511217,
      ""btc"": 21000000,
      ""cad"": 843031767392,
      ""chf"": 570289915053,
      ""clp"": 507664639945452,
      ""cny"": 4608483592144,
      ""czk"": 13805312213431,
      ""dkk"": 4335023004723,
      ""dot"": 127229891467,
      ""eos"": 917051186247,
      ""eth"": 341924922,
      ""eur"": 582167155271,
      ""gbp"": 503529530149,
      ""hkd"": 4977788233588,
      ""huf"": 216050094384693,
      ""idr"": 9534467162574866,
      ""ils"": 2331922946776,
      ""inr"": 52137937628685,
      ""jpy"": 91848015403733,
      ""krw"": 834081883689912,
      ""kwd"": 195373928980,
      ""lkr"": 195211897749610,
      ""ltc"": 7438829063,
      ""mmk"": 1335151382559559,
      ""mxn"": 10857201984159,
      ""myr"": 2968674568141,
      ""ngn"": 486204265297883,
      ""nok"": 6882200436016,
      ""nzd"": 1046076652321,
      ""php"": 35122058680509,
      ""pkr"": 182226631761641,
      ""pln"": 2613325842825,
      ""rub"": 54936524270429,
      ""sar"": 2383473600949,
      ""sek"": 6867441265119,
      ""sgd"": 860501923135,
      ""thb"": 22653362402960,
      ""try"": 16561582453416,
      ""twd"": 19711516798303,
      ""uah"": 23478305050887,
      ""usd"": 635486368006,
      ""vef"": 63631250028,
      ""vnd"": 14966707566019098,
      ""xag"": 27925488858,
      ""xau"": 332848695,
      ""xdr"": 476856896311,
      ""xlm"": 6204369120353,
      ""xrp"": 1346519375812,
      ""yfi"": 102253376,
      ""zar"": 11896536761601,
      ""bits"": 21002179047443,
      ""link"": 105917838175,
      ""sats"": 2100217904744278
    },
    ""total_volume"": {
      ""aed"": 53730982724,
      ""ars"": 3742565626467,
      ""aud"": 22119230174,
      ""bch"": 62383397,
      ""bdt"": 1583496722095,
      ""bhd"": 5515815252,
      ""bmd"": 14628636734,
      ""bnb"": 62523943,
      ""brl"": 70985459751,
      ""btc"": 481863,
      ""cad"": 19398713343,
      ""chf"": 13119180853,
      ""clp"": 11686086454892,
      ""cny"": 106086873594,
      ""czk"": 317689869892,
      ""dkk"": 99785222605,
      ""dot"": 2914003270,
      ""eos"": 20960561918,
      ""eth"": 7842425,
      ""eur"": 13400123821,
      ""gbp"": 11590034826,
      ""hkd"": 114596878213,
      ""huf"": 4973102294244,
      ""idr"": 219447838267573,
      ""ils"": 53738414071,
      ""inr"": 1200333696831,
      ""jpy"": 2113866404868,
      ""krw"": 19197448872241,
      ""kwd"": 4497428077,
      ""lkr"": 4493698184711,
      ""ltc"": 170565935,
      ""mmk"": 30734639708373,
      ""mxn"": 249931721463,
      ""myr"": 68337676503,
      ""ngn"": 11192223678754,
      ""nok"": 158262817605,
      ""nzd"": 24051058683,
      ""php"": 808861269443,
      ""pkr"": 4194782663317,
      ""pln"": 60153115165,
      ""rub"": 1265453000109,
      ""sar"": 54866589165,
      ""sek"": 158071899267,
      ""sgd"": 19804760413,
      ""thb"": 521423127744,
      ""try"": 381244655100,
      ""twd"": 453758368531,
      ""uah"": 540460996504,
      ""usd"": 14628636734,
      ""vef"": 1464765396,
      ""vnd"": 344527497533909,
      ""xag"": 643186634,
      ""xau"": 7662334,
      ""xdr"": 10977051061,
      ""xlm"": 140924558205,
      ""xrp"": 30906454321,
      ""yfi"": 2344201,
      ""zar"": 274059156258,
      ""bits"": 481863098952,
      ""link"": 2425570706,
      ""sats"": 48186309895219
    },
    ""total_supply"": 21000000,
    ""max_supply"": 21000000,
    ""circulating_supply"": 19414306
  },
  ""public_interest_stats"": {
    ""alexa_rank"": 9440,
    ""bing_matches"": null
  },
  ""status_updates"": [],
  ""last_updated"": ""2023-06-28T14:38:41.825Z""
}";

			try
			{
				JObject jsonObject = JObject.Parse(jsonResponse);

                CurrencyDetails currency = new CurrencyDetails();
                currency.Id = (string)jsonObject["id"];
                currency.Symbol = (string)jsonObject["symbol"];
                currency.Name = (string)jsonObject["name"];
                currency.Image = (string)jsonObject["image"]["large"];
                currency.MarketCap = (decimal)jsonObject["market_data"]["market_cap"]["usd"];
                currency.Rank = (int)jsonObject["market_data"]["market_cap_rank"];
                currency.Price = (decimal)jsonObject["market_data"]["current_price"]["usd"];
                currency.FullyDilutedValuation = (decimal)jsonObject["market_data"]["fully_diluted_valuation"]["usd"];
                currency.TotalVolume = (decimal)jsonObject["market_data"]["total_volume"]["usd"];
                currency.TotalSupply = (decimal)jsonObject["market_data"]["total_supply"];
                currency.CirculatingSupply = (decimal)jsonObject["market_data"]["circulating_supply"];

				return currency;
			}
			catch (Exception)
			{

				throw;
			}
		}
        public CoinPriceChartData GetCurrencyHistorycalMarketData(string CurrencyId, string days)
        {
			//https://api.coingecko.com/api/v3/coins/bitcoin/market_chart?vs_currency=usd&days=1&interval=5

			string jsonResponse = @"{
  ""prices"": [
    [
      1687897856445,
      30618.431505410103
    ],
    [
      1687898144536,
      30599.99445396842
    ],
    [
      1687898421276,
      30592.669792640692
    ],
    [
      1687898741125,
      30590.36907363265
    ],
    [
      1687898996396,
      30589.86586259212
    ],
    [
      1687899293356,
      30624.644665680727
    ],
    [
      1687899624271,
      30644.64832067187
    ],
    [
      1687899931017,
      30650.255783694356
    ],
    [
      1687900217949,
      30652.1958205672
    ],
    [
      1687900516399,
      30639.583839970008
    ],
    [
      1687900844605,
      30631.55789035104
    ],
    [
      1687901163101,
      30644.142872470242
    ],
    [
      1687901479920,
      30644.046805704456
    ],
    [
      1687901745150,
      30649.292053895642
    ],
    [
      1687902051937,
      30640.995343217463
    ],
    [
      1687902348181,
      30665.806305357764
    ],
    [
      1687902603857,
      30695.58040473857
    ],
    [
      1687902910837,
      30762.427364040886
    ],
    [
      1687903272096,
      30738.091565569943
    ],
    [
      1687903528116,
      30741.115015009476
    ],
    [
      1687903807174,
      30731.552212534592
    ],
    [
      1687904115909,
      30725.663587147374
    ],
    [
      1687904424478,
      30712.66076441425
    ],
    [
      1687904722312,
      30686.466865774586
    ],
    [
      1687905096119,
      30673.51677183306
    ],
    [
      1687905310613,
      30680.727774715542
    ],
    [
      1687905650149,
      30661.275568969173
    ],
    [
      1687905905672,
      30649.97140808091
    ],
    [
      1687906227859,
      30625.199714219347
    ],
    [
      1687906503234,
      30601.389167021232
    ],
    [
      1687906833279,
      30600.522500461633
    ],
    [
      1687907108805,
      30594.552625449585
    ],
    [
      1687907425925,
      30605.7180507909
    ],
    [
      1687907712429,
      30608.630669330774
    ],
    [
      1687908031424,
      30648.074430507713
    ],
    [
      1687908341082,
      30626.236989111974
    ],
    [
      1687908659018,
      30632.85463912879
    ],
    [
      1687908904248,
      30637.958450193983
    ],
    [
      1687909211907,
      30661.264587992573
    ],
    [
      1687909499659,
      30643.01021604429
    ],
    [
      1687909808089,
      30670.238398972793
    ],
    [
      1687910105473,
      30693.54635606798
    ],
    [
      1687910476309,
      30677.02681166844
    ],
    [
      1687910734225,
      30666.263839388772
    ],
    [
      1687910990856,
      30662.534638586167
    ],
    [
      1687911319155,
      30593.456099148945
    ],
    [
      1687911618825,
      30595.796944569767
    ],
    [
      1687911925625,
      30575.354546378367
    ],
    [
      1687912286647,
      30579.73314262931
    ],
    [
      1687912511811,
      30523.417962325526
    ],
    [
      1687912830409,
      30516.044647046714
    ],
    [
      1687913117118,
      30513.286314415203
    ],
    [
      1687913413900,
      30512.69963395172
    ],
    [
      1687913732655,
      30529.469131733833
    ],
    [
      1687914041709,
      30601.864524971417
    ],
    [
      1687914309945,
      30628.86205718727
    ],
    [
      1687914617649,
      30617.164293725888
    ],
    [
      1687914925523,
      30635.197968046326
    ],
    [
      1687915254143,
      30577.042290679736
    ],
    [
      1687915551550,
      30562.822692912032
    ],
    [
      1687915861246,
      30571.94019821519
    ],
    [
      1687916148184,
      30559.897261696482
    ],
    [
      1687916477885,
      30560.789240115555
    ],
    [
      1687916734744,
      30510.66925057534
    ],
    [
      1687917001816,
      30514.032648297547
    ],
    [
      1687917310941,
      30514.817560790405
    ],
    [
      1687917639449,
      30499.5382132967
    ],
    [
      1687917916284,
      30517.428549005643
    ],
    [
      1687918224757,
      30540.759678587605
    ],
    [
      1687918523179,
      30535.54386954223
    ],
    [
      1687918810298,
      30521.22334126058
    ],
    [
      1687919118949,
      30508.289437570776
    ],
    [
      1687919466991,
      30533.16746388128
    ],
    [
      1687919724164,
      30525.520635052115
    ],
    [
      1687920061759,
      30545.790821686354
    ],
    [
      1687920317956,
      30542.262519725584
    ],
    [
      1687920656074,
      30531.80111716605
    ],
    [
      1687920922747,
      30513.493374613012
    ],
    [
      1687921202292,
      30439.163370224687
    ],
    [
      1687921499807,
      30438.91014789692
    ],
    [
      1687921828616,
      30441.472623965743
    ],
    [
      1687922128659,
      30432.05561111853
    ],
    [
      1687922485659,
      30433.064018264242
    ],
    [
      1687922763048,
      30442.5067821242
    ],
    [
      1687923001421,
      30469.846692282834
    ],
    [
      1687923298811,
      30449.53433964389
    ],
    [
      1687923668911,
      30457.513083442183
    ],
    [
      1687923948113,
      30460.544381088206
    ],
    [
      1687924212766,
      30456.41367370499
    ],
    [
      1687924519900,
      30468.148539054357
    ],
    [
      1687924906753,
      30453.522638559632
    ],
    [
      1687925162652,
      30463.729933586448
    ],
    [
      1687925470704,
      30459.33408301156
    ],
    [
      1687925696511,
      30451.76795171114
    ],
    [
      1687925999556,
      30462.506679251394
    ],
    [
      1687926297073,
      30437.04941485683
    ],
    [
      1687926594163,
      30420.787220157166
    ],
    [
      1687926892398,
      30433.80194089315
    ],
    [
      1687927211286,
      30458.73632989582
    ],
    [
      1687927529733,
      30445.42687858052
    ],
    [
      1687927879180,
      30461.167867396056
    ],
    [
      1687928115667,
      30457.386223054567
    ],
    [
      1687928443767,
      30484.065345447125
    ],
    [
      1687928711046,
      30479.74446849667
    ],
    [
      1687929029953,
      30463.046655033184
    ],
    [
      1687929336126,
      30452.955196809267
    ],
    [
      1687929613249,
      30459.348887134074
    ],
    [
      1687929919876,
      30440.039899070336
    ],
    [
      1687930240672,
      30440.91776974537
    ],
    [
      1687930508024,
      30428.416760199525
    ],
    [
      1687930836548,
      30428.783746338664
    ],
    [
      1687931135189,
      30459.886065480594
    ],
    [
      1687931433929,
      30461.744606283326
    ],
    [
      1687931700741,
      30462.36877946909
    ],
    [
      1687932008106,
      30455.037294765945
    ],
    [
      1687932305060,
      30440.544699657978
    ],
    [
      1687932602234,
      30446.384092761957
    ],
    [
      1687932920896,
      30454.642183461583
    ],
    [
      1687933249338,
      30454.161988494583
    ],
    [
      1687933525015,
      30411.243106656075
    ],
    [
      1687933842931,
      30415.808172213154
    ],
    [
      1687934130444,
      30441.27489337084
    ],
    [
      1687934397150,
      30435.35084817276
    ],
    [
      1687934724947,
      30448.87859413154
    ],
    [
      1687935034030,
      30442.302872106487
    ],
    [
      1687935323105,
      30431.071044988646
    ],
    [
      1687935620711,
      30429.001564049908
    ],
    [
      1687935908464,
      30393.094219323513
    ],
    [
      1687936237998,
      30405.975868985777
    ],
    [
      1687936546158,
      30394.869416490812
    ],
    [
      1687936844747,
      30339.329051017423
    ],
    [
      1687937092011,
      30344.055401752994
    ],
    [
      1687937411846,
      30377.8576396
    ],
    [
      1687937731153,
      30330.19872942898
    ],
    [
      1687938088022,
      30306.557967498222
    ],
    [
      1687938334053,
      30290.551893680793
    ],
    [
      1687938681687,
      30252.22293016975
    ],
    [
      1687938949314,
      30180.930217518555
    ],
    [
      1687939267289,
      30178.660969637123
    ],
    [
      1687939545796,
      30180.94970858871
    ],
    [
      1687939872640,
      30186.98278826474
    ],
    [
      1687940142198,
      30181.482952719387
    ],
    [
      1687940450692,
      30211.810790429947
    ],
    [
      1687940757315,
      30251.997908317728
    ],
    [
      1687941036641,
      30257.15109627116
    ],
    [
      1687941345570,
      30253.23191153777
    ],
    [
      1687941613020,
      30246.166573151113
    ],
    [
      1687941900956,
      30261.214724077978
    ],
    [
      1687942207014,
      30233.09792459597
    ],
    [
      1687942504886,
      30262.471294367937
    ],
    [
      1687942803819,
      30270.93176226537
    ],
    [
      1687943144996,
      30253.14333337285
    ],
    [
      1687943487938,
      30248.54313011659
    ],
    [
      1687943703794,
      30249.972159438432
    ],
    [
      1687944000655,
      30260.894824451734
    ],
    [
      1687944328700,
      30258.066451864226
    ],
    [
      1687944656559,
      30327.758097410777
    ],
    [
      1687944944125,
      30332.501825819734
    ],
    [
      1687945210942,
      30326.829706426404
    ],
    [
      1687945508592,
      30315.94256113485
    ],
    [
      1687945827680,
      30309.547544143246
    ],
    [
      1687946125610,
      30297.077325251306
    ],
    [
      1687946472158,
      30309.083219457636
    ],
    [
      1687946759015,
      30307.768250998917
    ],
    [
      1687947046434,
      30301.784711937915
    ],
    [
      1687947322582,
      30297.190324268322
    ],
    [
      1687947651054,
      30298.542778143175
    ],
    [
      1687947930239,
      30299.765413586025
    ],
    [
      1687948299120,
      30302.223959053674
    ],
    [
      1687948535208,
      30312.95805039491
    ],
    [
      1687948831787,
      30333.151267308825
    ],
    [
      1687949130622,
      30323.045639196123
    ],
    [
      1687949429527,
      30331.451321799614
    ],
    [
      1687949757859,
      30326.664152114467
    ],
    [
      1687950035719,
      30334.234501781015
    ],
    [
      1687950332484,
      30338.450962225354
    ],
    [
      1687950651239,
      30337.48680469394
    ],
    [
      1687950938387,
      30333.914656697347
    ],
    [
      1687951235873,
      30340.39054783488
    ],
    [
      1687951545884,
      30343.402139621016
    ],
    [
      1687951843026,
      30348.056677528133
    ],
    [
      1687952129708,
      30342.19797702375
    ],
    [
      1687952437620,
      30347.03086949185
    ],
    [
      1687952736164,
      30365.45934600613
    ],
    [
      1687953043917,
      30373.755469213156
    ],
    [
      1687953300099,
      30365.94644623768
    ],
    [
      1687953610442,
      30356.262770199464
    ],
    [
      1687953906600,
      30300.112254405904
    ],
    [
      1687954288265,
      30284.48420230075
    ],
    [
      1687954493598,
      30276.006084525558
    ],
    [
      1687954812700,
      30277.013891088594
    ],
    [
      1687955121815,
      30305.357595308706
    ],
    [
      1687955429753,
      30309.873807927353
    ],
    [
      1687955749075,
      30332.483884168672
    ],
    [
      1687956056720,
      30316.095975138254
    ],
    [
      1687956333509,
      30223.015163481476
    ],
    [
      1687956682939,
      30263.384226912403
    ],
    [
      1687956921048,
      30251.58768576929
    ],
    [
      1687957264329,
      30098.49319936007
    ],
    [
      1687957502358,
      30073.868397898357
    ],
    [
      1687957821468,
      30073.85070212852
    ],
    [
      1687958129818,
      30166.992723379244
    ],
    [
      1687958396549,
      30166.192161548064
    ],
    [
      1687958703934,
      30163.210833491736
    ],
    [
      1687959024884,
      30162.45636161822
    ],
    [
      1687959323206,
      30180.860007961062
    ],
    [
      1687959611560,
      30184.614078249324
    ],
    [
      1687959940092,
      30195.62045966381
    ],
    [
      1687960249701,
      30173.775667348502
    ],
    [
      1687960517651,
      30181.45399608657
    ],
    [
      1687960853062,
      30177.34386252665
    ],
    [
      1687961161360,
      30188.33045752025
    ],
    [
      1687961498765,
      30200.207915547864
    ],
    [
      1687961746841,
      30196.799066462714
    ],
    [
      1687962056383,
      30199.608820777717
    ],
    [
      1687962354930,
      30275.446417930565
    ],
    [
      1687962701300,
      30261.255619344
    ],
    [
      1687962916628,
      30327.907581854222
    ],
    [
      1687963245349,
      30450.803512143204
    ],
    [
      1687963542601,
      30458.586916254255
    ],
    [
      1687963870171,
      30418.222113079
    ],
    [
      1687964138034,
      30415.639640670775
    ],
    [
      1687964476931,
      30391.132702761683
    ],
    [
      1687964733502,
      30383.144595424426
    ],
    [
      1687965082513,
      30407.907597414607
    ],
    [
      1687965328489,
      30356.34703641829
    ],
    [
      1687965628552,
      30386.54232651214
    ],
    [
      1687965946721,
      30374.503702524726
    ],
    [
      1687966223433,
      30373.104095842475
    ],
    [
      1687966531492,
      30383.795860955448
    ],
    [
      1687966839922,
      30379.835871907526
    ],
    [
      1687967137491,
      30444.827112744893
    ],
    [
      1687967466270,
      30400.70878260752
    ],
    [
      1687967701567,
      30390.915410524896
    ],
    [
      1687968020745,
      30404.600869214308
    ],
    [
      1687968298269,
      30413.40973998819
    ],
    [
      1687968608829,
      30420.59407228828
    ],
    [
      1687968908065,
      30418.316495395968
    ],
    [
      1687969206098,
      30392.82230542819
    ],
    [
      1687969503256,
      30405.635085494512
    ],
    [
      1687969841719,
      30383.528314073206
    ],
    [
      1687970130855,
      30379.98873454855
    ],
    [
      1687970445389,
      30339.450119251665
    ],
    [
      1687970702016,
      30363.068871701187
    ],
    [
      1687971031406,
      30346.715302662986
    ],
    [
      1687971320575,
      30333.129666720717
    ],
    [
      1687971691757,
      30306.739357480987
    ],
    [
      1687971917572,
      30289.011669923286
    ],
    [
      1687972245761,
      30112.16636064836
    ],
    [
      1687972525255,
      30117.57699287413
    ],
    [
      1687972803714,
      30110.513871723466
    ],
    [
      1687973100895,
      30148.96759168473
    ],
    [
      1687973419885,
      30169.52431998867
    ],
    [
      1687973709580,
      30174.752505390887
    ],
    [
      1687974018618,
      30098.064721942108
    ],
    [
      1687974307278,
      30113.38573007971
    ],
    [
      1687974615652,
      30122.451159380376
    ],
    [
      1687974923727,
      30129.351513145535
    ],
    [
      1687975293599,
      30165.786328770137
    ],
    [
      1687975498825,
      30184.002793362826
    ],
    [
      1687975869980,
      30164.58953660656
    ],
    [
      1687976146628,
      30173.4028170059
    ],
    [
      1687976424504,
      30186.624068382942
    ],
    [
      1687976742822,
      30199.48174664203
    ],
    [
      1687976999956,
      30206.43080368866
    ],
    [
      1687977316984,
      30220.70733291953
    ],
    [
      1687977634628,
      30234.266611911316
    ],
    [
      1687977942020,
      30258.00781532829
    ],
    [
      1687978249918,
      30242.613118540794
    ],
    [
      1687978506929,
      30197.222962972308
    ],
    [
      1687978859494,
      30191.127651254246
    ],
    [
      1687979138302,
      30188.045064646638
    ],
    [
      1687979435203,
      30182.518357198212
    ],
    [
      1687979745389,
      30203.265118594343
    ],
    [
      1687980003210,
      30249.605748675356
    ],
    [
      1687980322110,
      30234.515334671596
    ],
    [
      1687980651535,
      30158.637246574024
    ],
    [
      1687980928258,
      30192.027569795642
    ],
    [
      1687981227046,
      30207.367501692097
    ],
    [
      1687981523900,
      30016.54640920967
    ],
    [
      1687981821991,
      30027.350655280487
    ],
    [
      1687982151409,
      30073.870146712616
    ],
    [
      1687982418285,
      30113.377866157047
    ],
    [
      1687982737714,
      30079.37468317627
    ],
    [
      1687983047565,
      30037.429055544893
    ],
    [
      1687983303403,
      30019.666467572642
    ],
    [
      1687983599841,
      30032.144607908678
    ],
    [
      1687983921970,
      30053.143535656218
    ],
    [
      1687984074000,
      30047.36367892102
    ]
  ]
}";

			try
			{
				CoinPriceChartData chartData = JsonConvert.DeserializeObject<CoinPriceChartData>(jsonResponse);

				return chartData;
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}
