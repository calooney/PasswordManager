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
    public partial class EditEntryForm : BaseForm
    {
        private int _entryID;
        public EditEntryForm(int entryId) : base()
        {
            InitializeComponent();
            this._entryID = entryId;
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

        }
    }
}
