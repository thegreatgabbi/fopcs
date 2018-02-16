using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalExercises
{
    public class Question24
    {
        public static bool CheckPassword(string input)
        {
            bool isPasswordValid = true;

            // check if length is at least 8 characters
            if (input.Length < 8)
            {
                isPasswordValid = false;
            }

            // check that it contains lower and uppercase characters and numbers
            // https://stackoverflow.com/questions/27402126/check-if-string-have-uppercase-lowercase-and-number/27402159
            if ( !( input.Any(char.IsUpper) && input.Any(char.IsLower) &&input.Any(char.IsDigit) ) )
            {
                isPasswordValid = false;
            }

            Random r = new Random();

            return isPasswordValid;
        }
    }
}
