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

namespace ABCEnergy
{
    //Log in for Public user is   Username = publicuser    Password = pubpass     Usertype = Public
    //Log in for Staff user is    Username = staffuser     Password = staffpass   Usertype = Staff
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\ABCEnergy.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userType.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection();

        private void logButton_Click(object sender, EventArgs e)
        {
            //Connects to Sql Server. To change server replace everything within quotation marks with your connection string located within: Server Explorer tab> Data Connections>[your pc\sqlexpress.abclogin.dbo]>Properties>Connection String.
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from Users where username='" + userInput.Text + "' and password='" + passInput.Text + "'", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            string userTypeValue = userType.SelectedItem.ToString();

            if (dt.Rows.Count > 0)
            {
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["usertype"].ToString() == userTypeValue) //"usertype" could be changed to 2 as we only have 2 types of users. with "usertypes" easily scalable to add new users, e.g admin, HR, despatch.
                    {
                        MessageBox.Show("Logged in successfully as "+dt.Rows[i]["usertype"]);
                        if(userType.SelectedIndex == 0) //0 is Public in the userType Combobox
                        {
                            Form1 a = new Form1();
                            a.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form1 b = new Form1();  
                            b.Show();
                            this.Hide();
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }
            con.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Would be implemented in final product, used to demonstrate UI for prototype.
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }

        private void createaccount_Click(object sender, EventArgs e)
        {
            CreateAccount a = new CreateAccount();
            a.Show();
            this.Hide();
        }

        private void showPassCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassCheck.Checked == true)
            {
                passInput.UseSystemPasswordChar = false;
            }
            else
            {
                passInput.UseSystemPasswordChar = true;
            }
        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
