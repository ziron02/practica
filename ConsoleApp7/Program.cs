using System.Text.Json;

class Program
{
    static void savingTasks(List<Task> tasks)
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonInString = JsonSerializer.Serialize(tasks, options);
        File.WriteAllText("tasks.json", jsonInString);
    }
    static List<Task> loadTask()
    {
        string textJson = File.ReadAllText("tasks.json");
        var tasks = JsonSerializer.Deserialize<List<Task>>(textJson);
        return tasks;
    }
    
    static void addTasks(List<Task> tasks)
    {
        Task addTask = new Task();
        Console.WriteLine("Введите задачу: ");
        string newTask = Console.ReadLine();
        if (newTask!= "")
        {
            addTask.name = newTask;
        }
        else
        {
            Console.WriteLine("Введена не строка!");
        }
        
        Console.WriteLine("Введите описание задачи: ");
        string newDesc = Console.ReadLine();
        if (newDesc!= "")
        {
            addTask.desc = newDesc;
        }
        else
        {
            Console.WriteLine("Введена не строка!");
        }

        Console.WriteLine("Введите время, до которого планируется выполнить задачу: ");
        Console.Write("Год: ");
        int year = Convert.ToInt32(Console.ReadLine());
        Console.Write("Месяц: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("День: ");
        int day = Convert.ToInt32(Console.ReadLine());
        Console.Write("Час: ");
        int hour = Convert.ToInt32(Console.ReadLine());
        Console.Write("Минута: ");
        int minute = Convert.ToInt32(Console.ReadLine());
        
        var date = new DateTime(year, month, day, hour, minute, 0);
        long unixTime = ((DateTimeOffset)date).ToUnixTimeSeconds();
        addTask.timestamp = unixTime;

        tasks.Add(addTask);
        Console.WriteLine("Задача добавлена.\n");
        savingTasks(tasks);
    }

    static void deletTask(List<Task> tasks)
    {
        Console.WriteLine("Введите номер задачи, которую хотите удалить: ");
        int a = int.Parse(Console.ReadLine());
        tasks.Remove(tasks[a - 1]);
        Console.Clear();
        Console.WriteLine($"Задача {a} была удалена.");
        savingTasks(tasks);
    }

    static void redactTask(List<Task> tasks)
    {
        Console.WriteLine("Введите номер задачи, которую хотите отредактировать: ");
    }
    
    static void Main()
    {
        var tasks = new List<Task>();
        
        Console.WriteLine("1 - добавить задачу\n"      +
                          "2 - удалить задачу\n"       +
                          "3 - редактировать задачу\n" +
                          "4 - просмотр задачи\n"        );

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                addTasks(tasks);
                break;
        }
    }
}