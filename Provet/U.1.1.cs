using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_U._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // asks the Person to enter a number and then stores it to number, number2 and so on 
            Console.Write("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a double: "); 
            double number2 = Convert.ToDouble(Console.ReadLine());  
            Console.Write("Please enter a float: "); 
            float number3 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please enter a word: "); 
            String word = Console.ReadLine();
            // Writes them out 
            Console.WriteLine(word);
            Console.WriteLine(number);
            Console.WriteLine(number2);
            Console.WriteLine(number3);
            // Writes out the description of variables
            Console.WriteLine("An int stores whole numbers so numbers without decimals");
            Console.WriteLine("A float is a number with less dicimals than a double");
            Console.WriteLine("A double is a number with decimals it can hold alot of them");
            Console.WriteLine("A string is a word that can hold characters");

            Console.ReadLine(); 

        }
    }
}
