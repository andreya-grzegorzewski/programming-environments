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
    public partial class formAddJobFairVenues : Form
    {
        public formAddJobFairVenues()
        {
            InitializeComponent();
        }

        private void formAddJobFairVenues_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'venuesDataSet.Venues' table. You can move, or remove it, as needed.
            this.venuesTableAdapter.Fill(this.venuesDataSet.Venues);

        }
    }
}
