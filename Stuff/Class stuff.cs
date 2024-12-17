using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_Examples
{
    public class Wiglo
    {
        public int Height; 
        public int Width;
        public int Age; 

        public Wiglo(int height, int width, int age)
        {
            Height = height;
            Width = width;
            Age = age; 

        }
        public void DisplayInfo()
        {
            
            Console.WriteLine($"Wiglo: {Height}cm tall {Width}cm fat {Age} years old ");
        }


        public static void Main()
        {
            Wiglo wiglo = new Wiglo(168, 50, 16);
            wiglo.DisplayInfo();
            Console.ReadLine();
        }

    }
}
