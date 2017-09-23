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

namespace JobFairs
{
    public partial class formAddJobFairVenues : Form
    {
        public formAddJobFairVenues()
        {
            InitializeComponent();

            FillListBox();
        }

        private int jobFairID = -1;
        private string jobFairTitle = "";
        private int venueID = -1;
        private bool specificJobFair = false;

        public void SpecifyJobFair(JobFair j)
        {
            cbJobFair.Visible = false;
            labelJobFair.Visible = false;
            labelTitle.Text = "Where is " + j.Title.Replace("''", "'") + "?";
            jobFairTitle = j.Title.Replace("''", "'");
            jobFairID = j.ID;
            specificJobFair = true;

            for (int i = 0; i < lbAssociations.Items.Count; i++)
            {
                if (!lbAssociations.Items[i].ToString().Contains(jobFairTitle))
                {
                    lbAssociations.Items.RemoveAt(i);
                    i--;
                }
            }
        }

        private void AddJobFairVenues_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFairVenuesDataSet.Venues' table. You can move, or remove it, as needed.
            this.venuesTableAdapter.Fill(this.jobFairVenuesDataSet.Venues);
            // TODO: This line of code loads data into the 'jobFairsDataSet.JobFairs' table. You can move, or remove it, as needed.
            this.jobFairsTableAdapter.Fill(this.jobFairsDataSet.JobFairs);

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            DataRow jobFair = ((DataRowView)cbJobFair.SelectedItem).Row;
            DataRow venue = ((DataRowView)cbVenue.SelectedItem).Row;
            if (!specificJobFair)
            {
                jobFairID = int.Parse(jobFair["ID"].ToString());
            }
            venueID = int.Parse(venue["ID"].ToString());

            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO JobFairVenues " +
                "(JobFairID, VenueID) VALUES ('" +
                jobFairID + "', '" +
                venueID + "')";

            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            if (cmd.ExecuteNonQuery() != 1)
                MessageBox.Show(this, "The venue could not be added to the job fair.", "Error");

            sc.Close();
            lbAssociations.Items.Clear();
            FillListBox();
        }

        private void FillListBox()
        {
            string connStr = Form1.getConnStr();
            SqlConnection sc = new SqlConnection(connStr);
            sc.Open();

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT j.Title, v.Name " +
                "FROM JobFairVenues AS jv " +
                "INNER JOIN JobFairs AS j " +
                "ON j.ID = jv.JobFairID " +
                "INNER JOIN Venues AS v " +
                "ON v.ID = jv.VenueID;";


            cmd.CommandType = System.Data.CommandType.Text;
            cmd.Connection = sc;

            string thisTitle;
            string thisName;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    thisTitle = reader.GetString(0);
                    thisName = reader.GetString(1);

                    if (!specificJobFair || thisTitle == jobFairTitle)
                        lbAssociations.Items.Add(thisTitle + " will be at " + thisName);
                }
            }

            sc.Close();
        }
        
    }
}
