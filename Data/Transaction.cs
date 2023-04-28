using System;
namespace client.Data
{
	public struct Transaction
	{
		public Transaction(int id, double units, double price_per_unit, bool is_buy, string created_at, Asset asset, int portfolio)
		{
			Id = id;
			Units = units;
			Ppu = price_per_unit;
			IsBuy = is_buy;
			CreatedAt = created_at;
			Asset = asset;
			Portfolio = portfolio;
		}

		public int Id { get; set; }
		public double Units { get; set; }
        public double Ppu { get; set; }
        public bool IsBuy { get; set; }
        public string CreatedAt { get; set; }
		public Asset Asset { get; set; }
		public int Portfolio { get; set; }
    }
}

