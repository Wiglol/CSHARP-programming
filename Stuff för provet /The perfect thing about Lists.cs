using System;// YOU NEED THIS LOOK HERE PLZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ
using System.Collections.Generic; // ADD THIS using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Somethinh_ome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Myname");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony"); 

            for (int i = 0; i < shoppingList.Count; i++) // does the looping thingy  
            { 
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams"); // you can remove it with it's name 
            shoppingList.RemoveAt(2); // you can remove a thing from your list with a number 


            Console.WriteLine("---------");

            for (int i = 0; i < shoppingList.Count; i++) // does the looping thingy 
            {
                Console.WriteLine(shoppingList[i]);
            }


            Console.ReadLine();
        }
    }
}
