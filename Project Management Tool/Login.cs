using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Management_Tool
{
    public partial class Login : Form
    {
        private string logname;
        static string connStr = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;
        SqlConnection con = new SqlConnection(connStr);

        public Login()
        {
            InitializeComponent();
        }
        private void btblogin_Click(object sender, EventArgs e)
        {
            bool isUserok = false, ispassok = false;
            if (!Authenticate())
            {
                MessageBox.Show("Please Enter Valid Data");
                return;
            }

            string query = "SELECT * FROM user_profile WHERE Username=@uname";
            con.Open();
            SqlCommand scmd = new SqlCommand(query, con);

            scmd.Parameters.Add("@uname", SqlDbType.VarChar);
            scmd.Parameters["@uname"].Value = txtUsername.Text;

            SqlDataReader sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                isUserok = true;
            }
            con.Close();

            con.Open();
            query = "SELECT * FROM user_profile WHERE Username=@uname AND Password=@passcode";
            scmd = new SqlCommand(query, con);


            scmd.Parameters.Add("@uname", SqlDbType.VarChar);
            scmd.Parameters["@uname"].Value = txtUsername.Text;


            scmd.Parameters.Add("@passcode", SqlDbType.VarChar);
            scmd.Parameters["@passcode"].Value = txtPassword.Text;

            sda = scmd.ExecuteReader();

            if (sda.HasRows)
            {
                ispassok = true;
                sda.Read();

                logname = sda.GetString(1);
                sda.Close();
            }

            if (!isUserok)
            {
                MessageBox.Show("User does not exist!");

            }
            else if (isUserok && !ispassok)
            {
                MessageBox.Show("Wrong Password,Try Again.");
            }
            else
            {
                home page = new home();
                page.Show();
                this.Hide();
            }

            con.Close();
        }
        private void lblRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration form2 = new Registration();
            form2.Show();
        }
        private void loginClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );
        private void Login_Load(object sender, EventArgs e)
        {
            LoginPanel.BackColor = Color.FromArgb(50, 0, 0, 0);
            welcomepanel.BackColor = Color.FromArgb(50, 0, 0, 0);
            LoginPanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, LoginPanel.Width, LoginPanel.Height, 30, 30));
            welcomepanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, welcomepanel.Width, welcomepanel.Height, 30, 30));
        }

        bool Authenticate()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
                return false;
            else
                return true;
        }
    }
}
