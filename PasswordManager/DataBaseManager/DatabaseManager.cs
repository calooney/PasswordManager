/**************************************************************************
 *                                                                        *
 *  File:        DatabaseManager.cs                                       *
 *  Copyright:   (c) 2022, Adrian-Marian Grabovschi                       *
 *  E-mail:      adrian-marian.grabovschi@student.tuiasi.ro               *
 *  Description: In this file you will find the implementation for        *
 *               all persistence methods.                                 *
 *                                                                        *
 **************************************************************************/



using System;
using System.Data.SqlClient;
using System.IO;
using Utility;
using System.Collections.Generic;



namespace DataBaseManager
{
    public class DatabaseManager
    {
        SqlConnection _conn = null;
        private static DatabaseManager _instance = null;

        private static readonly object _lock = new object ();

        /// <summary>
        /// Vom accesa instanta bazei de date doar prin intermediul acestei proprietati
        /// </summary>
        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DatabaseManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public SqlConnection Conn { get => _conn;}

        /// <summary>
        ///  Constructorul privat al clasei DatabaseManager
        /// </summary>
        private DatabaseManager()
        {
            string connetionString;
            string workingDirectory = Environment.CurrentDirectory;
            
            //variabila care sa determine calea absoluta pana la solutia proiectului
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.Parent.Parent.FullName;
            Console.WriteLine(projectDirectory);

            connetionString = @$"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={projectDirectory}\DataBaseManager\Database.mdf;Integrated Security=True;MultipleActiveResultSets=true";
           _conn = new SqlConnection(connetionString);
            _conn.Open();
            Console.WriteLine("Connected to database!");
        }


        /// <summary>
        /// Metoda cu ajutorul careia se adauga un user in baza de date
        /// </summary>
        /// <param name="user"></param>
        /// <returns>True pentru succes, false pentru fail</returns>
        public bool AddUser(User user)
        {
            bool result = true;
            SqlCommand sqlCommand;

            string sql = $"insert into Users values('{user.username}', '{user.password}', '{user.name}','{user.email}', '{user.telephone}')";

            sqlCommand = new SqlCommand(sql, _conn);
            try
            { 
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                result = false;
                Console.WriteLine(e.Message);
            }
            sqlCommand.Dispose();
            return result;

        }


        /// <summary>
        /// pentru a accesa credentialele si datele personale ale utilizatorului
        /// </summary>
        /// <param name="username"></param>
        /// <returns>Un obiect de tipul User daca username-ul este in baza de date, null altfel</returns>
        public User GetUser(string username)
        {
            SqlCommand sqlCommand;
            SqlDataReader dataReader;
            User user = null;


            string sql = $"select name, username, password, email, telephone from Users where username = '{username}'";

            sqlCommand = new SqlCommand(sql, _conn);
            //comanda sqlCommand.ExecuteReader() va returna rezultatul interogarii din string-ul sql
            
            dataReader = sqlCommand.ExecuteReader();

            // se va citi linia unde se regaseste raspunsul interogarii si se va crea un obiect
            // de tipul User cu fiecare valoare din baza de date
            while (dataReader.Read())
            {
                user = new User((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2), (string)dataReader.GetValue(3), (string)dataReader.GetValue(4));
            }

            return user;
        }

        //
        /// <summary>
        /// adauga un cont al utilizatorului in tabela Accounts
        /// </summary>
        /// <param name="user"></param>
        /// <param name="info"></param>
        /// <returns>Id-ul din baza de date a contului adaugat</returns>
        public int AddPlatformInfo(User user, UserAccountInfo info)
        {
            SqlCommand sqlCommand;

            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;
            int id = -1;
            // query pentru a adauga un cont in baza de date
            // parametrul "OUTPUT Inserted.ID" va face ca acest query sa returneze ID-ul  contului abia inserat 
            string sql = $"insert into Accounts OUTPUT Inserted.ID values('{info.username}', '{info.password}', '{info.platform}','{info.extraInfo}', CONVERT(INT, (select id from Users where username = '{user.username}')))";

            Console.WriteLine(sql);

            sqlCommand = new SqlCommand(sql, _conn);

            try
            {
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                    id = (int)dataReader.GetValue(0);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine($"Account added succesfully. ID: {id}");

            sqlCommand.Dispose();

            return id;

        }


        /// <summary>
        /// metoda care returneaza o lista cu toate conturile utilizatorului salvate in aplicatie
        /// </summary>
        /// <param name="user"></param>
        /// <returns>O lista cu obiecte de tipul UserAccountInfo</returns>
        public List<UserAccountInfo> GetUserAccounts(User user)
        {
            List<UserAccountInfo> accountList = new List<UserAccountInfo>();
            SqlCommand sqlCommand;
            SqlDataReader dataReader;


            string sql = $"select platform, username, password, id, extra_info from Accounts where user_id = CONVERT(INT, (select id from Users where username = '{user.username}'))";

            sqlCommand = new SqlCommand(sql, _conn);

            dataReader = sqlCommand.ExecuteReader();
            while(dataReader.Read())
            {
                // creare si adaugare in lista a unui obiect de tipul UserAccountInfo
                // cu datele returnate de query
                accountList.Add(new UserAccountInfo((string)dataReader.GetValue(0), (string)dataReader.GetValue(1), (string)dataReader.GetValue(2), (string)dataReader.GetValue(4), (int)dataReader.GetValue(3)));
            }

            return accountList;
        }


        /// <summary>
        /// actualizarea conturilor din baza de date
        /// </summary>
        /// <param name="info"></param>
        /// <returns>True pentru succes, false pentru fail</returns>
        public bool UpdateAccountInfo(UserAccountInfo info)
        {
            SqlCommand sqlCommand;
            bool result = true;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;

            string sql = $"update Accounts set username = '{info.username}', password = '{info.password}', platform = '{info.platform}', extra_info = '{info.extraInfo}' where id = {info.id}";

            sqlCommand = new SqlCommand(sql, _conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            sqlCommand.Dispose();

            return result;
        }

        /// <summary>
        /// stergerea unui cont din baza de date
        /// </summary>
        /// <param name="info"></param>
        /// <returns>True pentru succes, false pentru fail</returns>
        public bool DeleteAccount(UserAccountInfo info)
        {
            SqlCommand sqlCommand;
            bool result = true;
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlDataReader dataReader;

            string sql = $"delete Accounts where id = {info.id}";

            Console.WriteLine(sql);

            sqlCommand = new SqlCommand(sql, _conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            sqlCommand.Dispose();
           
            return result;
        }

        /// <summary>
        /// metoda care sterge contul utilizatorului din aplicatie utilizata
        /// cu precadere in testarea unitatilor, pentru a asigura integritatea datelor
        /// </summary>
        /// <param name="user"></param>
        /// <returns>True pentru succes, false pentru fail</returns>
        public bool DeleteUser(User user)
        {
            SqlCommand sqlCommand;
            bool result = true;

            string sql = $"delete Users where username = '{user.username}'";

            sqlCommand = new SqlCommand(sql, _conn);

            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                result = false;
            }
            sqlCommand.Dispose();

            return result;
        }


        // destructorul clasei
        // apelat de catre Garbage Collector 
        // inchide conexiunea cu baza de date
        ~DatabaseManager()
        {
            if(_conn != null)
                _conn.Close();
        }
    }
}
