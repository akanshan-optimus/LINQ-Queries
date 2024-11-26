using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*you have a collection of Product objects, each with ProductID and StockQuantity 
     * properties. Write a LINQ query to remove all products that have a StockQuantity less than 10.*/

    class Product2
    {
    public int ProductId { get; set; }
        public int StockQuantity {  get; set; }


    }

    internal class SeventhQuestion
    {
        List<Product2> products = new List<Product2>()
        {new Product2(){ ProductId=1, StockQuantity=2},
        new Product2(){ProductId=2, StockQuantity=30 },
        new Product2(){ProductId=3, StockQuantity=12 },
        new Product2(){ ProductId=4, StockQuantity=9} };

        public void Execution()
        {
           /* foreach (var product in products)
            {
                Console.WriteLine("ID : " + product.ProductId + " Stock Quantity : " + product.StockQuantity);
            }*/

            products.RemoveAll(x => x.StockQuantity < 10);

            foreach (var product in products)
            {
                Console.WriteLine("ID : "+ product.ProductId+" Stock Quantity : "+product.StockQuantity);
            }
       
        }
    }
}
