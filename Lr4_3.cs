using System;
class Program
{
    static long FindNum(int n)
    {
        if (n == 0) return 2;
        if (n == 1 || n == 2) return 3;
        long x0 = 2;
        long x1 = 3;
        long x2 = 3;
        long xi = 0;
        for (int i = 3; i <= n; i++)
        {
            xi = 7 * x2 - x1 * x0;  
            x0 = x1;
            x1 = x2;
            x2 = xi;
        }
        return xi;
    }
    static void Main()
    {
        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());
        long result = FindNum(n);
        Console.WriteLine($"x_{n} = {result}");
    }
}