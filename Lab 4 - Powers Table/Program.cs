using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //powers table

            //input: prompts user for integer

            //proccessing: goes from 1 to userInput, returns square and cube of each

            //output: pretty table of 1)the number, 2)square, 3)cube

            Console.WriteLine("Welcome to Kyle's square and cube program");
            Console.WriteLine("----------------------------------------\n");


            string keepGoing = "y";
            while (keepGoing == "y")
            {
                Console.WriteLine("How high would you like to go?");
                int userInput = int.Parse(Console.ReadLine());

                //for each number, up to and inclusive of what the user entered, print the number, the square and the cube
                for (int i = 0; i < userInput; i++)
                {
                    Console.WriteLine($"Number: {i}     Square: {i * i}     Cube:{i * i * i}");
                }

                //prompt to continue, rejects anything except "y" and "n"
                Console.WriteLine("Would you like to continue? (y/n)");
                keepGoing = Console.ReadLine().ToLower();
                while (keepGoing != "y" && keepGoing != "n")
                {
                    Console.WriteLine("Please enter 'y' or 'n'.");
                    keepGoing = Console.ReadLine().ToLower();
                }

            }

            Console.WriteLine("Thanks for stoping by!");
        }

    }
}
