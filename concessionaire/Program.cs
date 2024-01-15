using concessionaire;
using concessionaire.Services;

var carList = new CarList();

int userChoiceInt;
do
{
    Console.WriteLine("\n");
    Console.WriteLine("Hi! Welcome to your concessionaire.");
    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[1] Buy a car");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("[2] Add a car");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[3] Remove a car");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("[4] Exit");
    Console.WriteLine("\n");
    Console.ResetColor();
    Console.WriteLine("Choose an option: ");
    var userChoiceString = Console.ReadLine().ToLower();
    userChoiceInt = int.Parse(userChoiceString);

    switch (userChoiceInt)
    {
        case 1:
            Console.WriteLine("\n");
            carList.WriteAllCars();
            Services.CreateClient();
            SelectEspecificCar();
            break;
        case 2:
            Console.WriteLine("\n");
            carList.AddCarToList();
            carList.WriteAllCars();
            break;

        case 3:
            Console.WriteLine("\n");
            break;

        case 4:
            Console.WriteLine("\n");
            return;
            //break;

        default:
            Console.WriteLine("Invalid answer");
            break;
    }
} while (userChoiceInt != 4);

Console.ReadKey();

void SelectEspecificCar()
{
    var car = carList.GetCar();
    Console.WriteLine("\n");
    if (car != null)
    {
        Console.WriteLine($"The car {car?._name}, brand {car?._brand} and price ${car?._price}");
    } else
    {
        Console.WriteLine("We don't have this car available...");
    }
}