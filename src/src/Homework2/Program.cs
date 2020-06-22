using System;

namespace ConsoleApp1
{
    class Program
    {
        static void DayName()
        {

            Console.WriteLine("enter name of day");

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


        }
        static void DayNumber()
        {

            Console.WriteLine("enter number of day");
            string day = Console.ReadLine();
            if (day == "1")
            {
                Console.WriteLine("monday");
            }
            else if (day == "2")
            {
                Console.WriteLine("tuesday");

            }
            else if (day == "3")
            {
                Console.WriteLine("wednesday");

            }
            else if (day == "4")
            {
                Console.WriteLine("thursday");

            }
            else if (day == "5")
            {
                Console.WriteLine("friday");

            }
            else if (day == "6")
            {
                Console.WriteLine("saturday");

            }
            else if (day == "7")
            {
                Console.WriteLine("sunday");
            }

            else
            {
                Console.WriteLine("Null");
            }


        }


        static void Main(string[] args)
        {

            DayName();
            DayNumber();
            Console.ReadKey();
        }
    }
}
