using System;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            Console.Write("Введiть значення x: ");
            try
            {
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Math.Pow(x, 3) + (4 * Math.Pow(x, 2)) + (x - 2);
                Console.WriteLine("Отриманий результат: " + y);
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Помилка: {exception.Message}");
            }
            catch (OverflowException exception)
            {
                Console.WriteLine($"Помилка: {exception.Message}");
            }

            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Task2
            Console.Write("Введiть цiну 1 кг цукерок: ");
            double candy = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть цiну 1 кг печива: ");
            double cookie = Convert.ToInt32(Console.ReadLine());

            double purchase = (300 * candy) / 1000 + (400 * cookie) / 1000;
            Console.WriteLine("Вартiсть всiєї покупки: " + purchase);

            double triplePurchase = 3 * ((cookie * 2) + ((1800 * candy) / 1000));
            Console.WriteLine("Вартiсть трьох покупок: " + triplePurchase);

            Console.ReadKey();
            Console.Clear();
            #endregion

            try
            {
                Console.Write("Введiть значення x: ");
                double x = Convert.ToDouble(Console.ReadLine());

                Console.Write("Введiть значення кута а: ");
                double a = Convert.ToDouble(Console.ReadLine());
                if (a == 0)
                {
                    Console.WriteLine("Не можна дiлити на нуль");
                }
                else
                {
                    double y = (Math.Log(Math.Pow(x, 3) - 8)) + (1 / Math.Sin(a));
                    Console.WriteLine("y = " + y);
                }
            }
            catch (FormatException exception)
            {
                Console.WriteLine($"Помилка: {exception.Message}");
            }

            catch (OverflowException exception)
            {
                Console.WriteLine($"Помилка: {exception.Message}");
            }
        }
    }
}
