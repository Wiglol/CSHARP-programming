using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
                Console.WriteLine("Your number is odd");
            Console.Write(number);


            Console.ReadLine(); 

        }
    }
}
