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
            // Create the Venue object
            Venue v = new Venue();
            v.Name = tbName.Text;
            v.ShortDescription = tbShortDesc.Text;
            v.LongDescription = tbLongDesc.Text;

            // Insert it and let the user know if the insertion worked
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
