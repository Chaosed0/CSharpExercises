using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            while (count < 100) {
                sum += count;
                count++;
            }
            Console.Out.Write("Sum of numbers 0-100 is " + sum + " (while loop)\n");

            count = 0;
            sum = 0;
            for (count = 0; count < 100; count++) {
                sum += count;
            }
            Console.Out.Write("Sum of numbers 0-100 is " + sum + " (for loop)\n");

            Console.In.Read();
        }
    }
}
