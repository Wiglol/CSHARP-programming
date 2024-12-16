using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {


        //static void Main(string[] args)
        //{
        //    Multiply(3, 8);
        //    Multiply(6, 9);

        //    Console.ReadLine();

        //}

        //static void Multiply(int num1, int num2)
        //{
        //    int result = num1 * num2;
        //    Console.WriteLine("The result is: " + result);
        //}
        static void Main(string[] args)
        {
            int result = Multiply(3, 3);

            Console.WriteLine("The result is: " + result);

            if (result % 2 == 0)
            {
                Console.WriteLine(result + " is an even number!");
            }
            else
            {
                Console.WriteLine(result + " is an uneven number!");
            }


            Console.ReadLine();

        }

        static int Multiply(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

    }
}