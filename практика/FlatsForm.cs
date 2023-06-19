using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика.Connection;

namespace практика
{
    public partial class FlatsForm : Form
    {
        string connectionString = DataBase.ConnectionString;

        public FlatsForm(int id)
        {
            InitializeComponent();

            DataTable dataTable = new DataTable();
            string query = "select " +
                "Flats.Address as 'Адрес', " +
                "Area as 'Площадь', " +
                "Price as 'Цена', " +
                "Level as 'Этаж', " +
                "RoomsAmount as 'Количество комнат', " +
                "PublishDate as 'Дата публикации', " +
                "CONCAT(Users.FirstName, ' ', Users.SecondName) as 'Имя' " +
                "from Flats left join Users on Flats.UserID = Users.ID " +
                "where UserId <> @Id";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Id", id));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);

                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
