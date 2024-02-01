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
            Console.WriteLine("We need some information about the car before we put it up for sale...");
            Console.WriteLine("Car's Name:");
            var name = Console.ReadLine();
            var plate = getAndValidatePlate();
            Console.WriteLine("Car's Brand:");
            var brand = Console.ReadLine();
            int yearOfRelease = getAndValidateYearOfRelease();
            double price = getAndValidatePrice();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("********* SUCCESS!! *********");
            Console.ForegroundColor = ConsoleColor.White;
            var newCar = new Car(name, plate, brand, yearOfRelease, price);
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

        private int getAndValidateYearOfRelease()
        {
            int yearOfReleaseInt;
            bool isValid = false;
            do
            {
                Console.WriteLine("Car's Release Year:");
                var yearOfRelelase = Console.ReadLine();
                if (int.TryParse(yearOfRelelase, out yearOfReleaseInt))
                {
                    if (yearOfReleaseInt < 1900 || yearOfReleaseInt > 2024)
                    {
                        Console.WriteLine("The year needs to be between 1900 and 2024.");
                    } else
                    {
                        isValid = true;
                    }
                } else
                {
                    Console.WriteLine("You not typed a valid value for year.");
                }
            } while (isValid == false);
            return yearOfReleaseInt;
        }

        private double getAndValidatePrice()
        {
            double priceDouble;
            bool isValid = false;
            do
            {
                Console.WriteLine("Car's Price:");
                var price = Console.ReadLine();
                if (double.TryParse(price, out priceDouble))
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("You not typed a valid value for price.");
                }
            } while (isValid == false);
            return priceDouble;
        }

        private string getAndValidatePlate()
        {
            bool isValid = false;
            string plate;
            do
            {
                Console.WriteLine("Car's Plate:");
                plate = Console.ReadLine();
                if(plate?.Length <= 5)
                {
                    Console.WriteLine("A plate need to have at least 6 numbers");
                } else
                {
                    isValid = true;
                }

            } while (isValid == false);
            return plate!;
        }
    }
}

