using System.Drawing;
using System.Threading.Tasks;

string userChoice;
bool isToShowOptionsAgain = true;
List<string> tasks = new List<string>();
string message = "================== Don't have any tasks yet ======================";
do
{
    Console.WriteLine("\n");
    Console.WriteLine("Hi! Welcome to your toDo list app.");
    Console.WriteLine("\n");
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("[S] See all toDos");
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("[A] Add a toDo");
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("[R] Remove a toDo");
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("[E] Exit");
    Console.WriteLine("\n");
    Console.ResetColor();
    Console.WriteLine("Choose an option: ");
    userChoice = Console.ReadLine().ToLower();
    switch (userChoice)
    {
        case "s":
            Console.WriteLine("\n");
            isToShowOptionsAgain = true;
            showtTasks(tasks);
            break;
        case "a":
            Console.WriteLine("\n");
            isToShowOptionsAgain = true;
            addTask();
            break;

        case "r":
            Console.WriteLine("\n");
            isToShowOptionsAgain = true;
            removeTask(tasks);
            break;

        case "e":
            Console.WriteLine("\n");
            return;

        default:
            Console.WriteLine("Invalid answer");
            isToShowOptionsAgain = false;
            break;
    }
} while (!isToShowOptionsAgain);

Console.ReadKey();

void addTask()
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Writetitle("Set a Task name");
    string task = Console.ReadLine();
    tasks.Add(task);
    isToShowOptionsAgain = false;
    Console.WriteLine("\n");
    Console.ResetColor();
}

void showtTasks(List<string> tasks)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    if (tasks.Count() > 0)
    {
        Writetitle("Showing all toDo list");
        tasks.ForEach(task =>
        {
            task.ToUpper();
            var index = tasks.IndexOf(task);
            Console.WriteLine($"{index + 1} - {task}");
        });
        Console.WriteLine("\n");
        Console.ResetColor();
    } else
    {
        Console.WriteLine(message);
    }
    Console.ResetColor();
    isToShowOptionsAgain = false;
}

void removeTask(List<string> tasks)
{
    Console.ForegroundColor = ConsoleColor.Red;
    if(tasks.Count() > 0)
    {
        Writetitle("Type the id for remove the task");
        var indexTaskOnStringFormat = Console.ReadLine();
        var indexTaskOnIntFormat = int.Parse(indexTaskOnStringFormat) - 1;
        tasks.ToList().ForEach(task =>
        {
            var index = tasks.IndexOf(task);
            if (indexTaskOnIntFormat == index)
            {
                Console.WriteLine($"The task {task} was deleted.");
                tasks.Remove(task);
            };
        });
    } else
    {
        Console.WriteLine(message);
    }
    Console.ResetColor();
    isToShowOptionsAgain = false;
}

void Writetitle(string text)
{
     Console.WriteLine($"================== {text} ======================");
}