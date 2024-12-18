using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Provet_U._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: ");
            string userInput = Console.ReadLine();

            // Makes it so the console dosen't crash
            if (double.TryParse(userInput, out double number)) 
            {
                if (number > 0)
                {
                    Console.WriteLine("The number is positive.");
                }
                else if (number == 0)
                {
                    Console.WriteLine("It's zero.");
                }
                else
                {
                    Console.WriteLine("The number is negative.");
                }
            }
            else
            {
                Console.WriteLine("Can't do that! Please enter a valid number.");
            }

            Console.ReadLine(); // Keeps the console open and clean
        }
    }
    
}
