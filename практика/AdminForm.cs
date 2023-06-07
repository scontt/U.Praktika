using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика.Connection;
using практика.cs;

namespace практика
{
    public partial class AdminForm : Form
    {
        static readonly string connectionString = DataBase.ConnectionString;
        string name = string.Empty;
        string sex = string.Empty;
        SqlConnection con = new SqlConnection(connectionString);
        DataTable dataTable = new DataTable();

        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(int id)
        {
            InitializeComponent();

            int hour = DateTime.Now.Hour;
            string greetingText = string.Empty;

            if (hour >= 0 && hour < 6) greetingText = "Доброй ночи, ";
            else if (hour >= 6 && hour < 12) greetingText = "Доброе утро, ";
            else if (hour >= 12 && hour < 18) greetingText = "Добрый день, ";
            else if (hour >= 18 && hour < 24) greetingText = "Добрый вечер, ";

            string query = "select Name, Sex from Users where ID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            dataAdapter.Fill(dataTable);

            DataRow row;
            if (dataTable.Rows.Count == 1)
            {
                row = dataTable.Rows[0];
                name = row["Name"].ToString();
                sex = row["Sex"].ToString();
            }

            var sb = new StringBuilder(greetingText);
            sb.Append(name);

            greetingLabel.Text = sb.ToString();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
