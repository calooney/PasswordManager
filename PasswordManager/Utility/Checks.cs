/***************************************************************************
 *                                                                         *
 *  File:        Checks.cs                                        *
 *  Copyright:   (c) 2022, Luca Silviu-Catalin                             *
 *  E-mail:      silviu-catalin.luca@student.tuiasi.ro                     *
 *  Description: In this file you will find the implementation for         *
 *               a set of check functions that can be used in main app     *
 *               for data validation.                                      *
 *                                                                         *
 ***************************************************************************/

using System;
using System.Net.Mail;

namespace Utility
{
    public class Checks
    {
        public static bool IsValidEmail(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }


        public static bool IsDigitsOnly(string inputText)
        {
            foreach (char c in inputText)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
