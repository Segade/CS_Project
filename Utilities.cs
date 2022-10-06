/*****************************************************************************************************/
// ISBN validation reference
// https://www.dreamincode.net/forums/topic/365698-Validating-ISBN10-and-ISBN13-codes/
/*****************************************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Text;

namespace LibrarySYS
{
    class Utilities
    {

        public static bool isPhone(String phone)
        {
            bool pass = false;
 
            if ( phone.Length == 10 && phone.All(char.IsDigit))
                {
                if (phone.StartsWith("06") || phone.StartsWith("08"))
                    pass = true;
            } // end if length is digit 
            return pass;
        } // end is phone 

        public static bool isEmail(string email)
        {
            /*
            try
            {
                var mail = new MailAddress(email);

                return mail.Host.Contains(".");
            }
            catch
            {
                return false;
            }
            */

            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }

        } // end is email


        // validate ISBN


        public static bool isISBN(string isbn)
        {

            bool result = false;

            if (!string.IsNullOrEmpty(isbn))
            {
                if (isbn.Contains("-")) isbn = isbn.Replace("-", "");

                if (!isbn.All(char.IsDigit))
                    return false;
                switch (isbn.Length)
                {

                    case 10: result = IsValidIsbn10(isbn); break;

                    case 13: result = IsValidIsbn13(isbn); break;

                }

                }

            return result;

        } // end try isbn


        private static bool IsValidIsbn10(string isbn10)
        {

            bool result = false;

            if (!string.IsNullOrEmpty(isbn10))
            {

                long j;

                if (isbn10.Contains("-")) isbn10 = isbn10.Replace("-", "");

                // Check if it contains any non numeric chars, if yes, return false

                if (!Int64.TryParse(isbn10.Substring(0, isbn10.Length - 1), out j))
                    result = false;

                // Checking if the last char is not 'X' and
                // and if it's a numeric value

                char lastChar = isbn10[isbn10.Length - 1];

                if (lastChar == 'X' && !Int64.TryParse(lastChar.ToString(), out j))

                    result = false;

                int sum = 0;

                // Using the alternative way of calculation

                for (int i = 0; i < 9; i++)

                    sum += Int32.Parse(isbn10[i].ToString()) * (i + 1);

                // Getting the remainder or the checkdigit

                int remainder = sum % 11;

                // Check if the checkdigit is same as the last number of ISBN 10 code

                result = (remainder == int.Parse(isbn10[9].ToString()));

            }

            return result;

        } // end try is ISBN 10


        private static bool IsValidIsbn13(string isbn13)
        {

            bool result = false;

            if (!string.IsNullOrEmpty(isbn13))
            {
                long j;

                if (isbn13.Contains("-")) isbn13 = isbn13.Replace("-", "");

                // Check if it contains any non numeric chars, if yes, return false

                if (!Int64.TryParse(isbn13, out j))
                    result = false;

                int sum = 0;

                // Comment Source: Wikipedia
                // The calculation of an ISBN-13 check digit begins with the first
                // 12 digits of the thirteen-digit ISBN (thus excluding the check digit itself).
                // Each digit, from left to right, is alternately multiplied by 1 or 3,
                // then those products are summed modulo 10 to give a value ranging from 0 to 9.
                // Subtracted from 10, that leaves a result from 1 to 10. A zero (0) replaces a
                // ten (10), so, in all cases, a single check digit results.

                for (int i = 0; i < 12; i++)
                {

                    sum += Int32.Parse(isbn13[i].ToString()) * (i % 2 == 1 ? 3 : 1);

                }

                int remainder = sum % 10;

                int checkDigit = 10 - remainder;

                if (checkDigit == 10) checkDigit = 0;

                result = (checkDigit == int.Parse(isbn13[12].ToString()));

            }

            return result;

        } // end validate ISBN 13

    //} // end try isbn 13

    // end validate ISBN

        public static String getMonth(int monthNo)
        {
            switch (monthNo)
            {
                case 1: return "JAN";
                case 2: return "FEB";
                case 3: return "MAR";
                case 4: return "APR";
                case 5: return "MAY";
                case 6: return "JUN";
                case 7: return "JUL";
                case 8: return "AUG";
                case 9: return "SEP";
                case 10: return "OCT";
                case 11: return "NOV";
                case 12: return "DEC";
                default: return "";
            }
        } // end get month 

        public static bool isDouble(String value)
        {
             
            double d;

            try
            {
                d = Convert.ToDouble(value);

                if (value.Contains("."))
                {
                    String[] num = value.Split('.');

                    if (  num[1].Length != 2)
                        return false;
                }

            }
            catch (FormatException)
            { return false; }

            return true;
        } // end is double

        public static bool isEircode(String eircode)
        {
            bool pass = false;

            Regex pattern = new Regex("(?:^[AC-FHKNPRTV-Y][0-9]{2}|D6W)[ -]?[0-9AC-FHKNPRTV-Y]{4}$");

            String a = eircode.ToUpper();

            if (pattern.IsMatch(a))
                pass = true;


            return pass;
        } // end is eircode 



    } // end class 
}
