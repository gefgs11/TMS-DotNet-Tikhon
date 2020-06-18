using System;

namespace Homework1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("enter day");
            string day = Console.ReadLine();
            if (day == "mon" || day == "monday")
            {
                Console.WriteLine("1");
            }
            else if (day == "tu" || day == "tuesday")
            {
                Console.WriteLine("2");

            }
            else if (day == "wedn" || day == "wednesday")
            {
                Console.WriteLine("3");

            }
            else if (day == "thu" || day == "thursday")
            {
                Console.WriteLine("4");

            }
            else if (day == "fri" || day == "friday")
            {
                Console.WriteLine("5");

            }
            else if (day == "satu" || day == "saturday")
            {
                Console.WriteLine("6");

            }
            else if (day == "sunday" || day == "sunday")
            {
                Console.WriteLine("7");
            }

            else
            {
                Console.WriteLine("Null");
            }
            Console.ReadKey();

        }

    }
}
