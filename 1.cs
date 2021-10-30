using System;

namespace Zadanie1Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double First, Second;
            int a, b, c;
        check1:
            try
            {
                Console.WriteLine("Введите число a, отличное от нуля");
                a = int.Parse(Console.ReadLine());
                while (a == 0)
                {
                    Console.WriteLine("Коэффициент а не может быть равен нулю! Введите число отличное от нуля.");
                    a = int.Parse(Console.ReadLine());
                }
            }catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                goto check1;
            }catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзя обработать");
                goto check1;
            }
        check2:
            try
            {
                Console.WriteLine("Введите число b");
                b = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                goto check2;
            }catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзя обработать");
                goto check1;
            }
        check3:
            try
            {
                Console.WriteLine("Введите число c");
                c = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Вы ввели не число");
                goto check3;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Такое число нельзя обработать");
                goto check1;
            }
            Console.WriteLine($"Ваше уравнение: {a}x^2 + {b}x + {c}");
            //По первому св-ву коэффициента
            if (a + b + c == 0)
            {
                First = 1;
                Second = c / a;
                Console.WriteLine($"Первый корень = {First}, Второй корень = {Second}");
                //По второму св-ву коэффициента
            }
            else if (a - b + c == 0)
            {
                First = -1;
                Second = -c / a;
                Console.WriteLine($"Первый корень = {First}, Второй корень = {Second}");
            }
            else
            {
                double Discriminant = (b * b) - 4 * a * c;
                if (Discriminant <= 0)
                {            
                    Console.WriteLine($"Корни уравнения можно представить в виде комплексных чисел: ({-b} + i{Math.Sqrt( b*b +4*a*c)})/{2*a} , ({-b} + i{Math.Sqrt(b*b - 4*a*c)})/{2 * a}");
                }
                else
                {
                    First = (-b + Math.Sqrt(Discriminant)) / 2 * a;
                    Second = (-b - Math.Sqrt(Discriminant)) / 2 * a;
                    Console.WriteLine($"Первый корень = {First}, Второй корень = {Second}");
                    if (First > 0)
                    {
                        Console.WriteLine($"Первый корень уравнения равен {First}");
                    }
                    double x2 = (-b + Discriminant) / 2 * a;
                    if (Second > 0)
                    {
                        Console.WriteLine($"Второй корень уравнения равен {Second}");
                    }                  
                }
            }
        }
    }
}
