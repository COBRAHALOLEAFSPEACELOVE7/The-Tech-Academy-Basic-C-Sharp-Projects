using System;

namespace Branching_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // This Code takes input about packages, tells us if the package can be shipped, and gives a price
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("Package Weight");
            int Weight = Convert.ToInt32(Console.ReadLine());
            if (Weight > 50)
            {
                Console.WriteLine("Package too heavey to be shipped via Package Express.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Package Width");
                int Width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Package Height");
                int Height = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Package Length");
                int Length = Convert.ToInt32(Console.ReadLine());
                if (Width + Height + Length > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int Total = (Width * Height * Length);
                    int Total2 = (Total) * (Weight);
                    decimal Quote = (Total2 / 100);
                    Console.WriteLine("Your estimated total for shipping this package is $");
                    Console.WriteLine(Quote);
                    Console.WriteLine("Thank you");
                    Console.ReadLine();
                }
            }
        }
    }
}