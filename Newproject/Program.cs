using System;

namespace Newproject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Drawing a shape on console
            /* Console.WriteLine("Hello World!");
            Console.WriteLine("Yash Modi");
            Console.WriteLine("   /|");
            Console.WriteLine("  / |");
            Console.WriteLine(" /  |");
            Console.WriteLine("/___|");
            Console.ReadLine(); */

            // Variables
            /*string name = "Yash Modi";
            int age = 24;
            Console.WriteLine("Hello, My name is " + name + ". I am " + age + " years old."); */

            // Data Types
            /* string name = "Yash";
            int age = 24;
            char grade = 'A';
            double gpa = 3.55;
            bool hasGraduated = true;
            Console.WriteLine("These are my details: Name: " + name + ", Age: " + age + ", Grade: " + grade + ", GPA: " + gpa + ", Graduated:" + hasGraduated); */

            // String
            Console.WriteLine("Yash\nModi");
            string name = "University of Texas at Dallas";

            // String methods
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Contains("Dallas"));
            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf('n'));
            Console.WriteLine(name.Substring(14, 5));

            // Numbers

        }
    }
}
