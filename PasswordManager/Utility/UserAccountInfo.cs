/****************************************************************************
 *                                                                          *
 *  File:        UserAccountInfo.cs                                                    *
 *  Copyright:   (c) 2022, Draganescu Bianca-Andreea                        *
 *  E-mail:      bianca-andreea.draganescu@student.tuiasi.ro                *
 *  Description: In this file you will find the implementation for          *
 *               a UserAccountInfo class that will be used in               *
 *               main application foar data data transfer between entitie.  *
 *                                                                          *
 ****************************************************************************/

namespace Utility
{
    public class UserAccountInfo
    {
        public string platform;
        public string username;
        public string password;
        public string extraInfo;
        public int id;

        public UserAccountInfo(string platform, string username, string password, string extraInfo = null, int id = 0)
        {
            this.platform = platform;
            this.username = username;
            this.password = password;
            this.id = id;
            this.extraInfo = extraInfo;
        }

        public override string ToString()
        {
            return platform + ' ' + username + ' ' + password  + ' ' + extraInfo + ' ' + id;
        }
    }
}
