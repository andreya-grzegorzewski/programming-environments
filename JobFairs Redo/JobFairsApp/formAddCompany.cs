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
    public partial class formAddCompany : Form
    {
        Table companies;
        Table companyEmploymentTypes;

        public formAddCompany()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
        }

        private void formAddCompany_Load(object sender, EventArgs e)
        {

        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column name = new Column("Name");
            Column address1 = new Column("Address1");
            Column address2 = new Column("Address2");
            Column city = new Column("City");
            Column state = new Column("State");
            Column zip = new Column("Zip");
            Column website = new Column("Website");

            List<Column> Ccolumns = new List<Column>
            {
                id,
                name,
                address1,
                address2,
                city,
                state,
                zip,
                website
            };

            companies = new Table("Companies", Ccolumns);

            Column companyID = new Column("CompanyID");
            Column employmentTypeID = new Column("EmploymentTypeID");

            List<Column> CETcolumns = new List<Column>
            {
                companyID,
                employmentTypeID
            };

            companyEmploymentTypes = new Table("CompanyEmploymentTypes", CETcolumns);
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

        private void btnAddCompany_Click(object sender, EventArgs e)
        {
            companies.Columns[1].CurrentValue = tbName.Text;
            companies.Columns[2].CurrentValue = tbAddress1.Text;
            companies.Columns[3].CurrentValue = tbAddress2.Text;
            companies.Columns[4].CurrentValue = tbCity.Text;
            companies.Columns[5].CurrentValue = tbState.Text;
            companies.Columns[6].CurrentValue = tbZip.Text;
            companies.Columns[7].CurrentValue = tbWebsite.Text;

            companies.InsertRow();

            companyEmploymentTypes.Columns[0].CurrentValue = companies.Columns[0].CurrentValue;

            if (checkboxFullTime.Checked)
            {
                companyEmploymentTypes.Columns[1].CurrentValue = "1";
                companyEmploymentTypes.InsertRow();
            }
            if (checkboxCoop.Checked)
            {
                companyEmploymentTypes.Columns[1].CurrentValue = "2";
                companyEmploymentTypes.InsertRow();
            }
            if (checkboxInternship.Checked)
            {
                companyEmploymentTypes.Columns[1].CurrentValue = "3";
                companyEmploymentTypes.InsertRow();
            }
        }
    }
}
