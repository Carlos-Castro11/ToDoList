using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace concessionaire
{
    public class CarList
    {
        private List<Car> cars;

        public CarList()
        {
            var hillux = new Car("hillux", "133423", "Toyota", 2019, 80.000);
            var palio = new Car("palio", "22222", "Fiat", 2006, 20.000);
            var hb20 = new Car("hb20", "333333", "Hyundai", 2022, 60.000);
            var bmwX6 = new Car("bmw x6", "44444", "bmw", 1986, 999.200);
            cars = new List<Car>();

            cars.Add(hillux);
            cars.Add(palio);
            cars.Add(hb20); 
            cars.Add(bmwX6);
        }

         public void WriteAllCars()
        {
            Console.WriteLine("\n");
            foreach (var car in cars)
            {
                Console.WriteLine($"{car._name} | plate: {car._plate} | brand: {car._brand} | year: {car._yearOfRelease} | price: ${car._price}");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            }
        }

         public void AddCarToList()
        {
            Console.WriteLine("Name:");
            var name = Console.ReadLine();
            Console.WriteLine("Plate:");
            var plate = Console.ReadLine();
            Console.WriteLine("Brand:");
            var brand = Console.ReadLine();
            Console.WriteLine("Release year:");
            var yearOfRelease = Console.ReadLine();
            var yearOfReleaseToInt = int.Parse(yearOfRelease);
            Console.WriteLine("Price:");
            var price = Console.ReadLine();
            var priceToInt = int.Parse(price);

            var newCar = new Car(name, plate, brand, yearOfReleaseToInt, priceToInt);
            cars.Add(newCar);
        }

        public Car GetCar()
        {
            Console.WriteLine("Digite o nome do carro: ");
            Car response = null;
            var name = Console.ReadLine();
            var nameUpper = name?.ToUpper();
            foreach (var car in cars)
            {
                if (car._name == nameUpper)
                {
                    response = car;
                }
            }
            return response;
        }
    }
}
