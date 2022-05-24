/****************************************************************************
 *                                                                          *
 *  File:        MainForm.cs                                              *
 *  Copyright:   (c) 2022, Tarziu Matei-Stefan                              *
 *  E-mail:      matei-stefan.tarziu@student.tuiasi.ro                      *
 *  Description: In this file you will find the implementation for          *
 *               main user interaction window formular                      *
 *                                                                          *
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SecurityUtility;
using Utility;
using DataBaseManager;

namespace Interface
{
    public partial class MainForm : BaseForm
    {
        private LoginForm loginForm;
        private User _currentUser;
        private SecurityManager securityManager;
        private List<UserAccountInfo> _listAccount;
        private int _currentAccountIndex = -1;

        public MainForm(LoginForm _loginForm, SecurityManager _securityManager, User currentUser) : base()
        {
            InitializeComponent();

            loginForm       = _loginForm;
            securityManager = _securityManager;
            _currentUser = currentUser;
            groupBoxCurrentUser.Text = securityManager.DecryptData(currentUser.username);

            this.FormClosing += new FormClosingEventHandler(MainForm_Closing);

            RefreshEntries();
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
            (new AddEntryForm(securityManager, _currentUser)).Show();
        }

        private void buttonEditEntry_Click(object sender, EventArgs e)
        {
            if (_currentAccountIndex != -1)
                (new EditEntryForm(securityManager, _listAccount[_currentAccountIndex])).Show();
            else
                MessageBox.Show("Invalid Account!");
        }

        private void buttonRefreshEntries_Click(object sender, EventArgs e)
        {
            RefreshEntries();
        }
        private void RefreshEntries()
        {
            _listAccount = DatabaseManager.Instance.GetUserAccounts(_currentUser);
            listBoxEntries.Items.Clear();

            for (int i = 0; i < _listAccount.Count; i++)
            {
                string username = securityManager.DecryptData(_listAccount[i].username);
                string platform = securityManager.DecryptData(_listAccount[i].platform);

                listBoxEntries.Items.Add(platform + ": " + username);
            }
        }

        private void listBoxEntries_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBoxEntries.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                _currentAccountIndex = index;
                textBoxPlatform.Text = securityManager.DecryptData(_listAccount[index].platform);
                textBoxUsername.Text = securityManager.DecryptData(_listAccount[index].username);
                textBoxPassword.Text = securityManager.DecryptData(_listAccount[index].password);
                richTextBoxExtraInfo.Text = securityManager.DecryptData(_listAccount[index].extraInfo);
            }
        }

        private void buttonDeleteEntry_Click(object sender, EventArgs e)
        {
            if (_currentAccountIndex != -1)
                if (DatabaseManager.Instance.DeleteAccount(_listAccount[_currentAccountIndex]))
                {
                    RefreshEntries();
                    MessageBox.Show("Entry Deletion Success!");
                }
                else
                    MessageBox.Show("Entry Deletion Failed!");
            else
                MessageBox.Show("Please select an entry!");
        }
    }
}
