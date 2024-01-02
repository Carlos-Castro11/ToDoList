Console.WriteLine("Welcome to the ===CALCULATOR===");

Console.WriteLine("Enter the first number");
string string1 = Console.ReadLine();
//var numberTyped1 = int.Parse(string1);
int numberTyped1 = 0;
if (int.TryParse(string1, out numberTyped1))
{
    Console.WriteLine("Valid number");
}
else
{
    Console.WriteLine("Invalid value!");
    return;
}

Console.WriteLine("Enter the second number");
string string2 = Console.ReadLine();
//var numberTyped2 = int.Parse(string2);
int numberTyped2 = 0;
if (int.TryParse(string2, out numberTyped2))
{
    Console.WriteLine("Valid value");
}
else
{
    Console.WriteLine("Invalid value");
    return;
}

Console.WriteLine("Select what operation do you want: ");
Console.WriteLine("[S] Sum");
Console.WriteLine("[T] Subtraction");
Console.WriteLine("[M] Multiplication");
Console.WriteLine("[D] Division");
var chosenOperation = Console.ReadLine().ToLower();


switch(chosenOperation)
{
    case "s":
        var resSum = Sum(numberTyped1, numberTyped2);
        Console.WriteLine($"O resultado da soma entre {numberTyped1} e {numberTyped2} é {resSum}");
        break;

    case "t":
        var resSubtraction = Subtraction(numberTyped1, numberTyped2);
        Console.WriteLine($"O resultado da subtração entre {numberTyped1} e {numberTyped2} é {resSubtraction}");
        break;

    case "m":
        var resMultiplication = Multiplication(numberTyped1, numberTyped2);
        Console.WriteLine($"O resultado da multiplicação entre {numberTyped1} e {numberTyped2} é {resMultiplication}");
        break;

    case "d":
        var resDivision = Division(numberTyped1, numberTyped2);
        Console.WriteLine($"O resultado da divisão entre {numberTyped1} e {numberTyped2} é {resDivision}");
        break;

    default:
        Console.WriteLine("Invalid option!");
        break;
}

Console.ReadKey();

int Sum(int number1, int number2)
{
    return number1 + number2;
}

int Subtraction(int number1, int number2)
{
    return number1 - number2;
}

int Multiplication(int number1, int number2)
{
    return number1 * number2;
}

int Division(int number1, int number2)
{
    return (number1 / number2);
}
