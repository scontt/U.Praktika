using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using практика.Connection;

namespace практика.cs
{
    public class Event
    {
        public Event()
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public DateTime DateTime { get; set; }

        static public DataRow GetLastEvent()
        {
            string connectonString = DataBase.ConnectionString;
            SqlConnection con = new SqlConnection(connectonString);

            string query = "select top 1 * from EventsT order by ID desc";
            DataTable eventDT = new DataTable();
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(eventDT);

            DataRow row = eventDT.Rows[0];

            return row;
        }
    }
}
