using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

namespace JobFairsApp
{
    // A class representing a relational database
    public class Database
    {
        private string name = "";
        private static string connStr = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = JobFair; Integrated Security = True";
        private List<Table> tables = new List<Table>();

        public Database(string name, List<Table> tables)
        {
            this.name = name;
            this.tables = tables;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ConnectionString
        {
            get { return connStr; }
            set { connStr = value; }
        }

        public List<Table> Tables
        {
            get { return tables; }
            set { tables = value; }
        }

        public static bool GenerateInterviews()
        {
            string script = File.ReadAllText(@"C:\Users\Andreya\Documents\Assignments\2017-2018\Programming Environments\Interviews.sql");

            // Connect to the database
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            // Set command data
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = script;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            if (cmd.ExecuteNonQuery() > 0)
            {
                sc.Close();
                return true;
            }

            sc.Close();
            return false;
        }
    }
}
