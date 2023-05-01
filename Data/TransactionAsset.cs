using System;
namespace client.Data
{
	public class TransactionAsset
	{
        // this definition adapted from json2csharp.com
        // TransactionAsset myDeserializedClass = JsonConvert.DeserializeObject<TransactionAsset>(myJsonResponse);
        public int id { get; set; }
        public string name { get; set; }
        public string ticker_symbol { get; set; }
        public int asset_type { get; set; }
    }
}

