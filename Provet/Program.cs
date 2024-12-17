using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace u._4_prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first number: ");
            int input1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int input2 = Convert.ToInt32(Console.ReadLine());

            string sum = Add(input1, input2);
            string difference = Subtract(input1, input2);
            string product = Multiply(input1, input2);
            string quotient = Divide(input1, input2);

            Console.WriteLine($"The sum of the numbers is: {sum}");
            Console.WriteLine($"The difference of the numbers is: {difference}");
            Console.WriteLine($"The product of the numbers is: {product}");
            Console.WriteLine($"The quotient of the numbers is: {quotient}");

            Console.ReadLine();
        }


        static string Add(string input1, string input2)
        {
            return input1 + input2;
        }

        static string Subtract(string num1, string num2)
        {
            return num1 + "-" + num2;
        }


        static string Multiply(string num1, string num2)
        {
            return num1 + "*" + num2;
        }

        static string Divide(string num1, string num2)
        {
            return num1 + "/" + num2;
        }






    }
}
