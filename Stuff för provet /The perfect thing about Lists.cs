using System;
using System.Collections.Generic;
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

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(2);

            Console.WriteLine("---------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }


            Console.ReadLine();
        }
    }
}
