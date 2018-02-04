

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;


namespace MySqlConnectionEx
{
    class Program
    {
        static void Main(string[] args)
        {
            string myConnectionString = "";
            if (myConnectionString == "")
            {
                myConnectionString = "Database=world;Data Source=localhost;User Id=root;Password=Cuelogic";
            }
            MySqlConnection myConnection = new MySqlConnection(myConnectionString);
            string myInsertQuery = "select * from city";
            MySqlCommand myCommand = new MySqlCommand(myInsertQuery);
            myCommand.Connection = myConnection;

            MySqlDataAdapter dt = new MySqlDataAdapter(myCommand);
            var ds = new DataSet();
            
            myConnection.Open();
            dt.Fill(ds);
            myCommand.Connection.Close();
        }
    }
}
