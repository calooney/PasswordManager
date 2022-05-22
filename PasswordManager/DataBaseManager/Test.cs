using System;
using System.Data.SqlClient;
using System.IO;

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
            connetionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={projectDirectory}\DataBaseManager\Database.mdf;Integrated Security=True";
            conn = new SqlConnection(connetionString);
            conn.Open();
            Console.WriteLine("Connected to database!");
        }

        public  void AddUser(Utility.User user)
        {
            SqlCommand sqlCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();

            string sql = $"insert into Users values('{user.username}', '{user.password}', '{user.name}','{user.email}', '{user.telephone}')";

            sqlCommand = new SqlCommand(sql, conn);

            sqlCommand.ExecuteNonQuery();

            sqlCommand.Dispose();


        }

        ~DatabaseManager()
        {
            conn.Close();
        }
    }
}
