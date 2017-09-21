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
    public partial class formAddPerson : Form
    {
        public formAddPerson()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void formAddPerson_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddPerson_Click(object sender, EventArgs e)
        {
            Person p = new Person();

            p.First = tbFirst.Text;
            if (tbMI.Text.Length > 0)
                p.MI = tbMI.Text.Substring(0, 1);
            p.Last = tbLast.Text;
            p.Title = Int32.Parse(tbTitle.Text);
            p.Address1 = tbAddress1.Text;
            p.Address2 = tbAddress2.Text;
            p.City = tbCity.Text;
            p.State = tbState.Text;
            p.ZIP = tbZIP.Text;
            p.Email = tbEmail.Text;
            p.Phone = tbPhone.Text;

            if (p.Insert())
            {
                MessageBox.Show(this, p.First + " " + p.Last + " was added.", "Success!");
                this.Close();
            } else
            {
                MessageBox.Show(this, p.First + " " + p.Last + " could not be added.", "Error");
            }
        }

        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (tbTitle.Text != "" && !int.TryParse(tbTitle.Text, out int tryOutput))
            {
                MessageBox.Show(this, "The Title field must be empty or contain an integer.", "Hold on!");
                tbTitle.Text = "";
                tbTitle.Focus();
            }
        }

        private void tbState_Leave(object sender, EventArgs e)
        {
            if (tbState.Text != "" && tbState.Text.Length != 2)
            {
                MessageBox.Show(this, "Please enter your two-character state code, or leave the State field blank.", "Hold on!");
                tbState.Text = "";
                tbState.Focus();
            }
        }
    }
}
