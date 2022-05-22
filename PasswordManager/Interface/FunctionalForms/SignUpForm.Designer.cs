
namespace Interface
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxTelephone = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelephone = new System.Windows.Forms.Label();
            this.labelPassword1 = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.pictureBoxMainLogo = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelFeedback = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(399, 315);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(239, 23);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(399, 374);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(239, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.Location = new System.Drawing.Point(399, 432);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.Size = new System.Drawing.Size(239, 23);
            this.textBoxPassword1.TabIndex = 3;
            this.textBoxPassword1.UseSystemPasswordChar = true;
            // 
            // textBoxTelephone
            // 
            this.textBoxTelephone.Location = new System.Drawing.Point(399, 403);
            this.textBoxTelephone.Name = "textBoxTelephone";
            this.textBoxTelephone.Size = new System.Drawing.Size(239, 23);
            this.textBoxTelephone.TabIndex = 2;
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.Location = new System.Drawing.Point(399, 461);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.Size = new System.Drawing.Size(239, 23);
            this.textBoxPassword2.TabIndex = 4;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(285, 315);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 23);
            this.labelName.TabIndex = 5;
            this.labelName.Text = "Name";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(285, 374);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(58, 23);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "e-mail";
            // 
            // labelTelephone
            // 
            this.labelTelephone.AutoSize = true;
            this.labelTelephone.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTelephone.Location = new System.Drawing.Point(273, 403);
            this.labelTelephone.Name = "labelTelephone";
            this.labelTelephone.Size = new System.Drawing.Size(88, 23);
            this.labelTelephone.TabIndex = 7;
            this.labelTelephone.Text = "Telephone";
            // 
            // labelPassword1
            // 
            this.labelPassword1.AutoSize = true;
            this.labelPassword1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword1.Location = new System.Drawing.Point(273, 432);
            this.labelPassword1.Name = "labelPassword1";
            this.labelPassword1.Size = new System.Drawing.Size(80, 23);
            this.labelPassword1.TabIndex = 8;
            this.labelPassword1.Text = "Password";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword2.Location = new System.Drawing.Point(252, 461);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(139, 23);
            this.labelPassword2.TabIndex = 9;
            this.labelPassword2.Text = "Repeat password";
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.Location = new System.Drawing.Point(603, 511);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(75, 23);
            this.buttonSignUp.TabIndex = 10;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.UseVisualStyleBackColor = true;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(248, 511);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(75, 23);
            this.buttonClearFields.TabIndex = 11;
            this.buttonClearFields.Text = "Clear Fields";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // pictureBoxMainLogo
            // 
            this.pictureBoxMainLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMainLogo.Image")));
            this.pictureBoxMainLogo.Location = new System.Drawing.Point(248, 12);
            this.pictureBoxMainLogo.Name = "pictureBoxMainLogo";
            this.pictureBoxMainLogo.Size = new System.Drawing.Size(430, 271);
            this.pictureBoxMainLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMainLogo.TabIndex = 12;
            this.pictureBoxMainLogo.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelUsername.Location = new System.Drawing.Point(273, 345);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 23);
            this.labelUsername.TabIndex = 14;
            this.labelUsername.Text = "Username";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(399, 345);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(239, 23);
            this.textBoxUsername.TabIndex = 13;
            // 
            // labelFeedback
            // 
            this.labelFeedback.AutoSize = true;
            this.labelFeedback.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFeedback.Location = new System.Drawing.Point(399, 511);
            this.labelFeedback.Name = "labelFeedback";
            this.labelFeedback.Size = new System.Drawing.Size(0, 13);
            this.labelFeedback.TabIndex = 15;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.labelFeedback);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.pictureBoxMainLogo);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.labelPassword1);
            this.Controls.Add(this.labelTelephone);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.textBoxTelephone);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMainLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxTelephone;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelephone;
        private System.Windows.Forms.Label labelPassword1;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Button buttonSignUp;
        private System.Windows.Forms.Button buttonClearFields;
        private System.Windows.Forms.PictureBox pictureBoxMainLogo;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelFeedback;
    }
}