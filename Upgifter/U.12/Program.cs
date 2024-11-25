using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a password: ");
            string password = Console.ReadLine();
            Console.Write("Please enter your passord again: ");
            string password2 = Console.ReadLine();
            
            if
              (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(password2))
                Console.Write("please enter a password");
            else if (password.Length < 6 || password2.Length < 6)
                Console.Write("Password too short");
            else if (password == password2)
                Console.Write("password match");
            else Console.Write("Passwords do not match"); 


           

            Console.ReadLine();

        }

    }
}
