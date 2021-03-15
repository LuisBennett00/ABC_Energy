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

/*The Purchase Order Form item code. Here all elements that are used within this page are programmed. This includes code that manipulates the
 data grid view object used to display records of Purchase Orders that have been saved. Through using a number of tools for data input, buttons
 are used to create, read, update and delete purchase orders.*/


namespace ABCEnergy.Forms
{
    public partial class FormPurchaseOrder : Form
    {
        public FormPurchaseOrder()
        {
            InitializeComponent();

            //bindData is called to display current purchase orders saved in the SQL database
            bindData();
        }

        private void FormPurchaseOrder_Load(object sender, EventArgs e)
        {
            //When the form is loaded, themes used for the UI are loaded
            LoadTheme();
        }


        //Load theme uses a for each loop to attain the buttons available in the form and manipulate the appearence to fit the rest of the UI
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


        /*Allow for a connection between the application and the database through a connection string.
         The connection string contains the information that the provider needs to know to establish a connection
         to the database. Connection string is defines due to its constant use throughout functions, these functions
         are accessing the same declaration*/
        SqlConnection con = new SqlConnection("Data Source=THE_BEAST_00;Initial Catalog=ABCEnergy;Integrated Security=True");


        /*Bind data establishes a connection with a specific table within the database. The specific use of bind data in this form fills
         the data view grid with stored information in the database, it is called to refresh values in the database to display values after 
         changes have occured when using the application*/
        void bindData()
        {
            SqlCommand command = new SqlCommand("select * from ABCEnergy_PurchaseOrders_", con);
            SqlDataAdapter sd = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }


        /*This function is called when the insert button within this form is pressed. This function creats and inserts data entered by a user
         into the database.*/
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            //Open and establish a connection with the database
            con.Open();

            /*SqlCommand allows for the combination of SQl and C# to amend the database. Here we use the INSERT command to take the values
             entered by the user in relevant fields, and where neccasry parsing that data to be entered into the database as the correct
             datatypes.*/
            SqlCommand command = new SqlCommand("insert into ABCEnergy_PurchaseOrders_ values('" + int.Parse(textBox_PON.Text)+ "','" +  DateTime.Parse(dateTimePicker_POD.Text)
                                                                                    + "','" +  DateTime.Parse(dateTimePicker_DD.Text)
                                                                                    + "','" + int.Parse(textBox_Quantity.Text)
                                                                                    + "','" + textBox_Supplier.Text
                                                                                    + "','" + float.Parse(textBox_OrderTotal.Text)
                                                                                    + "','" + comboBox_Approval.Text + "')", con);

            //The query is executed
            command.ExecuteNonQuery();

            //Alert the user of successfull database insertion
            MessageBox.Show("Successfully inserted.");

            //close the connection as it is no longer needed
            con.Close();

            //call bindData to update and display the data view with the new inserted data
            bindData();
        }

        /*Function is called when the update button is clicked. Based on the purchase order which is used a unique identifier,
         a purchase order record is allowed to be updated base on the users input*/
        private void Btn_update_Click(object sender, EventArgs e)
        {
            //Open and establish a connection with the database
            con.Open();

            /*SqlCommand used to declare a query with C# variables. Here an "UPDATE SET WHERE" qeury is formulated. Based on existing variables,
             the table is updated setting current collumns equal to the variables in this form. These collumns are identified using the 
             Purchase Order Number as the unique identifier*/
            SqlCommand cmd = new SqlCommand("Update ABCEnergy_PurchaseOrders_ set PurchaseOrderDate=@PurchaseOrderDate, Quantity = @Quantity, Supplier = @Supplier, OrderTotal = @OrderTotal, Approval = @Approval WHERE PurchaseOrderNumber = @PurchaseOrderNumber", con);

            /*Where needed, parsing the relevant information and assinging them in the sqlcommand string to set its respective ocject in the 
             database*/
            cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
            cmd.Parameters.AddWithValue("@PurchaseOrderDate",   DateTime.Parse(dateTimePicker_POD.Text));
            cmd.Parameters.AddWithValue("@DeliveryDate",        DateTime.Parse(dateTimePicker_DD.Text));
            cmd.Parameters.AddWithValue("@Quantity",            int.Parse(textBox_Quantity.Text));
            cmd.Parameters.AddWithValue("@Supplier",            textBox_Supplier.Text);
            cmd.Parameters.AddWithValue("@OrderTotal",          float.Parse(textBox_OrderTotal.Text));
            cmd.Parameters.AddWithValue("@Approval",            comboBox_Approval.Text);

            //The query is executed
            cmd.ExecuteNonQuery();

            //Alert the user of successfully updating the database
            MessageBox.Show("Successfully Updated");

            //close the connection as it is no longer needed
            con.Close();

            //call bindData to update and display the data view with the new inserted data
            bindData();
        }


        /*Delete Purchase Order function. Allows for the deletion of a purchase order record given the Purchase Order Number
         used as the unique identifer.*/
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            //Statement checks to ensure a Purchase Order Number is entered. If so then delete the record otherwise alert the user of an error
            if (textBox_PON.Text != "")
            {
                /*Check to ensure the user wants to delete the purchase order. Message box is used to carry out this question.
                 If yes then delete the record, otherwise leave it.*/
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Purchase Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //Open and establish a connection with the database
                    con.Open();

                    //Using a DELETE WHERE sql command to identify the record linked with the purchase order number
                    SqlCommand command = new SqlCommand("Delete ABCEnergy_PurchaseOrders_ where PurchaseOrderNumber = '"+int.Parse(textBox_PON.Text)+"'", con);

                    //The query is executed
                    command.ExecuteNonQuery();

                    //close the connection as it is no longer needed
                    con.Close();

                    //Alert the user of successfully deletion
                    MessageBox.Show("Successfully deleted purchase order");

                    //call bindData to update and display the data view with the new inserted data
                    bindData();
                }
            }
            else
            {
                MessageBox.Show("Requires Purchase Order Number");
            }
        }


        //Function to search specific purchase orders based on Purchase Order Number
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
