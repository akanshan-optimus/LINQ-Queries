using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*Given a list of Student objects with StudentID, Name, and Courses 
     * (a collection of courses the student is enrolled in), write a LINQ query 
     * to find all students who are enrolled in more than 3 courses.*/

    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public List<string> Courses { get; set; }  // List of course names
    }


    internal class SixthQuestion
    {
        List<Student> student = new List<Student>() 
        {
          new Student(){StudentID=1, Name="Akansha",Courses= new List<string>(){ "SQL", "C#", "API" } },
         
          new Student(){StudentID=2, Name="Anjali",  Courses = new List<string> { "Math", "Science", "English" } },
          new Student(){ StudentID=3, Name="Riya", Courses=new List<string>(){ "c3","c4","c4","c8"} },
          new Student(){ StudentID=4, Name="Manisha", Courses=new List<string>(){"c5","c6"} }
        };

        public void Execution()
        {
            
            var ans = student.Where(x => x.Courses.Count > 3).Select(x => x.Name);
         
            foreach (var student in ans)
            {
                Console.WriteLine(student);
            }
        }
    }
}
