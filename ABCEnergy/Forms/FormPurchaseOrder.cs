using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABCEnergy.Forms
{
    public partial class FormPurchaseOrder : Form
    {
        public FormPurchaseOrder()
        {
            InitializeComponent();
            bindData();
        }

        private void FormPurchaseOrder_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColour.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColour.SecondaryColor;
                }
            }
            label4.ForeColor = ThemeColour.SecondaryColor;
            label5.ForeColor = ThemeColour.PrimaryColor;
        }

        private void Label4_Click(object sender, EventArgs e)
        {
           // SqlCommand command = new SqlCommand("update ABCEnergy_PurchaseOrders_ set PurchaseOrderDate = '"+dateTimePicker_POD.Text+"', DeliveryDate = '" + dateTimePicker_DD + "'", con);
        }

        SqlConnection con = new SqlConnection("Data Source=THE_BEAST_00;Initial Catalog=ABCEnergy;Integrated Security=True");

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("insert into ABCEnergy_PurchaseOrders_ values('" + int.Parse(textBox_PON.Text)+ "','" +  DateTime.Parse(dateTimePicker_POD.Text)
                                                                                    + "','" +  DateTime.Parse(dateTimePicker_DD.Text)
                                                                                    + "','" + int.Parse(textBox_Quantity.Text)
                                                                                    + "','" + textBox_Supplier.Text
                                                                                    + "','" + float.Parse(textBox_OrderTotal.Text)
                                                                                    + "','" + comboBox_Approval.Text + "')", con);


            command.ExecuteNonQuery();
            MessageBox.Show("Successfully inserted.");
            con.Close();
            bindData();
        }

        void bindData()
        {
            SqlCommand command = new SqlCommand("select * from ABCEnergy_PurchaseOrders_", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand command = new SqlCommand("update ABCEnergy_PurchaseOrders_ set PurchaseOrderDate = '" + dateTimePicker_POD.Text +
                                                                                             "', DeliveryDate = '" + dateTimePicker_DD.Text + 
                                                                                             "', Quantity = '" + textBox_Quantity.Text +
                                                                                             "', Supplier = '" + textBox_Supplier.Text +
                                                                                             "', OrderTotal = '" + textBox_OrderTotal.Text +
                                                                                             "', Approval = '" + comboBox_Approval.Text +
                                                                                             "', Where PurchaseOrderNumber = '"+ int.Parse(textBox_PON.Text), con);
            command.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Succesfully updated Purchase Order");
            bindData();
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (textBox_PON.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Purchase Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete ABCEnergy_PurchaseOrders_ where PurchaseOrderNumber = '"+int.Parse(textBox_PON.Text)+"'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted purchase order");
                    bindData();
                }
            }
            else
            {
                MessageBox.Show("Requires Purchase Order Number");
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from ABCEnergy_PurchaseOrders_ where PurchaseOrderNumber = '"+int.Parse(textBox_PON.Text)+"'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
