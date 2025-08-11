using Sales.Models;

namespace Sales
{
    public class SeasonalData
    {
        public required string SeasonName { get; set; }
        
        public List<ProductSale>  TotalSales { get; set; }

    }
}
