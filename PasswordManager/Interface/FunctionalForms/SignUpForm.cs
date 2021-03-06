/****************************************************************************
 *                                                                          *
 *  File:        SignUpForm.cs                                              *
 *  Copyright:   (c) 2022, Tarziu Matei-Stefan                              *
 *  E-mail:      matei-stefan.tarziu@student.tuiasi.ro                      *
 *  Description: In this file you will find the implementation for          *
 *               the Sign Up form of the application.                       *
 *                                                                          *
 ****************************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;

namespace Interface
{
    public partial class SignUpForm : BaseForm
    {
        public SignUpForm() : base()
        {
            InitializeComponent();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxEmail.Text = "";
            textBoxUsername.Text = "";
            textBoxTelephone.Text = "";
            textBoxPassword1.Text = "";
            textBoxPassword2.Text = "";
        }

        private void SetFeedbackLabel(Color color, string message)
        {
            labelFeedback.ForeColor = color;
            labelFeedback.Text = message;
        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            string name      = textBoxName.Text.Trim();
            string username  = textBoxUsername.Text.Trim();
            string email     = textBoxEmail.Text.Trim();
            string telephone = textBoxTelephone.Text.Trim();
            string password1 = textBoxPassword1.Text.Trim();
            string password2 = textBoxPassword2.Text.Trim();

            
            SetFeedbackLabel(Color.Black, "");

            if (name == "")
            {
                SetFeedbackLabel(Color.Red, "Insert a valid name!");
                return;
            }

            if (username == "")
            {
                SetFeedbackLabel(Color.Red, "Insert a valid username!");
                return;
            }

            if (!Utility.Checks.IsValidEmail(email))
            {
                SetFeedbackLabel(Color.Red, "Insert a valid email!");
                return;
            }

            if (telephone.Length == 10 || telephone == "" || !Utility.Checks.IsDigitsOnly(telephone))
            {
                SetFeedbackLabel(Color.Red, "Insert a valid telephone number!");
                return;
            }

            if (password1 == "" || password1.Length < 5)
            {
                SetFeedbackLabel(Color.Red, "Insert a valid password!");
                return;
            }

            if (password1 == "" || password1 != password2)
            {
                SetFeedbackLabel(Color.Red, "Passwords don't match!");
                return;
            }

            SetFeedbackLabel(Color.Green, "Account created!");


            SecurityUtility.SecurityManager securityManager = new SecurityUtility.SecurityManager(password1);
            name        = securityManager.EncryptData(name);
            username    = securityManager.EncryptData(username);
            email       = securityManager.EncryptData(email);
            telephone   = securityManager.EncryptData(telephone);

            string password = securityManager.ComputeKeyHash();

            Utility.User toAddUser = new Utility.User(name, username, password, email, telephone);

            bool status = false;
            try
            {
                DataBaseManager.DatabaseManager databaseManager = DataBaseManager.DatabaseManager.Instance;
                status = databaseManager.AddUser(toAddUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show("DATABASE ERROR:\n" + ex.Message);
            }

            if (status)
                MessageBox.Show("User Created");
            else
                MessageBox.Show("ERROR: User cannot be created!\nDatabse Error!");
        }
    }
}
