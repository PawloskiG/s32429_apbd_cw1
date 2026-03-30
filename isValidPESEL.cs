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

            return true;
        }
    }
}
