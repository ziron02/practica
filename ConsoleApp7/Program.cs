using System.Text.Json;
using System.Threading.Channels;

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
    
    static void addTasks()
    {
        List<Task> arr = loadTask();
        Task addTask = new Task();
        Console.WriteLine("Введите название задачи: ");
        string newTask = Console.ReadLine();
        if (newTask!= "")
        {
            addTask.nameTask = newTask;
        }
        else
        {
            Console.WriteLine("Введена пустая строка");
        }
        
        Console.WriteLine("Введите описание задачи: ");
        string newDescription = Console.ReadLine();
        if (newDescription!= "")
        {
            addTask.descriptionTask = newDescription;
        }
        else
        {
            Console.WriteLine("Введена пустая строка");
        }

        Console.WriteLine("Введите время, до которого вы хотите выполнить задачу: ");
        Console.Write("Год: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("День: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Час: ");
        int hour = int.Parse(Console.ReadLine());
        Console.Write("Минута: ");
        int minute = int.Parse(Console.ReadLine());
        
        var date = new DateTime(year, month, day, hour, minute, 0);
        long time = ((DateTimeOffset)date).ToUnixTimeSeconds();
        addTask.time = time;

        arr.Add(addTask);
        Console.WriteLine("Задача добавлена");
        savingTasks(arr);
    }

    static void deleteTask()
    {
        List<Task> arr = loadTask();
        Console.WriteLine("Введите номер задачи, которую хотите удалить: ");
        int a = int.Parse(Console.ReadLine());
        arr.Remove(arr[a - 1]);
        Console.WriteLine($"Задача {a} была удалена.");
        savingTasks(arr);
    }

    static void redactTasks()
    {
        List<Task> arr = loadTask();
        Console.WriteLine("Введите номер задачи, которую хотите изменить: ");
        int b = 1;
        foreach (var n in arr)
        {
            Console.WriteLine($"{b++} - {n.nameTask}");
        }
        
        int a = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Новое название задачи: ");
        string newName = Console.ReadLine();
        if (newName!= "")
        {
            arr[a - 1].nameTask = newName;
        }
        else
        {
            Console.WriteLine("Введена пустая строка!");
        }
        
        Console.WriteLine("Введите новое описание задачи: ");
        string newDescription = Console.ReadLine();
        if (newDescription!= "")
        {
            arr[a - 1].descriptionTask = newDescription;
        }
        else
        {
            Console.WriteLine("Введена пустая строка!");
        }
        
        Console.WriteLine("Введите новое время, до которого планируется выполнить задачу: ");
        Console.Write("Год: ");
        int year = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("День: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Час: ");
        int hour = int.Parse(Console.ReadLine());
        Console.Write("Минута: ");
        int minute = int.Parse(Console.ReadLine());
        
        var date = new DateTime(year, month, day, hour, minute, 0);
        long unixTime = ((DateTimeOffset)date).ToUnixTimeSeconds();
        arr[a - 1].time = unixTime;

        Console.WriteLine("Редактирование сохранено");
        savingTasks(arr);
    }

    static void taskReview()
    {
        List<Task> arr = loadTask();
        
        var now = DateTime.Now;
        var today = new DateTime(now.Year, now.Month, now.Day);
        var tomorrow = new DateTime(now.Year, now.Month, now.Day+1);
        var week = new DateTime(now.Year, now.Month, now.Day+7);

        long unixNow = ((DateTimeOffset)now).ToUnixTimeSeconds();
        long unixToday = ((DateTimeOffset)today).ToUnixTimeSeconds();
        long unixTomorrow = ((DateTimeOffset)tomorrow).ToUnixTimeSeconds();
        long unixWeek = ((DateTimeOffset)week).ToUnixTimeSeconds();
        
        Console.WriteLine("Выберите какую задачу хотите посмотреть: ");
        Console.WriteLine("1 - на сегодня:\n" +
                          "2 - на завтра:\n" +
                          "3 - на неделю:\n" +
                          "4 - все задачи:\n" +
                          "5 - выполненные:\n" +
                          "6 - невыполненные");
        int a = int.Parse(Console.ReadLine());
        switch (a)
        {
            case 1:
                Console.WriteLine("Задачи на сегодня:" );
                foreach (var t in arr)
                {
                    if (t.time >= unixToday && t.time < unixTomorrow)
                    {
                        DateTime time = new DateTime(1970, 1, 1);
                        time = time.AddSeconds(t.time).ToLocalTime();
                        Console.WriteLine($"\nНазвание задачи: {t.nameTask}\n" +
                                          $"Описание задачи: {t.descriptionTask}\n" +
                                          $"Время: {time}");
                    }
                }
                break;
            case 2:
                Console.WriteLine("Задачи на завтра:");
                foreach (var t in arr)
                {
                    if (t.time >= unixTomorrow && t.time < unixWeek)
                    {
                        DateTime time = new DateTime(1970, 1, 1);
                        time = time.AddSeconds(t.time).ToLocalTime();
                        Console.WriteLine($"\nНазвание задачи: {t.nameTask}\n" +
                                          $"Описание задачи: {t.descriptionTask}\n" +
                                          $"Время: {time}");
                    }
                }
                break;
            case 3:
                Console.WriteLine("Задачи на неделю:");
                foreach (var t in arr)
                {
                    if (t.time >= unixToday && t.time < unixWeek)
                    {
                        DateTime time = new DateTime(1970, 1, 1);
                        time = time.AddSeconds(t.time).ToLocalTime();
                        Console.WriteLine($"\nНазвание задачи: {t.nameTask}\n" +
                                          $"Описание задачи: {t.descriptionTask}\n" +
                                          $"Время: {time}");
                    }
                }
                break;
            case 4:
                Console.WriteLine("Все задачи:");
                foreach (var t in arr)
                {
                    DateTime time = new DateTime(1970, 1, 1);
                    time = time.AddSeconds(t.time).ToLocalTime();
                    Console.WriteLine($"\nНазвание задачи: {t.nameTask}\n" +
                                      $"Описание задачи: {t.descriptionTask}\n" +
                                      $"Время: {time}");
                }
                break;
            case 5:
                Console.WriteLine("Выполненные задачи:");
                foreach (var t in arr)
                {
                    if (t.time >unixNow)
                    {
                        DateTime time = new DateTime(1970, 1, 1);
                        time = time.AddSeconds(t.time).ToLocalTime();
                        Console.WriteLine($"\nНазвание задачи: {t.nameTask}\n" +
                                          $"Описание задачи: {t.descriptionTask}\n" +
                                          $"Время: {time}");
                    }
                }
                break;
            case 6:
                Console.WriteLine("Невыполненные задачи:");
                foreach (var t in arr)
                {
                    if (t.time < unixNow)
                    {
                        DateTime time = new DateTime(1970, 1, 1);
                        time = time.AddSeconds(t.time).ToLocalTime();
                        Console.WriteLine($"\nНазвание задачи: {t.nameTask}\n" +
                                          $"Описание задачи: {t.descriptionTask}\n" +
                                          $"Время: {time}");
                    }
                }
                break;
        }
        savingTasks(arr);
    }
    
    static void Main()
    {
        
        var tasks = loadTask();
        
        Console.WriteLine("1 - добавить задачу\n"      +
                          "2 - удалить задачу\n"       +
                          "3 - редактировать задачу\n" +
                          "4 - просмотр задачи\n"        );
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                addTasks();
                break;
            case 2:
                deleteTask();
                break;
            case 3:
                redactTasks();
                break;
            case 4:
                taskReview();
                break;
        }
    }
}