using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaire
{
    public class Person
    {
        public String _name { get; private set; }
        public int _age { get; private set; }
        public double _salary { get; private set; }

        public Person(String name, int age, double salary) 
        {
            _name = name;
            _age = age;
            _salary = salary;
        }

       public static Person CreatePerson()
        {
            Console.WriteLine("What's your name?");
            var name = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine("How old are you?");
            var age = Console.ReadLine();
            var ageInt = int.Parse(age);
            Console.WriteLine("\n");
            Console.WriteLine("What's your salary?");
            var salary = Console.ReadLine();
            var salaryDouble = double.Parse(salary);

            var client = new Person(name, ageInt, salaryDouble);
            return client;
        }

        public static void GetPerson(Person client)
        {
           Console.WriteLine($"Name: {client._name} | Age: {client._age} | Salary: {client._salary}");
            return;
        }
    }
}
