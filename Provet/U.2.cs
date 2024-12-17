using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_U._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number: "); 
            int Num = Convert.ToInt32(Console.ReadLine());
            // Checks if Num is over 0
            if (Num > 0)
            {
                Console.WriteLine("Number is positive");
            } // checks if Num is 0
            else if (Num == 0)
            {
              Console.WriteLine("The number is zero");
    
            } // checks if Num is under 0 
            else if( Num < 0)
            {
                Console.WriteLine("The number is negative"); 
            }
            else // Gives an error message 
            {
                Console.WriteLine("Invalid Input"); 
            }
            
            
            
            
                
            




            Console.ReadLine();
        }
    }
}
