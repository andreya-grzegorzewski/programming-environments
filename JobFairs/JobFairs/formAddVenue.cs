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
    public partial class formAddVenue : Form
    {
        public formAddVenue()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonAddVenue_Click(object sender, EventArgs e)
        {
            Venue v = new Venue();
            v.Name = tbName.Text;
            v.ShortDescription = tbShortDesc.Text;
            v.LongDescription = tbLongDesc.Text;

            if (v.Insert())
            {
                MessageBox.Show(this, v.Name + " was added.", "Success!");
                this.Close();
            }
            else
            {
                MessageBox.Show(this, v.Name + " could not be added.", "Error");
            }
        }
    }
}
