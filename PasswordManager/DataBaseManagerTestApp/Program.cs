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
