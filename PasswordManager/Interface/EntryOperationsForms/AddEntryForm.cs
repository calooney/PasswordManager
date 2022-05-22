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
    public partial class AddEntryForm : BaseForm
    {
        public AddEntryForm() : base()
        {
            InitializeComponent();
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


        }
    }
}
