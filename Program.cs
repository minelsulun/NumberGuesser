using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine();
            Console.WriteLine("hello {0} do you want to play game?(yes or no)",name);
            string response = Console.ReadLine();
            if (response.ToLower()=="yes")
            {
                Console.WriteLine("Lets go then!!");
                PlayGame(); // start game
            }
            else if (response.ToLower() == "no")
            {
                Console.WriteLine("Too bad. Maybe another time!");
                
            }
            else
            {
                Console.WriteLine("Invalid response. Please respond with 'yes' or 'no'.");
            }
            Console.ReadKey();

            void PlayGame()
            {
                //creat a new random object
                Random random = new Random();
                int correctNumber = random.Next(1,10);
                int guess = 0;

                Console.WriteLine("guess a number between 1-10");

                while (guess != correctNumber)
                {
                    //get users input
                    string input = Console.ReadLine();
                    if(!int.TryParse(input, out guess))
                    {
                        Console.WriteLine("enter an number");
                        continue;
                    }
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        guess = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("wrong number, correct number was {0}- another number created try again?", correctNumber);
                        correctNumber = random.Next(1, 10);
                        
                        Console.ResetColor();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("CORRECT number was {0}!!",correctNumber);

                Console.ResetColor();
                Console.ReadKey();
            }
            
        }
    }
}
