using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_U._3
{
    internal class Program
    {
        static void Main(string[] args)
        {    // Makes an Array
            string[] Names = { "Alice", "John", "Mia" };

            Array.Sort(Names);
            // For loop 
            for (int i = 0; i < Names.Length; i++)
            { // makes it say goodbye before the names
                Console.WriteLine("Hello " + Names[i]);
            }
            // Array of numbers
            int[] myNumbers = { 12, 45, 78, 3, 99, 21, 8 };
            Array.Sort(myNumbers); // sorts the numbers in ascending oreder 
            int numToRemove = 99;// removes the number 99 
            int numIndex = Array.IndexOf(myNumbers, numToRemove);
            myNumbers = myNumbers.Where((val, idx) => idx != numIndex).ToArray();
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
