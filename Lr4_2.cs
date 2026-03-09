//Дано послідовність з m натуральних чисел  n1 ,n2 ,..., nm Обчислити суму цифр всіх чисел
using System;
namespace LR4_2{
class Program
{
    static int SumOfDigits(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10; 
            number /= 10;       
        }
        return sum;
    }

    static void Main()
    {
        Console.Write("Введіть кількість чисел m: ");
        int m = int.Parse(Console.ReadLine());
        int totalSum = 0;
        for (int i = 1; i <= m; i++)
        {
            Console.Write($"Введіть число n{i}: ");
            int value = int.Parse(Console.ReadLine());
            totalSum += SumOfDigits(value); 

        Console.WriteLine($"Сума цифр усіх чисел = {totalSum}");
    }
}}}