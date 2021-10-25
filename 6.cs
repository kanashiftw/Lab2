using System;

namespace Zadanie6Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число от одного до ста");
            int n = int.Parse(Console.ReadLine());
                while (n < 1 || n > 100)
                {
                    Console.WriteLine("Некорректный ввод! Введите число от одного до ста");
                    n = int.Parse(Console.ReadLine());
                }
            if (n%10 == 1 & (n>11 || n <2))
            {
                Console.WriteLine($"{n} год");
            }
            else if (n % 10 < 5 & n % 10 > 1)
            {
                Console.WriteLine($"{n} года");
            }
            else
            {
                Console.WriteLine($"{n} лет");
            }
        }
    }
}
