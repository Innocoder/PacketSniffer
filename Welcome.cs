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
    public partial class Welcome : Form
    {
        public static string currentUser = "";
        public Welcome()
        {
            InitializeComponent();
            lblUser.Visible = false;
            panelRequest.Visible = false;
            panelChange.Visible = false;
            lblChangePass.Visible = false;
            lblRequestchange.Visible = false;
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            lblUser.Text = Login.user;
            currentUser = Login.user;
            this.Text = "Welcome " + Login.user;
            lblUser.Visible = true;

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnChangePass_Click(object sender, EventArgs e)
        {
            Color color = Color.FromName("red");

            string snifferConnection = ConfigurationManager.ConnectionStrings["connectionSnifferDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(snifferConnection);
            string sqlQuery = "UPDATE [dbo].[RegisteredUsers] SET UserPassword=@UserPassword WHERE Username='" + currentUser + "'";           
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);

           
            //Check Fields
            if (txtNewPassword.Text != txtConfirmPass.Text)
            {

                lblChangePass.Text = "Passwords Not Matching";
                lblChangePass.ForeColor = color;
                lblChangePass.Visible = true;
                //lblChangePass.Focus();
                //return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text) || string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                lblChangePass.Text = "Fill all Fields";
                lblChangePass.ForeColor = color;
                lblChangePass.Visible = true;
            }

            if (txtNewPassword.Text == txtConfirmPass.Text && !string.IsNullOrWhiteSpace(txtNewPassword.Text) && !string.IsNullOrWhiteSpace(txtConfirmPass.Text))
            {
                //MessageBox.Show("Password Is Not Matching");
                lblChangePass.Visible = false;
            }

            if (!string.IsNullOrWhiteSpace(txtNewPassword.Text) && !string.IsNullOrWhiteSpace(txtConfirmPass.Text)
               && txtNewPassword.Text == txtConfirmPass.Text)
            {
                sqlCmd.Parameters.AddWithValue("@UserPassword", txtNewPassword.Text);
                SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                sqlCmd.ExecuteNonQuery();


                lblChangePass.Text = "Password Changed";
                lblChangePass.ForeColor = Color.FromName("green");
                lblChangePass.Visible = true;
                //if (dt.Rows.Count > 0)
                //{
                //    lblChangePass.Text = "Password Changed";
                //    lblChangePass.ForeColor = Color.FromName("green");
                //    lblChangePass.Visible = true;
                //}
            }

            txtUsername.Text = "";
            txtPassword.Text = "";
            sqlConn.Close();
        }

        private void lblCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelChange.Visible = false;
            panelRequest.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panelRequest.Visible = true;
        }

        private void btnRequestPass_Click(object sender, EventArgs e)
        {
            Color color = Color.FromName("red");

            string snifferConnection = ConfigurationManager.ConnectionStrings["connectionSnifferDB"].ConnectionString;
            SqlConnection sqlConn = new SqlConnection(snifferConnection);
            string sqlQuery = "SELECT * FROM [dbo].[RegisteredUsers] WHERE UserName=@UserName and UserPassword=@UserPassword";
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, sqlConn);
            sqlCmd.Parameters.AddWithValue("@UserName", txtUsername.Text);
            sqlCmd.Parameters.AddWithValue("@UserPassword", txtPassword.Text);
            SqlDataAdapter sda = new SqlDataAdapter(sqlCmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            int rows = sqlCmd.ExecuteNonQuery();

            if(txtUsername.Text != currentUser)
            {
                lblRequestchange.Text = "That's not your Username";
                lblRequestchange.Visible = true;
                lblRequestchange.ForeColor = color;
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                lblRequestchange.Text = "Fill all Fields";
                lblRequestchange.Visible = true;
                lblRequestchange.ForeColor = color;
            }
            else if (dt.Rows.Count > 0)
            {
                panelChange.Visible = true;
                lblRequestchange.Visible = false;
            }
            else
            {
                lblRequestchange.Text = "Invalid Email or Password";
                lblRequestchange.ForeColor = color;
                lblRequestchange.Visible = true;
            }
            txtUsername.Text = "";
            txtPassword.Text = "";
            sqlConn.Close();
        }

        private void btnChangeCancel_Click(object sender, EventArgs e)
        {
            panelRequest.Visible = false;
        }

        private void btnChangePassCancel_Click(object sender, EventArgs e)
        {
            panelChange.Visible = false;
        }
    }
}
