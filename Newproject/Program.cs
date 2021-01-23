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
            /*Console.WriteLine("Yash\nModi");
            string name = "University of Texas at Dallas";

            // String methods
            Console.WriteLine(name.Length);
            Console.WriteLine(name.ToUpper());
            Console.WriteLine(name.ToLower());
            Console.WriteLine(name.Contains("Dallas"));
            Console.WriteLine(name[0]);
            Console.WriteLine(name.IndexOf('n'));
            Console.WriteLine(name.Substring(14, 5));*/

            // Working with Numbers
            /*Console.WriteLine(Math.Abs(-40));
            Console.WriteLine(Math.Pow(2,4));
            Console.WriteLine(Math.Sqrt(36));*/

            // Getting User Input
            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);*/

            // Converting string to int
            /*int num = Convert.ToInt32("50");
            Console.WriteLine(num + 10);*/

            /*Console.Write("Enter a num: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another num: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);*/

            // Mad lib

            /*string color, noun, celebrity;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();

            Console.Write("Enter a celebrity: ");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color);
            Console.WriteLine(noun + " are blue");
            Console.WriteLine("I Love " + celebrity);*/

            // Arrays

            /*int[] numbers = {4,5,6,7,8,9};
            numbers[2] = 10;
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            string[] friends = new string[10];
            friends[0] = "A";
            friends[1] = "B";*/

            // Methods

            /* Hello("Yash");

             int cubedNumber = Cube(5);
             Console.WriteLine(cubedNumber); */

            // if statement
            /* bool isMale = false;
            bool isTall = false;

            if (isMale && isTall)
            {
                Console.WriteLine("You are Male and Tall");
            } 
            else if (isMale && !isTall)
            {
                Console.WriteLine("You are Male but not Tall");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("You are not Male but you are Tall");
            } 
            else
            {
                Console.WriteLine("You are not Male and you are not Tall");
            }
            */
            /*
            Console.Write("Enter num1: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter any operator ");
            string op = Console.ReadLine();

            Console.Write("Enter num2: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            if (op == "+")
            {
                Console.WriteLine(num1 + num2);
            } 
            else if (op == "-")
            {
                Console.WriteLine(num1 - num2);
            }
            else if (op == "*")
            {
                Console.WriteLine(num1 * num2);
            }
            else if (op == "/")
            {
                Console.WriteLine(num1 / num2);
            } 
            else
            {
                Console.WriteLine("Invalid Operator");
            }
            */

            // loops
            /* int index = 1;
            while(index <= 5)
            {
                Console.WriteLine(index);
                index += 1;
            }
            */

            // Guessing game
            /*
            string secretWord = "UTD";
            string guess = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuesses = false;

            while (guess != secretWord && !outOfGuesses)
            {   
                if(guessCount < guessLimit)
                {
                    Console.Write("Enter a guess: ");
                    guess = Console.ReadLine();
                    guessCount += 1;
                } 
                else
                {
                    outOfGuesses = true;
                } 
            }
            if (outOfGuesses)
            {
                Console.WriteLine("You Lose");
            } else
            {
                Console.WriteLine("You Win!!!");
            }
            */

            // for loops
            /*
            int[] luckyNumbers = { 4, 6, 9, 18, 25 };
            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }
            */

            // Exponential Method
            /* Console.WriteLine(GetPow(4, 3));


            // 2-D array
            int[,] numberGrid =
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };
            Console.WriteLine(numberGrid[0, 0]);
            */

            // Exception Handling
            /*try
            {
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter another number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Exception Handled");
            }
            */

            // Classes and Objects
            Book book1 = new Book("The Alchemist", "Paulo Coelho", 200);
            Console.WriteLine(book1.title);
            /* book1.title = "The Alchemist";
            book1.author = "Paulo Coelho";
            book1.pages = 200; */

            Book book2 = new Book("Harry Potter", "JK Rowling", 400);
            /*book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400; */

            Chef chef = new Chef();
            chef.Makepizza();

            ItalianChef ichef = new ItalianChef();
            ichef.Makepizza();
        }

        /*
        static int GetPow(int baseNum, int powNum)
        {
            int result = 1;
            for(int i = 0; i < powNum; i++)
            {
                result = result * baseNum;
            }
            return result;
        }

        */

        /* static void Hello(string name)
        {
            Console.WriteLine("Hello " + name);
        }

        static int Cube(int number)
        {
            int result = number * number * number;
            return result;
        } */
    }
}
