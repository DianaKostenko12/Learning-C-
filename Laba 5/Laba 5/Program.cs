using System;

namespace Laba_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введiть довжину радiуса першого кола: ");
            double R1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введiть довжину радiуса другого кола: ");
            double R2 = Convert.ToDouble(Console.ReadLine());

            double S1 = 0, S2 = 0, S3 = 0;

            if (R1 > R2)
            {
                CircleAreaUsingRef(R1, R2, ref S1, ref S2, ref S3);
                Console.WriteLine($" Площа першого кола: {S1}.\n Площа другого кола: {S2}.\n Площа кiльця: {S3}.");
            }
            else
            {
                Console.WriteLine("Довжина радiуса першого кола, повинна бути бiльша за довжину радiуса другого кола");
            }
            //Console.Write("Введiть двозначне число: ");
            //string twoDigitNumber = Console.ReadLine();
            //GetNumbersofArray(twoDigitNumber);
        }

        //static void GetNumbersofArray(string twoDigitNumber)
        //{
        //    Console.WriteLine($"Перше цифра числа {twoDigitNumber[0]} , друга цифра числа {twoDigitNumber[1]}");
        //}

        static void CircleAreaUsingRef(double R1, double R2, ref double S1, ref double S2, ref double S3)
        {
            S1 = Math.PI * Math.Pow(R1, 2);
            S2 = Math.PI * Math.Pow(R2, 2);
            S3 = Math.PI * (Math.Pow(R1, 2) - Math.Pow(R2, 2));
        }


    }


}
