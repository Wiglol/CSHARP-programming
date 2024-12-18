using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace U6
{
    internal class Program
    {

       





            public class Book
            {
                public string Name { get; set; }
                public string Publisher { get; set; }
                public int Year { get; set; }
                public string Genre { get; set; }




                public Book(string name, string publisher, int year, string genre)
                {
                    Name = name;
                    Publisher = publisher;
                    Year = year;
                    Genre = genre;
                }

               
                public void DisplayName()
                {


                    Console.WriteLine($"Book: {Name} {Publisher} {Year} {Genre} ");
                }
                static void Main(string[] args)
                {
                    //Gör en till med egna specs v o printa ut den 
                    Book book1 = new Book("To kill a Mockingbird", "Harper Lee", 1960, "Fiction"); // copy this change book1 to 2
                    Book book2 = new Book("Wiglo", "Wiggo", 2024, "Fiction"); // copy this change book1 to 2



                book1.DisplayName();
                book2.DisplayName();



                Console.ReadLine();
                }
            
        }
    }           
}

