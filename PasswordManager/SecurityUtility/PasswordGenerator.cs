using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityUtility
{
    public static class PasswordGenerator
    {
        public static string GeneratePassword(int passwordLength)
        {
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_=+<,>.";
            string upperLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";

            /*
            string[] alphabet = { upperLetters, lowerLetters, digits, specialChars };
            int partition = GENERATED_PASSWORD_LENGTH / 4;
            int[] counter = { partition, partition, partition, partition };
            */

            string validChars = upperLetters + lowerLetters + digits + specialChars;

            StringBuilder result = new StringBuilder(); ;
            Random rand = new Random();

            for (int i = 0; i < passwordLength; i++)
                result.Append(validChars[rand.Next(validChars.Length)]);

            return result.ToString();
        }
    }
}
