using System;
using System.Linq;

namespace PalindromeExercise
{
    public class Wordsmith
    {
        public Wordsmith()
        {
        }

        public bool IsAPalendrome(string word)
        {
            char[] reversed = word.ToCharArray();
            Array.Reverse(reversed);
            string s = new string(reversed);


            if (word == s)
            {
                return true;
            }
            return false;
        }
    }
}

