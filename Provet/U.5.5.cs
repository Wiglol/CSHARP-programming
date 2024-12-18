


   using System;
            using System.Collections.Generic;
using System.Security;

public class Program
{
    
    public static void Main()
    {
        // Create a dictionary where the key is a string and the value is an integer
        Dictionary<string, string> Items = new Dictionary<string, string>();

        // Adding elements
        for (int i = 0; i < 1; i++)
        {
            Console.Write("Please enter a name of a item: ");
            string name = Console.ReadLine();  // User input for name

            Console.Write("Please enter a descrition for that item: ");
            string Description = (Console.ReadLine());  // User input for Description

            // Add to dictionary
            Items.Add(name, Description);
        }

        if (Items.ContainsKey(Console.ReadLine()))
        {
            Console.WriteLine("This item already exists. Do you wan to overwrite it? (yes/no)"); 
        }
        Console.Write("What item do you wish to remove? :  ");
        string ItemToRemove = Console.ReadLine();
        if (Items.ContainsKey(ItemToRemove)) // This can remove items
        {
            Items.Remove(ItemToRemove);
            Console.WriteLine("The item has been removed");
        }
        else
        {
            Console.WriteLine("Item not found"); 
        }
        Console.WriteLine("\nHere are Your items:"); //Shows your items in the end 
        foreach (var My in Items)
        {
            Console.WriteLine(My.Key + ": " + My.Value);
        }
        Console.WriteLine();
        Console.WriteLine("To exit press anything twice"); // tells you to exit 


        Console.ReadLine();

        
        
    }
}
    