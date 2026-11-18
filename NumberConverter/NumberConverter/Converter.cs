using System;
using System.Collections.Generic;
using System.Text;

namespace NumberConverter
{
    public class MyConverter
    {
        public string ConvertToRomanNumber(int numberToConvert)
        {
            int[] arabianValues = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

            string[] romanValues = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string romanNumber = "";

            for (int i = 0; i <= arabianValues.Length - 1; i++)
            {
                while (numberToConvert >= arabianValues[i])
                {
                    romanNumber += romanValues[i];

                    numberToConvert -= arabianValues[i];
                }
            }

            return romanNumber;
        }

        public int ConvertToArabianNumber(string numberToConvert)
        {
            int[] arabianValues = { 1000, 900, 500, 400, 90, 100, 40, 50, 9, 10, 4, 5, 1 };

            string[] romanValues = { "M", "CM", "D", "CD", "XC", "C", "XL", "L", "IX", "X", "IV", "V", "I" };

            int arabianNumber = 0;

            for (int i = 0; i <= romanValues.Length - 1; i++)
            {
                while (numberToConvert.Contains(romanValues[i]))
                {
                    arabianNumber += arabianValues[i];
                }
            }

            return arabianNumber;
        }
    }
}