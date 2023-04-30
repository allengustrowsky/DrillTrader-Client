using System;
namespace client.Data
{
    // Definition adapted from json2csharp.com
    // RooAssetPriceDatat myDeserializedClass = JsonConvert.DeserializeObject<AssetPriceData>(myJsonResponse);
    public class AssetPriceData
    {
        public string name { get; set; }
        public double currentPrice { get; set; }
        public long time { get; set; }
        public string assetType { get; set; }
    }
}

