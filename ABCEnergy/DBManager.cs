using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ABCEnergy
{
    /// <summary>
    /// Singleton class used to manage interactions with the database
    /// </summary>
    class DBManager
    {
        private static DBManager self;

        /// <summary>
        ///Allow for a connection between the application and the database through a connection string.
        ///The connection string contains the information that the provider needs to know to establish a connection
        ///to the database.Connection string is defines due to its constant use throughout functions, these functions
        ///are accessing the same declaration
        /// </summary>
        private SqlConnection con;

        private DBManager() {
            con = new SqlConnection();

            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;

                          AttachDbFilename=|DataDirectory|\localDataBase.mdf;

                          Integrated Security=True;

                          Connect Timeout=30;";
        }
        ~DBManager() { }

        /// <summary>
        /// Gets the instance of the DBManager
        /// </summary>
        /// <returns>DBManager instance</returns>
        static public DBManager getManager()
        {
            if (self == null)
                self = new DBManager();
            return self;
        }

        /// <summary>
        /// Gets data from a database and reuturns it in a DataTable
        /// </summary>
        /// <param name="attribute">A String formated for sql commands containg the attributes that want to be gotten</param>
        /// <param name="table">The table of the DB with the data in</param>
        /// <returns>DataTable full of data from database. Empty database is returned on database error</returns>
        public DataTable getDataTable(String attribute, String table)
        {
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select " + attribute + " from " + table;
                cmd.ExecuteNonQuery();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                con.Close();
                return dt;
            }
            catch
            {
                return dt;
            }
        }


        /// <summary>
        /// Returns a DataTable of the records that fit the condictions given
        /// </summary>
        /// <param name="attributes">The attributes that are selected</param>
        /// <param name="table">The table that the records are selected from</param>
        /// <param name="condition">The value used choose what rows to select - format for the sql command</param>
        /// <returns>Returns the selected data in a datatable; returns an empty table if an exception is thown</returns>
        public DataTable select(String attributes, String table, String condition)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand command = new SqlCommand("select " + attributes + " from " + table + " " + condition, con);
                SqlDataAdapter sd = new SqlDataAdapter(command);
                sd.Fill(dt);
                return dt;
            }
            catch
            {
                return dt;
            }
        }

        /// <summary>
        /// Insert the values given into the given table
        /// </summary>
        /// <param name="table">The table that the data will be inserted into</param>
        /// <param name="values">The values to be inserted into the table - format for the sql command</param>
        /// <returns>True if susscesful; False if an exception is thrown</returns>
        public bool insert(String table, String values)
        {
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("insert into " + table + " values('" + values + "')", con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Deletes the values from the given table acording to the given whereValue
        /// </summary>
        /// <param name="table">The table that the rows are removed from</param>
        /// <param name="whereValue">The value used choose what rows to remove - format for the sql command</param>
        /// <returns>True if successful; False if an exception is thown</returns>
        public bool delete(String table, String whereValue)
        {
            try{
                con.Open();
                SqlCommand command = new SqlCommand("Delete " + table + " where " + whereValue, con);
                command.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
