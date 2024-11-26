using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have two collections: Customer objects (with CustomerID, CustomerName, Email) 
     * and Order objects (with OrderID, CustomerID, OrderAmount). Write a LINQ query to join 
     * these collections and get a list of all orders along with the CustomerName for each order.*/

    public class Customer
    { 
    public int CustomerId { get; set; }
    public string CustomerName { get; set; }
        
    public string CustomerEmail { get; set; }



    }

    public class Order2
    { 
    public int OrderId { get; set; }
    public int CustomerId { get; set; }

    public int OrderAmount {  get; set; }



    }
    internal class ForthQuestion
    {
        List<Customer> customer = new List<Customer>() 
        {new Customer(){ CustomerName="Akansha", CustomerEmail="akansha@gmail.com", CustomerId=1},
        new Customer(){CustomerName="Diksha", CustomerEmail="diksha@gmail.com", CustomerId=2 },
        new Customer(){ CustomerName="Manisha", CustomerEmail="manisha@gmail.com", CustomerId=1} };

        List<Order2> order = new List<Order2>()
        {
        new Order2(){OrderId=1, CustomerId=2, OrderAmount=3},
        new Order2(){OrderId=2, CustomerId=1, OrderAmount=4 },
        new Order2(){ OrderId=3, CustomerId=2, OrderAmount=2},
        new Order2(){ OrderId=4, CustomerId=1, OrderAmount=4},
        new Order2(){ OrderId=5, CustomerId=3, OrderAmount=3}
        };



        public void Execution()
        {
            var ans = customer.Join(order, c => c.CustomerId, o => o.CustomerId, (c, o) =>
            new { c.CustomerName, o.CustomerId, o.OrderAmount, o.OrderId }).GroupBy(x => x.CustomerName).Select(x => new { x.Key, TotalORderAmount=x.Sum(x=>x.OrderAmount)}); ;

        }

    }
}
