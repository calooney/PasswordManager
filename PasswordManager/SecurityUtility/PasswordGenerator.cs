/***************************************************************************
 *                                                                         *
 *  File:        PasswordGenerator.cs                                        *
 *  Copyright:   (c) 2022, Luca Silviu-Catalin                             *
 *  E-mail:      silviu-catalin.luca@student.tuiasi.ro                     *
 *  Description: In this file you will find the implementation for         *
 *               a random password generator.                              *
 *                                                                         *
 ***************************************************************************/

using System;
using System.Text;

namespace SecurityUtility
{
    public static class PasswordGenerator
    {
        /// <summary>
        /// Generator de parola Random de o lungime data ca parametru.
        /// </summary>
        /// <param name="passwordLength"></param>
        /// <returns></returns>
        public static string GeneratePassword(int passwordLength)
        {
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_=+<,>.";
            string upperLetters = "QWERTYUIOPASDFGHJKLZXCVBNM";
            string lowerLetters = "qwertyuiopasdfghjklzxcvbnm";

            string validChars = upperLetters + lowerLetters + digits + specialChars;

            StringBuilder result = new StringBuilder(); ;
            Random rand = new Random();

            for (int i = 0; i < passwordLength; i++)
                result.Append(validChars[rand.Next(validChars.Length)]);

            return result.ToString();
        }
    }
}
