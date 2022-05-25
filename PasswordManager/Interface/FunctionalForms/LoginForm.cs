/****************************************************************************
 *                                                                          *
 *  File:        LoginForm.cs                                               *
 *  Copyright:   (c) 2022, Tarziu Matei-Stefan                              *
 *  E-mail:      matei-stefan.tarziu@student.tuiasi.ro                      *
 *  Description: In this file you will find the implementation for          *
 *               the Login form of the application.                         *
 *                                                                          *
 ****************************************************************************/

using System;
using System.Windows.Forms;

namespace Interface
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm() : base()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            textBoxPassword.Text = "";

            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(password);
            string encrypteduser = securityManager.EncryptData(username);

            Utility.User currentUser = null;
            try
            {
                DataBaseManager.DatabaseManager databaseManager = DataBaseManager.DatabaseManager.Instance;
                currentUser = databaseManager.GetUser(encrypteduser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR:\n" + ex.Message);
            }

            if (currentUser != null)
                if (securityManager.ComputeKeyHash() == currentUser.password)
                {
                    (new MainForm(this, securityManager, currentUser)).Show();
                    this.Hide();
                    return;
                }
            
            MessageBox.Show("Wrong Credentials");
        }

        public void RefreshInterface()
        {
            textBoxPassword.Text = "";
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            (new SignUpForm()).Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager("P@saw0rd!");

            string name = securityManager.EncryptData("Razvan Sprinceana");
            string username = securityManager.EncryptData("sprnache");
            string email = securityManager.EncryptData("spranche@lache.com");
            string telephone = securityManager.EncryptData("0707070707");

            string password = securityManager.ComputeKeyHash();

            MessageBox.Show(name);
            MessageBox.Show(username);
            MessageBox.Show(email);
            MessageBox.Show(telephone);
            MessageBox.Show(password);

            Utility.User toAddUser = new Utility.User(name, username, password, email, telephone);

            try
            {
                DataBaseManager.DatabaseManager databaseManager = DataBaseManager.DatabaseManager.Instance;
                databaseManager.AddUser(toAddUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR:\n" + ex.Message);
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string startupPath = Environment.CurrentDirectory;
            string projectName = "PasswordManager";
            string rootPath = startupPath.Split(projectName)[0] + '/' + projectName + '/';
            string helpPath = rootPath + "PasswordManager.chm";

            // MessageBox.Show(helpPath);
            System.Windows.Forms.Help.ShowHelp(this, helpPath);
        }
    }
}
