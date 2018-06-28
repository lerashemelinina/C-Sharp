using System;
using System.Linq;

namespace entity_framework_HW
{
    class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindEntities ef = new NorthwindEntities())
            {

                Product[] productArr = ef.Products.Where(p => p.ProductName.Length == p.Category.CategoryName.Length).ToArray();

                foreach (Product prod in productArr)
                {
                    Console.WriteLine($"product name is {prod.ProductName}, prodact categoty name is" +
                                      $" {prod.Category.CategoryName} and its price before discount is {prod.UnitPrice}");

                    prod.UnitPrice = prod.UnitPrice * 0.9M;
                }

                Console.WriteLine("-----------------------------------------------");
                foreach (Product prod in productArr)
                {
                    Console.WriteLine($"product name is {prod.ProductName} and its price after discount is {prod.UnitPrice}");
                  
                }

                ef.SaveChanges();

                Console.ReadKey();
            }
        }
    }
}
