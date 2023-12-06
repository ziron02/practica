class Program
{
    /* 1 задание
    static void Main()
    {
        string[] num = File.ReadAllLines("numsTask1.txt")[0].Split(' ');
        foreach (var n in num)
        {
            if (n.Length % 2 != 0)
            {
                Console.WriteLine(n);
            }
        }
    }
    */
    
    /* 2 задание
    static void Main()
    {
        string[] num = File.ReadAllText("numsTask2.txt").Split(' ');
        string line = "";
        StreamReader sr = new StreamReader("numsTask1.txt");
        for (int i = 0; i < num.Length; i++)
        {
            string temp = sr.ReadLine();
            line += temp;
        }

        Console.WriteLine(line);
    }
    */

    /* 3 задание
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a % 2 == 0)
        {
            if (a % 10 == 0)
            {   
                Console.WriteLine("число является чётным и кратным 10");
            }
            else
            {
                Console.WriteLine("число является чётным но не является кратным 10");
            }   
        }
    }
    */

    /* 4 задание
    static void Main()
    {
        List<int> nums = new List<int>();
        int num = int.Parse(Console.ReadLine());
        while (num != 0)
        {
            nums.Add(num);
            num = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("введите число a");
        int a = int.Parse(Console.ReadLine());
        int sum = 0;
        foreach (var n in nums)
        {
            if (a % n == 0)
            {
                sum += n;
            }
        }

        Console.WriteLine(sum);
    }
    */

    /* 5 задание
    static void Main()
    {
        Random r = new Random();
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n,m];
        int[,] s = new int[n, m + 1];
        int c = 0;
        for (int i = 0; i < n; i++)
        {
            c = 0;
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = r.Next(0,2);
                s[i, j] = matrix[i, j];
                if (s[i,j] == 1)
                {
                    c++;
                }
            }
            if (c % 2 != 0)
            {
                s[i, m] = 1;
            }
            else
            {
                s[i, m] = 0;
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m + 1; j++)
            {
                Console.Write(s[i,j] + " ");
            }

            Console.WriteLine();
        }   
    }
    */

    /* 6 задание
    static void Main()
    {
        float[] mas = new float[10];
        int positiveCount = 0;
        int negativeCount = 0;
        Random r = new Random();
        Console.WriteLine("начальник массивов:");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = Convert.ToSingle(Math.Round((r.NextDouble() * 200 - 100), 1));
            if (mas[i] > 0)
            {
                positiveCount++;
            }
            if (mas[i] < 0)
            {
                negativeCount++;
            }

            Console.Write(mas[i] + " ");
        }
        float[] positiveMas = new float[positiveCount];
        float[] negativeMas = new float[negativeCount];
        positiveCount = 0;
        negativeCount = 0;
        for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > 0)
            {
                positiveMas[positiveCount] = mas[i];
                positiveCount++;
            }
            if (mas[i] < 0)
            {
                negativeMas[negativeCount] = mas[i];
                negativeCount++;
            }
        }
        Console.WriteLine("\nпозитивный массив");
        foreach (var n in positiveMas)
        {
            Console.Write(n + " ");
        }
        Console.WriteLine("\nнегативный массив");
        foreach (var n in negativeMas)
        {
            Console.Write(n + " ");
        }
    }
    */
}