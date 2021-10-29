using System;

namespace Zadanie4Lab2
{
    class Program
    {
        static int Factorial(int fact)
        {
            if (fact == 0)
            {
                return 1;
            }
            else
            {
                return fact * Factorial(fact - 1);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа вычисляет косинус числа по формуле ряда Тейлора.");
            int x,q;
            check:
            try
            {
                Console.WriteLine("Введите число.");
                x = int.Parse(Console.ReadLine());
            }catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число.");
                goto check;
            }catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзая обработать.");
                goto check;
            }
            check2:
            try
            {
                Console.WriteLine("Введите число q(при превышении числом q модуля следующего слагаемого расчет будет окончен).");
                q = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число.");
                goto check2;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзая обработать.");
                goto check2;
            }
            double cos = 1;
            int stepen = 2;
            int k = -1;
            int n = 0;
            int fact = 2;
            double slag;
            do
            {
                slag = (Math.Pow(x, stepen) / Factorial(fact));
                cos += slag * k;
                stepen += 2;
                fact += 2;
                k *= -1;
                n++;
            } while (Math.Abs(slag) > q);
            Console.WriteLine($"Вычисленное нами значение = {cos}, кол-во действий = {n}");
        }
    }
}
