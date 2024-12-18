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
        {   // The dictionay stores items 
            Dictionary<string, string> Items = new Dictionary<string, string>();
            bool running = true;
            // A while loop
            while (running)
            {
                Console.WriteLine("1. Add Subject");
                Console.WriteLine("2. Remove Subject");
                Console.WriteLine("3. Show all");
                Console.WriteLine("4. Exit");

                string input = Console.ReadLine();  
                // A switch case that let's you choose options 1-4
                switch (input)
                {
                    case "1": // Adds item and description to the dictionary
                        Console.Write("Enter the name of a new item: ");
                        string ItemName = Console.ReadLine();
                        Console.Write("Please enter the description of that item: ");
                        string Description = Console.ReadLine();

                        Items.Add(ItemName, Description); 
                        Console.WriteLine("Succesfully added to dictionary");

 
                        break;

                    case "2": // Let's you remove a item from the dictionary 
                        Console.Write("Please enter the name of the item you wish to remove: ");
                       
                        Console.WriteLine(Items.Remove(Console.ReadLine()) ? "Item removed." : "Item not found.");
                       



                        break;
                    case "3": // Shows what items are in the dictionary
                        Console.WriteLine("Here are the Item and it's description"); 
                        foreach (var subject in Items)
                        {
                            Console.WriteLine($"Items: {subject.Key}, Description: {subject.Value}");
                        }

                        break;
                    case "4": // Shows you Exit 
                        Console.WriteLine("Exit");   
                        running = false; 
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                       
                }
            }
            Console.ReadLine();
        }
    }
}



   