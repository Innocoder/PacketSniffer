namespace PacketSniffer
{
    partial class Welcome
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
            this.lblUser = new System.Windows.Forms.Label();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.linkChangePass = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelChange = new System.Windows.Forms.Panel();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkCancel = new System.Windows.Forms.LinkLabel();
            this.panelRequest = new System.Windows.Forms.Panel();
            this.lblRequestchange = new System.Windows.Forms.Label();
            this.lblChangePass = new System.Windows.Forms.Label();
            this.btnRequestPass = new System.Windows.Forms.Button();
            this.btnChangeCancel = new System.Windows.Forms.Button();
            this.btnChangePassCancel = new System.Windows.Forms.Button();
            this.panelChange.SuspendLayout();
            this.panelRequest.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(31, 19);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(34, 16);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "user";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(667, 12);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnLogOut.TabIndex = 2;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // linkChangePass
            // 
            this.linkChangePass.AutoSize = true;
            this.linkChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkChangePass.Location = new System.Drawing.Point(350, 20);
            this.linkChangePass.Name = "linkChangePass";
            this.linkChangePass.Size = new System.Drawing.Size(107, 15);
            this.linkChangePass.TabIndex = 3;
            this.linkChangePass.TabStop = true;
            this.linkChangePass.Text = "Change Password";
            this.linkChangePass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "New Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password";
            // 
            // panelChange
            // 
            this.panelChange.Controls.Add(this.btnChangePassCancel);
            this.panelChange.Controls.Add(this.lblChangePass);
            this.panelChange.Controls.Add(this.txtConfirmPass);
            this.panelChange.Controls.Add(this.txtNewPassword);
            this.panelChange.Controls.Add(this.btnChangePass);
            this.panelChange.Controls.Add(this.label4);
            this.panelChange.Controls.Add(this.label3);
            this.panelChange.Location = new System.Drawing.Point(235, 202);
            this.panelChange.Name = "panelChange";
            this.panelChange.Size = new System.Drawing.Size(364, 148);
            this.panelChange.TabIndex = 5;
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(144, 112);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(80, 23);
            this.btnChangePass.TabIndex = 5;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(117, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(217, 20);
            this.txtUsername.TabIndex = 6;
            this.txtUsername.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(144, 34);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(206, 20);
            this.txtNewPassword.TabIndex = 6;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(144, 77);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(206, 20);
            this.txtConfirmPass.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(217, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(0, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(0, 13);
            this.linkLabel2.TabIndex = 7;
            // 
            // linkCancel
            // 
            this.linkCancel.AutoSize = true;
            this.linkCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCancel.Location = new System.Drawing.Point(486, 20);
            this.linkCancel.Name = "linkCancel";
            this.linkCancel.Size = new System.Drawing.Size(45, 15);
            this.linkCancel.TabIndex = 8;
            this.linkCancel.TabStop = true;
            this.linkCancel.Text = "Cancel";
            this.linkCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCancel_LinkClicked);
            // 
            // panelRequest
            // 
            this.panelRequest.Controls.Add(this.btnChangeCancel);
            this.panelRequest.Controls.Add(this.btnRequestPass);
            this.panelRequest.Controls.Add(this.lblRequestchange);
            this.panelRequest.Controls.Add(this.label1);
            this.panelRequest.Controls.Add(this.label5);
            this.panelRequest.Controls.Add(this.txtUsername);
            this.panelRequest.Controls.Add(this.txtPassword);
            this.panelRequest.Location = new System.Drawing.Point(236, 48);
            this.panelRequest.Name = "panelRequest";
            this.panelRequest.Size = new System.Drawing.Size(363, 148);
            this.panelRequest.TabIndex = 9;
            // 
            // lblRequestchange
            // 
            this.lblRequestchange.AutoSize = true;
            this.lblRequestchange.Location = new System.Drawing.Point(140, 12);
            this.lblRequestchange.Name = "lblRequestchange";
            this.lblRequestchange.Size = new System.Drawing.Size(35, 13);
            this.lblRequestchange.TabIndex = 7;
            this.lblRequestchange.Text = "label2";
            // 
            // lblChangePass
            // 
            this.lblChangePass.AutoSize = true;
            this.lblChangePass.Location = new System.Drawing.Point(141, 9);
            this.lblChangePass.Name = "lblChangePass";
            this.lblChangePass.Size = new System.Drawing.Size(35, 13);
            this.lblChangePass.TabIndex = 7;
            this.lblChangePass.Text = "label2";
            // 
            // btnRequestPass
            // 
            this.btnRequestPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestPass.Location = new System.Drawing.Point(117, 113);
            this.btnRequestPass.Name = "btnRequestPass";
            this.btnRequestPass.Size = new System.Drawing.Size(75, 23);
            this.btnRequestPass.TabIndex = 8;
            this.btnRequestPass.Text = "Request";
            this.btnRequestPass.UseVisualStyleBackColor = true;
            this.btnRequestPass.Click += new System.EventHandler(this.btnRequestPass_Click);
            // 
            // btnChangeCancel
            // 
            this.btnChangeCancel.Location = new System.Drawing.Point(259, 113);
            this.btnChangeCancel.Name = "btnChangeCancel";
            this.btnChangeCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChangeCancel.TabIndex = 9;
            this.btnChangeCancel.Text = "Cancel";
            this.btnChangeCancel.UseVisualStyleBackColor = true;
            this.btnChangeCancel.Click += new System.EventHandler(this.btnChangeCancel_Click);
            // 
            // btnChangePassCancel
            // 
            this.btnChangePassCancel.Location = new System.Drawing.Point(260, 111);
            this.btnChangePassCancel.Name = "btnChangePassCancel";
            this.btnChangePassCancel.Size = new System.Drawing.Size(75, 23);
            this.btnChangePassCancel.TabIndex = 8;
            this.btnChangePassCancel.Text = "Cancel";
            this.btnChangePassCancel.UseVisualStyleBackColor = true;
            this.btnChangePassCancel.Click += new System.EventHandler(this.btnChangePassCancel_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 450);
            this.Controls.Add(this.panelRequest);
            this.Controls.Add(this.linkCancel);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.panelChange);
            this.Controls.Add(this.linkChangePass);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.lblUser);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.panelChange.ResumeLayout(false);
            this.panelChange.PerformLayout();
            this.panelRequest.ResumeLayout(false);
            this.panelRequest.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.LinkLabel linkChangePass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelChange;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkCancel;
        private System.Windows.Forms.Panel panelRequest;
        private System.Windows.Forms.Label lblChangePass;
        private System.Windows.Forms.Label lblRequestchange;
        private System.Windows.Forms.Button btnRequestPass;
        private System.Windows.Forms.Button btnChangeCancel;
        private System.Windows.Forms.Button btnChangePassCancel;
    }
}