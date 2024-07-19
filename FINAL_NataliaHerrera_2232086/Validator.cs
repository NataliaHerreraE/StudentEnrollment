using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FINAL_NataliaHerrera_2232086
{
    internal class Validator
    {

        public static bool ValidateYear(string year)
        {
            //match a year within the 2020 to 2029 by checking the last number
            Regex regex = new Regex(@"^202[0-9]$");


            // Returns true if the input string 'year' matches the regex pattern.
            return regex.IsMatch(year);
        }

        public static bool ValidateSession(string session)
        {

            // check the  following strings: "Fall", "Winter", "Summer"
            Regex regex = new Regex(@"^(Fall|Winter|Summer)$");


            // Returns true if the input string 'session' matches the regex pattern.
            return regex.IsMatch(session);
        }
        public static bool ValidateNumber(string text)
        {
       
            //A number with one or two digits, optionally followed by a decimal and another digit.

            //Regex regex = new Regex(@"^(\d{1,2}(\.\d)?|100?)$"); //tested
            Regex regex = new Regex(@"^(\d{1,2}(\.\d)?|100)$");



            return regex.IsMatch(text);
        }
    }
}

