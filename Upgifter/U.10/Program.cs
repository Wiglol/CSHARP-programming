using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace U._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1 ; int num2 = 2; int num3 = 3 ; int num4 = 4 ; int num5 = 5 ; int num6 = 6 ;


            Console.WriteLine(num1 + num2); 
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num5 / num6);


            int prefix = ++num6;
            int postfix = num6++; 
            int Decrement = --num6; 

            Console.WriteLine(prefix + Decrement);

            Console.WriteLine(num5 /= num2);
            Console.WriteLine(num5 += num4);
            Console.WriteLine(num5 -= num2);
            Console.WriteLine(num5 *= num1);
            Console.WriteLine(num5 %= num3);

            Console.ReadLine();
        }
    }
}
