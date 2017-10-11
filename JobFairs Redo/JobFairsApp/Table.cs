using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JobFairsApp
{
    // A class defining a table in a database
    public class Table
    {
        private string name = "";
        private List<Column> columns = new List<Column>();
        private string connStr = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = JobFair; Integrated Security = True";

        public Table(string name, List<Column> columns)
        {
            this.name = name;
            this.columns = columns;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Column> Columns
        {
            get { return columns; }
            set { columns = value; }
        }

        // Return the true if the insert was successful; false otherwise
        public bool InsertRow()
        {
            string commandText = "INSERT INTO " + this.name + " (";
            for (int i = 1; i < columns.Count - 1; i++)
            {
                commandText += columns[i].Name + ", ";
            }
            commandText += columns[columns.Count - 1].Name + ") VALUES (";
            for (int i = 1; i < columns.Count - 1; i++)
            {
                commandText += "'" + columns[i].CurrentValue + "', ";
            }
            commandText += "'" + columns[columns.Count - 1].CurrentValue + "')";

            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            if (cmd.ExecuteNonQuery() == 1)
            {
                cmd.CommandText = "SELECT @@IDENTITY;";
                this.columns[0].CurrentValue = cmd.ExecuteScalar().ToString();
                sc.Close();
                return true;
            }

            sc.Close();
            return false;
        }
    }
}
