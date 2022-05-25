/**************************************************************************
 *                                                                        *
 *  File:        Program.cs                                               *
 *  Copyright:   (c) 2022, Adrian-Marian Grabovschi                       *
 *  E-mail:      adrian-marian.grabovschi@student.tuiasi.ro               *
 *  Description: This program was created for testing outside project     *
 *               all persistence methods functionally.                    *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using DataBaseManager;
using Utility;
namespace DataBaseManagerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager databaseManager = DatabaseManager.Instance;
            User user = new User("name", "users", "pass", "users@email.com", "0745896321");
            databaseManager.AddUser(user);


            UserAccountInfo info = new UserAccountInfo("facebook.com", "usr", "pass");
            UserAccountInfo info2 = new UserAccountInfo("instagram.com", "usr", "pass");

            databaseManager.AddPlatformInfo(user, info);
            databaseManager.AddPlatformInfo(user, info2);

            Console.WriteLine("\n\nConturile utilizatorului:");
            List<UserAccountInfo> accounts = databaseManager.GetUserAccounts(user);

            foreach( UserAccountInfo account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

            Console.WriteLine("\n\nUtilizator returnat de metoda GetUser:");
            User userReturned = databaseManager.GetUser("users");
            Console.WriteLine(userReturned.ToString());


            Console.WriteLine("\n\nUpdate cont facebook:");
            accounts[0].password = "password";
            databaseManager.UpdateAccountInfo(accounts[0]);
            accounts = databaseManager.GetUserAccounts(user);
            foreach (UserAccountInfo account in accounts)
            {
                Console.WriteLine(account.ToString());
            }


            Console.WriteLine("\n\nStergere cont instagram:");
            databaseManager.DeleteAccount(accounts[1]);
            accounts = databaseManager.GetUserAccounts(user);

            foreach (UserAccountInfo account in accounts)
            {
                Console.WriteLine(account.ToString());
            }

            accounts = databaseManager.GetUserAccounts(user);
            foreach (UserAccountInfo account in accounts)
            {
                databaseManager.DeleteAccount(account);
            }

            databaseManager.DeleteUser(user);
        }
    }
}
