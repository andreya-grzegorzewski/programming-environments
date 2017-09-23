using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JobFairs
{
    public class JobFair
    {
        private string title = "";
        private string desc = "";
        private string startDate = "";
        private string endDate = "";
        private string website = "";
        private string phone = "";
        private int contactID = -1;
        private int id;

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Description
        {
            get { return desc; }
            set { desc = value; }
        }

        public string StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        public string EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }

        public string Website
        {
            get { return website; }
            set { website = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int ContactPersonID
        {
            get { return contactID; }
            set { contactID = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public bool Insert()
        {
            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO JobFairs " +
                "(Title, Description, StartDate, EndDate, Website, Phone, ContactPersonID) VALUES ('" +
                title + "', '" +
                desc + "', '" +
                startDate + "', '" +
                endDate + "', '" +
                website + "', '" +
                phone + "', '" +
                contactID + "')";

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;
            if (cmd.ExecuteNonQuery() == 1)
            {
                sc.Close();
                return true;
            }
            sc.Close();
            return false;
        }
    }
}
