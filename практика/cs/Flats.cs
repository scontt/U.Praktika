using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика.Connection;

namespace практика.cs
{
    public class Flats
    {
        public int Id { get; set; }

        public int Area { get; set; }

        public decimal Price { get; set; }

        public int Level { get; set; }

        public int RoomsAmount { get; set; }

        public int FlatTypeId { get; set; }

        public int UserId { get; set; }

        public DateTime PublishDate { get; set; }

        public Image Image { get; set; }

        public static Image GetFlatImage(int id)
        {
            string query = "select Image from Flats where ID = @Id";

            using (var con = new SqlConnection(DataBase.ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                DataTable dataTable = new DataTable();
                var dataAdapter = new SqlDataAdapter(cmd);

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
    }
}
