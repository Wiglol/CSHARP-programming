using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Prov_U._6
{
    class Game
    {
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }


        // Create a class constructor for the Game class
         public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year; 
            Genre = genre;


        }

        static void Main(string[] args)
        {
            
        }
    }
}
