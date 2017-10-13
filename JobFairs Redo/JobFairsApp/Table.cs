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
            // Create the command
            string commandText = "INSERT INTO " + this.name + " (";

            // Make sure we don't accidentally insert an ID column
            int start;
            if (columns[0].Name == "ID")
                start = 1;
            else
                start = 0;

            // Add each column name to the command text
            for (int i = start; i < columns.Count - 1; i++)
            {
                commandText += columns[i].Name + ", ";
            }
            commandText += columns[columns.Count - 1].Name + ") VALUES (";

            // Add each column value to the command text
            for (int i = start; i < columns.Count - 1; i++)
            {
                commandText += "'" + columns[i].CurrentValue + "', ";
            }
            commandText += "'" + columns[columns.Count - 1].CurrentValue + "')";

            // Connect to the database
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            // Set command data
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = commandText;
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            // Try to execute the insert
            if (cmd.ExecuteNonQuery() == 1)
            {
                // Get the ID of the row we just inserted
                cmd.CommandText = "SELECT @@IDENTITY;";
                if (columns[0].Name == "ID")
                    this.columns[0].CurrentValue = cmd.ExecuteScalar().ToString();

                // Close the connection - return true for success
                sc.Close();
                return true;
            }

            // Close the connection - return false for failure
            sc.Close();
            return false;
        }

        /// <summary>
        /// Reads data from the database
        /// </summary>
        /// <param name="command">The CommandText for a SqlCommand object</param>
        /// <param name="columns">The number of columns that will be selected by the command</param>
        /// <returns></returns>
        public List<string> Read(string command, int columns)
        {
            // Connect to the DB
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            // Select job fair title/venue name pairs
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = command;

            // Set command data
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            // List for holding the results
            List<string> results = new List<string>();
            
            // Iterate through data
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    for (int i = 0; i < columns; i++)
                    {
                        results.Add(reader.GetString(i));
                    }
                }
            }
            sc.Close();
            return results;
        }
    }
}
