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
        
        // interviewsForFlag - A flag indicating who these interviews are for. 'c' is for candidates,
        // 'i' is for interviewers, and 'm' is for master. Used to order the data.
        public static List<string> GetInterviews(char interviewsForFlag)
        {
            string script = File.ReadAllText(@"C:\Users\Andreya\Documents\GitHub\programming-environments\JobFairs Redo\Sql Files\GetInterviewsReadableGeneral.sql");

            if (interviewsForFlag == 'c')
                script += "SELECT * FROM #InterviewsReadable ORDER BY CandidateFirst, CandidateLast, InterviewDate, StartTime;";
            else if (interviewsForFlag == 'i')
                script += "SELECT * FROM #InterviewsReadable ORDER BY InterviewerFirst, InterviewerLast, InterviewDate, StartTime;";
            else if (interviewsForFlag == 'm')
                script += "SELECT * FROM #InterviewsReadable ORDER BY InterviewDate, StartTime, TableID;";

            int numColumns = 13;

            List<string> interviews = Table.Read(script, numColumns);
            List<string> interviewInfo = new List<string>();

            if (interviewsForFlag == 'c')
                interviewInfo.Add("Interviews for " + interviews[1] + " " + interviews[2]);
            else if (interviewsForFlag == 'i')
                interviewInfo.Add("Interviews for " + interviews[11] + " " + interviews[12]);

            for (int i = 0; i < interviews.Count; i += numColumns)
            {
                if (interviewsForFlag == 'c')
                {
                    if (i > 0 && (interviews[i + 1] != interviews[i - numColumns + 1] || interviews[i + 2] != interviews[i - numColumns + 2]))
                    {
                        interviewInfo.Add("Interviews for " + interviews[i + 1] + " " + interviews[i + 2]);
                    }
                } 
                else if (interviewsForFlag == 'i')
                {
                    if (i > 0 && (interviews[i + 11] != interviews[i - numColumns + 11] || interviews[i + 12] != interviews[i - numColumns + 12]))
                    {
                        interviewInfo.Add("Interviews for " + interviews[i + 11] + " " + interviews[i + 12]);
                    }
                }

                int interviewID = Int32.Parse(interviews[i]);
                string startTime = interviews[i + 3].Substring(0, interviews[i + 3].LastIndexOf(":00"));
                string endTime = interviews[i + 4].Substring(0, interviews[i + 4].LastIndexOf(":00"));
                int tableID = Int32.Parse(interviews[i + 5]);
                string interviewDate = interviews[i + 6];
                string company = interviews[i + 7];
                string location = interviews[i + 8];
                string employmentType = interviews[i + 9];
                string specialty = interviews[i + 10];
                string otherPersonFirst = "";
                string otherPersonLast = "";

                if (startTime.IndexOf("0") == 0)
                    startTime = startTime.Substring(1);
                if (endTime.IndexOf("0") == 0)
                    endTime = endTime.Substring(1);

                if (interviewsForFlag == 'c')
                {
                    otherPersonFirst = interviews[i + 11];
                    otherPersonLast = interviews[i + 12];
                }
                else if (interviewsForFlag == 'i')
                {
                    otherPersonFirst = interviews[i + 1];
                    otherPersonLast = interviews[i + 2];
                }

                if (interviewsForFlag != 'm')
                {
                    string thisInterview = "You will interview with " + otherPersonFirst + " " + otherPersonLast
                        + " from " + company + " for a " + employmentType + " position in " + specialty
                        + ".\n   The interview will take place at Table " + tableID + " in " + location
                        + ", from " + startTime + " to " + endTime + " on " + interviewDate + ".";

                    interviewInfo.Add(thisInterview);
                }
                else
                {
                    string candidateFirst = interviews[i + 1];
                    string candidateLast = interviews[i + 2];
                    string interviewerFirst = interviews[i + 11];
                    string interviewerLast = interviews[i + 12];

                    string thisInterview = candidateFirst + " " + candidateLast + " will be interviewed by "
                        + interviewerFirst + " " + interviewerLast + " from " + company + " for a " + employmentType 
                        + " position in " + specialty + ".\n   The interview will take place at Table " + tableID 
                        + " in " + location + ", from " + startTime + " to " + endTime + " on " + interviewDate + ".";

                    interviewInfo.Add(thisInterview);
                }
            }
            return interviewInfo;
        }
    }
}
