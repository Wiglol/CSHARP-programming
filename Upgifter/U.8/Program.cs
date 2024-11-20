using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._8
{
    internal class Program
    {
        static void Main(string[] args)
        {

           

            Console.Write("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            const int LegalAge = 18;

            if (age >= LegalAge)
            {
                Console.WriteLine("You are of legal age.");
            }
            else
            {
                Console.WriteLine("You are not of legal age.");
            }

            int Counter = 1;

            while (Counter <= 5)
            {
                Console.WriteLine("Counter: " + Counter);
                Counter++;

            }

            switch (Counter)
            {
                case 0:
                    Console.WriteLine("1");
                    break;
                case 1:
                    Console.WriteLine("2");
                    break;
                case 2:
                    Console.WriteLine("3");
                    break;
                case 3:
                    Console.WriteLine("4");
                    break;
                case 4:
                    Console.WriteLine("5");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;

            }
            var name = "John";

            Console.Write("Welcome John here are your results");



            Console.ReadKey();















            }
    }
}
