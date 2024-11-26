using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{

    /*You have a list of Sale objects with ProductID, SaleDate, and QuantitySold properties.
     * Write a LINQ query to find the total quantity sold for each product in the past 30 days.*/

    public class Sale
    {
        public int ProductID { get; set; }
        public DateTime SaleDate { get; set; }
        public int QuantitySold { get; set; }
    }
    internal class FifthQuestion
    {
        List<Sale> sales = new List<Sale>
      {
        new Sale { ProductID = 1, SaleDate = DateTime.Now.AddDays(-20), QuantitySold = 10 },
        new Sale { ProductID = 2, SaleDate = DateTime.Now.AddDays(-10), QuantitySold = 5 },
        new Sale { ProductID = 1, SaleDate = DateTime.Now.AddDays(-10), QuantitySold = 7 },
        new Sale { ProductID = 3, SaleDate = DateTime.Now.AddDays(-15), QuantitySold = 3 },
        new Sale { ProductID = 2, SaleDate = new DateTime(2024, 10, 4), QuantitySold = 8 },
        new Sale { ProductID = 1, SaleDate = new DateTime(2024, 10, 5), QuantitySold = 12 },
     };

        public void Execution()
        {

            var PastThirtyDates = sales.Where(x => x.SaleDate > x.SaleDate.AddDays(-30));
            var ans = PastThirtyDates.GroupBy(x => x.ProductID).Select(x => new { x.Key, TotalQuantitySold = x.Sum(x => x.QuantitySold) });

            var res = sales.Where(s => s.SaleDate >= DateTime.Now.AddDays(-30)).GroupBy(x => x.ProductID).Select(x => new { x.Key, TotalQuantitySold = x.Sum(x => x.QuantitySold) });

            foreach (var item in res)
            {
                Console.WriteLine($"ProductID: {item.Key}, Total Quantity Sold: {item.TotalQuantitySold}");
            }


            var maxValue = sales.Aggregate(0, (max, Qs) => Qs.QuantitySold > max ? Qs.QuantitySold : max);
            Console.WriteLine(maxValue);

            var minValue = sales.Aggregate(int.MaxValue, (min, Qs) => Qs.QuantitySold < min ? Qs.QuantitySold : min);
            Console.WriteLine(minValue);

            List<int> val = new List<int>() { 1, 2, 3, 4, 5 };
            var a = val.Aggregate(int.MaxValue, (min, x) => x < min ? x : min);
            Console.WriteLine(a);


            List<Im> im = new List<Im>() { 
             new Im(){name="name1", list=new List<Cm>(){ new Cm() { id = 1, age = 34 } } },
             new Im(){ name="name2", list=new List<Cm>(){ new Cm() { id=2, age=45} } }
            };



            im.SelectMany(x => x.list, (x, y) => new {x.name, y.age, y.id });



        }

            }


    class Im
    {
        public string name { get; set; }
        public List<Cm> list { get; set; }
    }


    class Cm
    {
        public int id { get; set; }

        public int age { get; set; }
    }


}
            

       

