using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UC1on7
{
    class Program
    {
        static Random rand = new Random(); 

        static string GetRandomWord()
        {
            string[] words = { "no play", "snake", "ladder" };
            int index = rand.Next(words.Length);
            return words[index];
        }

        static int Roll()
        {
            return rand.Next(1, 7); 
        }

        static void Main()
        {
            int playerPosition = 0;
            int boardEnd = 100;
            int diceRollCount = 0;

            while (playerPosition < boardEnd)
            {
                int rollValue = Roll();
                diceRollCount++;
                string action = GetRandomWord();

                Console.WriteLine($"Roll {diceRollCount}: Rolled {rollValue}, Action: {action}");

                switch (action)
                {
                    case "ladder":
                        if (playerPosition + rollValue <= boardEnd)
                        {
                            playerPosition += rollValue;
                        }
                        break;
                    case "snake":
                        playerPosition -= rollValue;
                        if (playerPosition < 0) playerPosition = 0; 
                        break;
                       
                }

                Console.WriteLine($"Player position: {playerPosition}");

                if (playerPosition == boardEnd)
                {
                    Console.WriteLine($"Player reached the winning position in {diceRollCount} rolls!");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}
