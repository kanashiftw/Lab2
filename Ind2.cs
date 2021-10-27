using System;

namespace Indiv2Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            check:
            try 
            {
                Console.WriteLine("Введите число от 1 до 100000");
                num = double.Parse(Console.ReadLine());
                while (num < 1 || num > 100000)
                {
                    Console.WriteLine("Ошибка! Введите число от 1 до 100000");
                    num = double.Parse(Console.ReadLine());
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Введите число");
                goto check;
            }           
            Console.WriteLine("Все нечетные делители данного числа:");
            for (int i = 1; i <= 50000; i+=2)
            {
                if (num%i == 0)
                {
                    Console.WriteLine(i);
                } 
            }
        }
    }
}
