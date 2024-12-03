using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age");
            String AgeText = Console.ReadLine();
            int age  = Convert.ToInt32(AgeText);

            
            

            

            if (age >= 50)
            {
                Console.WriteLine("Over 50");
            }
            else if (age >= 30)
            {
                Console.WriteLine("Over 30");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Over 18");
            }
            else if (age <= 17)
            {
                Console.WriteLine("Your are under 18"); 
            }

            Console.ReadLine();
        }
    }
}
