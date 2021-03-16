using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AccountingUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetPurchaseOrderTest()
        {
            SqlConnection con = new SqlConnection("Data Source=THE_BEAST_00;Initial Catalog=ABCEnergy;Integrated Security=True");
            string connectionString = GetConnectionString();

            using (TransactionScope ts = new TransactionScope())
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    DataLayer dataAccessLayer = new DataLayer();

                    DataSet dataSet = dataAccessLayer.GetUsers();
                    AddNewUser("Fred", connection);

                    dataSet = dataAccessLayer.GetUsers();
                    DataRow[] dr = dataSet.Tables[0].Select("[UserName] = 'Fred'");
                    Assert.AreEqual(1, dr.Length);
                }
            }
        }
    }

    public DataSet Users
    {
        get
        {
            DataSet dataSet = new DataSet();
            string connectionString = GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT * FROM [User]";
                SqlCommand command = new SqlCommand(sql, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataSet);
            }

            return dataSet;
        }
    }
}
