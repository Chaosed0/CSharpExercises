using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Enter a list of numbers seperated by spaces:\n");
            String numbers = Console.In.ReadLine();

            String[] numbersArray = numbers.Split(' ');
            int min = int.Parse(numbersArray[0]);

            for (int i = 1; i < numbersArray.Length; i++) {
                int number = int.Parse(numbersArray[i]);
                if (number < min) {
                    min = number;
                }
            }

            Console.Out.Write("The minimum was " + min + "\n");
            Console.In.Read();
        }
    }
}
