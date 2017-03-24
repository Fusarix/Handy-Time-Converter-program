using PROG2070_QualityAssurance03_C;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Programmer: Derek Fusari
/// Software Quality Assurance Assignment 3
/// Date: Thursday March 23rd/2017
/// </summary>

namespace PROG2070_QualityAssurance03_C
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayMenu();
        }

        /// <summary>
        /// Displays the menu and handles all 
        /// interactions between the user and the menu
        /// </summary>
        public static void DisplayMenu()
        {
            int menuOption = 0;
            double value = 0;
            string convertFrom = "";
            string convertTo = "";
            double answer = 0;

            Console.WriteLine("******MAIN MENU******");
            Console.WriteLine("1. Convert a Time");
            Console.WriteLine("2. Help Menu");
            Console.WriteLine("3. Exit Program");

            try
            {
                menuOption = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
            }

            if (menuOption == 1)
            {
                Console.WriteLine("");
                Console.WriteLine("Enter a time "
                    + "value you wish to convert.");
                Console.WriteLine("");

                try
                {
                    value = double.Parse(Console.ReadLine());
                    if (value <= 0)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Please enter " 
                            + "a time greater than zero.");
                        Console.WriteLine("");
                        DisplayMenu();
                    }

                    Console.WriteLine("");
                    Console.WriteLine("What is the unit if time you entered?");
                    Console.WriteLine("");

                    convertFrom = Console.ReadLine();

                    Console.WriteLine("");
                    Console.WriteLine("What is the unit " 
                        + "if time you wish to convert to?");
                    Console.WriteLine("");

                    convertTo = Console.ReadLine();

                    //Calls the Convert method to determine the 
                    //converted value the user wants
                    answer = TimeConversion.Convert(
                        value, convertFrom, convertTo);

                    if (answer != -1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(value + " " + convertFrom + 
                            " is equal to " + answer + " " + convertTo);
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Incorect Time Unit");
                        Console.WriteLine("");
                    }
                    DisplayMenu();
                }
                catch (Exception)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Please enter a proper time");
                    Console.WriteLine("");
                    DisplayMenu();
                }
            }
            else if (menuOption == 2)
            {
                //A help menu that tells the user all the valid input
                //for units of time
                Console.WriteLine("");
                Console.WriteLine("When entering a unit of time, " 
                    + "choose any of these options: ");
                Console.WriteLine("Seconds, seconds, S or s");
                Console.WriteLine("Minutes, minutes, M or m");
                Console.WriteLine("Hours, hours, H or h");
                Console.WriteLine("Days, days, D or d");
                Console.WriteLine("");

                DisplayMenu();
            }
            else if (menuOption == 3)
            {
                System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("You did not " 
                    + "enter a viable menu option.");
                Console.WriteLine("");
                DisplayMenu();
            }
        }
    }
}
