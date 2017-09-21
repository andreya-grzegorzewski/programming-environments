using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace JobFairs
{
    class Venue
    {
        private int id;
        private string name = "";
        private string shortDesc = "";
        private string longDesc = "";

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ShortDescription
        {
            get { return shortDesc; }
            set { shortDesc = value; }
        }

        public string LongDescription
        {
            get { return longDesc; }
            set { longDesc = value; }
        }

        public bool Insert()
        {
            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venues " +
                "(Name, [Short Description], [Long Description]) VALUES ('" +
                name + "', '" +
                shortDesc + "', '" +
                longDesc + "')";

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
            return name;
        }
    }
}
