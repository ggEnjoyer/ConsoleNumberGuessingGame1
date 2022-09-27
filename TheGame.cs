using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNumberGuessingGame1
{
    static class TheGame
    {
        private static int score;
        private static int secretNumber;
        private static int trialNumber;
        private static string? pastActions;

        public static void Start()
        {
            score = 100;
            secretNumber = Random.Shared.Next(101);
            pastActions = "";

            while(true)
            {
                Console.Clear();
                Console.WriteLine("\n\tIf you guess the number right now, you will get " + score + " points");
                Console.WriteLine("\n\tYour tries: " + pastActions);
                Console.Write("\n\tEnter your guess: ");

                try
                {
                    trialNumber = Convert.ToInt32(Console.ReadLine());
                    if (secretNumber == trialNumber)
                    {
                        SaveController.AddResult(score);
                        Console.Write("\t - Yes! Exactly");
                        Console.ReadKey(true);
                        break;
                    }
                    else if(secretNumber < trialNumber)
                    {
                        pastActions += trialNumber + "(<);   ";
                        score--;
                        Console.Clear();
                    }
                    else if (secretNumber > trialNumber)
                    {
                        pastActions += trialNumber + "(>);   ";
                        score--;
                        Console.Clear();
                    }
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("Please, enter integers just in numeric format. Press any key to continue... ");
                    Console.ReadKey(true);
                    Console.Clear();
                }
            }
        }
    }
}
