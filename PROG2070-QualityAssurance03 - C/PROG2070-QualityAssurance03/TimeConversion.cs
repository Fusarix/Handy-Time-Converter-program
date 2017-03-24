using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070_QualityAssurance03_C
{
    class TimeConversion
    {
        /// <summary>
        /// Converts the time the user enters to the unit specified
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="convertFrom">Conver time From</param>
        /// <param name="convertTo">Convert time To</param>
        /// <returns></returns>
        public static double Convert(
            double value, string convertFrom, string convertTo)
        {
            double answer = 0;
            double multiplier = 0;


            convertFrom = ModifyInput(convertFrom);
            convertTo = ModifyInput(convertTo);

            //If the user enters an incorrect time unit, the answer
            // is ser to -1 so It is easy to determine there was an error
            //in the program method
            if (convertFrom == "Incorrect Time Unit")
            {
                answer = -1;
            }
            else if (convertTo == "Incorrect Time Unit")
            {
                answer = -1;
            }
            else
            {
                //Grabs the correct multiplier for calculating conversion
                multiplier = GetMultiplier(convertFrom, convertTo);
                answer = value * multiplier;
            }
            
            return answer;
        }
        /// <summary>
        /// Modify Input takes the users entry and changes it to 
        /// a basic word to shorten code elsewhere and give leeway
        /// to the users input
        /// </summary>
        /// <param name="input">User input of time unit</param>
        /// <returns></returns>
        private static string ModifyInput(string input)
        {
            if (input == "s" || input == "S" || 
                input == "Seconds" || input == "seconds")
            {
                input = "seconds";
            }
            else if (input == "m" || input == "M" || 
                input == "Minutes" || input == "minutes")
            {
                input = "minutes";
            }
            else if (input == "h" || input == "H" || 
                input == "Hours" || input == "hours")
            {
                input = "hours";
            }
            else if (input == "d" || input == "D" ||
                input == "Days" || input == "days")
            {
                input = "days";
            }
            else
            {
                input = "Incorrect Time Unit";
            }
            return input;
        }
        /// <summary>
        /// Checks the convertFrom unit and the
        /// convertTo unit and sets the multiplier
        /// to calculate the proper conversion
        /// </summary>
        /// <param name="convertFrom">Convert time from</param>
        /// <param name="convertTo">Conver time to</param>
        /// <returns></returns>
        private static double GetMultiplier(
            string convertFrom, string convertTo)
        {
            double multiplier = 0;
            
            if (convertFrom == "seconds"
                && convertTo == "minutes")
            {
                multiplier = 0.01666666666666666666;
            }
            else if (convertFrom == "seconds"
                && convertTo == "hours")
            {
                multiplier = 0.000277778;
            }
            else if (convertFrom == "seconds"
                && convertTo == "days")
            {
                multiplier = 1.1574083333e-5;
            }
            else if (convertFrom == "seconds"
                && convertTo == "seconds")
            {
                multiplier = 1;
            }
            else if (convertFrom == "minutes"
                && convertTo == "seconds")
            {
                multiplier = 60;
            }
            else if (convertFrom == "minutes"
                && convertTo == "hours")
            {
                multiplier = 0.016666666666666666;
            }
            else if (convertFrom == "minutes"
                && convertTo == "days")
            {
                multiplier = 0.00069444444444444444;
            }
            else if (convertFrom == "minutes" 
                && convertTo == "minutes")
            {
                multiplier = 1;
            }
            else if (convertFrom == "hours"
                && convertTo == "seconds")
            {
                multiplier = 3600;
            }
            else if (convertFrom == "hours" 
                && convertTo == "minutes")
            {
                multiplier = 60;
            }
            else if (convertFrom == "hours"
                && convertTo == "days")
            {
                multiplier = 0.041666666666666666;
            }
            else if (convertFrom == "hours"
                && convertTo == "hours")
            {
                multiplier = 1;
            }
            else if (convertFrom == "days" 
                && convertTo == "seconds")
            {
                multiplier = 86400;
            }
            else if (convertFrom == "days"
                && convertTo == "minutes")
            {
                multiplier = 1440;
            }
            else if (convertFrom == "days"
                && convertTo == "hours")
            {
                multiplier = 24;
            }
            else if (convertFrom == "days"
                && convertTo == "days")
            {
                multiplier = 1;
            }
            return multiplier;
        }
    }
}
