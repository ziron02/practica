class Program
{
    /* 1 задание
    static void Main(string[] args)
    {
        List<int> arr = new List<int>(100);
        int num = int.Parse(Console.ReadLine());
        
        for (int i = 0; i <= 100; i++)
        {
            arr.Add(num);
            num -= 3;
            Console.Write(arr[i] + " ");
        }

    }
    */

    /* 2 задание
    static void Main()
    { 
        int[] arr = new int[50];
        int a = 1;
        for (int i = 0; i < arr.Length; i ++)
        {
            arr[i] = a;
            a += 2;
            Console.Write(arr[i] + " ");
        }
    }
    */
     
    /* 3 задание 
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        
        int[,] matrix = new int[n,n];

        for (int i = 0; i < n; i ++)
        {
            for (int j = 0; j < n; j++)
            {
                matrix[0, j] = 1;
                matrix[i, 0] = 1;
            }
        }
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < n; j++)
            {
                matrix[i, j] = matrix[i - 1, j] + matrix[i, j - 1];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(matrix[i,j] + " ");
            }

            Console.WriteLine();
        }
    } 
    */
    
    /* 4 задание
    static int[] AvgTemperature(int[,] temperature)
    {
        int[] avgTemps = new int[12];
        int sum = 0;
        
        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 30; j++)
            {
                sum += temperature[i, j];
            }

            avgTemps[i] = sum / 30;
            sum = 0;
        }

        return avgTemps;
    }
    
    static void Main()
    {
        int days = 30;
        int months = 12;
        int[,] temperature = new int[months,days];
        int min = -30;
        int max = -20;
        Random rand = new Random();

        for (int i = 0; i < months; i++)
        { 
            for (int j = 0; j < days; j++)
            {
                temperature[i,j] = rand.Next(min,max);
            }

            min = i < 6 ? min += 8 : min -= 8;
            max = i < 6 ? max += 10 : max -= 10;
        }

        Console.WriteLine("Cредняя температура за месяц");
            
        int[] avgTempsMonth = AvgTemperature(temperature);
            for (int i = 0; i < months; i++)
        {
            Console.Write(avgTempsMonth[i] + " ");
        }

        Console.WriteLine("\nОтсортированный массив");
        Array.Sort(avgTempsMonth);
        for (int i = 0; i < months; i++)
        {
            Console.Write(avgTempsMonth[i] + " ");
        }
    }
}
*/
     
    /* 5 задание
    static Dictionary<string, int> AvgTemperature(Dictionary<string,int[]> monthDict)
    {
        Dictionary<string, int> arr = new Dictionary<string, int>();
        int sum = 0;

        foreach (var month in monthDict)
        {
            for (int i = 0; i < 30; i++)
            {
                sum += monthDict[month.Key][i];
            }
            arr.Add(month.Key, sum / 30);
            sum = 0;
        }

        return arr;
    }
    
    static void Main()
    {
        Dictionary<string, int[]> months_dict = new Dictionary<string, int[]>()
        {
            ["January"] =     new int[30], 
            ["February"] =    new int[30],
            ["March"] =       new int[30],
            ["April"] =       new int[30],
            ["May"] =         new int[30],
            ["June"] =        new int[30],
            ["July"] =        new int[30],
            ["August"] =      new int[30],
            ["September"] =   new int[30],
            ["October"] =     new int[30],
            ["November"] =    new int[30],
            ["December"] =    new int[30],
        };
        
        int min = -30;
        int max = -20;
        int a = 10;
        int nextmonth = 0;
        Random rand = new Random();
        
        foreach (var month in months_dict)
        {
            for (int i = 0; i < 30; i++)
            {
                months_dict[month.Key][i] = rand.Next(min, max);
            }
            if (nextmonth < 6)
            {
                min += a;
                max += a;
            }
            else
            {
                min -= a;
                max -= a;
            }
            
            nextmonth++;
        }

        Dictionary<string, int> averageTemp = AvgTemperature(months_dict);
        foreach (var pair in averageTemp)
        {
            Console.Write(pair.Key+ ": ");
            Console.WriteLine(pair.Value);
        }
    }
    */
}


    





