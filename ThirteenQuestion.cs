using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice
{
    /*You have a list of Student objects, each with StudentID, Name, and a list of Grades. 
     * Write a LINQ query to check if all students have passed all their subjects (assuming passing grade is 50).*/

    public class Student1
    { 
        public int StudentID { get; set; }  

        public string Name { get; set; }

        public List<int> Grade { get; set; }
    }
    internal class ThirteenQuestion
    {
        List<Student1> students = new List<Student1>
            {
                new Student1 { StudentID = 1, Name = "Akansha", Grade = new List<int> { 90, 85, 88, 92 } },
                new Student1 { StudentID = 2, Name = "Mitali", Grade = new List<int> { 78, 84, 79, 80 } },
                new Student1 { StudentID = 3, Name = "Manjulika", Grade = new List<int> { 95, 98, 94, 97 } },
                new Student1 { StudentID = 4, Name = "Anushka", Grade = new List<int> { 87, 89, 85, 90 } },
                new Student1 { StudentID = 5, Name = "Pyari", Grade = new List<int> { 76, 78, 80, 74 } },
                new Student1 { StudentID = 6, Name = "Urmila", Grade = new List<int> { 88, 92, 77, 90 } }
             };

        public void Execution()
        {
           bool ans= students.All(x => x.Grade.All(x => x > 50));
            if (ans)
            {
                Console.WriteLine("Pass");
            }
            else 
            {
                Console.WriteLine("Fail");
            }
        }

    }
}
