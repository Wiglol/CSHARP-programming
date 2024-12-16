using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._8_at_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LegalAge = 18;

            var name = "John";

            int Counter = 1; 

            Console.Write("Please enter your age: "); 
            int Age = Convert.ToInt32(Console.ReadLine());

            if (Age >= LegalAge)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are under the legal age");
            }

            Console.Write("Welcome " + name + " Here are the results of your loops and switch statement"); 
            while (Counter <= 5)
            {
                Console.WriteLine(Counter++); 
            }
            switch(Counter)
            {
                case 1: Console.WriteLine("One"); 
                 break;
                case 2: Console.WriteLine("Two");
                    break;
                case 3: Console.WriteLine("Three");
                    break;
                case 4: Console.WriteLine("Four");
                    break;
                case 5: Console.WriteLine("Five");
                    break;
                default:
                    Console.WriteLine("Invalid Number");
                    break;





            }


            Console.ReadLine();
        }
    }
    
}
