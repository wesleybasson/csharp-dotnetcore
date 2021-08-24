using System;
using System.Text;

namespace ControlStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int score = 0;

            begingame:  bool found = false;
            int goldenNumber = random.Next(1000);
            Console.WriteLine("First game: Find the number within 10 tries. If you find it you will get 1000 points. You can try as many times as you want.");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("Choose a number between 0 and 1000:");
                int myvar = int.Parse(Console.ReadLine());
                if (myvar == goldenNumber)
                {
                    Console.WriteLine("Congratulations!! You guessed the correct number");
                    found = true;
                    score = 1000;
                    break;
                }
                else if (myvar > goldenNumber)
                {
                    Console.WriteLine("Your number is greater that the golden number. Try again!");
                }
                else
                {
                    Console.WriteLine("Your number is smaller than the golden number. Try again!");
                }
            }

            if (!found)
            {
                Console.WriteLine("Game Over! Do you want to try again? Type 'Y' for yes and 'N' for no");
                string answer = Console.ReadLine();
                if (answer == "Y")
                {
                    goto begingame;
                }
            }

            Console.WriteLine("Onto the next game!");

            if (score == 1000)
            {
                int roundTwo = random.Next(1000);
                Console.WriteLine("Second Game: Guess the number. This time we subtract the number of guesses from your overall score.");
                int guesses = 0;
                found = false;
                while (score > 0 && !found)
                {
                    Console.WriteLine("Choose a number between 0 and 1000:");
                    int myvar2 = int.Parse(Console.ReadLine());
                    guesses++;
                    if (myvar2 == roundTwo)
                    {
                        Console.WriteLine("Congratulations!! You guessed the correct number");
                        score -= guesses;
                        found = true;
                    }
                    else if (myvar2 > roundTwo)
                    {
                        Console.WriteLine("Your number is greater that the golden number. Try again!");
                    }
                    else
                    {
                        Console.WriteLine("Your number is smaller than the golden number. Try again!");
                    }
                }
                Console.WriteLine("Your final score is {0}, thanks for playing!", score);
            } else
            {
                Console.WriteLine("Game Over! Thanks for playing. You scored no points.");
            }
            
            Console.ReadLine();
        }
    }
}
