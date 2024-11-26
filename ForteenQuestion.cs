using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have a list of Customer objects, each with CustomerID, CustomerName,
     * and Country. Write a LINQ query to return all unique countries where customers are located.*/

    class Customer2
    {
        public int CustomerID { get; set; }
        public string CustomerName { get; set; }

        public string Country { get; set; }

    }
    internal class ForteenQuestion
    {
        List<Customer2> customers = new List<Customer2>
        {
            new Customer2 { CustomerID = 1, CustomerName = "Akansha", Country = "India" },
            new Customer2 { CustomerID = 2, CustomerName = "Anjali", Country = "Canada" },
            new Customer2 { CustomerID = 3, CustomerName = "Riya", Country = "UK" },
            new Customer2 { CustomerID = 4, CustomerName = "Anushka", Country = "India" },
            new Customer2 { CustomerID = 5, CustomerName = "Anita", Country = "USA" }

        };

        public void Execution()
        {
            var ans= customers.DistinctBy(x=>x.Country);

            var ans2= customers.Select(x=>x.Country).Distinct();
            foreach (var customer in ans2)
            {
                Console.WriteLine(customer);
            }
            foreach (var customer in ans)
            {
                Console.WriteLine(customer.Country);
            }
        }


    }

}
