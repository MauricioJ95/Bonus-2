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

            bool run = true;
            bool fail;

            Console.WriteLine("Please enter your name.");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your birthdate. (MM/DD/YYYY)");
            DateTime dOB;

            if (fail = DateTime.TryParse(Console.ReadLine(), out dOB))
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("That's not a valid date. Try again.");
            }


            if (DateTime.TryParse(Console.ReadLine(), out dOB))
            {
                TimeSpan age = DateTime.Now - dOB;
                Console.WriteLine(name + " is {0} Years and {1} Days old!", (int)(age.Days / 365), age.Days % 365);
            }

            run = Continue();

        }
        public static bool Continue()
        {
            bool shouldContinue;

            Console.WriteLine("Do you want to continue? (y/n)");
            string input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                shouldContinue = true;
            }
            else if (input.Equals("n", StringComparison.InvariantCultureIgnoreCase))
            {
                shouldContinue = false;
            }
            else
            {
                Console.WriteLine("Are you missing your Y and N keys? Try again.");
                shouldContinue = Continue();
            }
            return shouldContinue;
        }

    }
}





