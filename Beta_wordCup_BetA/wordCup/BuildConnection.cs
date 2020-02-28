using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wordCup
{
    public class BuildConnection
    {
        private OracleConnection con;
        public void Connect()
        {
            try
            {
                string connectionString = GetConnectionString();
                con = new OracleConnection();

                con.ConnectionString = connectionString;
                con.Open();
                //MessageBox.Show("Database connection is : " + con.State.ToString());
            }
            catch
            {
                MessageBox.Show("CANNOT connect to Database");
            }
        }

        public OracleConnection getConnection()
        {
            return con;
        }

        public void Close()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }

        }

        private string GetConnectionString()
        {
            return "Data Source=192.168.137.132:1521/XE;" +
                   "User ID=worldcup;Password=656117";
        }


        public void open()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }

        }


        public bool isConnected()
        {
            if (con.State.Equals(System.Data.ConnectionState.Open))
            {
                return true;
            }else
            {
                return false;
            }
        }


    }
}
