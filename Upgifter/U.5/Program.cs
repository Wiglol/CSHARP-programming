using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Enter your grade: ");
            int Grade = Convert.ToInt32(Console.ReadLine());
            switch (Grade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvement");
                    break;
                case 2:
                    Console.WriteLine("ok");
                    break;
                case 3:
                    Console.WriteLine("satisfactory");
                    break;
                case 4:
                    Console.WriteLine("good");
                    break;
                case 5:
                    Console.WriteLine("Excellent");
                    break;
              
                default:
                    Console.WriteLine("Invalid, enter a value between 0 and 5");
                    break;

            }
            Console.ReadKey();
        }
    }
}
