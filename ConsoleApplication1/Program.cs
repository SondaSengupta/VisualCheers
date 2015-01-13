using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World");

            //Step 1: Getting user's name and print it.

            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Welcome," + name);

            //Step 2: Cheer the user on.
            //If name is "Bob" output should be "Give me a...b Give me a...o Give me a...b BOB is GRAND!"

            for (int i = 0; i < name.Length; i++)
            {
                char lowerLetter = System.Char.ToLower(name[i]);

                // You can also do if (lowerLetter == 'h' || lowerLetter == 'a' || lowerLetter == 'l' || etc..)
                string article = "a";
                if ("halfnorsemix".IndexOf(lowerLetter) > -1)
                {
                    article = "an";
                }

                System.Console.WriteLine("Give me " + article + " ... " + lowerLetter);
            }

            string upperName = name.ToUpper();
            System.Console.WriteLine(upperName + " is Great!");

            //Step 3: Ask user "When is your birthday". User will type in "8/25". Your birthday is in 28 days"
            //Step 4: If they have birthday recently. You say "Aw shucks, I missed it. Your birthday was 28 days ago."
            //Step 5: Profit!
            System.Console.WriteLine("When is your birthday? Please give it to me in mm/dd/year");
            string birthday = System.Console.ReadLine();
            DateTime date = Convert.ToDateTime(birthday);
            System.Console.WriteLine("Year: {0}, Month: {1}, Day: {2}", date.Year, date.Month, date.Day);

            DateTime dateNow = DateTime.Now;
            System.Console.WriteLine("Year: {0}, Month {1}, Day: {2}", dateNow.Year, dateNow.Month, dateNow.Day);
            double difference = (dateNow - date).TotalDays;
            System.Console.WriteLine("Your birthday was " + difference + " days ago.");

            System.Console.WriteLine("Press any key when you are ready to exit");
            System.Console.ReadKey();
        }
    }
}