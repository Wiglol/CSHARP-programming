using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._8_at_home
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1; 

            int num2 = 2;

            int num3 = 3;

            int num4 = 1;

            bool isTrue = true;

            bool resultAnd = isTrue && (num1 > num3 && num2 < num4);
            bool resultOr = isTrue && (num1 < num3 || num2 > num4);
            bool resultNot = !isTrue;

            Console.WriteLine(resultAnd);
            Console.WriteLine(resultOr);
            Console.WriteLine(resultNot);

            if (num1 > num3)
            {
                Console.WriteLine("1 is greater than 3");
            }
            else
            {
                Console.WriteLine("1 is not greater than 3");
            }


            if (num2 < num4)
            {
                Console.WriteLine("2 is less than 4");
            }
            else
            {
                Console.WriteLine("2 is not greater than 4");
            }

            if (num1 == num4)
            {
                Console.WriteLine("1 is equal to 4");
            }
            else
            {
                Console.WriteLine("1 is not equal to 4");
            }

            if (num2 != num3)
            {
                Console.WriteLine("2 is not equal to 3");
            }
            else
            {
                Console.WriteLine("2 is equal to 3");
            }

            bool expression1 = (num1 > num3 && num2 < num4);
            bool expression2 = (num1 < num3 || num2 > num4);

            Console.WriteLine(expression1);
            Console.WriteLine(expression2);



            Console.ReadLine();



            Console.ReadLine();
        }
    }
    
}
