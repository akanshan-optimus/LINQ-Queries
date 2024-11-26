using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have a collection of Order objects with OrderID, 
     * CustomerID, OrderAmount, and OrderDate properties.Write a LINQ query to 
     * group the orders by CustomerID and calculate the total OrderAmount for each customer.
   */


    public class Order
    { 
      public int OrderId { get; set; } 
        public int CustomerId { get; set; }
        public int OrderAmount { get; set; }
       



    }
    internal class SecondQuesion
    {
        List<Order> list = new List<Order>() 
        { 
        new Order(){OrderId=1, CustomerId=2, OrderAmount=3},
        new Order(){OrderId=2, CustomerId=1, OrderAmount=4 },
        new Order(){ OrderId=3, CustomerId=2, OrderAmount=2},
        new Order(){ OrderId=4, CustomerId=1, OrderAmount=4},
        new Order(){ OrderId=5, CustomerId=3, OrderAmount=3}
        };

        public void Execution()
        {

            var order = list.GroupBy(x => x.CustomerId).Select(x => new { x.Key, TotalOrderAmount=x.Sum(x=>x.OrderAmount)});

            foreach (var item in order)
            {
                Console.WriteLine(item.Key+" "+item.TotalOrderAmount);
                
            }













            /* Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

             foreach (var v in list)
             {

                 if (keyValuePairs.ContainsKey(v.CustomerId))
                 {
                     keyValuePairs[v.CustomerId] += v.OrderAmount;
                 }
                 else 
                 {
                   keyValuePairs.Add(v.CustomerId, v.OrderAmount);
                 }
             }



             foreach (var kv in keyValuePairs)
             {
                 Console.WriteLine($"OrderId : {kv.Key} OrderAmount : {kv.Value}");
             }*/


        }
    }
}
