using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace MySqlConnectionOledb
{
    class Program
    {
        static void Main(string[] args)
        {
            //OleDbConnection conn = new OleDbConnection(
            // "Provider=MySQLProv;" +
            // "Data Source=localhost;" +
            // "User id=root;" +
            // "Password=Cuelogic;"
            //);

            OleDbConnection conn = new OleDbConnection("Provider=MySQLProv;Server=localhost;Database=world;Uid=sa;Pwd=Cuelogic;");
            string queryString = "SELECT * from world";
            OleDbCommand command = new OleDbCommand(queryString, conn);
            try
            {
                OleDbDataAdapter dt = new OleDbDataAdapter(command);
                var ds = new DataSet();

                conn.Open();
                dt.Fill(ds);

            }
            catch (Exception)
            {
                conn.Close();
                throw;
            }
        }
    }
}
