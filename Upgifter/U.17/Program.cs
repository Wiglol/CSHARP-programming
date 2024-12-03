using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U._17_true
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> subjects = new Dictionary<string, string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Show all");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();  

                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter the name of a new subject");
                        string subjectName = Console.ReadLine();
                        Console.WriteLine("Enter the name of the teacher for that subject");
                        string teachersName = Console.ReadLine();

                        subjects.Add(subjectName, teachersName); 
                        Console.WriteLine("Succesfully added to dictionary");

 
                        break;
                    case "2":
                        Console.WriteLine("Please enter the name of the subject you wish to remove");
                       
                        Console.WriteLine(subjects.Remove(Console.ReadLine()) ? "Subject removed." : "Subject not found.");
                       



                        break;
                    case "3":
                        Console.WriteLine("Here are the subject and their teacher"); 
                        foreach (var subject in subjects)
                        {
                            Console.WriteLine($"Subject: {subject.Key}, Teacher: {subject.Value}"); // Used the help of ChatGPT for this part
                        }

                        break;
                    case "4":
                        Console.WriteLine("Exit");   
                        running = false; 
                        break;
                    default:
                        Console.WriteLine("please don't do that. Please choose a number between 1 and 4.");
                        break;

                       
                }
            }
            Console.ReadLine();
        }
    }
}
