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
    public partial class FormQuotes : Form
    {
        public FormQuotes()
        {
            InitializeComponent();
            bindData();
            //LoadTheme();
        }

        private void FormQuotes_Load(object sender, EventArgs e)
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
           // label4.ForeColor = ThemeColour.SecondaryColor;
           // label5.ForeColor = ThemeColour.PrimaryColor;
        }

        SqlConnection con = new SqlConnection("Data Source=THE_BEAST_00;Initial Catalog=ABCEnergy;Integrated Security=True");
        Random rnd = new Random();
        DateTime localDate = new DateTime(2021, 03, 03);
        String QTapproved = "Approved";
        String QTUnapproved = "Un-approved";

        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }


        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            int orderTotalRan = rnd.Next(1, 1000);
            int POGenerator = rnd.Next(1, 1000);
            int INGenerator = rnd.Next(1, 1000);

            String body = "\nQuote proposed is:\n" + "Supplier Name: "+ textBox_Supplier.Text
                                                                                    + "\n" + "Item: " + textBox_Item.Text
                                                                                    + "\n" + "Quantity: " + textBox_Quantity.Text
                                                                                    + "\n" + "Delivery Date: " + dateTimePicker_DD.Text
                                                                                    + "\n" + "Purchase Order Number: " + POGenerator
                                                                                    + "\n" + "Invoive Number: " + INGenerator
                                                                                    + "\n" + "Date and time of order: " + localDate
                                                                                    + "\n" + "Grand Total(GBP): " + orderTotalRan + "\nDo you want to accept this quote?";

            if (MessageBox.Show(body, "Quote", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into ABCEnergy_Quotes values('" + textBox_Supplier.Text
                                                                                        + "','" + textBox_Item.Text
                                                                                        + "','" + int.Parse(textBox_Quantity.Text)
                                                                                        //+ "','" + DateTime.Parse(dateTimePicker_DD.Text)
                                                                                        + "','" + POGenerator
                                                                                        + "','" + INGenerator
                                                                                        + "','" + localDate
                                                                                        + "','" + orderTotalRan
                                                                                        + "','" + QTapproved
                                                                                        + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Quote Saved.");
                con.Close();
                bindData();

            }
            else
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into ABCEnergy_Quotes values('" + textBox_Supplier.Text
                                                                                        + "','" + textBox_Item.Text
                                                                                        + "','" + int.Parse(textBox_Quantity.Text)
                                                                                        //+ "','" + DateTime.Parse(dateTimePicker_DD.Text)
                                                                                        + "','" + POGenerator
                                                                                        + "','" + INGenerator
                                                                                        + "','" + localDate
                                                                                        + "','" + orderTotalRan
                                                                                        + "','" + QTUnapproved
                                                                                        + "')", con);
                command.ExecuteNonQuery();
                MessageBox.Show("Quote Saved.");
                con.Close();
                bindData();
            }
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_delete_Click(object sender, EventArgs e)
        {
            
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            
        }

        void bindData()
        {
            SqlCommand command = new SqlCommand("select * from ABCEnergy_Quotes", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView_quote.DataSource = dt;
        }

        private void Btn_update_Click_1(object sender, EventArgs e)
        {
            String body = "Would you like to amend approval on quote with Purchase Order Number: " + textBox_PON.Text + " and Invoice Number: " + textBox_IN.Text + "\n";

            if (MessageBox.Show(body, "Ammend Quote Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update ABCEnergy_Quotes set QuoteApproval = @QuoteApproval WHERE PurchaseOrderNumber = @PurchaseOrderNumber", con);
                cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
                cmd.Parameters.AddWithValue("@QuoteApproval", QTapproved);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updated");
                bindData();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Update ABCEnergy_Quotes set QuoteApproval = @QuoteApproval WHERE PurchaseOrderNumber = @PurchaseOrderNumber AND InvoiceNumber =@InvoiceNumber", con);
                cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
                cmd.Parameters.AddWithValue("@InvoiceNumber", int.Parse(textBox_IN.Text));
                cmd.Parameters.AddWithValue("@QuoteApproval", QTUnapproved);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Successfully Updated");
                bindData();
            }
        }

        private void Btn_delete_Click_1(object sender, EventArgs e)
        {
            if (textBox_PON.Text != "")
            {
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Purchase Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand command = new SqlCommand("Delete ABCEnergy_Quotes where PurchaseOrderNumber = '" + int.Parse(textBox_PON.Text) + "' AND InvoiceNumber = '"+ int.Parse(textBox_IN.Text) +"'", con);
                    command.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Successfully deleted purchase order");
                    bindData();
                }
            }
            else
            {
                MessageBox.Show("Requires Purchase Order Number and Invoice Number");
            }
        }

        private void Btn_Search_Click_1(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from ABCEnergy_Quotes where PurchaseOrderNumber = '" + int.Parse(textBox_PON.Text) + "' AND InvoiceNumber = '" + int.Parse(textBox_IN.Text) + "'", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView_quote.DataSource = dt;
        }
    }
}
