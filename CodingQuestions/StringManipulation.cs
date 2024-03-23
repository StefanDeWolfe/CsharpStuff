using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public  class StringManipulation
    {
        public static string Reverse(string stringToReverse)
        {
            if (stringToReverse == null)
                throw new ArgumentNullException("StringManipulation.Reverse: stringToReverse argument is null.");
            char[] stringAsCharArray = stringToReverse.ToCharArray();
            Array.Reverse(stringAsCharArray);
            return new string(stringAsCharArray);
        }
        public static bool IsPalendrome(string str)
        {
            char[] stringAsCharArray1 = str.ToCharArray();
            char[] stringAsCharArray2 = str.ToCharArray();
            if (stringAsCharArray1 == null)
                throw new ArgumentNullException("StringManipulation.IsPalendrome: str argument is null.");
            Array.Reverse(stringAsCharArray2);
            for (int i = 0; i < stringAsCharArray1.Length; i++)
            {
                if (stringAsCharArray1[i] != stringAsCharArray2[i])
                {
                    return false;
                }
            }
            return true;

        }
        public static bool ContainsSubstring(string sourceStr, string toCheckStr, StringComparison comp)
        {
            return sourceStr.IndexOf(toCheckStr, comp) >= 0;
        }
    }
}
