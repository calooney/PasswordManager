
namespace Interface
{
    partial class EditEntryForm
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
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonGeneratePassword = new System.Windows.Forms.Button();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonEditEntry = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelExtraInfo = new System.Windows.Forms.Label();
            this.labelPlatform = new System.Windows.Forms.Label();
            this.richTextBoxExtraInfo = new System.Windows.Forms.RichTextBox();
            this.textBoxPlatform = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.AutoSize = true;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(427, 110);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(108, 19);
            this.checkBoxShowPassword.TabIndex = 27;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // buttonGeneratePassword
            // 
            this.buttonGeneratePassword.Location = new System.Drawing.Point(219, 144);
            this.buttonGeneratePassword.Name = "buttonGeneratePassword";
            this.buttonGeneratePassword.Size = new System.Drawing.Size(128, 23);
            this.buttonGeneratePassword.TabIndex = 26;
            this.buttonGeneratePassword.Text = "Generate Password";
            this.buttonGeneratePassword.UseVisualStyleBackColor = true;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(86, 106);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(79, 21);
            this.labelPassword.TabIndex = 25;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(171, 106);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 23);
            this.textBoxPassword.TabIndex = 24;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(346, 399);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 23;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonEditEntry
            // 
            this.buttonEditEntry.Location = new System.Drawing.Point(171, 399);
            this.buttonEditEntry.Name = "buttonEditEntry";
            this.buttonEditEntry.Size = new System.Drawing.Size(75, 23);
            this.buttonEditEntry.TabIndex = 22;
            this.buttonEditEntry.Text = "Apply Edit";
            this.buttonEditEntry.UseVisualStyleBackColor = true;
            this.buttonEditEntry.Click += new System.EventHandler(this.buttonEditEntry_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(81, 77);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(84, 21);
            this.labelUsername.TabIndex = 21;
            this.labelUsername.Text = "Username:";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(171, 77);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(250, 23);
            this.textBoxUsername.TabIndex = 20;
            // 
            // labelExtraInfo
            // 
            this.labelExtraInfo.AutoSize = true;
            this.labelExtraInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelExtraInfo.Location = new System.Drawing.Point(11, 194);
            this.labelExtraInfo.Name = "labelExtraInfo";
            this.labelExtraInfo.Size = new System.Drawing.Size(180, 21);
            this.labelExtraInfo.TabIndex = 19;
            this.labelExtraInfo.Text = "Extra info about account:";
            // 
            // labelPlatform
            // 
            this.labelPlatform.AutoSize = true;
            this.labelPlatform.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPlatform.Location = new System.Drawing.Point(91, 48);
            this.labelPlatform.Name = "labelPlatform";
            this.labelPlatform.Size = new System.Drawing.Size(73, 21);
            this.labelPlatform.TabIndex = 18;
            this.labelPlatform.Text = "Platform:";
            // 
            // richTextBoxExtraInfo
            // 
            this.richTextBoxExtraInfo.Location = new System.Drawing.Point(11, 218);
            this.richTextBoxExtraInfo.Name = "richTextBoxExtraInfo";
            this.richTextBoxExtraInfo.Size = new System.Drawing.Size(560, 150);
            this.richTextBoxExtraInfo.TabIndex = 17;
            this.richTextBoxExtraInfo.Text = "";
            // 
            // textBoxPlatform
            // 
            this.textBoxPlatform.Location = new System.Drawing.Point(171, 48);
            this.textBoxPlatform.Name = "textBoxPlatform";
            this.textBoxPlatform.Size = new System.Drawing.Size(250, 23);
            this.textBoxPlatform.TabIndex = 16;
            // 
            // EditEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.checkBoxShowPassword);
            this.Controls.Add(this.buttonGeneratePassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonEditEntry);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.labelExtraInfo);
            this.Controls.Add(this.labelPlatform);
            this.Controls.Add(this.richTextBoxExtraInfo);
            this.Controls.Add(this.textBoxPlatform);
            this.Name = "EditEntryForm";
            this.Text = "EditEntryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Button buttonGeneratePassword;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonEditEntry;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelExtraInfo;
        private System.Windows.Forms.Label labelPlatform;
        private System.Windows.Forms.RichTextBox richTextBoxExtraInfo;
        private System.Windows.Forms.TextBox textBoxPlatform;
    }
}