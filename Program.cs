using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
          
            Console.Write("How old are you human: ");

            int age = Convert.ToInt32(Console.ReadLine());




            if (age >= 18)
            {
                Console.WriteLine("You can vote");
            }
            else
            {
                Console.WriteLine("You can't vote ");
            }

            Console.ReadLine();
            
            
            
           




        }
    }
}
