using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace concessionaire
{
    public class Person
    {
        public String Name { get; private set; }
        public int Age { get; private set; }
        public double Salary { get; private set; }
        public Person(string name, int age, double salary) {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public static void createPerson()
        {
            Console.WriteLine("\n");
            Console.WriteLine("To proceed we need to now some information about you first...");
            Console.WriteLine("\n");
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("How old are you? ");
            var age = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("What is the value of your salary?");
            var salary = Console.ReadLine();

            //var client = new Person(name, age, 200);
        }
    }
}
