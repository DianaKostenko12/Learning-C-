using System;
using System.Collections.Generic;

namespace Laba7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберiть шлях заповнення масиву: ручний або рандомний? ");
            int[,] array = (Console.ReadLine() == "ручний") ? HandInput() : RandomInput();

            Console.WriteLine("Масив: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write($"{array[i,j]}, ");
                }
                Console.WriteLine();
            }
            //Console.WriteLine("Середнє значення непарних елементiв масиву: " + FindAverageNum(array));
            GetRotatedMatrix(array);
        }
        static int[,] RandomInput()
        {
            Console.Write("Введiть довжину рядкiв i стовпцiв масиву: ");
            int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

            Console.Write("Введiть максимальне число масиву: ");
            int MaxValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть мiнiмальне число масиву: ");
            int MinValue = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j] = random.Next(MinValue, MaxValue);
                }
            }
            Console.Clear();
            return array;
        }
        static int[,] HandInput()
        {
            Console.Write("Введiть довжину рядкiв i стовпцiв масиву: ");
            int[,] array = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];

            Console.Write("Заповнiть масив вручну: ");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.Clear();
            return array;
        }

        static double FindAverageNum(int[,] array)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i,j] % 2 != 0)
                    {
                        list.Add(array[i, j]);
                    }
                }
                Console.WriteLine();
            }

            int sumOfNum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfNum += list[i];
            }
            double averageOfNum = sumOfNum / list.Count;
            return averageOfNum;
        }

        static void GetRotatedMatrix(int [,] array)
        {
            Console.WriteLine("Перевернутий масив на 180 градусiв вправо: ");
            for (int i = array.GetLength(0)-1; i >= 0; i--)
            {
                for (int j = array.GetLength(1)-1; j >= 0; j--)
                {
                    Console.Write($"{array[i,j]},");
                }
                Console.WriteLine();
            }
        }
    }
}
