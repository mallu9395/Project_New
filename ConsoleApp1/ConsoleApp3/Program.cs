using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 25 },
            new Person { Name = "Bob", Age = 30 },
            new Person { Name = "Charlie", Age = 20 },
            new Person { Name = "David", Age = 35 }
        };

            // Predicate delegate to find people older than 25
            Predicate<Person> isOlderThan25 = (person) => person.Age > 25;

            // Using Predicate with List<T>.FindAll method
            List<Person> olderThan25 = people.FindAll(isOlderThan25);

            foreach (var person in olderThan25)
            {
                Console.WriteLine($"{person.Name} is older than 25.");
            }
            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
