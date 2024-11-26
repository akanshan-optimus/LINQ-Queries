using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*Given a list of Product objects with ProductID, ProductName, and Price, 
     * write a LINQ query to return all products whose Price is between $30 and $100, 
     * and whose ProductName contains the word "Lamp".*/

    public class Product5
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }

    }
        internal class TwelveQuestion
        {
        List<Product5> products = new List<Product5>
        {
            new Product5 { ProductID = 2, ProductName = "Smartphone", Price = 90 },
            new Product5 { ProductID = 3, ProductName = "Lamp", Price = 300 },
            new Product5 { ProductID = 7, ProductName = "Mouse", Price = 25 },
            new Product5 { ProductID = 8, ProductName = "Monitor", Price = 30 }
        };

        public void Execution()
        {
           var ans= products.Where(x =>( (x.Price > 30 && x.Price < 100) || x.ProductName.Contains("Lamp")));
            foreach (var x in ans)
            {
                Console.WriteLine($"ProductId : {x.ProductID}, Price : {x.Price}, ProductName : {x.ProductName}");
            }
            
        }
    }
}    
