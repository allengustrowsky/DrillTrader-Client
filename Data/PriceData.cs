using System;
namespace client.Data
{
	public class PriceData
	{
		public static Dictionary<string, AssetPriceData> Data { get; set; } = new Dictionary<string, AssetPriceData>();
	}
}

