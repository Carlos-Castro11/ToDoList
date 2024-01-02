using System.Threading.Tasks;

string userChoice;
bool isValid = true;
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
            isValid = true;
            showtTasks(tasks);
            break;
        case "a":
            Console.WriteLine("\n");
            isValid = true;
            addTask();
            break;

        case "r":
            Console.WriteLine("\n");
            isValid = true;
            removeTask(tasks);
            break;

        case "e":
            Console.WriteLine("\n");
            isValid = true;
            return;

        default:
            Console.WriteLine("Invalid answer");
            isValid = false;
            break;
    }
} while (!isValid);

Console.ReadKey();

void addTask()
{
    Console.WriteLine("set a Task name: ");
    string task = Console.ReadLine();
    tasks.Add(task);
    isValid = false;
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
    isValid = false;
}

void removeTask(List<string> tasks)
{
    Console.WriteLine("Type the id for remove the task: ");
    var idTaskOnStringFormat = Console.ReadLine();
    var idTaskOnIntFormat = int.Parse(idTaskOnStringFormat);
    tasks.ForEach(task =>
    {
        var index = tasks.IndexOf(task);
        Console.WriteLine($"{task}  {index}");
    });
    isValid = false;
}