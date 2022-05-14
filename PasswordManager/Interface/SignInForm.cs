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
    public partial class SignInForm : BaseForm
    {
        public SignInForm() : base()
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

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            // TODO: partea de check date si adaugare in baza de date
        }
    }
}
