using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecurityUtility;
using DataBaseManager;
using Utility;

namespace Interface
{
    public partial class AddEntryForm : BaseForm
    {
        private SecurityManager _securityManager;
        private User _currentUser;

        public AddEntryForm(SecurityManager securityManager, User mainUser) : base()
        {
            InitializeComponent();

            _securityManager = securityManager;
            _currentUser = mainUser;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked) textBoxPassword.UseSystemPasswordChar = false;
            else textBoxPassword.UseSystemPasswordChar = true;
        }

        private void buttonGeneratePassword_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = SecurityUtility.PasswordGenerator.GeneratePassword(18);
        }

        private void buttonAddEntry_Click(object sender, EventArgs e)
        {
            string platform = textBoxPlatform.Text.Trim();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string extrInfo = richTextBoxExtraInfo.Text.Trim();

            platform = _securityManager.EncryptData(platform);  

            username = _securityManager.EncryptData(username);
            password = _securityManager.EncryptData(password);
            extrInfo = _securityManager.EncryptData(extrInfo);

            UserAccountInfo accountInfo = new UserAccountInfo(platform, username, password, extrInfo);
            accountInfo.id = DatabaseManager.Instance.AddPlatformInfo(_currentUser, accountInfo);

            MessageBox.Show("Account added!");
            this.Close();
        }
    }
}
