using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pscsharpcourse
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello World";
            Console.WriteLine(myString);
            int myFirstValue = 23;
            double mySecondValue = 45.79;
            double sum = myFirstValue + mySecondValue;
            Console.WriteLine(sum.ToString());
            bool myFirstBoolean = 3 + 2 == 5; //will evaluate true
            bool mySecondBoolean = 3 + 2 > 5; //will evaluate false
            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            Console.WriteLine("bothAreTrue evaluates " + bothAreTrue);
            bool oneIsTrue = myFirstBoolean || mySecondBoolean;
            Console.WriteLine("oneIsTrue evaluates {0} because one expression is true", oneIsTrue);
            bool reverseMyFirstBoolean = !myFirstBoolean;
            Console.WriteLine("myFirstBoolean is {0} but reverseMyFirstBoolean is {1}", myFirstBoolean, reverseMyFirstBoolean);
            Console.ReadKey();
        }
    }
}
