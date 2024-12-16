using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._6_at_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 1;

            while (Counter <= 5)
            {
                Console.WriteLine(Counter++);  // The 2 pluses make it go from 1-5 instead of 1111111111111111111111111111111111111111
            }




            Console.ReadLine();
        }
    }
}
