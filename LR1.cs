//Дано два дійсних числа. Знайти суму, добуток, середнє арифметичне та середнє
//геометричне цих чисел
using System;
namespace LR1{
class Program1
{
    static void Main()
    {
        Console.Write("Введіть число:");
        float a=double.Parse(Console.ReadLine());
        Console.Write("Введіть число:");
        float b=double.Parse(Console.ReadLine());
        double sum=a+b;
        double dot=a*b;
        const int N=2;
        double averageA=sum/N;
        double averageG=Math.Sqrt(dot);
        Console.WriteLine("Сума ={0}, добуток={1} , середнє арифметичне={2}, середнє геометричне={3}",sum , dot, averageA, averageG);
        Console.ReadKey();
    }
}
}