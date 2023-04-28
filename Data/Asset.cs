using System;
namespace client.Data
{
    //public struct Asset
    //{
    //	public Asset(int id, string name, string ticker_symbol, int asset_type)
    //	{
    //		Id = id;
    //		Name = name;
    //		Symbol = ticker_symbol;
    //		AssetType = asset_type;
    //	}

    //	public int Id { get; set; }
    //	public string Name { get; set; }
    //	public string Symbol { get; set; }
    //	public int AssetType { get; set; }
    //   }

    public class Asset
    {
        //public Asset(int id, string name, string ticker_symbol, int asset_type)
        //{
        //    Id = id;
        //    Name = name;
        //    Symbol = ticker_symbol;
        //    AssetType = asset_type;
        //}

        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Symbol { get; set; }
        public int AssetType { get; set; }
    }
}

