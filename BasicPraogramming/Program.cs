using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPraogramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int heads = 0;
            int tails = 0;
            int counter = 0;
            Random coinflip = new Random();

            Console.WriteLine("How many times would you like to flip a coin? ");
            counter = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < counter; i++)
            {
                int flip = coinflip.Next(1, 3);
                if (flip == 1)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }

            Console.WriteLine("You flipped a coin : " + counter
               + "times " + "and you got " + heads + "heads and " + tails + "tails.");
            Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
