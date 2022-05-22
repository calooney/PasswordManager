using System;
using System.Data.SqlClient;
using System.IO;
using Utility;
using System.Collections.Generic;



namespace DataBaseManager
{
    public class DatabaseManager
    {
        static SqlConnection conn = null;
        public static DatabaseManager instance = null;

        private static readonly object _lock = new object ();
        public static DatabaseManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (_lock)
                        {
                            if (instance == null)
                            {
                                instance = new DatabaseManager();
                            }
                        }
                }
                return instance;
            }
        }
        DatabaseManager()
        {
            string connetionString;
            string workingDirectory = Environment.CurrentDirectory;

            // This will get the current PROJECT bin directory (ie ../bin/)
           // string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName;

            // This will get the current PROJECT directory
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);
            connetionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={projectDirectory}\DataBaseManager\Database.mdf;Integrated Security=True;MultipleActiveResultSets=true";
            conn = new SqlConnection(connetionString);
            conn.Open();
            Console.WriteLine("Connected to database!");
        }

        public void AddUser(Utility.User user)
        {
            SqlCommand sqlCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = $"insert into Users values('{user.username}', '{user.password}', '{user.name}','{user.email}', '{user.telephone}')";

            sqlCommand = new SqlCommand(sql, conn);
            try { 
            sqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sqlCommand.Dispose();


        }

        public User GetUser(string username)
        {
            SqlCommand sqlCommand;
            SqlDataReader dataReader;
            User user = null;


            string sql = $"select name, username, password, email, telephone from Users where username = '{username}'";

            sqlCommand = new SqlCommand(sql, conn);

            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                //dataReader.GetValues(values);
                user = new User((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2), (string)dataReader.GetValue(3), (string)dataReader.GetValue(4));
            }

            return user;
        }
        public  int AddPlatformInfo(User user, UserAccountInfo info)
        {
            SqlCommand sqlCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;
            int id = -1;

            string sql = $"insert into Accounts OUTPUT Inserted.ID values('{info.username}', '{info.password}', '{info.platform}','{info.extraInfo}', CONVERT(INT, (select id from Users where username = '{user.username}')))";

            //string sql = $"select id from Users as u where u.username = '{user.username}'";

            Console.WriteLine(sql);

            sqlCommand = new SqlCommand(sql, conn);

            try
            {
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                    id = (int)dataReader.GetValue(0);

                //dataReader.Close();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Account added succesfully. ID: {id}");

            sqlCommand.Dispose();

            return id;

        }

        public List<UserAccountInfo> GetUserAccounts(User user)
        {
            List<UserAccountInfo> accountList = new List<UserAccountInfo>();
            SqlCommand sqlCommand;
            SqlDataReader dataReader;


            string sql = $"select platform, username, password, id, extra_info from Accounts where user_id = CONVERT(INT, (select id from Users where username = '{user.username}'))";

            sqlCommand = new SqlCommand(sql, conn);

            dataReader = sqlCommand.ExecuteReader();
            while(dataReader.Read())
            {
                //dataReader.GetValues(values);
                accountList.Add(new UserAccountInfo((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2), (string)dataReader.GetValue(4), (int)dataReader.GetValue(3)));
            }

            return accountList;
        }

        public void UpdateAccountInfo(UserAccountInfo info)
        {
            SqlCommand sqlCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;

            string sql = $"update Accounts set username = '{info.username}', password = '{info.password}', platform = '{info.platform}', extra_info = '{info.extraInfo}' where id = {info.id}";

            //string sql = $"select id from Users as u where u.username = '{user.username}'";

            Console.WriteLine(sql);

            sqlCommand = new SqlCommand(sql, conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sqlCommand.Dispose();
        }


        public void DeleteAccount(UserAccountInfo info)
        {
            SqlCommand sqlCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;

            string sql = $"delete Accounts where id = {info.id}";

            //string sql = $"select id from Users as u where u.username = '{user.username}'";

            Console.WriteLine(sql);

            sqlCommand = new SqlCommand(sql, conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            sqlCommand.Dispose();
        }

        ~DatabaseManager()
        {
            conn.Close();
        }
    }
}
