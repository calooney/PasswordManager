/****************************************************************************
 *                                                                          *
 *  File:        User.cs                                                    *
 *  Copyright:   (c) 2022, Draganescu Bianca-Andreea                        *
 *  E-mail:      bianca-andreea.draganescu@student.tuiasi.ro                *
 *  Description: In this file you will find the implementation for          *
 *               a User class that will be used in main application         *
 *               for data data transfer between entities.                   *
 *                                                                          *
 ****************************************************************************/

namespace Utility
{
    public class User
    {
        public string name;
        public string username;
        public string password;
        public string email;
        public string telephone;

        public User(string name, string username, string password, string email, string telephone)
        {
            this.name = name;
            this.username = username;
            this.password = password;
            this.email = email;
            this.telephone = telephone;
        }

        public override string ToString()
        {
            return $"{name} {username} {password} {email} {telephone}";
        }
    }
}
