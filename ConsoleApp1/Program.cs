class program
{
    /* 1 задание
    static void Main()
    {
        int n = 10;
        int[] arr = new int[n];

        Random r = new Random();
        for (int i = 0; i < n; i++)
        {
            arr[i] = r.Next(-100, 100);
            Console.Write(arr[i] + " ");
        }

        int index = 0;
        int min = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (min > arr[i])
            {
                min = arr[i];
                index = i;
            }
        }
        Console.WriteLine($"\nИндекс минимального элемента массива: {index}");
    }
    */
        
    /* 2 задание
    static void Main()
    {
        List<int> nums = new List<int>();
        int sum = 0;
        int product = 1;
        int num = int.Parse(Console.ReadLine());

        while (num != 0)
        {
            nums.Add(num);
            sum += num;
            product *= num;
            num = int.Parse(Console.ReadLine());
        }
        int avg = sum / nums.Count;
        Console.WriteLine($"Сумма: {sum}, произведение: {product}, среднее: {avg}");
    }
    */
    
    /* 3 задание
    static void Main()
    {
        List<string> words = new List<string>();
        string word = Console.ReadLine();
        string shortWord = word;
        string longWord = word;
        while (word != "")
        {
            words.Add(word);
            if (word.Length < shortWord.Length)
            {
                shortWord = word;
            }
            if (word.Length > longWord.Length)
            {
                longWord = word;
            }
            word = Console.ReadLine();
        }
        
        Console.WriteLine($"Самое короткое слово: {shortWord}, самое длинное слово: {longWord}");
    }
    */
    
    /* 4 задание
    static void Main()
    {
        static int[] Filter(int a, int b)
        {
            int[] nums = new int[10];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(a, b);
            }
            return nums;
        }
        
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int[] arr = Filter(a,b);
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
    */

    /* 5 задание
    static void Main()
    {
        Console.WriteLine("Введите текст: ");
        string words = Console.ReadLine();
        int a = 1;
        foreach (var sym in words)
        {
            if (sym == ' ')
            {
                a++;
            }
        }

        Console.WriteLine($"Количество слов в тексте: {a}");
        Console.WriteLine($"Start {words} End");
    }
    */
}