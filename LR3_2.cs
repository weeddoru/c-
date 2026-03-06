using System;
namespace LR1{
class Program3_2
{
    static double Cos(double x, double eps = 1e-10)
    {
        x = x * Math.PI / 180;
        double current = 1;
        double sum = 1;
        int n = 1;
        while (Math.Abs(current) > eps)
        {
            current *= -x * x / ((2 * n - 1) * (2 * n));
            sum += current;
            n++;
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введіть кут у градусах: ");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine($"cos({x}) = {Cos(x)}");
    }
}}