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
    public partial class MainForm : BaseForm
    {
        private LoginForm loginForm;
        public MainForm(LoginForm _loginForm) : base()
        {
            InitializeComponent();

            loginForm = _loginForm;
            this.FormClosing += new FormClosingEventHandler(MainForm_Closing);
        }

        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            loginForm.RefreshInterface();
            loginForm.Show();
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            listBoxEntries.Items.Add("Item ASDASDASD");
        }
    }
}
