using System;
using static System.Console;

namespace RipeCode_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length of array: ");
            var len = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the length of the subsequence: ");
            var subLen = Convert.ToInt32(Console.ReadLine());
            if (subLen > len)
            {
                Console.Write("Invalid Subsequence Size");
                Console.ReadKey();
                return;
            }
            int[] array = new int[len];
            Console.WriteLine($"Enter enter {len} array elements: ");

            for (var i = 0; i < len; i++)
            {
                Console.Write($"Enter a[{i}]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int max = 0, sum = 0; ;
            bool firstSum = true;
            for (var i = 0; i < len - subLen; i++)
            {
                for (var j = 1; j <= subLen; j++)
                {
                    sum += array[i + j];
                }

                if ((sum > max) || firstSum)
                {
                    max = sum;
                    firstSum = false;
                }
                sum = 0;
            }
            Console.Write($"Largest sum of subsequence: {max}");

        }
    }
}
