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
using DataBaseManager;
using Utility;
namespace DataBaseManagerTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseManager databaseManager = DatabaseManager.Instance;

            databaseManager.AddUser(new User("users", "pass", "users", "pass", "1235864"));
        }
    }
}
