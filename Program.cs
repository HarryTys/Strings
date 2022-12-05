// Conversion utility problem 

using System;

namespace ConsoleApp1

{

    class Program

    {

        static string Number;

        static double DNumber;

        static bool ValidInput;

        static double Inches;

        static double Feet;

        static double MenuChoice;

        // Function to return valid input  

        static double GetInput()

        {

            Number = "";

            DNumber = 0;

            ValidInput = false;

            // Validation 

            while (!ValidInput)

            {

                Console.Write(": ");

                Number = Console.ReadLine();

                // Type check - no input is valid 

                if (Number == "")

                {

                    ValidInput = true;

                }

                // Type check 

                else if (double.TryParse(Number, out DNumber))

                {

                    ValidInput = true;

                }

                if (ValidInput == false)

                {

                    Console.WriteLine("Invalid input.");

                }

            }

            return DNumber;

        }

        // Subroutine to convert feet to inches 

        static void FeetToInches()

        {

            Console.Write("Enter the number of feet: ");

            Feet = GetInput();

            Inches = Feet * 12;

            Console.WriteLine("{0} feet is {1:0.00} inches", Feet, Inches);

        }

        // Subroutine to convert inches to feet 

        static void InchesToFeet()

        {

            Console.Write("Enter the number of inches: ");

            Inches = GetInput();

            Feet = Inches / 12;

            Console.WriteLine("{0} inches is {1:0.00} feet", Inches, Feet);

        }

        // Subroutine to offer the conversion choice to the user 

        static void Menu()

        {

            MenuChoice = 0;

            // Iterate until quit is chosen 

            while (MenuChoice != 3)

            {

                Console.WriteLine("1. Feet to inches");

                Console.WriteLine("2. Inches to feet");

                Console.WriteLine("3. Quit");

                MenuChoice = GetInput();

                // Action menu choice 

                if (MenuChoice == 1)

                { FeetToInches(); }

                else if (MenuChoice == 2)

                { InchesToFeet(); }

                else if (MenuChoice == 3)

                { Console.WriteLine("Goodbye."); }

                else

                { Console.WriteLine("Invalid input."); }

                Console.WriteLine("-------------------------");

            }

        }

        // Main program 

        static void Main(string[] args)

        {

            Menu();

        }

    }

}