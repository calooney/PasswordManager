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
using Utility;
using DataBaseManager;

namespace Interface
{
    public partial class EditEntryForm : BaseForm
    {
        private UserAccountInfo _currentAccountInfo;
        private SecurityManager _securityManager;

        public EditEntryForm(SecurityManager securityManager, UserAccountInfo accountInfo) : base()
        {
            InitializeComponent();

            _currentAccountInfo = accountInfo;
            _securityManager = securityManager;

            textBoxPlatform.Text = securityManager.DecryptData(_currentAccountInfo.platform);
            textBoxUsername.Text = securityManager.DecryptData(_currentAccountInfo.username);
            textBoxPassword.Text = securityManager.DecryptData(_currentAccountInfo.password);
            richTextBoxExtraInfo.Text = securityManager.DecryptData(_currentAccountInfo.extraInfo);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEditEntry_Click(object sender, EventArgs e)
        {
            _currentAccountInfo.platform = _securityManager.EncryptData(textBoxPlatform.Text.Trim());
            _currentAccountInfo.username = _securityManager.EncryptData(textBoxUsername.Text.Trim());
            _currentAccountInfo.password = _securityManager.EncryptData(textBoxPassword.Text.Trim());
            _currentAccountInfo.extraInfo = _securityManager.EncryptData(richTextBoxExtraInfo.Text.Trim());

            DatabaseManager.Instance.UpdateAccountInfo(_currentAccountInfo);

            MessageBox.Show("Update successfully");
            this.Close();
        }
    }
}
