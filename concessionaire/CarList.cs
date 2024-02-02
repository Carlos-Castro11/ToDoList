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
            var hillux = new Car(1, "hillux", "133423", "Toyota", 2019, 80.499);
            var palio = new Car(2, "palio", "22222", "Fiat", 2006, 19.999);
            var hb20 = new Car(3, "hb20", "333333", "Hyundai", 2022, 60.699);
            var hb20s = new Car(4, "hb20", "666666", "Hyundai", 2024, 90.499);
            var bmwX6 = new Car(5, "bmw x6", "44444", "bmw", 1986, 999.199);
            cars = new List<Car>();

            cars.Add(hillux);
            cars.Add(palio);
            cars.Add(hb20); 
            cars.Add(bmwX6);
            cars.Add(hb20s);
        }

         public void WriteAllCars()
        {
            Console.WriteLine("\n");
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Name} | plate: {car.Plate} | brand: {car.Brand} | year: {car.YearOfRelease} | price: ${car.Price},00");
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
            int yearOfRelease = getAndValidateIfIsInt("year");
            double price = getAndValidatePrice();
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("********* SUCCESS!! Your car is for SALE *********");
            Console.ForegroundColor = ConsoleColor.White;
            int generateId = cars.Count + 1;
            var newCar = new Car(generateId, name, plate, brand, yearOfRelease, price);
            cars.Add(newCar);
        }

        private int getAndValidateIfIsInt(string type)
        {
            int valueInt;
            bool isValid = false;
            do
            {
                if (type == "year")
                {
                    Console.WriteLine("Car's Release Year:");
                } else if (type == "id")
                {
                    Console.WriteLine("Type the id of the car that you want to buy: ");
                }
                var value = Console.ReadLine();
                if (int.TryParse(value, out valueInt))
                {
                    if(type == "year")
                    {
                        if (valueInt < 1900 || valueInt > 2024)
                        {
                            Console.WriteLine("The year needs to be between 1900 and 2024.");
                        }
                        else
                        {
                            isValid = true;
                        }
                    }
                    else if (type == "id")
                    {
                        isValid = true;
                    }
                } else
                {
                    Console.WriteLine("You not typed a valid value.");
                }
            } while (isValid == false);
            return valueInt;
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

        public List<Car> GetCar()
        {
            Console.WriteLine("What is the car's name that you want? ");
            Car response;
            var listCar = new List<Car>();
            var name = Console.ReadLine();
            var nameUpper = name?.ToUpper();
            foreach (var car in cars)
            {
                if (car.Name == nameUpper)
                {
                    response = car;
                    listCar.Add(car);
                }
            }
            return listCar;
        }

        public List<Car> ValidateIfCarExist(List<Car> cars)
        {
            if (cars.Count == null || cars.Count <= 0)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Sorry, we don't have any cars like that.");
                Console.ForegroundColor = ConsoleColor.White;
                return cars;
            } else if (cars.Count == 1)
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Nice! We have the perfect car for you: ");
                Console.ForegroundColor = ConsoleColor.White;
                var listValidated = WriteEspecificCarInformation(cars);
                return listValidated;
            }
            else
            {
                Console.WriteLine("\n");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine($"Nice! We have {cars.Count} cars like that for you: ");
                Console.ForegroundColor = ConsoleColor.White;
                var listValidated = WriteEspecificCarInformation(cars);
                return listValidated;
            }
        }

        public List<Car> WriteEspecificCarInformation(List<Car> cars)
        {      
            foreach (var car in cars)
            {
                Console.WriteLine("\n");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine($"********************************************** {car.Name} **********************************************");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"ID: {car.Id} | plate: {car.Plate} | brand: {car.Brand} | year: {car.YearOfRelease} | price: ${car.Price},00");
                Console.WriteLine("-----------------------------------------------------------------------------------------------------");
            }
            return cars;
        }

        public void verifyIfUserWantTheCar(List<Car> cars)
        {
            Console.WriteLine("\n");
            Console.WriteLine("Do you want to proceed with this buy? YES or NO");
            var userWantToProceed = Console.ReadLine();
            if (userWantToProceed.ToUpper() != "YES")
            {
                return;
            } else
            {
                if (cars.Count == 1)
                {
                    Person.createPerson();
                }
                else
                {
                    verifyIfIdExist(cars);
                }
            }
        }

        public void verifyIfIdExist(List<Car> cars)
        {
            var carId = getAndValidateIfIsInt("id");
            Car targetCar;
            bool Idexist = false;
            foreach (var car in cars)
            {
                Idexist = false;
                if (carId == car.Id)
                {
                    targetCar = car;
                    Person.createPerson();
                    Idexist = true;
                }
            }
            if (Idexist == false)
            {
                Console.WriteLine("\n");
                Console.WriteLine("This id do not exist in this List");
            }
        }
    }
}

