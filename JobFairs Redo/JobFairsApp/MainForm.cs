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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            formAddPerson form = new formAddPerson();
            form.ShowDialog(this);
        }

        private void buttonAddJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFair form = new formAddJobFair();
            form.ShowDialog(this);
        }

        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            formAddVenue form = new formAddVenue();
            form.ShowDialog(this);
        }

        private void buttonAssociateVenueWithJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFairVenues form = new formAddJobFairVenues();
            form.ShowDialog(this);
        }

        private void CreateDatabaseObjects()
        {
            string connStr = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = JobFair; Integrated Security = True";
            /*
            List<Table> tables = new List<Table>
            {
                jobFairs
            };
            */
            //Database db = new Database(connStr, "JobFairs", )

        }

        private void buttonAddCompany_Click(object sender, EventArgs e)
        {
            formAddCompany form = new formAddCompany();
            form.ShowDialog(this);
        }

        private void btnAddLocation_Click(object sender, EventArgs e)
        {
            formAddLocation form = new formAddLocation();
            form.ShowDialog(this);
        }

        private void buttonAssociatePersonWithJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFairPerson form = new formAddJobFairPerson();
            form.ShowDialog(this);
        }
    }
}
