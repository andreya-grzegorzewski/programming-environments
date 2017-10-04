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
    public partial class formAddJobFair : Form
    {
        public formAddJobFair()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void tbStartDate_Leave(object sender, EventArgs e)
        {
            if (!verifyDate(tbStartDate.Text) && tbStartDate.Text.Length != 0)
            {
                MessageBox.Show(this, "Please enter a date in the format YYYY-MM-DD or leave the field blank.", "Hold on!");
                tbStartDate.Focus();
            }
        }

        private void tbEndDate_Leave(object sender, EventArgs e)
        {
            if (!verifyDate(tbEndDate.Text) && tbEndDate.Text.Length != 0)
            {
                MessageBox.Show(this, "Please enter a date in the format YYYY-MM-DD or leave the field blank.", "Hold on!");
                tbEndDate.Focus();
            }
        }

        private bool verifyDate(string text)
        {
            if (text.Length != 10)
                return false;

            if (text[4] != '-' || text[7] != '-')
                return false;

            for (int i = 0; i < text.Length; i++)
            {
                if (i == 4 || i == 7)
                    continue;
                else
                {
                    if (text[i] < 48 || text[i] > 57)
                        return false;
                }
            }

            return true;
        }

        private void tbStartDate_Enter(object sender, EventArgs e)
        {
            tbStartDate.Text = "";
        }

        private void tbEndDate_Enter(object sender, EventArgs e)
        {
            tbEndDate.Text = "";
        }

        private void formAddJobFair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFairPeopleDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.jobFairPeopleDataSet.People);
        }

        private void buttonAddJobFair_Click(object sender, EventArgs e)
        {
            JobFair j = new JobFair();
            DataRow contact = ((DataRowView)cbContact.SelectedItem).Row;

            j.Title = tbTitle.Text.Replace("'", "''");
            j.Description = tbDesc.Text.Replace("'", "''");
            if (verifyDate(tbStartDate.Text))
                j.StartDate = tbStartDate.Text;
            if (verifyDate(tbEndDate.Text))
                j.EndDate = tbEndDate.Text;
            j.Website = tbWebsite.Text;
            j.Phone = tbPhone.Text;
            j.ContactPersonID = int.Parse(contact["ID"].ToString());

            if (j.Insert())
            {
                MessageBox.Show(this, j.Title.Replace("''", "'") + " was added.", "Success!");
                this.Close();
                formAddJobFairVenues form = new formAddJobFairVenues();

                string connStr = Form1.getConnStr();
                SqlConnection sc = new SqlConnection(connStr);
                sc.Open();

                SqlCommand cmd = new SqlCommand();

                cmd.CommandText = "SELECT ID FROM JobFairs WHERE " +
                    "Title='" + j.Title + "' AND " +
                    "ContactPersonID=" + j.ContactPersonID + ";";

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.Connection = sc;

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        j.ID = reader.GetInt32(0);
                        form.SpecifyJobFair(j);
                    }
                }

                sc.Close();

                form.ShowDialog(this);
            }
            else
            {
                MessageBox.Show(this, j.Title.Replace("''", "'") + " could not be added.", "Error");
            }
        }
    }
}
