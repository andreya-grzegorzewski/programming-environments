using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JobFairs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        
        static string connStr = @"Data Source=localhost\SQLEXPRESS;Initial Catalog = JobFair; Integrated Security = True";

        public static string getConnStr()
        {
            return connStr;
        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            formAddPerson form = new formAddPerson();
            form.ShowDialog(this);
        }

        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            formAddVenue form = new formAddVenue();
            form.ShowDialog(this);
        }

        private void buttonAddJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFair form = new formAddJobFair();
            form.ShowDialog(this);
        }

        private void buttonAssociateVenueWithJobFair_Click(object sender, EventArgs e)
        {
            formAddJobFairVenues form = new formAddJobFairVenues();
            form.ShowDialog(this);
        }
    }
}
