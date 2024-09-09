using System.Runtime.Intrinsics.X86;

internal class Program
{
    private static void Main(string[] args)
    {
        Baitap1 baitap1 = new Baitap1();
        Baitap2 baitap2 = new Baitap2();
        Baitap3 baitap3 = new Baitap3();
        Baitap4 baitap4 = new Baitap4();
        Baitap5 baitap5 = new Baitap5();
        Baitap6 baitap6 = new Baitap6();
        Baitap7 baitap7 = new Baitap7();
        Baitap8 baitap8 = new Baitap8();
        Baitap9 baitap9 = new Baitap9();
        Baitap10 baitap10 = new Baitap10();

        baitap1.Run();
        baitap2.Run();
        baitap3.Run();
        baitap4.Run();
        baitap5.Run();
        baitap6.Run();
        baitap7.Run();
        baitap8.Run();
        baitap9.Run();
        baitap10.Run();
    }
}
internal class Baitap1
{
    public void Run()
    {
        Console.WriteLine("Nhập độ dài 3 cạnh cần kiểm tra:");

        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (!(a + b > c && a + c > b && b + c > a))
        {
            Console.WriteLine("input sai rùi");
            return;
        }

        if (a == b && a == c)
        {
            Console.WriteLine("Tam giác đểu");
        }
        else if (a == b || a == c || b == c)
        {
            Console.WriteLine("Tam giác cân.");
        }
        else
        {
            Console.WriteLine("Tam giác thường.");
        }
    {
        Console.WriteLine("=====End bai 1=====");
        }
    }
}
internal class Baitap2
{
    public void Run()
    {
        double sum = 0;
        int length = 10;

        Console.WriteLine("Enter 10 numbers:");
        for (int i = 1; i <= length; i++)
        {
            double number = input(i);
            sum += number;
        }

        Console.WriteLine($"Sum: {sum}");

        double average = sum / length;

        Console.WriteLine($"Average: {average}");
    }

    static double input(int index)
    {
        double number;
        while (true)
        {
            Console.Write($"Number {index}: ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
internal class Baitap3
{
    public void Run()
    {
        Console.Write("Input integer number: ");
        int input = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\nResult:");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{input} x {i} = {input * i}");
        }
    }
}
internal class Baitap4
{
    public void Run()
    {
        Console.Write("Input number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(j);
            }
            Console.WriteLine();
        }

        int count = 1;
        for (int k = 1; k <= rows; k++)
        {
            for (int h = 1; h <= k; h++)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.WriteLine();
        }

        int count2 = 1;
        for (int m = 1; m <= rows; m++)
        {
            int space = rows - m;
            for (int s = 0; s < space; s++)
            {
                Console.Write(" ");
            }
            for (int n = 1; n <= m; n++)
            {
                Console.Write(count2 + " ");
                count2++;
            }
            Console.WriteLine();
        }
    }
}
internal class Baitap5
{
    public void Run()
    {
        Console.Write("Input total number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 1)
        {
            Console.WriteLine("input must be > 0.");
            return;
        }

        double sum = 0;

        Console.WriteLine("\nList of number:");

        for (int i = 1; i <= n; i++)
        {
            double term = 1.0 / i;
            Console.Write(term + " ");
            sum += term;
        }

        Console.WriteLine($"\nSum: {sum}");
    }
}
internal class Baitap6
{
    public void Run()
    {
        Console.Write("Input start : ");
        int min = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input end: ");
        int max = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nPerfect number within {min} to {max}:");

        for (int num = min; num <= max; num++)
        {
            if (IsPerfectNumber(num))
            {
                Console.WriteLine(num);
            }
        }
    }

    static bool IsPerfectNumber(int number)
    {
        if (number < 2)
            return false;

        int sum = 0;

        for (int i = 1; i <= number / 2; i++)
        {
            if (number % i == 0)
            {
                sum += i;
            }
        }

        return sum == number;

    }
}
internal class Baitap7
{
    public void Run() 
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsPrime(number))
        {
            Console.WriteLine($"\n{number} is prime.");
        }
        else
        {
            Console.WriteLine($"\n{number} is not prime.");
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;
        if (number == 2)
            return true;
        if (number % 2 == 0)
            return false;

        for (int i = 3; i <= Math.Sqrt(number); i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}
internal class Baitap8
{
    public void Run()
    {
        Console.Write("Input number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is even.");
        }
        else
        {
            Console.WriteLine($"{number} is odd.");
        }
    }
}
internal class Baitap9
{
    public void Run()
    {
        Console.Write("Input number 1: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input number 2: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input number 3: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = a;

        if (b > max)
        {
            max = b;
        }
        if (c > max)
        {
            max = c;
        }

        Console.WriteLine($"Largest number is: {max}");
    }
}
    internal class Baitap10
{
    public void Run()
    {
        Console.Write("Input X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.Write("Input Y: ");
        double y = Convert.ToDouble(Console.ReadLine());

        string quadrant = DetermineQuadrant(x, y);
        Console.WriteLine($" ({x}, {y}) in {quadrant}.");
    }

    static string DetermineQuadrant(double x, double y)
    {
        if (x > 0 && y > 0)
            return "quadrant 1";
        else if (x < 0 && y > 0)
            return "quadrant 2";
        else if (x < 0 && y < 0)
            return "quadrant 3";
        else if (x > 0 && y < 0)
            return "quadrant 4";
        else if (x == 0 && y != 0)
            return "Y-axis";
        else if (x != 0 && y == 0)
            return "X-axis";
        else
            return "origin";
    }
}

 
    
   
 

   
  