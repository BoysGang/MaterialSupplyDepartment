using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MTO.Utils
{
    public static class TextValidator
    {
        public static bool isNumber(string text)
        {
            return Regex.IsMatch(text, @"[0-9\b]+");
        }

        public static bool isCipher(string text)
        {
            return Regex.IsMatch(text, @"[0-9.\b]+");
        }
    }
}
