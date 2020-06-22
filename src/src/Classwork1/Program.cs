using System;

namespace Classwork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You will go to the store?");
            string answer1 = Console.ReadLine();
            if (answer1 == "Yes")
            {
                Console.WriteLine("What do you buy?");
                string answer2 = Console.ReadLine();
                switch (answer2)
                {
                    case "banana":
                        Console.WriteLine("Good choise");
                        break;
                    case "chips":
                        Console.WriteLine("Not good choise");
                        break;
                    case "apples":
                        Console.WriteLine("Very good choise");
                        break;
                    case "eggs":
                        Console.WriteLine("Good choise");
                        break;
                    case "milk":
                        Console.WriteLine("good choise");
                        break;



                }

            }
            else
            {
                Console.WriteLine("Lazy man");
            }
            Console.ReadKey();

        }
    }
}
