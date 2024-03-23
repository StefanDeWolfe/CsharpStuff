using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingQuestions
{
    public class NumberManipulation
    {
        public static bool IsPrime(int num)
        {
            if (num < 0)
                return false;
            else if (num.Equals(0))
                return false;
            else if (num.Equals(1))
                return false;
            else
            {
                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }                
                }
                return true;
            }
        }
    }
}
