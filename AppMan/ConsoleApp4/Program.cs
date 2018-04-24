using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum  = 0;
            int[] input = new int[25];
            int[] win1 = new int[] { 3, 4, 8, 13, 18, 19, 23 }; //bingo
            int[] win2 = new int[] { 2, 1, 12, 15, 6, 18, 16, 4, 3, 21, 11 }; //bingo
            Console.WriteLine("By Mr.Nitiphat Jumnongnok");
            Console.WriteLine("=================Bingo==============");
            for (int i = 0; i <= input.Length; i++)
            {
                try
                {
                    Console.WriteLine("Input your number : " + i);
                    int numBingo = int.Parse(Console.ReadLine());
                    input[i] = numBingo;
                }

                catch
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (win1.Contains(input[i]))
                {
                    Console.Write("[YOU BINGOooooooo]");
                }
                else if(win2.Contains(input[i]))
                {
                    Console.Write("[YOU BINGOooooooo]");
                }
                else
                {
                    Console.Write("[YOU LOSEeeeeeeee]");
                }
            }
            Console.WriteLine();

            foreach (int num in input)
            {
                Console.Write(" {0}", num);
            }

            Console.WriteLine();
            Console.WriteLine("Press Enter to exit.");
            Console.ReadLine();
        }
    }
}