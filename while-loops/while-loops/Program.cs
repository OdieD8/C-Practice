using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How old are you? ");
            int age = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Happy Birthday");
                age--;

            } while (age > 0);
            Console.WriteLine("\nTaDa!"); // "\n" starts a new line
            Console.ReadKey();
        }
    }
}
