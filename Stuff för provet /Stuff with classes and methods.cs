using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {

        static Random numberGen = new Random();
        static void Main(string[] args)
            {
             MeetAlien();

            Console.WriteLine("-----------"); 

             MeetAlien(); 

             Console.ReadLine();
            }

            static void MeetAlien()
        {
            

            string name = "x-" + numberGen.Next(10, 9999);
            int age = numberGen.Next(10, 500);

            Console.WriteLine("Hi im " + name);
            Console.WriteLine("Im " + age + " years old. ");
            Console.WriteLine("Oh and im an alien"); 
        }
        
    }
}