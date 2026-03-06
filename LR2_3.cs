//Дано чотири точки, що є вершинами чотирикутника З’ясувати, чи можуть вони бути вершинами трапеції
using System;
namespace LR1{
class Program2_3
{
    static void Main()
    {
        Console.WriteLine("Введіть координати 4 точок:");

        Console.Write("A (x): ");
        double x1 = double.Parse(Console.ReadLine());
        Console.Write("A (y): ");
        double y1 = double.Parse(Console.ReadLine());

        Console.Write("B (x): ");
        double x2 = double.Parse(Console.ReadLine());
        Console.Write("B (y): ");
        double y2 = double.Parse(Console.ReadLine());

        Console.Write("C (x): ");
        double x3 = double.Parse(Console.ReadLine());
        Console.Write("C (y): ");
        double y3 = double.Parse(Console.ReadLine());

        Console.Write("D (x): ");
        double x4 = double.Parse(Console.ReadLine());
        Console.Write("D (y): ");
        double y4 = double.Parse(Console.ReadLine());

        double abx = x2 - x1;
        double aby = y2 - y1;

        double bcx = x3 - x2;
        double bcy = y3 - y2;

        double cdx = x4 - x3;
        double cdy = y4 - y3;

        double dax = x1 - x4;
        double day = y1 - y4;

        bool ab_cd = abx * cdy == aby * cdx;
        bool bc_ad = bcx * day == bcy * dax;

        if (ab_cd ^ bc_ad)
            Console.WriteLine("Точки є вершинами трапеції");
        else
            Console.WriteLine("Точки не можуть бути вершинами трапеції");
    }

    
}}