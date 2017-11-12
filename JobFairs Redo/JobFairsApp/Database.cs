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
            string script = File.ReadAllText(@"C:\Users\Andreya\Documents\GitHub\programming-environments\JobFairs Redo\Interviews.sql");
            
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
        
        public static List<string> GetReadableInterviews()
        {
            string script = File.ReadAllText(@"C:\Users\Andreya\Documents\GitHub\programming-environments\JobFairs Redo\GetInterviewsReadable.sql");
            int numColumns = 13;

            List<string> interviews = Table.Read(script, numColumns);
            List<string> interviewInfo = new List<string>();

            interviewInfo.Add("Interviews for " + interviews[1] + " " + interviews[2]);

            for (int i = 0; i < interviews.Count; i += numColumns)
            {
                if (i > 0 && (interviews[i + 1] != interviews[i - numColumns + 1] || interviews[i + 2] != interviews[i - numColumns + 2]))
                {
                    interviewInfo.Add("Interviews for " + interviews[i + 1] + " " + interviews[i + 2]);
                }

                int interviewID = Int32.Parse(interviews[i]);
                string startTime = interviews[i + 3].Substring(0, interviews[i + 3].IndexOf(":00"));
                string endTime = interviews[i + 4].Substring(0, interviews[i + 4].IndexOf(":00"));
                int tableID = Int32.Parse(interviews[i + 5]);
                string interviewDate = interviews[i + 6];
                string company = interviews[i + 7];
                string location = interviews[i + 8];
                string employmentType = interviews[i + 9];
                string specialty = interviews[i + 10];
                string interviewerFirst = interviews[i + 11];
                string interviewerLast = interviews[i + 12];

                string thisInterview = "You will interview with " + interviewerFirst + " " + interviewerLast
                    + " from " + company + " for a " + employmentType + " position in " + specialty 
                    + ". The interview will take place at Table " + tableID + " in " + location
                    + ", from " + startTime + " to " + endTime + " on " + interviewDate + ".";

                interviewInfo.Add(thisInterview);
            }
            return interviewInfo;
        }

    }
}
