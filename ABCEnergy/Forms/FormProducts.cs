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
                          AttachDbFilename=|DataDirectory|\localDataBase.mdf;
                          Integrated Security=True;
                          Connect Timeout=30;";
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
        
        void UpdateCheckout()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Quantity");
            dt.Columns.Add("Name");
            dt.Columns.Add("Price");
            float total=0;
           foreach(checkout_Item Item in checkout)
            {
                dt.Rows.Add(Item.quantity, Item.Name, Item.Price);
                total += Item.Price*Item.quantity;
            }
            CheckoutGridView.DataSource = dt;
            priceLabel.Text = "Total cost: £" + total.ToString();
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
                cmd.CommandText = "select departmentname from Department";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    DeptCombobox.Items.Add(dr["departmentname"].ToString());
                }
                con.Close();
            }
            catch 
            {
                DeptCombobox.Items.Add("DATABASE ERROR");
            }
        }

        private void FormProducts_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            CatgCombobox.Items.Clear();
            if(DeptCombobox.SelectedItem != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select categoryName, department.departmentname from Category inner join Department on department.deptID = category.deptID where departmentName = '" + DeptCombobox.SelectedItem.ToString() + "';";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow dr in dt.Rows)
                    {
                        CatgCombobox.Items.Add(dr["categoryName"].ToString());
                    }
                    con.Close();
                }
                catch
                {
                    CatgCombobox.Items.Add("DATABASE ERROR");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CatgCombobox.SelectedItem != null)
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select productID,productName,price,productDesc from Product inner join Category on Product.categoryID = category.categoryID where categoryName = '" + CatgCombobox.SelectedItem.ToString() + "';";
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
                catch
                {
                    dataGridView1.DataSource = new DataTable("DATABASE ERROR");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                bool found = false;
               string name = dataGridView1.SelectedCells[1].Value.ToString();
               string Sprice = dataGridView1.SelectedCells[2].Value.ToString();
                float price = float.Parse(Sprice); 
                foreach(checkout_Item CI in checkout)
                { 
                    if(CI.Name == name)
                    {
                        CI.quantity += 1;
                        found = true;
                    }
                    
                }
                if(found==false)
                {
                    checkout.Add(new checkout_Item() { quantity = 1, Name = name, Price = price });
                }
                

            }
            UpdateCheckout();
        }
        class checkout_Item
        {
            public int quantity { get; set; }
            public string Name { get; set; }
            public float Price { get; set; }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
        CheckoutGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string name = CheckoutGridView.SelectedCells[1].Value.ToString();
                foreach (checkout_Item CI in checkout.ToList())
                {
                    if (CI.Name == name)
                    {
                        CI.quantity -= 1;
                        if(CI.quantity==0)
                        { checkout.Remove(CI); }
                    }

                }

            }
            UpdateCheckout();
        }
    }
}
