using System;

namespace Zadanie2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, Count;
            int k = -1;
            Console.WriteLine("Вычисление числа Пи по заданной формуле:");
            check:
            try { 
            Console.WriteLine("Введите кол-во слагаемых");
            Count = int.Parse(Console.ReadLine());
                while (Count <= 0)
                {
                    Console.WriteLine("Ошибка! Введите положительное число.");
                }
            }catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число.");
                goto check;
            }
             catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзя обработать.");
                goto check;
            }
            double n = 3;
            double p = 1;
            for (i=0; i < Count; i++) 
            {
                p = p + (1 / n)*k;
                n = n + 2;
                k = k * (-1);
            }
            Console.WriteLine($"Вычисленное нами примерное значение числа Пи = {p*4}");
        }
    }
}
