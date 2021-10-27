using System;

namespace Indiv1Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double first, second;
            check1:
            try
            {
                Console.WriteLine("Введите первое число");
                first = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число.");
                goto check1;
            }
            check2:
            try
            {
                Console.WriteLine("Введите второе число");
                second = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число.");
                goto check2;
            }
            if (first < 0 || second < 0)
            {
                Console.WriteLine("Error!");
            }
            else if (first < second)
            {
                Console.WriteLine($"Корень меньшего числа:{Math.Sqrt(first)}");
            }
            else if (second < first)
            {
                Console.WriteLine($"Корень меньшего числа:{Math.Sqrt(second)}");
            }
            else
            {
                Console.WriteLine($"Числа равны, их корни: {Math.Sqrt(first)} , {Math.Sqrt(second)}");
            }
        }
    }
}
