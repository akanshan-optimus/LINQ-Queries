using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*
     Given a list of Product objects and a list of ProductIDs that you want to check for availability, 
    write a LINQ query to return all Product objects whose ProductID exists in the provided list of ProductIDs.*/

    class Product4
    { 
     public int Id { get; set; }
        public string Name { get; set; }

        public int Quantity { get; set; }
    }
    internal class FifteenQuestion
    {
        List<Product3> product = new List<Product3>()
        { new Product3(){ Id=1, Name="Product 1", Quantity=2},
            new Product3(){Id=2, Name="Product 2", Quantity=3 },
            new Product3(){Id=9, Name="Product 3", Quantity=4 }
        };

        List<int> productId = new List<int>() {1,2,3,4,5 };

        public void Execution()
        {
            // var ans= product.Join(productId, x=>x.Id,y=>y, (x, y) => new {x.Id, x.Name, y });
            var ans = product.Where(x => productId.Contains(x.Id));
            foreach (var item in ans)
            {
                Console.WriteLine($"Id : {item.Id} Name : {item.Name}");
            }
        }
    }
}
