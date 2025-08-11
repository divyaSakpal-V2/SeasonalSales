using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Models;
using Sales.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;


namespace Sales
{
    public class Repository : IRepository
    {
        readonly List<Sale> monthlySales;

        List<Season> seasonMaster;
        public Repository()
        {
            seasonMaster = new List<Season>()
        {
            new Season { SeasonName = "spring", months = new List<int>() { 3, 4, 5 } },
            new Season { SeasonName = "summer", months = new List<int>() { 6, 7, 8 } },
            new Season { SeasonName = "autumn", months = new List<int>() { 9, 10, 11 } },
            new Season { SeasonName = "winter", months = new List<int>() { 1, 2, 12 } },
        };

            monthlySales = new List<Sale>
    {
        // Sales data from January to September 2023
        // January 2023
        new Sale { ProductName = "Laptop", QuantitySold = 65, SaleDate = new DateTime(2023, 01, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 55, SaleDate = new DateTime(2023, 01, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 30, SaleDate = new DateTime(2023, 01, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 20, SaleDate = new DateTime(2023, 01, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 15, SaleDate = new DateTime(2023, 01, 01) },

        // February 2023
        new Sale { ProductName = "Laptop", QuantitySold = 70, SaleDate = new DateTime(2023, 02, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 45, SaleDate = new DateTime(2023, 02, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 25, SaleDate = new DateTime(2023, 02, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 25, SaleDate = new DateTime(2023, 02, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 14, SaleDate = new DateTime(2023, 02, 01) },

        // March 2023
        new Sale { ProductName = "Laptop", QuantitySold = 55, SaleDate = new DateTime(2023, 03, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 60, SaleDate = new DateTime(2023, 03, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 40, SaleDate = new DateTime(2023, 03, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 30, SaleDate = new DateTime(2023, 03, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 12, SaleDate = new DateTime(2023, 03, 01) },

        // April 2023
        new Sale { ProductName = "Laptop", QuantitySold = 75, SaleDate = new DateTime(2023, 04, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 50, SaleDate = new DateTime(2023, 04, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 35, SaleDate = new DateTime(2023, 04, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 35, SaleDate = new DateTime(2023, 04, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 10, SaleDate = new DateTime(2023, 04, 01) },

        // May 2023
        new Sale { ProductName = "Laptop", QuantitySold = 80, SaleDate = new DateTime(2023, 05, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 70, SaleDate = new DateTime(2023, 05, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 45, SaleDate = new DateTime(2023, 05, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 40, SaleDate = new DateTime(2023, 05, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 9, SaleDate = new DateTime(2023, 05, 01) },

        // June 2023
        new Sale { ProductName = "Laptop", QuantitySold = 85, SaleDate = new DateTime(2023, 06, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 65, SaleDate = new DateTime(2023, 06, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 50, SaleDate = new DateTime(2023, 06, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 45, SaleDate = new DateTime(2023, 06, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 8, SaleDate = new DateTime(2023, 06, 01) },

        // July 2023
        new Sale { ProductName = "Laptop", QuantitySold = 90, SaleDate = new DateTime(2023, 07, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 75, SaleDate = new DateTime(2023, 07, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 55, SaleDate = new DateTime(2023, 07, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 50, SaleDate = new DateTime(2023, 07, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 7, SaleDate = new DateTime(2023, 07, 01) },

        // August 2023
        new Sale { ProductName = "Laptop", QuantitySold = 95, SaleDate = new DateTime(2023, 08, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 80, SaleDate = new DateTime(2023, 08, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 60, SaleDate = new DateTime(2023, 08, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 55, SaleDate = new DateTime(2023, 08, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 6, SaleDate = new DateTime(2023, 08, 01) },

        // September 2023
        new Sale { ProductName = "Laptop", QuantitySold = 100, SaleDate = new DateTime(2023, 09, 01) },
        new Sale { ProductName = "Smartphone", QuantitySold = 85, SaleDate = new DateTime(2023, 09, 01) },
        new Sale { ProductName = "Tablet", QuantitySold = 65, SaleDate = new DateTime(2023, 09, 01) },
        new Sale { ProductName = "Headphones", QuantitySold = 60, SaleDate = new DateTime(2023, 09, 01) },
        new Sale { ProductName = "Watch", QuantitySold = 5, SaleDate = new DateTime(2023, 09, 01) }
    };
        }


        public async Task<List<SeasonalData>> GetDataAsync(int topN)
        {

            var P = monthlySales
                 .GroupBy(s => (seasonMaster.Find(x => (x.months.Contains(s.SaleDate.Month)))).SeasonName)
                 .Select(seasonwisegrp => new SeasonalData()
                 {
                     SeasonName = seasonwisegrp.Key,
                     TotalSales = seasonwisegrp.GroupBy(x => x.ProductName)
                                            .Select(prdwisegrp => new ProductSale()
                                            {
                                                ProductName = prdwisegrp.Key,
                                                TotalQuantitySold = prdwisegrp.Sum(x => x.QuantitySold),
                                            }).OrderByDescending(result=>result.TotalQuantitySold).Take(topN).ToList()
                 });
  
            return P.ToList();
        }

    }
}

