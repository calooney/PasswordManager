using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataBaseManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Utility;

namespace DataBaseManager.Tests
{

    [TestClass()]
    public class DatabaseManagerTests
    {
        DatabaseManager database = null;
        [TestInitialize()]
        public void Init()
        {
            database = null;
        }

        [TestMethod()]
        public void DatabaseInstanceTest()
        {
            database = DatabaseManager.Instance;

            Assert.IsInstanceOfType(database, typeof(DatabaseManager));
        }

        [TestMethod()]
        public void DatabaseNullInstanceTest()
        {
            Assert.IsNull(database);
        }


        [TestMethod()]
        public void AddUserTestSuccess()
        {
            string username, clearPassword = "parola", name, email, telephone, password;
            database = DatabaseManager.Instance;
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(clearPassword);

            name = securityManager.EncryptData("User");
            username = securityManager.EncryptData("newUser");
            email = securityManager.EncryptData("test@email.com");
            telephone = securityManager.EncryptData("0741258963");

            password = securityManager.ComputeKeyHash();

            User toAddUser = new User(name, username, password, email, telephone);
            Assert.IsTrue(database.AddUser(toAddUser));
            
            database.DeleteUser(toAddUser);

        }

        [TestMethod()]
        public void AddUserTestFailed()
        {
            string username, clearPassword = "parola", name, email, telephone, password;
            database = DatabaseManager.Instance;
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(clearPassword);

            name = securityManager.EncryptData("User2");
            username = securityManager.EncryptData("newUser2");
            email = securityManager.EncryptData("test@email.com");
            telephone = securityManager.EncryptData("0741258963");

            password = securityManager.ComputeKeyHash();

            User toAddUser = new User(name, username, password, email, telephone);
            //TODO remove the comments
            database.AddUser(toAddUser);
            Assert.IsFalse(database.AddUser(toAddUser));
            database.DeleteUser(toAddUser);

        }

        [TestMethod()]
        public void GetUserTestSuccess()
        {
            DatabaseManager database = DatabaseManager.Instance;
            string username = "test";
            string password = "test";
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(password);
            string encryptedUsername = securityManager.EncryptData(username);
            User user = database.GetUser(encryptedUsername);

            Assert.IsNotNull(user);


        }
        [TestMethod()]
        public void GetUserTestReturnNull()
        {
            database = DatabaseManager.Instance;
            string username = "test";

            User user = database.GetUser(username);

            Assert.IsNull(user);

        }

        [TestMethod()]
        public void GetUserTestNullArguments()
        {
            database = DatabaseManager.Instance;

            User user = database.GetUser(null);

            Assert.IsNull(user);

        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddPlatformInfoTestFailNullArguments()
        {
            database = DatabaseManager.Instance;
            int result = database.AddPlatformInfo(null, null);

        }
        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddPlatformInfoTestFailOneNullArgument()
        {
            string username = "test";
            string password = "test";
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(password);
            string encryptedUsername = securityManager.EncryptData(username);
            database = DatabaseManager.Instance;
            User user = database.GetUser(encryptedUsername);

            int result = database.AddPlatformInfo(user, null);

        }


        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void AddPlatformInfoTestFailNullUser()
        {
            database = DatabaseManager.Instance;
            int result = database.AddPlatformInfo(null, new UserAccountInfo("facebook.com", "test", "test"));

        }
        //TODO GetUserAccounts 
        //TODO UpdateAccountInfo 


        [TestMethod()]
        
        public void DeleteAccountTestSuccess()
        {
            string username = "test";
            string password = "test";
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(password);
            string encryptedUsername = securityManager.EncryptData(username);
            database = DatabaseManager.Instance;
            User user = database.GetUser(encryptedUsername);

            List<UserAccountInfo> userAccounts = database.GetUserAccounts(user);
            UserAccountInfo data = userAccounts.Last<UserAccountInfo>();
            bool result = database.DeleteAccount(data);

            Assert.IsTrue(result);

            database.AddPlatformInfo(user, data);
        }
        [TestMethod()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DeleteAccountTestNoContent()
        {
            string username, clearPassword = "parola", name, email, telephone, password;
            database = DatabaseManager.Instance;
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(clearPassword);

            name = securityManager.EncryptData("User2");
            username = securityManager.EncryptData("newUser2");
            email = securityManager.EncryptData("test@email.com");
            telephone = securityManager.EncryptData("0741258963");

            password = securityManager.ComputeKeyHash();

            User toAddUser = new User(name, username, password, email, telephone);
            database.AddUser(toAddUser);

            List<UserAccountInfo> userAccounts = database.GetUserAccounts(toAddUser);
            UserAccountInfo data = userAccounts.Last<UserAccountInfo>();
            bool result = database.DeleteAccount(data);
        }

        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteAccountTestNullArgument()
        {
            database = DatabaseManager.Instance;
            Assert.IsTrue(database.DeleteAccount(null));
        }

        [TestMethod()]
       
        public void DeleteUserTest()
        {
            string username, clearPassword = "parola", name, email, telephone, password;
            database = DatabaseManager.Instance;
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(clearPassword);

            name = securityManager.EncryptData("User4");
            username = securityManager.EncryptData("newUser4");
            email = securityManager.EncryptData("test@email.com");
            telephone = securityManager.EncryptData("0741258963");

            password = securityManager.ComputeKeyHash();

            User toAddUser = new User(name, username, password, email, telephone);
            database.AddUser(toAddUser);

            Assert.IsTrue(database.DeleteUser(toAddUser));
        }


        [TestMethod()]
        [ExpectedException(typeof(NullReferenceException))]
        public void DeleteUserTestNullArgument()
        {
            database = DatabaseManager.Instance;
            Assert.IsTrue(database.DeleteUser(null));
        }

    }
}
