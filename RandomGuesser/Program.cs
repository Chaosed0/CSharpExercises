using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int randomNum = gen.Next(100);

            Console.Out.Write("I'm thinking of a number between 1 and 100: ");
            String input = Console.In.ReadLine();

            int inputNum = int.Parse(input);
            if (inputNum == randomNum) {
                Console.Out.Write("You guessed right! The number was " + randomNum + "!\n");
            } else {
                Console.Out.Write("You guessed wrong - the number was " + randomNum + "!\n");
            }

            Console.Out.Write("Press enter to continue...");
            Console.In.Read();
        }
    }
}
