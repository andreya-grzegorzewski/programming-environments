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
    public partial class formAddVenue : Form
    {
        private Table venues;
        public formAddVenue()
        {
            InitializeComponent();
            SetUpTable();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column name = new Column("Name");
            Column shortDescription = new Column("ShortDescription");
            Column longDescription = new Column("LongDescription");
            Column address1 = new Column("Address1");
            Column address2 = new Column("Address2");
            Column city = new Column("City");
            Column state = new Column("State");
            Column zip = new Column("Zip");

            List<Column> columns = new List<Column>
            {
                id,
                name,
                shortDescription,
                longDescription,
                address1,
                address2,
                city,
                state,
                zip
            };

            venues = new Table("Venues", columns);
        }

        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            venues.Columns[1].CurrentValue = tbName.Text.Replace("'", "''");
            venues.Columns[2].CurrentValue = tbShortDesc.Text.Replace("'", "''");
            venues.Columns[3].CurrentValue = tbLongDesc.Text.Replace("'", "''");
            venues.Columns[4].CurrentValue = tbAddress1.Text.Replace("'", "''");
            venues.Columns[5].CurrentValue = tbAddress2.Text.Replace("'", "''");
            venues.Columns[6].CurrentValue = tbCity.Text.Replace("'", "''");
            venues.Columns[7].CurrentValue = tbState.Text;
            venues.Columns[8].CurrentValue = tbZip.Text;

            if (!venues.InsertRow())
            {
                MessageBox.Show("Problems");
            }
        }

        private void tbState_Leave(object sender, EventArgs e)
        {
            if (!Column.VerifyState(tbState.Text))
            {
                MessageBox.Show(this, "Please enter your two-character state code, or leave the State field blank.", "Hold on!");
                tbState.Text = "";
                tbState.Focus();
            }
        }

        private void tbZip_Leave(object sender, EventArgs e)
        {
            if (!Column.VerifyZip(tbZip.Text))
            {
                MessageBox.Show("Please enter a five or nine digit ZIP code (##### or #####-####) or leave the field blank.", "Hold on!");
                tbZip.Text = "";
                tbZip.Focus();
            }

        }
    }
}
