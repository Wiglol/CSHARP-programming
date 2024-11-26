using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace U._16_real
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 45, 12, 78, 34 ,89, 23 };

            foreach (int num in array)

                Console.Write($"{num} ");
            Console.WriteLine();

             Array.Sort(array);

            foreach (int num in array)
                Console.Write($"{num} ");
            Console.WriteLine();

            Array.Reverse(array);
            foreach (int num in array)
                Console.Write($"{num} ");

            
            var numbersList = array.ToList();
            numbersList.Remove(78);

            Console.WriteLine();

            foreach (int num in numbersList)
                Console.Write($"{num} ");

            Console.WriteLine();

            int search = 34;

            int position = Array.IndexOf(array, search);

            if (position > -1)
            {
                Console.WriteLine($"Number {search} has been found at position {position + 1}");

            }
            else
            { Console.WriteLine($"Number {search} has been found");

             }













            Console.ReadLine(); 
        }
    }
}
