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
            string[] movies = new string[5];

            Console.Write("Type in your five best movies from 0-4 0 is best: ");


            for (int i = 0; i < movies.Length; i++)
            {
                movies[i] = Console.ReadLine();
            }

            Console.WriteLine( "\nHere they are "); 

            Array.Sort( movies );

            for ( int i = 0; i < movies.Length; i++ )
            {
                Console.WriteLine( movies[i] );
            }
            


            Console.ReadLine();
        }
    }
}
