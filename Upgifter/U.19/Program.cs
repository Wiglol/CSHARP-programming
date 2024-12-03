using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            int[] SumOfNumbers = { 0, 1, 2, 3, 4, 5 };
            int sum = 0;
            for (int i = 0; i < SumOfNumbers.Length; i++)
            {
                sum += SumOfNumbers[i];
            }


            if (sum >= -1) Console.WriteLine($"The sum is: {sum}");
            else Console.WriteLine("Cannot add up an empty array");

            int length = SumOfNumbers.Length;

         
            Console.WriteLine("The length of the array is: " + length);
            Console.ReadLine();





            


        }
    }
}
