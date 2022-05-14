
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.listBoxEntries = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxCurrentUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSignOut
            // 
            this.buttonSignOut.Location = new System.Drawing.Point(843, 504);
            this.buttonSignOut.Name = "buttonSignOut";
            this.buttonSignOut.Size = new System.Drawing.Size(111, 26);
            this.buttonSignOut.TabIndex = 1;
            this.buttonSignOut.Text = "Sign Out";
            this.buttonSignOut.UseVisualStyleBackColor = true;
            this.buttonSignOut.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // groupBoxCurrentUser
            // 
            this.groupBoxCurrentUser.Controls.Add(this.richTextBox1);
            this.groupBoxCurrentUser.Controls.Add(this.textBoxPassword);
            this.groupBoxCurrentUser.Controls.Add(this.textBoxUsername);
            this.groupBoxCurrentUser.Controls.Add(this.listBoxEntries);
            this.groupBoxCurrentUser.Controls.Add(this.buttonAdd);
            this.groupBoxCurrentUser.Controls.Add(this.button2);
            this.groupBoxCurrentUser.Controls.Add(this.button1);
            this.groupBoxCurrentUser.Controls.Add(this.buttonSignOut);
            this.groupBoxCurrentUser.Location = new System.Drawing.Point(12, 12);
            this.groupBoxCurrentUser.Name = "groupBoxCurrentUser";
            this.groupBoxCurrentUser.Size = new System.Drawing.Size(960, 537);
            this.groupBoxCurrentUser.TabIndex = 3;
            this.groupBoxCurrentUser.TabStop = false;
            this.groupBoxCurrentUser.Text = "[USER]";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(404, 220);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(342, 202);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPassword.Location = new System.Drawing.Point(404, 167);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(342, 29);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxUsername.Location = new System.Drawing.Point(404, 118);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(342, 29);
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
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(843, 121);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(111, 26);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Ceva ADD";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(843, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 26);
            this.button2.TabIndex = 3;
            this.button2.Text = "Ceva EDIT";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(843, 220);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 2;
            this.button1.Text = "CEVA CEVA";
            this.button1.UseVisualStyleBackColor = true;
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
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
    }
}