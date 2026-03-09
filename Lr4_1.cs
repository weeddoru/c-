using System;
namespace LR4{
class fProgram4
    {
        static double f(double x){
        if (x < 23)
            {
                return 0;
            }else if (x == 23)
            {
                return 1;
            }
            else
            {
                return 1;
            }
        }
        static void Main(){
        Console.Write("Введіть число a:");
        double a=double.Parse(Console.ReadLine());
        Console.Write("Введіть число b:");
        double b=double.Parse(Console.ReadLine());

        double result=f(4)+2*f(a)-f(b);
        Console.WriteLine("f(4)+2*f(a)-f(b)= "+ result);
        }
        
    }
}