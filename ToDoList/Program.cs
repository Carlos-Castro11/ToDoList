using System.Threading.Tasks;

string userChoice;
bool isToShowOptionAgain = true;
List<string> tasks = new List<string>();

do
{
    Console.WriteLine("Hello!");
    Console.WriteLine("\n");
    Console.WriteLine("[S] See all toDos");
    Console.WriteLine("[A] Add a toDo");
    Console.WriteLine("[R] Remove a toDo");
    Console.WriteLine("[E] Exit");
    Console.WriteLine("\n");
    Console.WriteLine("Choose an option: ");
    userChoice = Console.ReadLine().ToLower();
    switch (userChoice)
    {
        case "s":
            Console.WriteLine("\n");
            isToShowOptionAgain = true;
            showtTasks(tasks);
            break;
        case "a":
            Console.WriteLine("\n");
            isToShowOptionAgain = true;
            addTask();
            break;

        case "r":
            Console.WriteLine("\n");
            isToShowOptionAgain = true;
            removeTask(tasks);
            break;

        case "e":
            Console.WriteLine("\n");
            return;

        default:
            Console.WriteLine("Invalid answer");
            isToShowOptionAgain = false;
            break;
    }
} while (!isToShowOptionAgain);

Console.ReadKey();

void addTask()
{
    Console.WriteLine("set a Task name: ");
    string task = Console.ReadLine();
    tasks.Add(task);
    isToShowOptionAgain = false;
    Console.WriteLine("\n");

}

void showtTasks(List<string> tasks)
{
    Console.WriteLine("================== Showing all toDo List ======================");
    tasks.ForEach(task =>
    {
        task.ToUpper();
        var index = tasks.IndexOf(task);
        Console.WriteLine($"{index + 1} - {task}");
    });
    Console.WriteLine("\n");
    isToShowOptionAgain = false;
}

void removeTask(List<string> tasks)
{
    Console.WriteLine("Type the id for remove the task: ");
    var indexTaskOnStringFormat = Console.ReadLine();
    var indexTaskOnIntFormat = int.Parse(indexTaskOnStringFormat) - 1;
    tasks.ToList().ForEach(task =>
    {
        var index = tasks.IndexOf(task);
        if (indexTaskOnIntFormat == index)
        {
            Console.WriteLine($"A task: {task} foi removida.");
            tasks.Remove(task);
        };
    });
    isToShowOptionAgain = false;
}