//Визначити координатну чверть, в яку потрапляє точка із координатами x і y
//(xy ≠ 0).
using System;
namespace LR1{
class Program2_1
    {
        static void Main()
        {
            double x, y;
            Console.Write("x=");
            x=double.Parse(Console.ReadLine());
            Console.Write("y=");
            y=double.Parse(Console.ReadLine());
            if (x>0 && y > 0)
                Console.WriteLine("1 чверть");
            else if (x<0 && y > 0)
                Console.WriteLine("2 чверть");
            else if (x<0 && y < 0)
                Console.WriteLine("3 чверть");
            else
                Console.WriteLine("4 чверть");
        }
    }
}