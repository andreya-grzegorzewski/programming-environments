using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobFairsApp
{
    // A class representing a relational database
    public class Database
    {
        private string name = "";
        private string connStr = "";
        private List<Table> tables = new List<Table>();

        public Database(string name, string connStr, List<Table> tables)
        {
            this.name = name;
            this.connStr = connStr;
            this.tables = tables;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ConnectionString
        {
            get { return connStr; }
            set { connStr = value; }
        }

        public List<Table> Tables
        {
            get { return tables; }
            set { tables = value; }
        }
    }
}
