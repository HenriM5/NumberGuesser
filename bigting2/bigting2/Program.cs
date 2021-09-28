using System;

namespace bigting2
{
    class Program
    {
        static void Main(string[] args)
        {
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Brad TT";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            Console.WriteLine("What is your name?");

            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game...", inputName);

            int correctnumber = 7;

            int guess = 0;

            Console.WriteLine("Guess a number between 1 and 10");

            while (guess != correctnumber)
            {


                string Input = Console.ReadLine();

                guess = Int32.Parse(inputName);

                if (guess != correctnumber)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Wrong number, please try again");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("you are correct!");
                    Console.ResetColor();

                }
            }
        }
    }    }        
    