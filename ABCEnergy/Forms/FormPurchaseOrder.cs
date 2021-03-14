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
        }

        private void Label4_Click(object sender, EventArgs e)
        {

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
            SqlCommand cmd = new SqlCommand("Update ABCEnergy_PurchaseOrders_ set PurchaseOrderDate=@PurchaseOrderDate, Quantity = @Quantity, Supplier = @Supplier, OrderTotal = @OrderTotal, Approval = @Approval WHERE PurchaseOrderNumber = @PurchaseOrderNumber", con);
            cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
            cmd.Parameters.AddWithValue("@PurchaseOrderDate",   DateTime.Parse(dateTimePicker_POD.Text));
            cmd.Parameters.AddWithValue("@DeliveryDate",        DateTime.Parse(dateTimePicker_DD.Text));
            cmd.Parameters.AddWithValue("@Quantity",            int.Parse(textBox_Quantity.Text));
            cmd.Parameters.AddWithValue("@Supplier",            textBox_Supplier.Text);
            cmd.Parameters.AddWithValue("@OrderTotal",          float.Parse(textBox_OrderTotal.Text));
            cmd.Parameters.AddWithValue("@Approval",            comboBox_Approval.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Successfully Updated");
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

        private void TextBox_OrderTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox_Approval_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_DD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker_POD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_Quantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_PON_TextChanged(object sender, EventArgs e)
        {

        }

        private void PO_label_editor_Click(object sender, EventArgs e)
        {

        }
    }
}
