namespace PhotoAlbum
{
    partial class Login
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
            this.loginViewPanel = new System.Windows.Forms.Panel();
            this.signinNotifyLabel = new System.Windows.Forms.Label();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.signinPassword = new System.Windows.Forms.TextBox();
            this.signinUsername = new System.Windows.Forms.TextBox();
            this.createAccountPanel = new System.Windows.Forms.Panel();
            this.signupErrorLabel = new System.Windows.Forms.Label();
            this.signupBackButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.signupEmail = new System.Windows.Forms.TextBox();
            this.signupPassword = new System.Windows.Forms.TextBox();
            this.signupUsername = new System.Windows.Forms.TextBox();
            this.signupName = new System.Windows.Forms.TextBox();
            this.loginViewPanel.SuspendLayout();
            this.createAccountPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginViewPanel
            // 
            this.loginViewPanel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loginViewPanel.Controls.Add(this.signinNotifyLabel);
            this.loginViewPanel.Controls.Add(this.forgotPasswordButton);
            this.loginViewPanel.Controls.Add(this.signUpButton);
            this.loginViewPanel.Controls.Add(this.signInButton);
            this.loginViewPanel.Controls.Add(this.label3);
            this.loginViewPanel.Controls.Add(this.label1);
            this.loginViewPanel.Controls.Add(this.signinPassword);
            this.loginViewPanel.Controls.Add(this.signinUsername);
            this.loginViewPanel.Location = new System.Drawing.Point(0, 2);
            this.loginViewPanel.Name = "loginViewPanel";
            this.loginViewPanel.Size = new System.Drawing.Size(1172, 731);
            this.loginViewPanel.TabIndex = 0;
            this.loginViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.loginViewPanel_Paint);
            // 
            // signinNotifyLabel
            // 
            this.signinNotifyLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinNotifyLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.signinNotifyLabel.Location = new System.Drawing.Point(337, 360);
            this.signinNotifyLabel.Name = "signinNotifyLabel";
            this.signinNotifyLabel.Size = new System.Drawing.Size(494, 38);
            this.signinNotifyLabel.TabIndex = 15;
            this.signinNotifyLabel.Text = "label7";
            this.signinNotifyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signinNotifyLabel.Visible = false;
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordButton.AutoSize = true;
            this.forgotPasswordButton.BackColor = System.Drawing.Color.DarkOrange;
            this.forgotPasswordButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.forgotPasswordButton.FlatAppearance.BorderSize = 2;
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.forgotPasswordButton.Location = new System.Drawing.Point(57, 559);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(209, 36);
            this.forgotPasswordButton.TabIndex = 14;
            this.forgotPasswordButton.Text = "Forgot Something?";
            this.forgotPasswordButton.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            this.signUpButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signUpButton.AutoSize = true;
            this.signUpButton.BackColor = System.Drawing.Color.DarkOrange;
            this.signUpButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signUpButton.FlatAppearance.BorderSize = 2;
            this.signUpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signUpButton.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signUpButton.Location = new System.Drawing.Point(907, 559);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(209, 36);
            this.signUpButton.TabIndex = 13;
            this.signUpButton.Text = "Create an Account";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signInButton.AutoSize = true;
            this.signInButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.signInButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signInButton.FlatAppearance.BorderSize = 2;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signInButton.Location = new System.Drawing.Point(476, 432);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(216, 39);
            this.signInButton.TabIndex = 12;
            this.signInButton.Text = "SignIn";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label3.Location = new System.Drawing.Point(472, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label1.Location = new System.Drawing.Point(473, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Username";
            // 
            // signinPassword
            // 
            this.signinPassword.AcceptsReturn = true;
            this.signinPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinPassword.Location = new System.Drawing.Point(476, 306);
            this.signinPassword.Name = "signinPassword";
            this.signinPassword.PasswordChar = '*';
            this.signinPassword.Size = new System.Drawing.Size(216, 29);
            this.signinPassword.TabIndex = 9;
            this.signinPassword.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            this.signinPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.signinPassword_KeyDown);
            // 
            // signinUsername
            // 
            this.signinUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signinUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signinUsername.Location = new System.Drawing.Point(476, 247);
            this.signinUsername.Name = "signinUsername";
            this.signinUsername.Size = new System.Drawing.Size(216, 29);
            this.signinUsername.TabIndex = 8;
            this.signinUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // createAccountPanel
            // 
            this.createAccountPanel.Controls.Add(this.signupErrorLabel);
            this.createAccountPanel.Controls.Add(this.signupBackButton);
            this.createAccountPanel.Controls.Add(this.label6);
            this.createAccountPanel.Controls.Add(this.createAccount);
            this.createAccountPanel.Controls.Add(this.label5);
            this.createAccountPanel.Controls.Add(this.label4);
            this.createAccountPanel.Controls.Add(this.label2);
            this.createAccountPanel.Controls.Add(this.signupEmail);
            this.createAccountPanel.Controls.Add(this.signupPassword);
            this.createAccountPanel.Controls.Add(this.signupUsername);
            this.createAccountPanel.Controls.Add(this.signupName);
            this.createAccountPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.createAccountPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.createAccountPanel.Name = "createAccountPanel";
            this.createAccountPanel.Size = new System.Drawing.Size(1176, 737);
            this.createAccountPanel.TabIndex = 1;
            this.createAccountPanel.Visible = false;
            // 
            // signupErrorLabel
            // 
            this.signupErrorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupErrorLabel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signupErrorLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signupErrorLabel.CausesValidation = false;
            this.signupErrorLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.signupErrorLabel.Location = new System.Drawing.Point(384, 434);
            this.signupErrorLabel.Name = "signupErrorLabel";
            this.signupErrorLabel.Size = new System.Drawing.Size(407, 25);
            this.signupErrorLabel.TabIndex = 19;
            this.signupErrorLabel.Text = "temp this is  a temporary error!! ";
            this.signupErrorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.signupErrorLabel.Visible = false;
            this.signupErrorLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // signupBackButton
            // 
            this.signupBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupBackButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signupBackButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkTurquoise;
            this.signupBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupBackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupBackButton.ForeColor = System.Drawing.Color.DarkOrange;
            this.signupBackButton.Location = new System.Drawing.Point(12, 12);
            this.signupBackButton.Name = "signupBackButton";
            this.signupBackButton.Size = new System.Drawing.Size(173, 58);
            this.signupBackButton.TabIndex = 18;
            this.signupBackButton.Text = "<--  Back";
            this.signupBackButton.UseVisualStyleBackColor = false;
            this.signupBackButton.Click += new System.EventHandler(this.signupBackButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label6.Location = new System.Drawing.Point(473, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 22);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // createAccount
            // 
            this.createAccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccount.AutoSize = true;
            this.createAccount.BackColor = System.Drawing.Color.DarkOrange;
            this.createAccount.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.createAccount.FlatAppearance.BorderSize = 2;
            this.createAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createAccount.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccount.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.createAccount.Location = new System.Drawing.Point(384, 492);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(407, 36);
            this.createAccount.TabIndex = 15;
            this.createAccount.Text = "Create  Account";
            this.createAccount.UseVisualStyleBackColor = false;
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label5.Location = new System.Drawing.Point(473, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 13;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label4.Location = new System.Drawing.Point(473, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "Username";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.label2.Location = new System.Drawing.Point(473, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name";
            // 
            // signupEmail
            // 
            this.signupEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupEmail.BackColor = System.Drawing.SystemColors.Window;
            this.signupEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupEmail.Location = new System.Drawing.Point(477, 157);
            this.signupEmail.Name = "signupEmail";
            this.signupEmail.Size = new System.Drawing.Size(216, 29);
            this.signupEmail.TabIndex = 16;
            this.signupEmail.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // signupPassword
            // 
            this.signupPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupPassword.Location = new System.Drawing.Point(477, 387);
            this.signupPassword.Name = "signupPassword";
            this.signupPassword.PasswordChar = '*';
            this.signupPassword.Size = new System.Drawing.Size(216, 29);
            this.signupPassword.TabIndex = 14;
            // 
            // signupUsername
            // 
            this.signupUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupUsername.Location = new System.Drawing.Point(477, 310);
            this.signupUsername.Name = "signupUsername";
            this.signupUsername.Size = new System.Drawing.Size(216, 29);
            this.signupUsername.TabIndex = 10;
            // 
            // signupName
            // 
            this.signupName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupName.Location = new System.Drawing.Point(477, 236);
            this.signupName.Name = "signupName";
            this.signupName.Size = new System.Drawing.Size(216, 29);
            this.signupName.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1176, 737);
            this.Controls.Add(this.loginViewPanel);
            this.Controls.Add(this.createAccountPanel);
            this.Name = "Login";
            this.Text = "Photo Album";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.loginViewPanel.ResumeLayout(false);
            this.loginViewPanel.PerformLayout();
            this.createAccountPanel.ResumeLayout(false);
            this.createAccountPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginViewPanel;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox signinPassword;
        private System.Windows.Forms.TextBox signinUsername;
        private System.Windows.Forms.Panel createAccountPanel;
        private System.Windows.Forms.Button createAccount;
        private System.Windows.Forms.TextBox signupPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox signupUsername;
        private System.Windows.Forms.TextBox signupName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox signupEmail;
        private System.Windows.Forms.Button signupBackButton;
        private System.Windows.Forms.Label signupErrorLabel;
        private System.Windows.Forms.Label signinNotifyLabel;

    }
}

