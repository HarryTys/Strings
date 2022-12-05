using System;
using System.Text;

namespace C_Sharp_Strings
{
    class C_Sharp_Strings
    {
        static void Initials()
        {
            Console.WriteLine("Please enter your first name...");
            string F_Name = Console.ReadLine();
            Console.WriteLine("Please enter your last name");
            Console.WriteLine(F_Name.ToUpper().Remove(1) + " " + Console.ReadLine().ToUpper());
        }

        static void Inventory()
        {
            string inventory = "bow, potion, sword, charm";
            Console.WriteLine("What would you like to check against the players inventory...");
            Console.WriteLine(inventory.Contains(Console.ReadLine()));
        }

        static void Airline_Ticket()
        {
            Console.WriteLine("Please enter the name of the city you are departing from...");
            string City1 = Console.ReadLine();
            Console.WriteLine("Please enter the name of the city you are arriving to...");
            Console.WriteLine(City1.ToUpper().Remove(4) + "-" + Console.ReadLine().ToUpper().Remove(4));
        }

        static void Teachers()
        {
            Console.WriteLine("Please enter the teachers first name...");
            string First_Name = Console.ReadLine();
            Console.WriteLine("Please enter the teachers middle name...");
            string Middle_Name = Console.ReadLine();
            Console.WriteLine("Please enter the teachers last name...");
            string Last_Name = Console.ReadLine();
            if (string.IsNullOrEmpty(Middle_Name))
            {
                Middle_Name = "Z";
            }
            Console.WriteLine(First_Name.ToUpper().Remove(1) + Middle_Name.ToUpper().Remove(1) + Last_Name.ToUpper().Remove(1));
        }

        static void valid_email()
        {
            string char1 = "@";
            string char2 = ".";
            Console.WriteLine("Please enter your email address...");
            string x = Console.ReadLine();
            if (x.Contains(char1) && x.Contains(char2))
            {
                Console.WriteLine("Valid email address");
            }
            else
            {
                Console.WriteLine("Invalid email adress");
            }
        }

        static void Full_Name()
        {
            Console.WriteLine("Please enter your full name");
            string[] Name = Console.ReadLine().Split(" ");
            Console.WriteLine(Name[0] + "\n" + Name[1]);
        }

        static void Naming_Conventions()
        {
            Console.WriteLine("Please enter the naming convention you wish to use...");
            string Choice = Console.ReadLine().ToLower();
            Console.WriteLine("What is the two word string you would like to convert to the given naming convention...");
            string[] two_words = Console.ReadLine().Split(" ");
            if (Choice == "kebab-case")
            {
                Console.WriteLine(two_words[0] + "-" + two_words[1]);
            }
            else if (Choice == "snake_case")
            {
                Console.WriteLine(two_words[0] + "_" + two_words[1]);
            }
            else if (Choice == "camelcase")
            {
                Console.WriteLine(two_words[0].ToLower() + two_words[1].ToUpper().Remove(1) + two_words[1].Remove(0,1));
            }
            else if (Choice == "pascalcase")
            {
                Console.WriteLine(two_words[0].ToUpper().Remove(1) + two_words[0].Remove(0, 1) + two_words[1].ToUpper().Remove(1) + two_words[1].Remove(0, 1));
            }
            else
            {
                Console.WriteLine("Sorry ive never heard of that naming convention.");
            }
        }

        static void Conversion()
        {
            Console.WriteLine("Please enter the Letter you wish to know the ASCII and EBCDIC");
            char Letter = char.Parse(Console.ReadLine());
            Console.WriteLine($"The letter {Letter} in ASCII is {(int)Letter} and in EBCDIC it is {(int)Letter + 32}");
        }

        static void Main()
        {
            Console.WriteLine("Please enter 1 for intial and surname problem, enter 2 for inventory checker, enter 3 for Airline ticket generator, enter 4 for Teachers initials, enter 5 for valid address problem, enter 6 for Full Name, enter 7 for naming conventions, enter 8 for conversions...");

            int decision = int.Parse(Console.ReadLine());

            if (decision == 1)
            {
                Initials();
                Console.ReadLine();
            }
            if (decision == 2)
            {
                Inventory();
                Console.ReadLine();
            }
            if (decision == 3)
            {
                Airline_Ticket();
                Console.ReadLine();
            }
            if (decision == 4)
            {
                Teachers();
                Console.ReadLine();
            }
            if (decision == 5)
            {
                valid_email();
                Console.ReadLine();
            }
            if (decision == 6)
            {
                Full_Name();
                Console.ReadLine();
            }
            if (decision == 7)
            {
                Naming_Conventions();
                Console.ReadLine();
            }
            if (decision == 8)
            {
                Conversion();
                Console.ReadLine();
            }
        }
    }
}