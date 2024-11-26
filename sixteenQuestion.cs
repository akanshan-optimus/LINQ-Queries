using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*ou have two collections of Product objects: ProductsA and ProductsB. 
     * Write a LINQ query to combine the two collections into a single collection of products,
     * ensuring there are no duplicates (use Distinct).*/

    class Product3
    { 
        public int Id { get; set; } 
        public string Name { get; set; }

        public int Quantity { get; set; }
    }
    internal class sixteenQuestion
    {
        List<Product3> productA = new List<Product3>()
        { new Product3(){ Id=1, Name="Product 1", Quantity=2},
            new Product3(){Id=2, Name="Product 2", Quantity=3 },
            new Product3(){Id=3, Name="Product 3", Quantity=4 }
        };

        List<Product3> productB = new List<Product3>()
        {
            new Product3(){ Id=1, Name="Product 1", Quantity = 2},
            new Product3(){ Id=2, Name="Product 2", Quantity=8 }
         };

        public void Execution()
        { 
          //var ans=productA.Union(productB);
          var ans = productA.Union(productB).DistinctBy(x => new { x.Id, x.Name, x.Quantity });
            foreach (var item in ans)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name} Quantity : {item.Quantity}");
            }

        }




    }
}
