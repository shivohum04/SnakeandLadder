using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UC1on7
{
    class Program
    {
        static void Roll()
        {

            Random random = new Random();
            int value = random.Next(1, 6);
            Console.WriteLine(value);
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