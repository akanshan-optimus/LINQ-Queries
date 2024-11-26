using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have a collection of Order objects with OrderID, CustomerID, and OrderAmount properties. 
     * Write a LINQ query to find all unique CustomerID values in the orders list.*/
    public class Order3
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int OrderAmount { get; set; }




    }
    internal class EighthQuestion
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
           var ans= list.Select(x => x).DistinctBy(x => x.CustomerId);
            foreach (var x in ans)
            {
                Console.WriteLine($"OrderId : {x.OrderId} CustomerId : {x.CustomerId} OrderAmount : {x.OrderAmount}");
            }

        }
    }
}
