using System;
using System.Collections.Generic;
using System.Text;

namespace s32429_apbd_cw1
{
    internal interface PESELValidator
    {
        bool isValidPESEL(string PESEL)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(PESEL, "^\\d{11}$"))
                throw new ArgumentException("PESEL musi składać się z 11 cyfr.");


            int[] weights = { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            int sum = 0;

            for (int i = 0; i < weights.Length; i++)
                sum += weights[i] * (PESEL[i] - '0');

            int checksum = (10 - (sum % 10)) % 10;
            int lastDigit = PESEL[10] - '0';

            if(checksum != lastDigit)
                throw new ArgumentException("Niepoprawna suma kontrolna PESEL.");

            return true;
        }
    }
}
