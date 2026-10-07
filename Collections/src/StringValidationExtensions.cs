using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Collections.src
{
    public static class StringValidationExtensions
    {

        public static bool IsValidEgyptianPhone(this string phone)
        {
            if (string.IsNullOrEmpty(phone))
                return false;

            return Regex.IsMatch(
                      phone,
                      @"^(010|011|012|015)\d{8}$|^\+20(10|11|12|15)\d{8}$"
                  );
        }
        public static bool IsValidEgyptianNationalId(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return false;

            return Regex.IsMatch(
                      value,
                      @"^[23]\d{13}$"
                  );
        }




        }
}
