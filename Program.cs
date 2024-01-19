using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UC1on7
{
    using System;

    class Program
    {
        static string GetRandomWord()
        {
            string[] words = { "no play", "snake", "ladder" };
            Random rand = new Random();
            int index = rand.Next(words.Length);
            return words[index];
        }

        static void Roll()
        {
            Random random = new Random();
            int value = random.Next(1, 7); 
            Console.WriteLine("The dice roll gave: " + value);
            string word = GetRandomWord();
            Console.WriteLine("Random word: " + word);
            Console.ReadLine();
        }

        static void Main()
        {
            int[] board = new int[100];
            for (int i = 0; i < board.Length; i++)
            {
                Roll();
            }
        }
    }

}
