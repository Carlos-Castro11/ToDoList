using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Person
    {
        public int Id { get; private set; }
        public String _name { get; set; }
        public int _age { get; private set; }
        public String _country { get; private set; }
        public String _job { get; private set; }

        public Person(int id, String name, int age, String country, String job)
        {
            Id = id;
            _name = name;
            _age = age;
            _country = country;
            _job = job;
        }

        public string getPerson()
        {
            return $"The name is {_name}";
        }
    }
}
