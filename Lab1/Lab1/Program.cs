using System;
using System.Collections.Generic;

namespace Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> () {1,2,3,4,5};

            int sumOfNum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sumOfNum += list[i];
            }
            Console.WriteLine(sumOfNum);

        }
    }
}
