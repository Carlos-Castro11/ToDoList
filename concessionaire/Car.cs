using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaire
{
    public class Car
    {
        public String _name { get; private set; }
        public String _plate { get; private set; }
        public String _brand { get; private set; }
        public int _yearOfRelease { get; private set; }
        public double _price { get; private set; }

        public Car(String name, String plate, String brand, int yearOfRelease, double price)
        {
            _name = name.ToUpper();
            _plate = plate;
            _brand = brand;
            _yearOfRelease = yearOfRelease;
            _price = price;
        }
    }
}
