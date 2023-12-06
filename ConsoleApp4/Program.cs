class Program
{
    /* 1 задание
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int product = 1;
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0)
            {
                product *= i;
            }
        }
        Console.WriteLine(product);
    }
    */

    /* 2 задание
    static void Main()
    {
        Random r = new Random();
        StreamWriter writer = new StreamWriter("numsTask2.txt", false);
        string[] nums = new string[40];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToString(Math.Round((r.NextDouble() * 200 - 100), 3));
        }
        string rezult = string.Join(';', nums);
        writer.Write(rezult);
        writer.Close();

        nums = File.ReadAllLines("numsTask2.txt")[0].Split(';');
        float sum = 0;
        foreach (var n in nums)
        {
            if (n == "0") break;
            if (Convert.ToSingle(n) > 0)
            {
                sum += Convert.ToSingle(n);
            }
        }

        Console.WriteLine(sum);
    }
    */
    
    /* 3 задание 
    static void Main()
    {
        Random r = new Random();
        StreamWriter writer = new StreamWriter("numsTask3.txt", false);
        string[] nums = new string[10];
        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = Convert.ToString(r.Next(-20,40));
        }
        string rezult = string.Join(',', nums);
        writer.Write(rezult);
        writer.Close();
        
        nums = File.ReadAllLines("numsTask3.txt")[0].Split(',');
        float max = 0;
        float min = 0;
        foreach (var n in nums)
        {
            if (n == "0") break;
            if (int.Parse(n) > int.Parse(n + 1))
            {
                max = Convert.ToSingle(n);
            }
            if (int.Parse(n) < int.Parse(n + 1))
            {
                min = Convert.ToSingle(n);
            }
        }

        float a = Math.Abs(max / min);
        float b = Math.Abs(min / max);

        Console.WriteLine($"Отношение минимального и максимального элементов = {a}\nОтношение минимального к максимальному = {b}");
    }
    */
    
    /* 4 задание
    static void Main()
    {
        string[] numbers = File.ReadAllLines("numsTask4.txt")[0].Split(' ');
        int count = 1;
        for (int i = 1; i < numbers.Length; i++)
        {
            if ( numbers[i] == numbers[i - 1])
            {
                count ++;
            }
        }

        Console.WriteLine(count);
    }
    */

    /* 5 задание 
    static void Main()
    {
        float a = Convert.ToSingle(Console.ReadLine());
        float b = Convert.ToSingle(Console.ReadLine());
        float x1 = -1;
        float x2 =3;
        float y1 = -2;
        float y2 = 4;
        if ((x1 <= a && a <= x2) && (y1 <= b && b <= y2 ))
        {
            Console.WriteLine("Точка принадлежит заштрихованной области");
        }
        else
        {
            Console.WriteLine("Точка не принадлежит заштрихованной области");
        }
    }
    */
    
    /* 6 задание
    static void Main()
    {
        float x0 = Convert.ToSingle(Console.ReadLine());
        float y0 = Convert.ToSingle(Console.ReadLine());
        float x1 = -2, x2 = 0, x3 = 2;
        float y1 = -3, y2 = 2, y3 = -3;
        float a = (x1 - x0) * (y2 - y1) - (x2 - x1) * (y1 - y0);
        float b = (x2 - x0) * (y3 - y2) - (x3 - x2) * (y2 - y0);
        float c = (x3 - x0) * (y1 - y3) - (x1 - x3) * (y3 - y0);

        if ((a >= 0 && b >= 0 && c >= 0) || (a <= 0 && b <= 0 && c <= 0))
        {
            Console.WriteLine("Принадлежит треугольнику");
        }
        else
        {
            Console.WriteLine("Не принадлежит треугольнику");
        }
    }
    */
}