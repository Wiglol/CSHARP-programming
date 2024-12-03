using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace U._20
{
    public class Circle
    {
        public double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    class Program
    {
        static void Main()
        {
            Circle myCircle = new Circle(1.5);

            
            double area = myCircle.CalculateArea();

          
            Console.WriteLine($"Area of the circle is: {area}");

            Console.ReadLine();
        }
    }




}
