
namespace Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSignOut = new System.Windows.Forms.Button();
            this.groupBoxCurrentUser = new System.Windows.Forms.GroupBox();
            this.buttonRefreshEntries = new System.Windows.Forms.Button();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.richTextBoxExtraInfo = new System.Windows.Forms.RichTextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.buttonAddEntry = new System.Windows.Forms.Button();
            this.buttonEditEntry = new System.Windows.Forms.Button();
            this.buttonDeleteEntry = new System.Windows.Forms.Button();
            this.groupBoxCurrentUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(806, 504);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(111, 26);
            this.buttonSignOut.TabIndex = 1;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // groupBoxCurrentUser
            // 
            this.groupBoxCurrentUser.Controls.Add(this.buttonDeleteEntry);
            this.groupBoxCurrentUser.Controls.Add(this.buttonRefreshEntries);
            this.groupBoxCurrentUser.Controls.Add(this.textBoxPlatform);
            this.groupBoxCurrentUser.Controls.Add(this.labelPlatform);
            this.groupBoxCurrentUser.Controls.Add(this.label1);
            this.groupBoxCurrentUser.Controls.Add(this.labelPassword);
            this.groupBoxCurrentUser.Controls.Add(this.labelUsername);
            this.groupBoxCurrentUser.Controls.Add(this.richTextBoxExtraInfo);
            this.groupBoxCurrentUser.Controls.Add(this.textBoxPassword);
            this.groupBoxCurrentUser.Controls.Add(this.textBoxUsername);
            this.groupBoxCurrentUser.Controls.Add(this.listBoxEntries);
            this.groupBoxCurrentUser.Controls.Add(this.buttonAddEntry);
            this.groupBoxCurrentUser.Controls.Add(this.buttonEditEntry);
            this.groupBoxCurrentUser.Controls.Add(this.buttonSignOut);
            this.groupBoxCurrentUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCurrentUser.Name = "groupBoxCurrentUser";
            this.groupBoxCurrentUser.Size = new System.Drawing.Size(960, 537);
            this.groupBoxCurrentUser.TabIndex = 3;
            this.groupBoxCurrentUser.TabStop = false;
            this.groupBoxCurrentUser.Text = "[USER]";
            // 
            // buttonRefreshEntries
            // 
            this.buttonRefreshEntries.Location = new System.Drawing.Point(806, 425);
            this.buttonRefreshEntries.Name = "buttonRefreshEntries";
            this.buttonRefreshEntries.Size = new System.Drawing.Size(111, 26);
            this.buttonRefreshEntries.TabIndex = 14;
            this.buttonRefreshEntries.Text = "Refresh Entries";
            this.buttonRefreshEntries.UseVisualStyleBackColor = true;
            this.buttonRefreshEntries.Click += new System.EventHandler(this.buttonRefreshEntries_Click);
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPlatform.Location = new System.Drawing.Point(351, 61);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.ReadOnly = true;
            this.textBoxPlatform.Size = new System.Drawing.Size(408, 29);
            this.textBoxPlatform.TabIndex = 13;
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlatform.Location = new System.Drawing.Point(523, 37);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(70, 21);
            this.labelPlatform.TabIndex = 12;
            this.labelPlatform.Text = "Platform";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(357, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Extra info:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(523, 222);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(76, 21);
            this.labelPassword.TabIndex = 10;
            this.labelPassword.Text = "Password";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(523, 144);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(81, 21);
            this.labelUsername.TabIndex = 9;
            this.labelUsername.Text = "Username";
            // 
            // richTextBoxExtraInfo
            // 
            this.richTextBoxExtraInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxExtraInfo.Location = new System.Drawing.Point(351, 328);
            this.richTextBoxExtraInfo.Name = "richTextBoxExtraInfo";
            this.richTextBoxExtraInfo.ReadOnly = true;
            this.richTextBoxExtraInfo.Size = new System.Drawing.Size(408, 202);
            this.richTextBoxExtraInfo.TabIndex = 8;
            this.richTextBoxExtraInfo.Text = "";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(351, 246);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ReadOnly = true;
            this.textBoxPassword.Size = new System.Drawing.Size(408, 29);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(351, 168);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.ReadOnly = true;
            this.textBoxUsername.Size = new System.Drawing.Size(408, 29);
            this.textBoxUsername.TabIndex = 6;
            // 
            // listBoxEntries
            // 
            this.listBoxEntries.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxEntries.FormattingEnabled = true;
            this.listBoxEntries.ItemHeight = 21;
            this.listBoxEntries.Location = new System.Drawing.Point(6, 22);
            this.listBoxEntries.Name = "listBoxEntries";
            this.listBoxEntries.Size = new System.Drawing.Size(315, 508);
            this.listBoxEntries.TabIndex = 5;
            this.listBoxEntries.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBoxEntries_MouseDoubleClick);
            // 
            // buttonAddEntry
            // 
            this.buttonAddEntry.Location = new System.Drawing.Point(806, 328);
            this.buttonAddEntry.Name = "buttonAddEntry";
            this.buttonAddEntry.Size = new System.Drawing.Size(111, 26);
            this.buttonAddEntry.TabIndex = 4;
            this.buttonAddEntry.Text = "Add Entry";
            this.buttonAddEntry.UseVisualStyleBackColor = true;
            this.buttonAddEntry.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEditEntry
            // 
            this.buttonEditEntry.Location = new System.Drawing.Point(806, 360);
            this.buttonEditEntry.Name = "buttonEditEntry";
            this.buttonEditEntry.Size = new System.Drawing.Size(111, 26);
            this.buttonEditEntry.TabIndex = 3;
            this.buttonEditEntry.Text = "Edit Entry";
            this.buttonEditEntry.UseVisualStyleBackColor = true;
            this.buttonEditEntry.Click += new System.EventHandler(this.buttonEditEntry_Click);
            // 
            // buttonDeleteEntry
            // 
            this.buttonDeleteEntry.Location = new System.Drawing.Point(806, 393);
            this.buttonDeleteEntry.Name = "buttonDeleteEntry";
            this.buttonDeleteEntry.Size = new System.Drawing.Size(111, 26);
            this.buttonDeleteEntry.TabIndex = 15;
            this.buttonDeleteEntry.Text = "Delete Entry";
            this.buttonDeleteEntry.UseVisualStyleBackColor = true;
            this.buttonDeleteEntry.Click += new System.EventHandler(this.buttonDeleteEntry_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBoxCurrentUser);
            this.Name = "MainForm";
            this.Text = "Password Manager";
            this.groupBoxCurrentUser.ResumeLayout(false);
            this.groupBoxCurrentUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSignOut;
        private System.Windows.Forms.GroupBox groupBoxCurrentUser;
        private System.Windows.Forms.ListBox listBoxEntries;
        private System.Windows.Forms.Button buttonAddEntry;
        private System.Windows.Forms.Button buttonEditEntry;
        private System.Windows.Forms.RichTextBox richTextBoxExtraInfo;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPlatform;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonRefreshEntries;
        private System.Windows.Forms.Button buttonDeleteEntry;
    }
}