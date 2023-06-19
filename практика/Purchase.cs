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
using практика.db;

namespace практика
{
    public partial class Purchase : Form
    {
        int flatId;
        int userId;
        public Purchase(int id)
        {
            InitializeComponent();
            flatId = id;

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            string query = "select * from Flats where ID = @Id";

            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Id", flatId));

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    addressLabel.Text = reader["Address"].ToString();
                    areaLabel.Text = reader["Area"].ToString();
                    priceLabel.Text = reader["Price"].ToString();
                    levelLabel.Text = reader["Level"].ToString();
                    roomsAmountLabel.Text = reader["RoomsAmount"].ToString();
                    flatTypeLabel.Text = GetFlatType(Convert.ToInt32(reader["FlatTypeID"]));
                    userLabel.Text = GetUserName(Convert.ToInt32(reader["UserId"]));
                    publishDateLabel.Text = reader["PublishDate"].ToString();
                    pictureBox1.Image = GetFlatImage(flatId);

                    userId = Convert.ToInt32(reader["UserId"]);
                }
            }
        }

        private void sendRequestButton_Click(object sender, EventArgs e)
        {
            string query = "insert into Trade(UserId, FlatId, PaymentType, TradeDate, TradeType) " +
                "values(@UserId, @FlatId, @PaymentType, @Date, @TradeType)";

            using(SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.Add(new SqlParameter("@UserId", userId));
                command.Parameters.Add(new SqlParameter("@FlatId", flatId));
                command.Parameters.Add(new SqlParameter("@PaymentType", "Безналичные"));
                command.Parameters.Add(new SqlParameter("@Date", DateTime.Now));
                command.Parameters.Add(new SqlParameter("@TradeType", "Покупка"));

                command.ExecuteNonQuery();
                MessageBox.Show("Заявка успешно отправлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GetUserName(int userId)
        {
            string query = "select SecondName + ' ' + FirstName from Users where ID = @Id";

            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Id", userId));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader[0].ToString();
                }
            }
            return "Неизвестно";
        }

        private string GetFlatType(int flatId)
        {
            string query = "select Type from FlatType where ID = @Id";

            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add(new SqlParameter("@Id", flatId));
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    return reader[0].ToString();
                }
            }
            return "Неизвестно";
        }

        private Image GetFlatImage(int id)
        {
            string query = "select Image from Flats where ID = @Id";

            using (SqlConnection connection = new SqlConnection(DataBase.ConnectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                DataTable dataTable = new DataTable();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

                dataAdapter.Fill(dataTable);

                Image image = null;
                DataRow row = dataTable.Rows[0];
                try
                {
                    image = (Bitmap)((new ImageConverter()).ConvertFrom(row["Image"]));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return image;
                }
                return image;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
