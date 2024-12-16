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
            string[] movies = { "Lord Of The Rings", "Bee Movie", "Interstellar", "Why Not" };

            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + " " + movies[i]);
            }

            Console.ReadLine();
        }
    }
}
