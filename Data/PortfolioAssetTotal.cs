using System;
namespace client.Data
{
	public class PortfolioAssetTotal
	{
		public static Dictionary<int, PortfolioAssetTotalDatum> Data { get; set; } = new Dictionary<int, PortfolioAssetTotalDatum>();
        // {
        //		[assetType id]: {
        //			"name": "Stock",
        //		    "value": 1203.23
        //		}
        // }
        public static List<string> LabelList = new List<String>();
        //public static List<string> Values = new List<String>();
    }
}

