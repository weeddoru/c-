using System;
namespace LR1{
class Program3_1
{
    static void Main()
    {
        Console.Write("Введіть n: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        double factorial = 1;

        for (int i = 1; i <= n; i++)
        {
            factorial *= i;
            sum += 1.0 / factorial;
        }

        Console.WriteLine("Сума = " + sum);
    }
}}