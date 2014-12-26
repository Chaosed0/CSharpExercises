using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("How many iterations? ");
            String input = Console.In.ReadLine();
            int iterations = int.Parse(input);

            for (int i = 0; i < iterations; i++) {
                if (i % 3 == 0 && i % 5 == 0) {
                    Console.Out.Write("FizzBuzz\n");
                } else if(i % 3 == 0) {
                    Console.Out.Write("Fizz\n");
                } else if(i % 5 == 0) {
                    Console.Out.Write("Buzz\n");
                } else {
                    Console.Out.Write(i + "\n");
                }
            }

            Console.In.Read();
        }
    }
}
