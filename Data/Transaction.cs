using System;
namespace client.Data
{
    public class Transaction
    {
        public int id { get; set; }
        public double units { get; set; }
        public double price_per_unit { get; set; }
        public bool is_buy { get; set; }
        public DateTime created_at { get; set; }
        public TransactionAsset asset { get; set; }
        public int portfolio { get; set; }
    }
}

