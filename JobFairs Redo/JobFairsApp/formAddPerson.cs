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
    public partial class formAddPerson : Form
    {
        Table people;

        public formAddPerson()
        {
            InitializeComponent();
            SetUpTable();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void formAddPerson_Load(object sender, EventArgs e)
        {

        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column first = new Column("First");
            Column mi = new Column("MI");
            Column last = new Column("Last");
            Column title = new Column("Title");
            Column address1 = new Column("Address1");
            Column address2 = new Column("Address2");
            Column city = new Column("City");
            Column state = new Column("State");
            Column zip = new Column("Zip");
            Column email = new Column("EMail");
            Column phone = new Column("Phone");

            List<Column> columns = new List<Column>
            {
                id,
                first,
                mi,
                last,
                title,
                address1,
                address2,
                city,
                state,
                zip,
                email,
                phone
            };

            people = new Table("People", columns);
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            people.Columns[1].CurrentValue = tbFirst.Text.Replace("'", "''");
            string mi = "";
            if (tbMI.Text.Length > 0)
                mi = tbMI.Text.Substring(0, 1);
            people.Columns[2].CurrentValue = mi;
            people.Columns[3].CurrentValue = tbLast.Text.Replace("'", "''");
            people.Columns[4].CurrentValue = tbTitle.Text.Replace("'", "''");
            people.Columns[5].CurrentValue = tbAddress1.Text.Replace("'", "''");
            people.Columns[6].CurrentValue = tbAddress2.Text.Replace("'", "''");
            people.Columns[7].CurrentValue = tbCity.Text.Replace("'", "''");
            people.Columns[8].CurrentValue = tbState.Text;
            people.Columns[9].CurrentValue = tbZip.Text;
            people.Columns[10].CurrentValue = tbEmail.Text.Replace("'", "''");
            people.Columns[11].CurrentValue = tbPhone.Text;

            if (!people.InsertRow())
            {
                MessageBox.Show("Problems");
            }
            else
            {
                this.Close();
                formAddJobFairPerson form = new formAddJobFairPerson(Convert.ToInt32(people.Columns[0].CurrentValue), checkBoxCandidate.Checked, checkBoxInterviewer.Checked);
                form.ShowDialog(this);
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

        private void tbState_Leave(object sender, EventArgs e)
        {
            if (!Column.VerifyState(tbState.Text))
            {
                MessageBox.Show(this, "Please enter your two-character state code, or leave the State field blank.", "Hold on!");
                tbState.Text = "";
                tbState.Focus();
            }
        }

        private void tbPhone_Leave(object sender, EventArgs e)
        {
            if (!Column.VerifyPhone(tbPhone.Text))
            {
                MessageBox.Show("Please enter a valid phone number (###-###-####) or leave the field blank.", "Hold on!");
                tbPhone.Text = "";
                tbPhone.Focus();
            }
        }
    }
}
