using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter the message: C# is fun, I am going to code C# tommorow");
            var message = Console.ReadLine();
            Console.WriteLine(message);

            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);

            Console.WriteLine(messageArray);

            foreach (char c in message) Console.WriteLine(c);

            foreach (char c in messageArray)
                Console.WriteLine(c);
        
                

            Console.ReadLine();
        }
    }
}
