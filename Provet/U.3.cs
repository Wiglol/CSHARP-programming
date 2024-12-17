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
        {
            string[] Names = { "Bob", "Steve", "Nina" };

            Array.Sort(Names);

            for (int i = 0; i < Names.Length; i++)
            {
                Console.WriteLine("Goodbye " + Names[i]);
            }

            int[] myNumbers = { 5, 57, 87, 1, 150, 32, 14 };
            Array.Sort(myNumbers);
            int numToRemove = 150;
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
