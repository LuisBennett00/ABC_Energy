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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (name.Text == "" || email.Text == "" || username.Text == "" || password.Text == "")
                MessageBox.Show("Please Enter Mandatory Fields");
            else if (password.Text != passcheck.Text)
                MessageBox.Show("Password does not match");
            else
            {
                using (SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB;
                AttachDbFilename =| DataDirectory |\localDataBase.mdf;
                Integrated Security = True;
                Connect Timeout = 30; "))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UserAdd", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@name", name.Text.Trim());
                    cmd.Parameters.AddWithValue("@streetaddress", streetaddress.Text.Trim());
                    cmd.Parameters.AddWithValue("@postcode", postcode.Text.Trim());
                    cmd.Parameters.AddWithValue("@phone", phone.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email.Text.Trim());
                    cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", password.Text.Trim());
                    cmd.Parameters.AddWithValue("@usertype", "Public");
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account Created Successfully");
                    Clear();
                }
            }
        }
        void Clear()
        {
            name.Text = streetaddress.Text = postcode.Text = phone.Text = email.Text = username.Text = password.Text = passcheck.Text = ""; // Clears data from form once added to db
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit(); //closes the application.
        }

        private void name_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
