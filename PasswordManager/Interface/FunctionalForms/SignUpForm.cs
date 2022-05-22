using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            if (telephone.Length < 10 || telephone == "" || !Utility.Checks.IsDigitsOnly(telephone))
            {
                SetFeedbackLabel(Color.Red, "Insert a valid telephone number!");
                return;
            }

            if (password1 == "")
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

            DataBaseManager.DatabaseManager databaseManager = DataBaseManager.DatabaseManager.Instance;
            databaseManager.AddUser(toAddUser);

            MessageBox.Show("User Created");
        }
    }
}
