using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*Given a collection of Product objects, write a LINQ query to find the first product 
     * whose Price is greater than $100. If no such product exists, return a null or default value.*/

    class Product6
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
    }

    internal class NinthQuestion
    {
        List<Product6> products = new List<Product6>
        {
         new Product6() { ProductId=4, ProductName="Product 4", Price=200 },
         new Product6() { ProductId = 1, ProductName = "[Product 1]", Price = 450 },
         new Product6() { ProductId = 2, ProductName = "[Product 2]", Price = 500 },
         new Product6() { ProductId = 3, ProductName = "[Product 3]", Price = 400 },

        };

        public void Execution()
        {
            var ans=products.Where(x=>x.Price>500).FirstOrDefault();
            if (ans == null)
            {
                Console.WriteLine("Empty");
            }
            else
            {
                Console.WriteLine(ans.ProductName+" "+ ans.Price+" "+ans.ProductId);
            }
        }


    }
}
