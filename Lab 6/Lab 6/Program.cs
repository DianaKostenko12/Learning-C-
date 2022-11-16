using System;
using System.Collections.Generic;

namespace Lab_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Оберiть шлях заповнення масиву: ручний або рандомний? ");
            int[] array = (Console.ReadLine() == "ручний") ? HandInput() : RandomInput();

            Console.Write("Масив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            array = InverseArray(array);
            Console.Write("\nОтриманий масив 1: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }

            array = GetFinArray(array);
            Console.Write("\nОтриманий масив 2: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]}, ");
            }
        }
        static int[] RandomInput()
        {
            Console.Write("Введiть довжину масиву: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            Console.Write("Введiть максимальне число масиву: ");
            int MaxValue = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введiть мiнiмальне число масиву: ");
            int MinValue = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(MinValue, MaxValue);
            }
            Console.Clear();
            return array;
        }


        static int[] HandInput()
        {
            Console.Write("Введiть довжину масиву: ");
            int[] array = new int[Convert.ToInt32(Console.ReadLine())];

            Console.Write("Заповнiть масив вручну: ");
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Clear();
            return array;
        }

        static int[] InverseArray(int[] array)
        {
            int min = int.MaxValue, max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];

                if (array[i] < min) min = array[i];
            }
            int indexOfMax = Array.IndexOf(array, max);
            int indexOfMin = Array.IndexOf(array, min);

            int indexStart = indexOfMax > indexOfMin ? indexOfMax : indexOfMin;
            int indexEnd = indexOfMax > indexOfMin ? indexOfMin : indexOfMax;

            List<int> list = new List<int>();

            for (int i = 0; i < indexEnd; i++)
            {
                list.Add(array[i]);
            }
            for (int i = indexStart; i >= indexEnd; i--)
            {
                list.Add(array[i]);
            }
            for (int i = indexStart + 1; i < array.Length; i++)
            {
                list.Add(array[i]);
            }
            return list.ToArray();
        }

        static int[] GetFinArray(int[] array)
        {
            List<int> listOfIndexesOfPosNums = new List<int>();
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) listOfIndexesOfPosNums.Add(i);

            for (int i = 0; i < listOfIndexesOfPosNums.Count / 2; i++)
            {
                var buff = array[listOfIndexesOfPosNums[i]];
                array[listOfIndexesOfPosNums[i]] = array[listOfIndexesOfPosNums[listOfIndexesOfPosNums.Count - (1 + i)]];
                array[listOfIndexesOfPosNums[listOfIndexesOfPosNums.Count - (1 + i)]] = buff;
            }

            return array;
        }
    }
}
