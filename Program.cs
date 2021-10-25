using System;

namespace Indiv1Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double first = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            double second = double.Parse(Console.ReadLine());
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
