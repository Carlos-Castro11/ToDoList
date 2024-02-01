using concessionaire;

var carList = new CarList();

bool isUserChoiceValid;
string? userChoice;
do
{
    Console.WriteLine("\n");
    Console.WriteLine("=============================== Welcome to your favorite concessionare! ===============================");
    Console.WriteLine("\n");
    Console.WriteLine("choose one of the options below:");
    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[1] LIST ALL CARS");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("[2] SELL A CAR");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("[3] BUY A CAR");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[4] EXIT");
    Console.ForegroundColor = ConsoleColor.White;

    Console.WriteLine("\n");
    Console.WriteLine("Your choice:");
    userChoice = Console.ReadLine();
    validateUserChoice(userChoice);
    switch (userChoice)
    {
        case "1":
            carList.WriteAllCars();
            break;
        case "2":
            carList.AddCarToList();
            break;
        case "3":
            Console.WriteLine("Escolheu 3");
            break;
    }
} while (userChoice != "4");

void validateUserChoice(string userChoice) {
   int userChoiceInt;
    if (int.TryParse(userChoice, out userChoiceInt))
    {
        if(userChoiceInt >= 1 && userChoiceInt <= 4) {
        } else
        {
            Console.WriteLine("\n");
            Console.WriteLine("ERROR: O valor deve ser entre 1 e 4 apenas");
        }
    }
    else
    {
        Console.WriteLine("\n");
        Console.WriteLine("ERROR: Preencha um valor numérico.");
    }
}

Console.ReadKey();