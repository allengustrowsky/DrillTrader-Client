using System;
namespace client.Data
{
    // this definition adapted from json2csharp.com
	public class TransactionRequest
	{
        // TransactionRequest myDeserializedClass = JsonConvert.DeserializeObject<TransactionRequest>(myJsonResponse);
        public int portfolio_id { get; set; }
        public int asset_id { get; set; }
        public double units { get; set; }
        public bool is_buy { get; set; }

    }
}

