using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Sample_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void m_btnGetName_Click(object sender, EventArgs e)
        {
            //  The following line contains a connection string for a database that is on my local machine (server).
            //  Beware of storing a connection string that includes a username and password for an online server
            //  in public places like this GitHub repository since that would allow everyone to see those credentials.

           
           string dbConnStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=firstdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

           SqlConnection sc = new SqlConnection(dbConnStr);     // Create a .Net framework SQL Server connection object
                                                                // based on the connection string.

            sc.Open();                                          // Establish an opened connection to the DB.

            SqlDataReader reader;                               // SqlDataReaders provide sequential access to rows in 
                                                                // a relational database table as follows:

            SqlCommand cmd = new SqlCommand();                  // A SqlCommand can have a variety of property values
                                                                // but at a minimum nees a command object and
                                                                // a connection object.
            int NameID; 

            if (int.TryParse(m_tbID.Text, out NameID))          // This is UI code.  Good practice would separate the
                                                                // UI code from the Database code.  We'll do that later.
                                                                // if the TryParse succeeds the integer value is stored
                                                                // in NameID.  If not, TryParse returns false..
            {

                cmd.CommandText = "SELECT Name FROM Names WHERE ID = " + NameID;
                                                                // Line above establishes the SQL command to be 
                                                                // be executed.  The next two lines, establish other 
                                                                // features of the SQLCommand object.  There are about
                                                                // a dozen SQLCommand object properties.  See the documentation
                                                                // for a complete list.
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sc;


                reader = cmd.ExecuteReader();                   // create a reader that can be called repeatedly
                                                                // to get the next available row.
                if (reader.Read())                              // Get the next available row.  The reader contains an 
                                                                // array of column values in the row.  These values can
                                                                // be retrieved with a variety of "Get.." methods.  
                                                                // See documentation for SqlDataReader.  There are dozens
                                                                // of "Get..." methods.

                  m_tbName.Text = reader.GetString(0);          // for example, GetString(0) gets the string that is
                                                                // in column number 0.
            }
            else
            {
                m_tbName.Text = "";                             // If TryParse fails this line is executed.  I chose to
                                                                // clear the value (.Text) in the text box named 'm_tbName'.
            }

            sc.Close();                                         // Don't forget to close the connection object at the 
                                                                // same syntax level it was opened.
        }
    }
}
