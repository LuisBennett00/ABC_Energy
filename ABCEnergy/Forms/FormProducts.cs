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
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
            //LoadTheme();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;
                          AttachDbFilename=|DataDirectory|\ABCEnergy.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;";
            //sets the connection string to the location of the local database in the program files
            bindData();
        }
        

        private void FormProducts_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        /*Allow for a connection between the application and the database through a connection string.
         The connection string contains the information that the provider needs to know to establish a connection
         to the database. Connection string is defines due to its constant use throughout functions, these functions
         are accessing the same declaration*/
        SqlConnection con = new SqlConnection();
        List<checkout_Item> checkout = new List<checkout_Item>();
        
        void UpdateCheckout()//updates both the checkout data grid and price label when called
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            float total=0;
            //creates a fresh data table for storing product data aswell as a temp float to hold the sum of products cost
           foreach(checkout_Item Item in checkout)
            {
                dt.Rows.Add(Item.quantity, Item.Name, Item.Price);
                total += Item.Price*Item.quantity;
            }//adds every product in the cart to the datatable and adds price*quantity to the sum
            CheckoutGridView.DataSource = dt;
            priceLabel.Text = "Total cost: £" + total.ToString();
            //updates the datagrid and label with the new datatable and sum
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void bindData()
        {
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select departmentname from Department";//opens a connection to the sql server and selects all departments stored within
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DeptCombobox.Items.Add(dr["departmentname"].ToString());
                }//fills a datatable with the department names and then adds them to a combobox so they can be selected in the ui
                con.Close();
            }
            catch 
            {
                DeptCombobox.Items.Add("DATABASE ERROR");
            }//shows if a connection to the server could not be made
        }

        private void FormProducts_Load_1(object sender, EventArgs e)
        {

        }

        private void deptSelectButton_Click(object sender, EventArgs e)//department selection button 
        {
            CatgCombobox.Items.Clear();
            if(DeptCombobox.SelectedItem != null)//checks a department is selected in the combobox
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select categoryName, department.departmentname from Category inner join Department on department.deptID = category.deptID where departmentName = '" + DeptCombobox.SelectedItem.ToString() + "';";
                    cmd.ExecuteNonQuery();//sql to sellect all categorys under the chosen department. 
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        CatgCombobox.Items.Add(dr["categoryName"].ToString());
                    }//fills a datatable with the category names and then adds them to a combobox so they can be selected in the ui
                    con.Close();
                }
                catch
                {
                    CatgCombobox.Items.Add("DATABASE ERROR");
                }//shows if a connection to the server could not be made
            }
        }

        private void catgSelectButton_Click(object sender, EventArgs e)//category selection button
        {
            if (CatgCombobox.SelectedItem != null)//checks a category is selected in the combobox 
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select productID,productName,price,productDesc from Product inner join Category on Product.categoryID = category.categoryID where categoryName = '" + CatgCombobox.SelectedItem.ToString() + "';";
                    cmd.ExecuteNonQuery();//selects all relevent data held in database for the products under the selected category
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;//fills a datatable with the selected product data then uses that as the data source for a data grid in the ui
                    con.Close();
                }
                catch
                {
                    dataGridView1.DataSource = new DataTable("DATABASE ERROR");
                }//shows if a connection to the server could not be made
            }
        }

        private void addButton_Click(object sender, EventArgs e)//add to checkout button 
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)//checks a row is selected 
            {
                bool found = false;//indicater used when itterating through checkout items
               string name = dataGridView1.SelectedCells[1].Value.ToString();
               string Sprice = dataGridView1.SelectedCells[2].Value.ToString();
                float price = float.Parse(Sprice); //stores name and price of selected product in datagrid 
                foreach(checkout_Item CI in checkout)
                { 
                    if(CI.Name == name)
                    {
                        CI.quantity += 1;
                        found = true;
                    }//itterates through all the products stored in checkout and increments the quantity of the stored item if it matches the product being added
                    
                }
                if(found==false)
                {
                    checkout.Add(new checkout_Item() { quantity = 1, Name = name, Price = price });
                }//if no item matches the product a new item is created and added to the checkout with a quantity of 1
                

            }
            UpdateCheckout();
        }
        class checkout_Item
        {
            public int quantity { get; set; }
            public string Name { get; set; }
            public float Price { get; set; }
        }//class used to store products in the checkout cart

        private void removeButton_Click(object sender, EventArgs e)//button to remove item from cart
        {
            Int32 selectedRowCount =
        CheckoutGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(CheckoutGridView.SelectedCells[0].Value!=null)//checks an item is selected and not a blank cell
            {
                if (selectedRowCount > 0)//checks a row is selected 
            {
                string name = CheckoutGridView.SelectedCells[1].Value.ToString();
                foreach (checkout_Item CI in checkout.ToList())
                {
                    if (CI.Name == name)
                    {
                        CI.quantity -= 1;
                        if(CI.quantity==0)
                        { checkout.Remove(CI); }
                    }//itterates through the items stored in checkout and compares the stored names to the selected items names, if a match is found the items quantity is reduced by 1, item is removed if this puts it at 0 quantity

                }

            }

            }
            
            UpdateCheckout();
        }
    }
}
