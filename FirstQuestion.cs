using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }

        public int Price { get; set; }


    }

    public class Queries
    {
        List<Product> products = new List<Product>()
        {
         new Product(){ ProductId=1, Name="product1", Price=100 },
         new Product(){ ProductId=2, Name="product2", Price=30},
         new Product(){ ProductId=3,Name="product3", Price=54}
        };

        public void Execution()
        {
            var product = products.Where(x => x.Price > 50).Select(x => new { x.ProductId, x.Name });

            foreach (var v in product)
            {
                Console.WriteLine(v.Name + " " + v.ProductId);
            }

        }
    }
}
