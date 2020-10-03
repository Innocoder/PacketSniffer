using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Threading;
using System.Text.RegularExpressions;


namespace PacketSniffer
{
    public partial class Register : Form
    {
        public static string user = "";
        public Register()
        {
            InitializeComponent();
            btnLogin.Visible = false;
            passwordLabelLeng.Visible = false;
            message.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void Name_Click(object sender, EventArgs e)
        {

        }


            private void btnRegister_Click(object sender, EventArgs e)
        {

            string snifferConnection = ConfigurationManager.ConnectionStrings["connectionSnifferDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(snifferConnection);

            //Check if email exist in DB
            if (checkUserExist(txtName.Text))
            {
                message.Text = "Username already registered";
                message.Visible = true;
                message.ForeColor = Color.FromName("red");
            }

            string sqlQuery = "INSERT INTO [dbo].[RegisteredUsers] VALUES (@UserName, @UserEmail, @UserPassword)";
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);

            string email = txtEmail.Text;
            string name = txtName.Text;
            string password = txtPassword.Text;
            string comfirmPassword = txtConfirmPassword.Text;

            Color green = Color.FromName("green");
            Color red = Color.FromName("red");

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password)
                 || string.IsNullOrWhiteSpace(comfirmPassword))
            {
                message.Text = "Fill All Fields";
                message.Visible = true;
                message.ForeColor = red;
                btnLogin.Visible = false;
            }
            else if(!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(password)
                 && !string.IsNullOrWhiteSpace(comfirmPassword) && validEmail(email) && !checkUserExist(name) 
                 && password == comfirmPassword)
            {
                

                //Border textbox
                sqlCmd.Parameters.AddWithValue("@UserName", name);
                sqlCmd.Parameters.AddWithValue("@UserEmail", email);
                sqlCmd.Parameters.AddWithValue("@UserPassword", password);
                //Cryptography.Encrypt(password.ToString())
                int i = sqlCmd.ExecuteNonQuery();

                if (i != 0)
                {
                    message.Text = "Registered Successfully";
                    message.Visible = true;
                    btnLogin.Visible = true;
                    message.ForeColor = green;

                }

            }
            sqlConn.Close();
        }

        private bool checkUserExist(string user)
        {
            string snifferConnection = ConfigurationManager.ConnectionStrings["connectionSnifferDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(snifferConnection);
            string sqlQuery = "SELECT * FROM [dbo].[RegisteredUsers] WHERE UserName=@UserName";
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
            sqlCmd.Parameters.AddWithValue("@UserName", user);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int rows = sqlCmd.ExecuteNonQuery();
            if (dt.Rows.Count > 0)
            {
                sqlConn.Close();
                return true;
            }
            else
            {   sqlConn.Close();
                return false;
            }
            
        }
    

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            Color red = Color.FromName("red");

            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                //MessageBox.Show("Password Is Not Matching");
                passwordLabel.Visible = true;
                passwordLabel.Text = "Passwords Not Matching";
                passwordLabel.ForeColor = red;
                txtConfirmPassword.Focus();
                return;
            }
            else
            {
                passwordLabel.Visible = false;
                passwordLabel.Text = "";
            }
        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            
        }

        private bool validEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (reg.IsMatch(email))
                {
                    return true;
                }
            }
            return false;
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!validEmail(txtEmail.Text))
                {
                    emailLabel.Text = "Invalid Email";
                    emailLabel.Visible = true;
                }
                else
                {
                    emailLabel.Text = "";
                    emailLabel.Visible = false;
                }
            }
        }

        private void passwordLabelLeng_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            Color red = Color.FromName("red");

            if (txtPassword.Text.Length < 6)
            {
                passwordLabelLeng.Text = "Password must be 6 or more characters";
                passwordLabelLeng.Visible = true;
                passwordLabelLeng.ForeColor = red;
                txtPassword.Focus();
            }
            else
            {
                passwordLabelLeng.Visible = false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Redirect to login
            user = txtEmail.Text;
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void lblBTlogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
