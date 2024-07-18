using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LinqQueriesExamples
    {
        public static void AggregateAndRestrictionOP()
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            int getSum = numbers.Aggregate((a, b) => b > a ? b : a);
            //get squre of each elements
           IEnumerable<int> getSquare = numbers.Select(num => num*num);

            //All numbers with indexs 
            var AllNumWithIndex = numbers.Select((num, ind) => new
            {
                Numbers = num,
                Indexs = ind
            }).ToList();

            //All Even numbers with indexs 
            var AllEvenNumWithIndex = numbers.Select((num, ind) => new
            {
                Numbers = num,
                Indexs = ind
            }).Where(x => x.Numbers % 2 == 0).Select(x => x.Indexs).ToList();
            //only indexs which numbers are even
            var OnlyIndex = numbers.Select((num, ind) => new
            {
                Numbers = num,
                Indexs = ind
            }).Where(x => x.Numbers % 2 == 0).Select(x => x.Indexs).ToList();

            int[] num2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            string[] nummm = { "India", "USA", "UK" };
            var getttt = nummm.Min(x => x.Length);
            var getLinq = from nums in num2
                          where (nums % 2) == 0
                          select nums;
            var newquery = num2.Where(c => c % 2 == 0).Select(c => c).Sum();
        }

        public static void OrderOperator()
        {
            int[] order = {15,4,3,1,6};
            List<Student> students = Student.GetAllStudent().ToList();
            //Sort the element first based on the total marks by OrderBy and then sort by Name now
            //the result will be combinaton of both
            var getOrder = students.OrderBy(num => num.TotalMarks).ThenBy(num1=>num1.Name).ThenByDescending(num2=>num2.Id).ToList();
            // below we dont used Thenby and ThenByDescending instead we are specifig sort excpression , sep list
            var getOrder1 = from student in students orderby student.TotalMarks, student.Name, student.Id descending
                            select student;

            IEnumerable<int> get = from num in students orderby num.Id descending where num.TotalMarks > 300 select num.TotalMarks;
            
           IEnumerable<Student> studentss = students.OrderByDescending(x => x.Id).Where(sal => sal.TotalMarks > 300 && sal.Name.Equals("Shiv1")).ToList();
           IEnumerable<Student> studentss1 = students.OrderBy(x => x.Id).Where(sal => sal.TotalMarks > 300 && sal.Name.Equals("Shiv1")).ToList();


            var getOrder12 = students.OrderBy(num =>num).Reverse();
            Console.WriteLine("..........OrderBy Operator........");
            foreach (var student in studentss1)
            {
                Console.WriteLine("Name: {0},Id: {1},TotalMarks: {2}",student.Name,student.Id,student.TotalMarks);
            }
        }
    }

    public class Student
    {
        public int Id { get; set; }
        public int TotalMarks { get; set; }
        public string Name { get; set; }

        public static List<Student> GetAllStudent()
        {
            List<Student> students = new List<Student>()
            {
                new Student() { Id = 1, TotalMarks = 200, Name= "Ashiv" },
                new Student() { Id = 2, TotalMarks = 100, Name= "Ashiv" },
                new Student() { Id = 3, TotalMarks = 50, Name=  "Ashiv" },
                new Student() { Id = 2, TotalMarks = 400, Name= "Bshiv1" },
                new Student() { Id = 3, TotalMarks = 500, Name= "Dshiv1" },
                new Student() { Id = 4, TotalMarks = 700, Name= "Dshiv1" },
                new Student() { Id = 5, TotalMarks = 800, Name= "Fshiv2" },
                new Student() { Id = 6, TotalMarks = 900, Name= "Fshiv2" },
                new Student() { Id = 7, TotalMarks = 200, Name= "Gshiv2" },
                new Student() { Id = 2, TotalMarks = 200, Name= "Zshiv2" },
            };

            return students;
        }
    }

}
