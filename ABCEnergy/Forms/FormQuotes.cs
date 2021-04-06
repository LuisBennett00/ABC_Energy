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
using System.Globalization;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;

namespace ABCEnergy.Forms
{
    public partial class FormQuotes : Form
    {
        //Global Variables
        Random rnd = new Random();
        DateTime localDate = new DateTime(2021, 03, 03);
        String QTapproved = "Approved";
        String QTUnapproved = "Un-approved";
        private int speechRate = 0;
        private int speechVolume = 50;



        /*Allow for a connection between the application and the database through a connection string.
         The connection string contains the information that the provider needs to know to establish a connection
         to the database. Connection string is defines due to its constant use throughout functions, these functions
         are accessing the same declaration*/
        SqlConnection con = new SqlConnection();

        public FormQuotes()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\ABCEnergy.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;";

            //bindData is called to display current purchase orders saved in the SQL database
            bindData();

            //label_speechRate.Text = speechRate.ToString(CultureInfo.InvariantCulture);
            //label_speechRate.Text = speechVolume.ToString(CultureInfo.InvariantCulture);
            //AddInstalledVoicesToList();
        }

        private void FormQuotes_Load(object sender, EventArgs e)
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
           // label4.ForeColor = ThemeColour.SecondaryColor;
           // label5.ForeColor = ThemeColour.PrimaryColor;
        }


        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(rnd.Next(range));
        }


        /*Bind data establishes a connection with a specific table within the database. The specific use of bind data in this form fills
         the data view grid with stored information in the database, it is called to refresh values in the database to display values after 
         changes have occured when using the application*/
        void bindData()
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from ABCEnergy_Quotes", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView_quote.DataSource = dt;
            }
            catch
            {
                dataGridView_quote.DataSource = new DataTable();
            }
        }


        /*This function is called when the insert button within this form is pressed. This function creats and inserts data entered by a user
         into the database.*/
        private void Btn_Insert_Click(object sender, EventArgs e)
        {

            //Random generators to simulate real quotes from suppliers 
            int orderTotalRan = rnd.Next(1, 1000);
            int POGenerator = rnd.Next(1, 1000);
            int INGenerator = rnd.Next(1, 1000);


            /*The string including information needed to simulate a quote*/
            String body = "\nQuote proposed is:\n" + "Supplier Name: "+ textBox_Supplier.Text
                                                                                    + "\n" + "Item: " + textBox_Item.Text
                                                                                    + "\n" + "Quantity: " + textBox_Quantity.Text
                                                                                    + "\n" + "Delivery Date: " + dateTimePicker_DD.Text
                                                                                    + "\n" + "Purchase Order Number: " + POGenerator
                                                                                    + "\n" + "Invoive Number: " + INGenerator
                                                                                    + "\n" + "Date and time of order: " + localDate
                                                                                    + "\n" + "Grand Total(GBP): " + orderTotalRan + "\nDo you want to accept this quote?";


            /*If statment used to simulate a supplier returning a quote. Using the information entered by the user and random
             data to create a realistic quote. The user is given the option to accept or decline the quote.
             If accepted, all information entered and generated is saved to the database and approval set to accpeted.
             Else all information entered and generated is saved to the database with approval set to un-accepted.*/
            if (MessageBox.Show(body, "Quote", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    //Open and establish a connection with the database
                    con.Open();

                    /*SqlCommand allows for the combination of SQl and C# to amend the database. Here we use the INSERT command to take the values
                    entered by the user in relevant fields, and where neccasry parsing that data to be entered into the database as the correct
                    datatypes.*/
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
                    //The query is executed
                    command.ExecuteNonQuery();

                    //Alert the user of successfull database insertion
                    MessageBox.Show("Quote approved and saved!");

                    //close the connection as it is no longer needed
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("DATABASE ERROR - Quote Failed to Save");
                }

                //call bindData to update and display the data view with the new inserted data
                bindData();

            }
            else
            {
                try
                {
                    //Open and establish a connection with the database
                    con.Open();

                    /*SqlCommand allows for the combination of SQl and C# to amend the database. Here we use the INSERT command to take the values
                    entered by the user in relevant fields, and where neccasry parsing that data to be entered into the database as the correct
                    datatypes.*/
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
                    //The query is executed
                    command.ExecuteNonQuery();

                    //Alert the user of successfull database insertion
                    MessageBox.Show("Quote not approved and saved");

                    //close the connection as it is no longer needed
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("DATABASE ERROR - Quote Failed to Saved");
                }

                //call bindData to update and display the data view with the new inserted data
                bindData();
            }
        }


        /*Function is called when the update button is clicked. To update, two unique idetidiers must be used to identify 
         a saved quote. The quote and invoice number are used for extra validation, whilst allowing two way invoice mathcing*/
        private void Btn_update_Click_1(object sender, EventArgs e)
        {

            /*The string including information needed to simulate a quote update*/
            String body = "Would you like to amend approval on quote with Purchase Order Number: " + textBox_PON.Text + " and Invoice Number: " + textBox_IN.Text + "\n";


            //Check allows a user to approve or un-approve a quote. Message box is used to confirm this desicion.
            if (MessageBox.Show(body, "Ammend Quote Approval", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update ABCEnergy_Quotes set QuoteApproval = @QuoteApproval WHERE PurchaseOrderNumber = @PurchaseOrderNumber", con);
                    cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
                    cmd.Parameters.AddWithValue("@QuoteApproval", QTapproved);
                    cmd.ExecuteNonQuery();

                    //The query is executed
                    cmd.ExecuteNonQuery();

                    //Alert the user of successfull database insertion
                    MessageBox.Show("Quote approved and saved");

                    //close the connection as it is no longer needed
                    con.Close();
                }
                catch
                {
                    MessageBox.Show("DATABASE ERROR - Quote Failed to Save");
                }

                //call bindData to update and display the data view with the new inserted data
                bindData();
            }
            else
            {

                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Update ABCEnergy_Quotes set QuoteApproval = @QuoteApproval WHERE PurchaseOrderNumber = @PurchaseOrderNumber AND InvoiceNumber =@InvoiceNumber", con);
                    cmd.Parameters.AddWithValue("@PurchaseOrderNumber", int.Parse(textBox_PON.Text));
                    cmd.Parameters.AddWithValue("@InvoiceNumber", int.Parse(textBox_IN.Text));
                    cmd.Parameters.AddWithValue("@QuoteApproval", QTUnapproved);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Quote not approved and saved");
                }
                catch
                {
                    MessageBox.Show("DATABASE ERROR - Quote Failed to Save");
                }

                bindData();
            }
        }


        /*Delete quote function. Allows for the deletion of a quote record given the Purchase Order Number and invoice number
         as the unique identifer.*/
        private void Btn_delete_Click_1(object sender, EventArgs e)
        {
            //Statement checks to ensure a Purchase Order Number is entered. If so then delete the record otherwise alert the user of an error
            if (textBox_PON.Text != "")
            {
                /*Check to ensure the user wants to delete the quote. Message box is used to carry out this question.
                 If yes then delete the record, otherwise leave it.*/
                if (MessageBox.Show("Are you sure you want to delete?", "Delete Purchase Order", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    try
                    {
                        con.Open();
                        SqlCommand command = new SqlCommand("Delete ABCEnergy_Quotes where PurchaseOrderNumber = '" + int.Parse(textBox_PON.Text) + "' AND InvoiceNumber = '" + int.Parse(textBox_IN.Text) + "'", con);
                        command.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Successfully deleted purchase order");
                    }
                    catch
                    {
                        MessageBox.Show("DATABASE ERROR - Order Deletion Failed");
                    }

                    bindData();
                }
            }
            else
            {
                MessageBox.Show("Requires Purchase Order Number and Invoice Number");
            }
        }


        //Function to search specific purchase orders based on Purchase Order Number
        private void Btn_Search_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("select * from ABCEnergy_Quotes where PurchaseOrderNumber = '" + int.Parse(textBox_PON.Text) + "' AND InvoiceNumber = '" + int.Parse(textBox_IN.Text) + "'", con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                sd.Fill(dt);
                dataGridView_quote.DataSource = dt;
            }
            catch
            {
                dataGridView_quote.DataSource = new DataTable();
            }
        }

        private void textBox_Supplier_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
