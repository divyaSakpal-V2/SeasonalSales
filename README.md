# SeasonalSales
# Story: Trend Analysis of Seasonal Product Sales
#
# As a business analyst, aid the marketing team by determining the top-selling products in each season to optimize promotional strategies.
#
# Acceptance Criteria:
# 1. Data Access:
#    - Retrieve product sales data (ECommerceApplication.Data.Db.MonthlySales), noting the sales data includes timestamps.
#
# 2. Algorithm Focus:
#    - Calculate total sales for each product grouped by season (Spring, Summer, Autumn, Winter).
#      - Spring: March, April, May
#      - Summer: June, July, August
#      - Autumn: September, October, November
#      - Winter: December, January, February
#    - Ensure high efficiency in time and space complexity due to large data volumes.
#
# 3. Return Data:
#    - Return a list of the top N products by sales volume for each season.
#
# 4. Parameterization:
#    - Accept an integer N to specify how many top products to return for each season.
#
# Example API Request:
GET http://localhost:5141/products/seasonal-tops?topN=3
 
public static readonly List<Sale> MonthlySales =
[
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
];
