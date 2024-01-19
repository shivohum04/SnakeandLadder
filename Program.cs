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
            int[] playerPositions = new int[2] { 0, 0 };
            int boardEnd = 100;
            int currentPlayer = 0; 
            bool gameWon = false;

            while (!gameWon)
            {
                int rollValue = Roll();
                string action = GetRandomWord();

                Console.WriteLine($"Player {currentPlayer + 1} rolled {rollValue}, Action: {action}");

                switch (action)
                {
                    case "ladder":
                        playerPositions[currentPlayer] += rollValue;
                        if (playerPositions[currentPlayer] > boardEnd)
                        {
                            playerPositions[currentPlayer] -= rollValue; 
                        }
                        break;
                    case "snake":
                        playerPositions[currentPlayer] -= rollValue;
                        if (playerPositions[currentPlayer] < 0)
                        {
                            playerPositions[currentPlayer] = 0; 
                        }
                        break;
                }

                Console.WriteLine($"Player {currentPlayer + 1}'s position: {playerPositions[currentPlayer]}");

                if (playerPositions[currentPlayer] == boardEnd)
                {
                    Console.WriteLine($"Player {currentPlayer + 1} won the game!");
                    Console.ReadLine();
                    gameWon = true;

                }
                if (action != "ladder" && !gameWon)
                {
                    currentPlayer = (currentPlayer + 1) % 2; 
                }
            }
        }
    }
}
