using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool shouldContinue;

            do
            {
                Console.WriteLine("Please enter your name.");
                string name = Console.ReadLine();
                Console.WriteLine("Please enter your birthdate. (MM/DD/YYYY)");
                DateTime dOB;
                if (DateTime.TryParse(Console.ReadLine(), out dOB))
                {
                    TimeSpan age = DateTime.Now - dOB;
                    Console.WriteLine(name + " is {0} Years and {1} Days old!", (int)(age.Days / 365.25), age.Days % 365.25);
                }
                else
                {
                    Console.WriteLine("That's an invalid date. Try again.");
                }

                Console.WriteLine("Continue? (y/n)");
                input = Console.ReadLine();
                shouldContinue = input == "y";
            }
            while (shouldContinue);
        }
    }
}
