using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatGPT_example_on_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
                // Create a dictionary to store names and grades
    Dictionary<string, int> studentGrades = new Dictionary<string, int>();

    // Get user input for 3 students
    for (int i = 0; i < 3; i++)
    {
        Console.Write("Enter student's name: ");
        string name = Console.ReadLine();  // User input for name

        Console.Write("Enter student's grade: ");
        int grade = int.Parse(Console.ReadLine());  // User input for grade

        // Add to dictionary
        studentGrades.Add(name, grade);
    }

    // Display all student grades
    Console.WriteLine("\nStudent Grades:");
    foreach (var student in studentGrades)
    {
        Console.WriteLine(student.Key + ": " + student.Value);
    }



    Another Example 

   using System;
   using System.Collections.Generic;

   public class Program
{
   public static void Main()
   {
       // Create a dictionary where the key is a string and the value is an integer
       Dictionary<string, int> studentGrades = new Dictionary<string, int>();

       // Adding elements
       studentGrades.Add("John", 85);
       studentGrades.Add("Sarah", 92);
       studentGrades.Add("Tom", 78);

       // Accessing elements by key
       Console.WriteLine("John's Grade: " + studentGrades["John"]); // Output: 85

       // Checking if a key exists
       if (studentGrades.ContainsKey("Sarah"))
       {
           Console.WriteLine("Sarah's Grade: " + studentGrades["Sarah"]); // Output: 92
       }

       // Iterating through the dictionary
       foreach (var student in studentGrades)
       {
           Console.WriteLine(student.Key + ": " + student.Value);
       }
        }
    }
}
