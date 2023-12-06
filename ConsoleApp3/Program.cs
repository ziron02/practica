class Program
{
    /* 1 задание
    static void Main()
    {
        string[] lines = File.ReadAllLines("input.txt");
        string[] luckyNums = lines[0].Split(' ');
        int ticketCount = Convert.ToInt32(lines[1]);
        StreamWriter writer = new StreamWriter("output.txt", true);
        for (int i = 2; i < 2 + ticketCount; i++)
        {
            int a = 0;
            string[] num = lines[i].Split(' ');
            foreach (var n in num)
            {
                if (luckyNums.Contains(n))
                {
                    a++;
                }
                
            }
            if (a >= 3)
            {
                writer.WriteLine("lucky");
                Console.WriteLine("lucky");
            }
            else
            {
                writer.WriteLine("Unlucky");
                Console.WriteLine("Unlucky");
            }
        }
        writer.Close();
    }
    */

    /* 2 задание
    static void Main()
    {
        Random r = new Random();
        StreamWriter writer = new StreamWriter("nums.txt", false);
        string[] nums = new string[10];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToString(r.Next(-20, 40));
        }

        string rezult = string.Join(' ', nums);
        writer.Write(rezult);
        writer.Close();

        nums = File.ReadAllLines("nums.txt")[0].Split(' ');
        List<string> num = new List<string>();
        foreach (var n in nums)
        {
            if (int.Parse(n) % 2 != 0)
            {
               num.Add(n);
            }
        }

        string numbers = " ";
        foreach (var a in num)
        {
            numbers += $"{a} ";
        }

        Console.WriteLine(numbers);
    }
    */
    
    /* 3 задание
    static void Main()
    {
        string[] a = File.ReadAllLines("heights.txt")[0].Split(' ');
        int[] height = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            height[i] = int.Parse(a[i]);
        }

        int minH = 0;
        int maxS = 0;
        int line1 = 0;
        int line2 = 0;
        for (int i = 0; i < height.Length; i++)
        {
            for (int j = i + 1; j < height.Length; j++)
            {
                if (height[i] < height[j])
                {
                    minH = height[i];
                }
                else
                {
                    minH = height[j];
                }
                int Xdiff = 0;
                if (j - i > 0)
                {
                    Xdiff = j - i;
                }
                else
                {
                    Xdiff = i - j;
                }
                int S = minH * Xdiff;
                if (S > maxS)
                {
                    maxS = S;
                    line1 = i + 1;
                    line2 = j + 1;
                }
            }
        }
        Console.WriteLine($"первая линия: {line1}\nвторая линия: {line2}");
        Console.WriteLine($"площадь контейнера, содержащего наибольшее количество воды: {maxS}");
    }
    */
}
