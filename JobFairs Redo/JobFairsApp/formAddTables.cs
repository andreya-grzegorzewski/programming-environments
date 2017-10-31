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
    public partial class formAddTables : Form
    {
        int givenJobFairID = -1;

        Table tables;

        public formAddTables()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();

            string command = "SELECT l.Name, l.ID " +
                "FROM Locations AS l;";
            List<string> locations = Table.Read(command, 2);

            cbLocation.Items.Clear();

            for (int i = 0; i < locations.Count; i += 2)
            {
                Column thisColumn = new Column(locations[i]);
                thisColumn.CurrentValue = locations[i + 1];
                cbLocation.Items.Add(thisColumn);
            }
        }

        public formAddTables(int jobFairID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            givenJobFairID = jobFairID;
            tables.Columns[1].CurrentValue = jobFairID.ToString();
            labelJobFair.Visible = false;
            cbJobFair.Visible = false;
        }

        private void formAddTables_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobFairDataSet.JobFairs' table. You can move, or remove it, as needed.
            this.jobFairsTableAdapter.Fill(this.jobFairDataSet.JobFairs);

            if (givenJobFairID != -1)
            {
                cbJobFair.SelectedIndex = 0;

                string command = "SELECT l.Name, l.ID " +
                    "FROM Locations AS l " +
                    "WHERE l.JobFairID = " + givenJobFairID + ";";
                List<string> locations = Table.Read(command, 2);

                cbLocation.Items.Clear();

                for (int i = 0; i < locations.Count; i += 2)
                {
                    Column thisColumn = new Column(locations[i]);
                    thisColumn.CurrentValue = locations[i + 1];
                    cbLocation.Items.Add(thisColumn);
                }
            }
        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column jobFairID = new Column("JobFairID");
            Column locationID = new Column("LocationID");
            Column accessible = new Column("Accessible");
            Column hasPower = new Column("HasPower");

            List<Column> columns = new List<Column>
            {
                id,
                jobFairID,
                locationID,
                accessible,
                hasPower
            };

            tables = new Table("Tables", columns);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            if (givenJobFairID == -1)
                tables.Columns[1].CurrentValue = cbJobFair.SelectedValue.ToString();
            tables.Columns[2].CurrentValue = ((Column) cbLocation.SelectedItem).CurrentValue.ToString();
            if (!checkboxAccessible.Checked)
                tables.Columns[3].CurrentValue = "0";
            else
                tables.Columns[3].CurrentValue = "1";
            if (!checkboxHasPower.Checked)
                tables.Columns[4].CurrentValue = "0";
            else
                tables.Columns[4].CurrentValue = "1";

            tables.InsertRow();
        }

        private void cbJobFair_SelectedIndexChanged(object sender, EventArgs e)
        {
            string command = "SELECT l.Name, l.ID " +
                "FROM Locations AS l "
                + "WHERE JobFairID = " + cbJobFair.SelectedValue + ";";
            List<string> locations = Table.Read(command, 2);
            int index = cbJobFair.SelectedIndex;
            cbLocation.Items.Clear();

            for (int i = 0; i < locations.Count; i += 2)
            {
                Column thisColumn = new Column(locations[i]);
                thisColumn.CurrentValue = locations[i + 1];
                cbLocation.Items.Add(thisColumn);
            }
        }
    }
}
