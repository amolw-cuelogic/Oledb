using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
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

            //OleDbConnection conn = new OleDbConnection("Provider=MySQL;Server=localhost;Database=world;Uid=sa;Pwd=Cuelogic;");
            //string queryString = "SELECT * from world";
            //OleDbCommand command = new OleDbCommand(queryString, conn);
            //try
            //{
            //    OleDbDataAdapter dt = new OleDbDataAdapter(command);
            //    var ds = new DataSet();

            //    //conn.Open();
            //    dt.Fill(ds);

            //}
            //catch (Exception)
            //{
            //    conn.Close();
            //}
            OdbcConnection con = new OdbcConnection("DRIVER={MySQL ODBC 5.3 ANSI Driver};SERVER=localhost;DATABASE=world;USER=root;PASSWORD=Cuelogic;OPTION=3;");
            OdbcCommand cmd = new OdbcCommand("select * from city", con);
            OdbcDataAdapter da = new OdbcDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds); 
            
        }
    }
}
