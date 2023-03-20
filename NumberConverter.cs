using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roman_Numeral_Converter___Algorithm_Practice
{
    internal class NumberConverter
    {
        public string ConvertToRomanNum(int input)
        {

            string[] ones = { "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string[] tens = { "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };

            string[] hundreds = { "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };

            string[] thousands = { "M", "MM", "MMM", "MMMM", "MMMMM", "MMMMMM", "MMMMMMM", "MMMMMMMM", "MMMMMMMMM" };


            string output = "";

            string inputString = input.ToString();


            if (inputString.Length == 1)
            {
                output += ones[input - 1];
            }
            else if (inputString.Length == 2)
            {
                int firstDigit = (int)Char.GetNumericValue(inputString[0]);
                output += tens[firstDigit - 1];

                int secondDigit = (int)Char.GetNumericValue(inputString[1]);

                if(secondDigit != 0)
                {
                    output += ones[secondDigit - 1];
                } 
                
            }
            else if (inputString.Length == 3)
            {
                int firstDigit = (int)Char.GetNumericValue(inputString[0]);
                output += hundreds[firstDigit - 1];

                int secondDigit = (int)Char.GetNumericValue(inputString[1]);

                if (secondDigit != 0)
                {
                    output += tens[secondDigit - 1];
                }

                int thirdDigit = (int)Char.GetNumericValue(inputString[2]);
                
                if (thirdDigit != 0)
                {
                    output += ones[thirdDigit - 1];
                }

            }
            else if (inputString.Length == 4)
            {
                int firstDigit = (int)Char.GetNumericValue(inputString[0]);
                output += thousands[firstDigit - 1];

                int secondDigit = (int)Char.GetNumericValue(inputString[1]);

                if (secondDigit != 0)
                {
                    output += hundreds[secondDigit - 1];
                }

                int thirdDigit = (int)Char.GetNumericValue(inputString[2]);

                if(thirdDigit != 0)
                {
                    output += tens[thirdDigit - 1];
                } 

                int fourthDigit = (int)Char.GetNumericValue(inputString[3]);

                if(fourthDigit != 0)
                {
                    output += ones[fourthDigit - 1];
                }           
            }

            return output;
        }
    }
}
