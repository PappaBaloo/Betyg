using System;
using System.Collections.Generic;

namespace Betyg
{
    class Program
    {
        static void Main(string[] args)
        {

            basement b1 = new basement();

            Console.WriteLine("How many prisoners does this buldings basement have do you think?");
            Console.WriteLine("Write a number below:");

            string answer = Console.ReadLine();
            int result;

            bool corrector = int.TryParse(answer, out result);

            if (corrector == false)
            {
                Environment.Exit(0);
            }

            if (result == b1.numberOfPrisoners)
            {
                Console.WriteLine("congrats you won!");
            }
            else
            {
                Console.WriteLine("wow you guessed wrong, git gud ;)");
            }


            Console.ReadLine();

        }
    }
}
