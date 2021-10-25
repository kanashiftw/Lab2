using System;

namespace Zadanie2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Вычисление числа Пи по заданной формуле:");
            Console.WriteLine("Введите кол-во слагаемых");
            int Count = int.Parse(Console.ReadLine());
            double n = 3;
            double p = 1;
            for (i=0; i < Count; i++) 
            {
                p = p - (1 / n) +( 1 / (n + 2));
                n = n + 4;
            }
            Console.WriteLine($"Вычисленное нами примерное значение числа Пи = {p*4}");
        }
    }
}
