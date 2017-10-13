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
    public partial class formAddLocation : Form
    {
        Table locations;
        int givenJobFairID = -1;

        public formAddLocation()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
        }

        public formAddLocation(int jobFairID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            locations.Columns[1].CurrentValue = jobFairID.ToString();
            givenJobFairID = jobFairID;
            labelJobFair.Visible = false;
            cbJobFair.Visible = false;
        }

        private void formAddLocation_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFairDataSet.JobFairs' table. You can move, or remove it, as needed.
            this.jobFairsTableAdapter.Fill(this.jobFairDataSet.JobFairs);

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            if (givenJobFairID == -1)
                locations.Columns[1].CurrentValue = cbJobFair.SelectedValue.ToString();
            locations.Columns[2].CurrentValue = tbName.Text;
            locations.Columns[3].CurrentValue = tbDesc.Text;
            locations.InsertRow();
        }

        private void SetUpTable() {
            Column id = new Column("ID");
            Column jobFairID = new Column("JobFairID");
            Column name = new Column("Name");
            Column desc = new Column("Description");

            List<Column> columns = new List<Column>
            {
                id,
                jobFairID,
                name,
                desc
            };

            locations = new Table("Locations", columns);
        }
    }
}
