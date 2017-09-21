using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JobFairs
{
    class Person
    {
        private int id;
        private string first = "";
        private string mi = "";
        private string last = "";
        private int title;
        private string address1 = "";
        private string address2 = "";
        private string city = "";
        private string state = "";
        private string zip = "";
        private string email = "";
        private string phone = "";

        public int ID
        {
            get { return id; }
            set { id = value;  }
        }

        public string First
        {
            get { return first; }
            set { first = value; }
        }

        public string MI
        {
            get { return mi; }
            set { mi = value; }
        }

        public string Last
        {
            get { return last; }
            set { last = value; }
        }

        public int Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Address1
        {
            get { return address1; }
            set { address1 = value; }
        }

        public string Address2
        {
            get { return address2; }
            set { address2 = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public string ZIP
        {
            get { return zip; }
            set { zip = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public bool Insert()
        {
            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO People " +
                "(First, MI, Last, Title, Address1, Address2, City, State, Zip, EMail, Phone) VALUES ('" +
                first + "', '" +
                mi + "', '" +
                last + "', '" +
                title + "', '" +
                address1 + "', '" +
                address2 + "', '" +
                city + "', '" +
                state + "', '" +
                zip + "', '" +
                email + "', '" +
                phone + "')";

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

        public override string ToString()
        {
            return first + " " + last;
        }
    }
}

