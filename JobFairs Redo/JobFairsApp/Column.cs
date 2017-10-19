using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairsApp
{
    // A class defining a column in a database
    public class Column
    {
        private string name = "";
        private string currentValue = "";

        public Column(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string CurrentValue
        {
            get { return currentValue; }
            set { currentValue = value; }
        }

        public static bool VerifyPhone(string phone)
        {
            if (phone.Length != 12)
                return false;

            if (phone[3] != '-' || phone[7] != '-')
                return false;

            for (int i = 0; i < phone.Length; i++)
            {
                if (phone[i] != '-' && (phone[i] < 48 || phone[i] > 57))
                    return false;
            }

            return true;
        }

        public static bool VerifyZip(string zip)
        {
            if (zip.Length != 0 && zip.Length != 5 && zip.Length != 10)
                return false;
            else if (zip.Length == 10 && zip[5] != '-')
                return false;
            else
            {
                for (int i = 0; i < zip.Length; i++)
                {
                    if (i == 5)
                        continue;
                    if (zip[i] < 48 || zip[i] > 57)
                        return false;
                }
            }
            return true;
        }

        public static bool VerifyState(string state)
        {
            if (state != "" && state.Length != 2)
                return false;
            return true;
        }

        public static bool VerifyDate(string date)
        {
            if (date.Length != 10)
                return false;

            if (date[4] != '-' || date[7] != '-')
                return false;

            for (int i = 0; i < date.Length; i++)
            {
                if (i == 4 || i == 7)
                    continue;
                else
                {
                    if (date[i] < 48 || date[i] > 57)
                        return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            return this.name;
        }
    }
}
