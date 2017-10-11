using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairsApp
{
    public partial class formAddJobFair : Form
    {
        Table jobFairs;
        public formAddJobFair()
        {
            InitializeComponent();
            SetUpTable();
        }

        private void formAddJobFair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactPersonDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactPersonDataSet.People);

        }

        private void btnAddJobFair_Click(object sender, EventArgs e)
        {
            jobFairs.Columns[1].CurrentValue = tbTitle.Text.Replace("'", "''");
            jobFairs.Columns[2].CurrentValue = tbDesc.Text.Replace("'", "''");
            jobFairs.Columns[3].CurrentValue = tbStartDate.Text;
            jobFairs.Columns[4].CurrentValue = tbEndDate.Text;
            jobFairs.Columns[5].CurrentValue = tbWebsite.Text.Replace("'", "''");
            jobFairs.Columns[6].CurrentValue = tbPhone.Text;
            jobFairs.Columns[7].CurrentValue = cbContactPerson.SelectedValue.ToString();

            if (!jobFairs.InsertRow())
            {
                MessageBox.Show("Problems");
            }
            else
            {
                // Use jobFairs.Columns[0].CurrentValue (id) to do candidate/interviewer stuff
            }
        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column title = new Column("Title");
            Column desc = new Column("Description");
            Column startDate = new Column("StartDate");
            Column endDate = new Column("EndDate");
            Column website = new Column("Website");
            Column phone = new Column("Phone");
            Column contactPersonID = new Column("ContactPersonID");

            List<Column> columns = new List<Column>
            {
                id,
                title,
                desc,
                startDate,
                endDate,
                website,
                phone,
                contactPersonID
            };

            jobFairs = new Table("JobFairs", columns);
        }

        private void tbStartDate_Leave(object sender, EventArgs e)
        {

        }

        private void tbEndDate_Leave(object sender, EventArgs e)
        {

        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {

        }
    }
}
