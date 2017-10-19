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
    public partial class formAddJobFair : Form
    {
        Table jobFairs;
        Table jobFairDays;
        Table timeSlots;

        // Time slot table data
        int startHour = 9;
        int endHour = 17;
        int interval = 20;

        public formAddJobFair()
        {
            InitializeComponent();
            SetUpTable();
            StartPosition = FormStartPosition.CenterParent;
        }

        private void formAddJobFair_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'contactPersonDataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.contactPersonDataSet.People);

        }

        private void btnAddJobFair_Click(object sender, EventArgs e)
        {
            jobFairs.Columns[1].CurrentValue = tbTitle.Text.Replace("'", "''");
            jobFairs.Columns[2].CurrentValue = tbDesc.Text.Replace("'", "''");
            if (tbStartDate.Text != "YYYY-MM-DD")
                jobFairs.Columns[3].CurrentValue = tbStartDate.Text;
            if (tbEndDate.Text != "YYYY-MM-DD")
                jobFairs.Columns[4].CurrentValue = tbEndDate.Text;
            jobFairs.Columns[5].CurrentValue = tbWebsite.Text.Replace("'", "''");
            jobFairs.Columns[6].CurrentValue = tbPhone.Text;
            jobFairs.Columns[7].CurrentValue = cbContactPerson.SelectedValue.ToString();

            if (!jobFairs.InsertRow())
            {
                MessageBox.Show("Problems");
            }
            else
            {
                // This script borrowed from https://www.dbrnd.com/2015/08/list-all-dates-between-two-dates-in-sql-server/
                string command = "DECLARE @StartDate DATE " +
                    "DECLARE @EndDate DATE " +
                    "SET @StartDate = '" + tbStartDate.Text + "' " +
                    "SET @EndDate = '" + tbEndDate.Text + "'; " +
                    "WITH DateRange(DateData) AS ( " +
                        "SELECT @StartDate as Date " +
                        "UNION ALL " +
                        "SELECT DATEADD(d, 1, DateData) " +
                        "FROM DateRange " +
                        "WHERE DateData < @EndDate) " +
                    "SELECT DateData " +
                    "FROM DateRange;";

                List<string> dates = Table.Read(command, 1);
                jobFairDays.Columns[1].CurrentValue = jobFairs.Columns[0].CurrentValue;
                timeSlots.Columns[1].CurrentValue = jobFairs.Columns[0].CurrentValue;

                // Variables for entering time slot data
                int minute = 0;
                string startTime;
                string endTime;

                for (int i = 0; i < dates.Count; i++)
                {
                    jobFairDays.Columns[2].CurrentValue = dates[i];
                    jobFairDays.InsertRow();

                    for (int hour = startHour; hour < endHour; hour++)
                    {
                        timeSlots.Columns[2].CurrentValue = jobFairDays.Columns[0].CurrentValue;
                        endTime = hour + ":" + minute.ToString("00") + ":00";

                        while (minute <= (60 - interval)) {
                            startTime = endTime;
                            minute += interval;
                            if (minute == 60)
                                endTime = (hour + 1) + ":00:00";
                            else
                                endTime = hour + ":" + minute.ToString("00") + ":00";
                            timeSlots.Columns[3].CurrentValue = startTime;
                            timeSlots.Columns[4].CurrentValue = endTime;
                            timeSlots.InsertRow();
                        }
                        minute = minute % 60;
                    }
                }
                formAddJobFairVenues form = new formAddJobFairVenues(Convert.ToInt32(jobFairs.Columns[0].CurrentValue), jobFairs.Columns[1].CurrentValue);
                form.ShowDialog(this);
                formAddTables formT = new formAddTables(Convert.ToInt32(jobFairs.Columns[0].CurrentValue));
                formT.ShowDialog(this);
                this.Close();
            }
        }

        private void SetUpTable()
        {
            Column jobFairID = new Column("ID");
            Column jobFairTitle = new Column("Title");
            Column jobFairDesc = new Column("Description");
            Column jobFairStartDate = new Column("StartDate");
            Column jobFairEndDate = new Column("EndDate");
            Column jobFairWebsite = new Column("Website");
            Column jobFairPhone = new Column("Phone");
            Column jobFairContactPersonID = new Column("ContactPersonID");

            List<Column> columns = new List<Column>
            {
                jobFairID,
                jobFairTitle,
                jobFairDesc,
                jobFairStartDate,
                jobFairEndDate,
                jobFairWebsite,
                jobFairPhone,
                jobFairContactPersonID
            };

            jobFairs = new Table("JobFairs", columns);

            Column jobFairDaysID = new Column("ID");
            Column jobFairDaysJobFairID = new Column("JobFairID");
            Column jobFairDaysDate = new Column("Date");

            List<Column> jfdColumns = new List<Column>
            {
                jobFairDaysID,
                jobFairDaysJobFairID,
                jobFairDaysDate
            };

            jobFairDays = new Table("JobFairDays", jfdColumns);

            Column timeSlotID = new Column("ID");
            Column timeSlotJobFairID = new Column("JobFairID");
            Column timeSlotDayID = new Column("DayID");
            Column timeSlotStartTime = new Column("StartTime");
            Column timeSlotEndTime = new Column("EndTime");

            List<Column> tsColumns = new List<Column>
            {
                timeSlotID,
                timeSlotJobFairID,
                timeSlotDayID,
                timeSlotStartTime,
                timeSlotEndTime
            };

            timeSlots = new Table("TimeSlots", tsColumns);
        }

        private void tbStartDate_Leave(object sender, EventArgs e)
        {
            if (!Column.VerifyDate(tbStartDate.Text))
            {
                MessageBox.Show("Please enter a valid date (YYYY-MM-DD) of leave the field blank.", "Hold on!");
                tbStartDate.Text = "";
                tbStartDate.Focus();
            }
        }

        private void tbEndDate_Leave(object sender, EventArgs e)
        {
            if (!Column.VerifyDate(tbEndDate.Text))
            {
                MessageBox.Show("Please enter a valid date (YYYY-MM-DD) of leave the field blank.", "Hold on!");
                tbEndDate.Text = "";
                tbEndDate.Focus();
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
