using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OuncesKilos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.Write("Enter number of ounces: ");
            String input = Console.In.ReadLine();
            Console.Out.Write("Kilograms: " + Double.Parse(input) / 35.274 + "\n");

            Console.Out.Write("Press enter to continue...");
            Console.In.Read();
        }
    }
}
