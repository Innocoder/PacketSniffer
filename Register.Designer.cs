namespace PacketSniffer
{
    partial class Register
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
            this.registerHeading = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.rePassword = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordL = new System.Windows.Forms.Label();
            this.passwordLabelLeng = new System.Windows.Forms.Label();
            this.lblBTlogin = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // registerHeading
            // 
            this.registerHeading.AutoSize = true;
            this.registerHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerHeading.Location = new System.Drawing.Point(192, 24);
            this.registerHeading.Name = "registerHeading";
            this.registerHeading.Size = new System.Drawing.Size(100, 25);
            this.registerHeading.TabIndex = 0;
            this.registerHeading.Text = "Register";
            this.registerHeading.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(91, 134);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(45, 16);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            this.name.Click += new System.EventHandler(this.Name_Click);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtName.Location = new System.Drawing.Point(207, 130);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(157, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(207, 180);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(157, 20);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(91, 184);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(42, 16);
            this.email.TabIndex = 3;
            this.email.Text = "Email";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(207, 231);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(157, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(91, 235);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(68, 16);
            this.password.TabIndex = 5;
            this.password.Text = "Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(207, 282);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(157, 20);
            this.txtConfirmPassword.TabIndex = 8;
            this.txtConfirmPassword.TextChanged += new System.EventHandler(this.txtConfirmPassword_TextChanged);
            this.txtConfirmPassword.Leave += new System.EventHandler(this.txtConfirmPassword_Leave);
            // 
            // rePassword
            // 
            this.rePassword.AutoSize = true;
            this.rePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rePassword.Location = new System.Drawing.Point(91, 286);
            this.rePassword.Name = "rePassword";
            this.rePassword.Size = new System.Drawing.Size(116, 16);
            this.rePassword.TabIndex = 7;
            this.rePassword.Text = "Confirm Password";
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(241, 331);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(101, 23);
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(184, 73);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(0, 15);
            this.message.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(241, 369);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 23);
            this.btnLogin.TabIndex = 11;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Red;
            this.emailLabel.Location = new System.Drawing.Point(204, 203);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(0, 13);
            this.emailLabel.TabIndex = 13;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordLabel.Location = new System.Drawing.Point(204, 305);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordLabel.TabIndex = 13;
            // 
            // passwordL
            // 
            this.passwordL.AutoSize = true;
            this.passwordL.Location = new System.Drawing.Point(204, 254);
            this.passwordL.Name = "passwordL";
            this.passwordL.Size = new System.Drawing.Size(0, 13);
            this.passwordL.TabIndex = 14;
            // 
            // passwordLabelLeng
            // 
            this.passwordLabelLeng.AutoSize = true;
            this.passwordLabelLeng.Location = new System.Drawing.Point(204, 254);
            this.passwordLabelLeng.Name = "passwordLabelLeng";
            this.passwordLabelLeng.Size = new System.Drawing.Size(36, 13);
            this.passwordLabelLeng.TabIndex = 15;
            this.passwordLabelLeng.Text = "length";
            this.passwordLabelLeng.Leave += new System.EventHandler(this.passwordLabelLeng_Leave);
            // 
            // lblBTlogin
            // 
            this.lblBTlogin.AutoSize = true;
            this.lblBTlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBTlogin.Location = new System.Drawing.Point(194, 58);
            this.lblBTlogin.Name = "lblBTlogin";
            this.lblBTlogin.Size = new System.Drawing.Size(81, 15);
            this.lblBTlogin.TabIndex = 16;
            this.lblBTlogin.TabStop = true;
            this.lblBTlogin.Text = "Back to LogIn";
            this.lblBTlogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblBTlogin_LinkClicked);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.lblBTlogin);
            this.Controls.Add(this.passwordLabelLeng);
            this.Controls.Add(this.passwordL);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.message);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.rePassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.password);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.name);
            this.Controls.Add(this.registerHeading);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerHeading;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label rePassword;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label passwordL;
        private System.Windows.Forms.Label passwordLabelLeng;
        private System.Windows.Forms.LinkLabel lblBTlogin;
    }
}

