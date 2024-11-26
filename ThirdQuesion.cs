using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*
     Given a list of Employee objects with properties
    EmployeeID, Name, and Salary, write a LINQ query to sort 
    the employees by Salary in descending order and then by Name 
    in ascending order if salaries are equal.
     */

    public class Employee
    { 
    public int Id { get; set; } 
    public string Name { get; set; }
    public int Salary { get; set; }

    }
    internal class ThirdQuesion
    {
        List<Employee> employees = new List<Employee>() 
        {new Employee(){Id=1, Name="Akansha",Salary=99 },
        new Employee(){ Id=2, Name="Manisha", Salary=76},
        new Employee(){ Id=3, Name="Riya", Salary=85 },
        new Employee(){Id=4, Name="Anjali", Salary=76 }
        };

        public void Execution()
        {
            /*var emp=employees.Select(x=>x).OrderByDescending(x => x.Salary).ThenBy(x=>x.Name);*/

            var emp = employees.Select(x => x).OrderByDescending(x => x.Salary).ThenByDescending(x=>x.Name);
            foreach (var v in emp)
            {
                Console.WriteLine(v.Salary+" "+v.Name);
            }
        }
        

    }
}
