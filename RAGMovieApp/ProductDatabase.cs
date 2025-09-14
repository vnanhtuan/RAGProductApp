namespace RAGMovieApp
{
    public static class ProductDatabase
    {
        public static List<Product> GetProducts()
        {
            var productData = new List<Product>()
            {
                new()
                {
                    Name = "Smart Tivi Sony 4K 55 inch KD-55X80L",
                    Type = "Tivi",
                    Description = "Màn hình 55\", 4K, HDR10, Google TV, Điều khiển giọng nói, Dolby Vision",
                    Price = 14990000,
                    Reference = "https://en.wikipedia.org/wiki/Smart_Tivi_Sony"
                },
                new()
                {
                    Name = "Tủ lạnh Panasonic Inverter 322 lít NR-BC360QKVN",
                    Type = "Tủ lạnh",
                    Description = "322 lít, Inverter, Ag Clean, Làm lạnh nhanh, tiết kiệm điện",
                    Price = 11000000,
                    Reference = "https://en.wikipedia.org/wiki/Tu_lanh_Panasonic"
                },
                new()
                {
                    Name = "Điều hòa Casper Inverter 1 HP GC-09IS32",
                    Type = "Điều hòa",
                    Description = "1 HP, Inverter, tự làm sạch, Làm lạnh nhanh, tiết kiệm điện",
                    Price = 7000000,
                    Reference = "https://en.wikipedia.org/wiki/dieu_hoa_Casper"
                },
                new()
                {
                    Name = "Smart Tivi Casper 43 inch 43FX6200",
                    Type = "Tivi",
                    Description = "43\", Full HD, Android TV, Hỗ trợ YouTube, Netflix",
                    Price = 6000000,
                    Reference = "https://en.wikipedia.org/wiki/Smart_Tivi_Casper"
                },
                new()
                {
                    Name = "Smart Tivi Samsung 65 inch 4K UA65CU8000",
                    Type = "Tivi",
                    Description = "65\", 4K, Tizen OS, HDR10+, Điều khiển giọng nói, Remote đa năng",
                    Price = 18000000,
                    Reference = "https://en.wikipedia.org/wiki/Smart_Tivi_Samsung"
                },
                new()
                {
                    Name = "Máy lạnh Daikin Inverter 2 HP FTKB25WAVMV",
                    Type = "Điều hòa",
                    Description = "2 HP, Inverter, chống ẩm mốc, Làm lạnh nhanh, vận hành êm",
                    Price = 14500000,
                    Reference = "https://en.wikipedia.org/wiki/May_lanh_Daikin"
                },
            };
            return productData;
        }
    }
}
