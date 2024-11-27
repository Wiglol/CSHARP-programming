using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;

            int lenght = 5;

            int[] multiplicationArray = new int[lenght];
            for (int i = 0; i < lenght; i++)
                multiplicationArray[i] = (i + 1) * num;

            Console.WriteLine("From 1-10 how fun is this Upgift?");
            
            int Maybeworks = Convert.ToInt32(Console.ReadLine());

            if (Maybeworks <= 0)
            {
                Console.WriteLine("Yes i agree it's a 0 but i said 1-10");
                Console.WriteLine("Please play again and enter a number from 1-10");
            }
            else if (Maybeworks <= 5)
            {
                Console.WriteLine("i agree the upgift was not fun");
                Console.WriteLine("Please play again and try a different outcome");
            }
            else if (Maybeworks <= 10)
            {
                Console.WriteLine("if you wrote a high number that means you are probably the teacher so here is the answer to the Upgift");
                Console.Write($" {num}: ");
                Console.WriteLine(string.Join(", ", multiplicationArray));
            }










            Console.ReadLine();















            Console.ReadLine();


        }
    }
}
