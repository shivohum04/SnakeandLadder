using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UC1on7
{
    using System;

    namespace UC1on7
    {
        class Program
        {
            static string GetRandomWord() 
            {
                string[] words = { "no play", "snake", "ladder" };
                Random rand = new Random();
                int index = rand.Next(words.Length);
       
            }

            static int Roll()
            {

                Random random = new Random();
                return random.Next(1, 7); 
            }

            static void Main()
            {
                int playerPosition = 0; 
                int boardEnd = 100; 

                while (playerPosition < boardEnd)
                {
                    int rollValue = Roll();
                    string action = GetRandomWord();

                    Console.WriteLine($"Rolled: {rollValue}, Action: {action}");

                    switch (action)
                    {
                        case "no play":
                           
                            break;
                        case "ladder":
                            playerPosition += rollValue;
                            break;
                        case "snake":
                            playerPosition -= rollValue;
                            break;
                    }

                    if (playerPosition < 0) playerPosition = 0; 
                    if (playerPosition > boardEnd) playerPosition = playerPosition; // ensuring the player needs the exact number to reach the winning position.
                    Console.WriteLine($"Player position: {playerPosition}");

                    if (playerPosition == boardEnd)
                    {
                        Console.WriteLine("Player reached the winning position!");
                        break;
                    }

                    Console.ReadLine(); 
                }
            }
        }
    }

}