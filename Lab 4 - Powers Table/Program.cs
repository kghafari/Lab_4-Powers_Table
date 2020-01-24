using System;

namespace Lab_4___Powers_Table
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Kyle's square and cube program");
            Console.WriteLine("----------------------------------------\n");


            string keepGoing = "y";
            while (keepGoing == "y")
            {
                Console.WriteLine("How high would you like to go?");
                string userInput = Console.ReadLine();
                int inputAsInt;
                bool isInt = int.TryParse(userInput, out inputAsInt);
                while (isInt == false)
                {
                    Console.WriteLine("Invalid entry. Please enter a whole number.");
                    userInput = Console.ReadLine();
                    isInt = int.TryParse(userInput, out inputAsInt);
                }

                //print table heading
                Console.WriteLine("==================================");
                Console.WriteLine("Number   |   Square   |   Cube   |");
                Console.WriteLine("==================================");

                //for each number, up to and inclusive of what the user entered, print the number, the square and the cube
                for (int i = 1; i <= inputAsInt; i++)
                {
                    ReturnPowers(i);
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

        //takes input, produces square and cube of input, and writes result to console
        public static void ReturnPowers(double input)
        {
            double square = Math.Pow(input, 2);
            double cube = Math.Pow(input, 3);
            Console.WriteLine(String.Format(" {0, -7} | {1, -10} | {2, -10}", input, square, cube));
        }

    }
}