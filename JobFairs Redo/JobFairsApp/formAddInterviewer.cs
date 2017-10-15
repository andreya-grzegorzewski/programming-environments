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
    public partial class formAddInterviewer : Form
    {
        Table interviewers;

        public formAddInterviewer(int personID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterParent;
            SetUpTable();
            interviewers.Columns[1].CurrentValue = personID.ToString();
        }

        private void formAddInterviewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'companyDataSet.Companies' table. You can move, or remove it, as needed.
            this.companiesTableAdapter.Fill(this.companyDataSet.Companies);

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            interviewers.Columns[2].CurrentValue = cbCompany.SelectedValue.ToString();
            interviewers.InsertRow();
            this.Close();
            formAddPersonSpecialties form = new formAddPersonSpecialties(-1, Convert.ToInt32(interviewers.Columns[0].CurrentValue));
            form.ShowDialog(this);
        }

        private void SetUpTable()
        {
            Column id = new Column("ID");
            Column personID = new Column("PersonID");
            Column companyID = new Column("CompanyID");

            List<Column> columns = new List<Column>
            {
                id,
                personID,
                companyID
            };

            interviewers = new Table("Interviewers", columns);
        }
    }
}
