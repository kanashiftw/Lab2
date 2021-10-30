using System;

namespace Zadanie5Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Данная программа представляет введенное вами число в виде суммы трех кубов");
            int num;
            check:
            try
            {
                Console.WriteLine("Введите число");
                num = int.Parse(Console.ReadLine());
            }catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                goto check;
            }catch (OverflowException)
            {
                Console.WriteLine("Такое большое число нельзя обработать введите другое");
                goto check;
            }
            int i, j, k;
            bool nelza = true;
            for (i = 1; i < num;i++)
            {
                for (j = i; j < num; j++)
                {
                    for (k = j; k < num; k++)
                    {
                        if (i*i*i + j*j*j + k*k*k == num)
                        {
                            Console.WriteLine($"Данное число можно разложить так: {i}^3 + {j}^3 + {k}^3");
                            nelza = false;
                        }                                         
                    }
                }
            } 
            if (nelza)
            {
                Console.WriteLine("Нет таких комбинаций!");
            }
        }  
    }
}
