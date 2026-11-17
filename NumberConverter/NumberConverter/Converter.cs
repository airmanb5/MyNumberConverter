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

            for (int i = 0; i<= arabianValues.Length; i++)
            {
                while (numberToConvert <= arabianValues[i])
                {
                    romanNumber += romanValues[i];

                    numberToConvert -= arabianValues[i];
                } 
            }

            return romanNumber;
        }
    }
}
