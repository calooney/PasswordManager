using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
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

            DataBaseManager.DatabaseManager databaseManager = DataBaseManager.DatabaseManager.Instance;
            Utility.User currentUser = databaseManager.GetUser(encrypteduser);

            if (currentUser != null)
                if (securityManager.ComputeKeyHash() == currentUser.password)
                {
                    (new MainForm(this, securityManager, username)).Show();
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

            DataBaseManager.DatabaseManager databaseManager = DataBaseManager.DatabaseManager.Instance;
            databaseManager.AddUser(toAddUser);
        }
    }
}
