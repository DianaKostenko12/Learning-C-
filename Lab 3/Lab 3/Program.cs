using System;

namespace Lab_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string answer;
            do
            {
                Console.Write("Введiть цiле число N: ");
                int N;
                    try
                    {
                        N = Convert.ToInt32(Console.ReadLine());
                        if ( N <= 0)
                        {
                            throw new Exception();
                        }

                        for (int c = 1; c < N; c++)
                        {
                            for (int b = 1; b < N; b++)
                            {
                                for (int a = 1; a < N; a++)
                                {
                                    if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
                                    {
                                        Console.WriteLine($"Пiфагорова трiйка: {a}, {b}, {c} ");
                                    }
                                }
                            }
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
                    catch(Exception) 
                    {
                        Console.WriteLine("Не можна вводити нуль!!!");
                    }

                    Console.WriteLine("Ви бажаєте вийти з програми? Yes/No");
                    answer = Console.ReadLine();
                    Console.Clear();
            }
            while (answer == "No");
            
        }
    }
}
