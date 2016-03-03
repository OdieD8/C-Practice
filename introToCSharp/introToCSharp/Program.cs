using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please neter your name");
            string name = Console.ReadLine();

            Console.WriteLine("How much sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine()); //int.Parse converts ReadLine to an integers

            Console.WriteLine("Hello, " + name);


            if (hoursOfSleep < 8)
            {
                Console.WriteLine("You must feel tired");
            }
            else
            {
                Console.WriteLine("You are well rested");
            }


            Console.ReadLine();
        }
    }
}
