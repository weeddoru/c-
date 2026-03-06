using System;
namespace LR1{
class Program2_2
    {
        static void Main()
        {
            int n,x;
            Console.Write("Введіть число n:");
            n=int.Parse(Console.ReadLine());
            Console.Write("Введіть число x:");
            x=int.Parse(Console.ReadLine());
            double z;
            if (n==10)
                z=Math.Pow(Math.Sin(x),n);
            else if (n==22)
                z=Math.Pow(x,n);
            else if(n==3)
                 z=Math.Pow(n,x);
            else
                 z=1;
            Console.Write("z={0}",z);
            
        }
    }
}