using System;

namespace NumberGuesser
{
    // main class
    class Program
    {
        //entry point methods
        static void Main(string[] args)
        {
            GetAppInfo(); // run app getinfo
            GreetUser(); // get user info
        

            while (true)
            {
                // init correrct number
                // int correctNumber = 7;

                //Create a New ramdom object

                Random random = new Random();

                // init correrct number
                int correctNumber = random.Next(1, 10);

                // init guess var
                int guess = 0;

                //ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //while guess is not correct
                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();
                    // make sure its a number
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please use an actual number");
                     
                        continue;

                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(input);

                    // match guess to correct number

                    if (guess != correctNumber)
                    {
                       
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                // out success message
                PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");


                //ask to play again
                Console.WriteLine("Play Again? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;

                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }

            }
        }
        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number";
            string appVersion = "1.0.0";
            string appAuthor = "Guilherme";

            //change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();

        }

        static void GreetUser()
        {
            //ask users name
            Console.WriteLine("What is your name");
            //Get user name

            string InputName = Console.ReadLine();

            //get input on console log
            Console.WriteLine("Hello {0} lets play a game", InputName);
        }

        //PRINT COLLOR MESSAGE

        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;

            // tell user its not a numberr
            Console.WriteLine(message);

            //reset text color
            Console.ResetColor();
        }
    }
}
