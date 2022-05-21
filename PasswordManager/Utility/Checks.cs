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
