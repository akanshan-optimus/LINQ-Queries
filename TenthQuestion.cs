using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have a list of Employee objects with EmployeeID, FirstName, LastName, and Department properties. 
     * Write a LINQ query to project the data into a new anonymous object that contains the EmployeeID 
     * and the full name (FirstName + " " + LastName) for employees in the "HR" department.*/

    class Employee2
    { 
       public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Department { get; set; }
        

    }
    internal class TenthQuestion
    {
        List<Employee2> employees = new List<Employee2>
        {
            new Employee2 { EmployeeId = 1, FirstName = "Arun", LastName = "Doe", Department = "HR" },
            new Employee2 { EmployeeId = 2, FirstName = "Abhinav", LastName = "Smith", Department = "IT" },
            new Employee2 { EmployeeId = 3, FirstName = "Anshul", LastName = "Johnson", Department = "HR" },
            new Employee2 { EmployeeId = 4, FirstName = "Akhil", LastName = "Williams", Department = "IT" },
           
        };
        public void Execution()
        {
           var ans= employees.Where(x => x.Department == "HR").Select(x => new { FullName= x.FirstName+ x.LastName});
            foreach (var x in ans)
            {
                Console.WriteLine(x.FullName);
            }
        }
    }
}
