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

namespace PacketSniffer
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            lblLoginMessage.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string user = "";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            Color color = Color.FromName("red");

            string snifferConnection = ConfigurationManager.ConnectionStrings["connectionSnifferDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(snifferConnection);
            string sqlQuery = "SELECT * FROM [dbo].[RegisteredUsers] WHERE UserName=@UserName and UserPassword=@UserPassword";
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
            sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            sqlCmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
            //Cryptography.Decrypt(txtPassword.Text.ToString())
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int rows = sqlCmd.ExecuteNonQuery();
            if(dt.Rows.Count > 0)
            {
                user = txtUsername.Text;
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }
            if(string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblLoginMessage.Text = "Fill all Fields";
                lblLoginMessage.Visible = true;
                lblLoginMessage.ForeColor = color;
            }
            else
            {
                lblLoginMessage.Text = "Invalid Email or Password";
                lblLoginMessage.ForeColor = color;
                lblLoginMessage.Visible = true;
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}
