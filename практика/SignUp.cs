using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web;
using System.Security.Cryptography;
using практика.Connection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;

namespace практика
{
    public partial class SignUp : Form
    {
        string server = "(localdb)\\MSSQLLocalDB";
        string db = "agency";
        string connectonString;

        DataBase connection = new DataBase();

        public SignUp()
        {
            InitializeComponent();
            roleComboBox.Items.AddRange(new string[] { "Администратор", "Пользователь" });
            connectonString = connection.Connect(server, db);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-zа-я]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)[0-9a-zа-я]@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            int admin;
            string email = string.Empty;
            if (roleComboBox.Text == "Администратор") admin = 1;
            else if (roleComboBox.Text == "Пользователь") admin = 0;
            else
            {
                MessageBox.Show("Роль не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectonString))
            {
                string name = firstNameTextBox.Text + " " + lastNameTextbox.Text;
                string query = "insert into Users(Name, Phone, Email, Passport, Address, Password, Admin) " +
                    "values(@Name, @Phone, @Email, @Passport, @Address, @Password, @Admin)";

                if (emailTextBox.Text != "")
                {
                    if (Regex.IsMatch(emailTextBox.Text, pattern, RegexOptions.IgnoreCase))
                    {
                        email = Hash.HashValue(emailTextBox.Text);
                    }
                    else { MessageBox.Show("Некорректный email"); return; }
                }
                var password = Hash.HashValue(passwordTextBox.Text);
                string pass = passwordTextBox.Text;


                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", name));
                cmd.Parameters.Add(new SqlParameter("@Phone", phoneTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Passport", passportTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Address", addressTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@Admin", admin));
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
