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
    public partial class Sell : Form
    {
        readonly string connectionString = DataBase.ConnectionString;
        int id;

        public Sell(int id)
        {
            InitializeComponent();
            this.id = id;

            string query = "select Type from FlatType";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        flatTypeComboBox.Items.Add(reader.GetString(0));
                    }
                }
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int flatTypeId = GetFlatTypeId(flatTypeComboBox.Text);
            string query = "insert into Flats(Address, Area, Price, Level, RoomsAmount, FlatTypeId, UserId, PublishDate) " +
                "values(@Address, @Area, @Price, @Level, @RoomsAmount, @FlatTypeId, @UserId, @Date)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@Address", addressTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Area", areaTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Price", priceTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Level", floorTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@RoomsAmount", roomsAmountTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@FlatTypeId", flatTypeId));
                cmd.Parameters.Add(new SqlParameter("@UserId", id));
                cmd.Parameters.Add(new SqlParameter("@Date", DateTime.Now));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Заявка успешно отправлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private int GetFlatTypeId(string typeName)
        {
            string query = "select ID from FlatType where Type = @Type";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();

                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Type", typeName));

                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                return Convert.ToInt32(row["ID"]);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
