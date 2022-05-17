using System;

namespace NbMagique
{
    class Program
    {
        static void Main(string[] args)
        {          
            bool playAgain = true;

            while (playAgain)
            {
                int lifeCounter = 5;
                int response = 0;
                int Guesses = 0;
                int randomNumber = new Random().Next(1, 11);
                Console.WriteLine("---------");
                Console.Write("Hello, whats your name ? ");
                string playerName = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine($"Hello {playerName}, Hope you are ready to play!!");
                Console.WriteLine();

                while (response != randomNumber)
                {
                    Console.WriteLine("Please choose a number between 1 and 10");
                    response = int.Parse(Console.ReadLine());
                    if (response < randomNumber)
                    {
                        Console.WriteLine($"Bad choice! the answer is bigger!! ");
                    }
                    if (response > randomNumber)
                    {
                        Console.WriteLine($"Bad choice! the answer is smaller!! ");
                    }
                    lifeCounter--;
                    Guesses++;
                    Console.WriteLine($"Lives left : {lifeCounter}");

                    if (lifeCounter == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("You are out of lives! Sorry");
                        Console.ForegroundColor = ConsoleColor.White;

                        return;
                    }
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Well played! You WON :) ");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("-------");
                Console.WriteLine($"You have tried {Guesses} times ! ");
                Console.WriteLine();
                Console.Write("Do you want to play again? (Y/N) : ");
                
                string Answer = Console.ReadLine().ToUpper();
                
                if (Answer == "Y")
                {
                    playAgain = true;
                }
                if (Answer == "N")
                {
                    playAgain = false;
                    Console.WriteLine("Thank you for playing!!");
                }            
            }            
        }
    }
}