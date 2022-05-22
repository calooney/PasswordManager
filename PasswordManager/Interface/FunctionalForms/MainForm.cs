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

namespace Interface
{
    public partial class MainForm : BaseForm
    {
        private LoginForm loginForm;
        private string currentUsername;
        private SecurityManager securityManager;

        public MainForm(LoginForm _loginForm, SecurityManager _securityManager, string username) : base()
        {
            InitializeComponent();

            loginForm       = _loginForm;
            securityManager = _securityManager;
            currentUsername = username;
            groupBoxCurrentUser.Text = username;

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
            (new AddEntryForm()).Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEditEntry_Click(object sender, EventArgs e)
        {
            (new EditEntryForm(1)).Show();
        }
    }
}
