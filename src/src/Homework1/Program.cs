using System;

namespace Homework1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("vvedite den");
            string str = Console.ReadLine();
            if (str == "mon" || str == "monday")
            {
                Console.WriteLine("1");

            }
            else if (str == "tu" || str == "tuesday")
            {
                Console.WriteLine("2");

            }
            else if (str == "wedn" || str == "wednesday")
            {
                Console.WriteLine("3");

            }
            else if (str == "thu" || str == "thursday")
            {
                Console.WriteLine("4");

            }
            else if (str == "fri" || str == "Friday")
            {
                Console.WriteLine("5");

            }
            else if (str == "satu" || str == "saturday")
            {
                Console.WriteLine("6");

            }
            else if (str == "sunday" || str == "sunday")
            {
                Console.WriteLine("7");

            }
            else
            {
                Console.WriteLine("Null");

            }

        }

    }
}
