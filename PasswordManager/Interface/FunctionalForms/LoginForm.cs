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

            // TODO: credentials check here
            // MessageBox.Show(username + " " + password);

            (new MainForm(this)).Show();
            this.Hide();
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
            
            //byte[] test = securityManager.EncryptData("MuieRazvan");
            //string test = securityManager.ComputeKeyHash();
            //MessageBox.Show(test);
        }
    }
}
