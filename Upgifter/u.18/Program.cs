using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace U._18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the width of your triangle: "); 
            string widthText = Console.ReadLine();  
            int width = Convert.ToInt32(widthText);
            Console.Write("Please enter the height of your triangle: "); 
            string heightText = Console.ReadLine();
            int height = Convert.ToInt32(heightText);

            Double area = (height * width) / 2.0;

            Console.WriteLine($"The area of the triangle is: {area}");

            Console.ReadLine();


        }
    }
}
