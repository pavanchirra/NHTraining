using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeLibrary
{
    public class Algebra
    {
        public static bool IsPalindrome(int n)
        {
            int rev = 0, rem, m;
            m = n;
            while (m > 0)
            {
                rem = m % 10;
                m = m / 10;
                rev = rev * 10 + rem;
            }
            if (n == rev)
                return true;
            else
                return false;
        }
    }
}
