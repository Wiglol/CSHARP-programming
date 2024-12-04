using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._23
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                string MyString = Console.ReadLine();
                int num = Convert.ToInt32(MyString);
                Console.WriteLine(num);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");

                // Custom function to try parsing a string into an integer
                bool TryParseToInt(string input, out int result)
                {
                    return int.TryParse(input, out result);
                }

                // Main logic
                string MyString = Console.ReadLine();  // Read input from the user

                // Try parsing the string to an integer using the custom function
                if (TryParseToInt(MyString, out int num))
                {
                    Console.WriteLine(num);  // Print the successfully parsed number
                }
                else
                {
                    Console.WriteLine("Error: The input is not a valid integer.");
                }

            }










        }
    }
}
