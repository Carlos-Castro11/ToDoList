using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaire
{
    public class Car
    {
        public int Id {  get; set; }
        public String Name { get; private set; }
        public String Plate { get; private set; }
        public String Brand { get; private set; }
        public int YearOfRelease { get; private set; }
        public double Price { get; private set; }

        public Car(int id, String name, String plate, String brand, int yearOfRelease, double price)
        {
            Id = id;
            Name = name.ToUpper();
            Plate = plate;
            Brand = brand;
            YearOfRelease = yearOfRelease;
            Price = price;
        }
    }
}
