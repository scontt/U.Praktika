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
        int id;
        SqlConnection con = new SqlConnection(connectionString);
        DataTable dataTable = new DataTable();
        DataRow row;

        public AdminForm()
        {
            InitializeComponent();
        }
        public AdminForm(int id)
        {
            InitializeComponent();

            this.id = id;

            #region Приветствие
            int hour = DateTime.Now.Hour;
            string greetingText = string.Empty;

            if (hour >= 0 && hour < 6) greetingText = "Доброй ночи, ";
            else if (hour >= 6 && hour < 12) greetingText = "Доброе утро, ";
            else if (hour >= 12 && hour < 18) greetingText = "Добрый день, ";
            else if (hour >= 18 && hour < 24) greetingText = "Добрый вечер, ";

            string query = "select FirstName, Sex from Users where ID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            dataAdapter.Fill(dataTable);

            DataRow row;
            if (dataTable.Rows.Count == 1)
            {
                row = dataTable.Rows[0];
                name = row["FirstName"].ToString();
                sex = row["Sex"].ToString();
            }

            var sb = new StringBuilder(greetingText);
            sb.Append(name);

            greetingLabel.Text = sb.ToString();
            #endregion
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Профиль

            if (tabControl1.SelectedIndex == 6)
            {
                dataTable.Clear();
                SqlDataAdapter dataAdapter;
                string query = "select * from Users where ID = @ID";
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.Add(new SqlParameter("@ID", id));

                dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
                row = dataTable.Rows[0];

                loginLabel.Text = Cryptography.Decrypt(row["Login"].ToString());
                passwordLabel.Text = Cryptography.Decrypt(row["Password"].ToString());
                firstNameLable.Text = row["FirstName"].ToString();
                secondNameLable.Text = row["SecondName"].ToString();
                sexLabel.Text = row["Sex"].ToString();
                phoneLabel.Text = row["Phone"].ToString();
                emailLabel.Text = Cryptography.Decrypt(row["Email"].ToString());
                addressLabel.Text = row["Address"].ToString();
                passportLabel.Text = row["Passport"].ToString();

                loginTextBox.Text = Cryptography.Decrypt(row["Login"].ToString());
                passwordTextBox.Text = Cryptography.Decrypt(row["Password"].ToString());
                firstNameTextBox.Text = row["FirstName"].ToString();
                secondNameTextBox.Text = row["SecondName"].ToString();
                sexTextBox.Text = row["Sex"].ToString();
                phoneTextBox.Text = row["Phone"].ToString();
                emailTextBox.Text = Cryptography.Decrypt(row["Email"].ToString());
                addressTextBox.Text = row["Address"].ToString();
                passportTextBox.Text = row["Passport"].ToString();
            }

            #endregion
        }

        private void changeProfileButton_Click(object sender, EventArgs e)
        {
            string login = Cryptography.Encrypt(loginTextBox.Text);
            string email = Cryptography.Encrypt(emailTextBox.Text);
            string password = Cryptography.Encrypt(passwordTextBox.Text);
            string query = "update Users set " +
                "Login = @Login, " +
                "Password = @Password, " +
                "FirstName = @FirstName, " +
                "SecondName = @SecondName, " +
                "Sex = @Sex, " +
                "Phone = @Phone, " +
                "Email = @Email, " +
                "Passport = @Passport, " +
                "Address = @Address " +
                "where ID = @ID";

            SqlCommand command = new SqlCommand(query, con);

            command.Parameters.Add(new SqlParameter("@Login", login));
            command.Parameters.Add(new SqlParameter("@Password", password));
            command.Parameters.Add(new SqlParameter("@FirstName", firstNameTextBox.Text));
            command.Parameters.Add(new SqlParameter("@SecondName", secondNameTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Sex", sexTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Phone", phoneTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Email", email));
            command.Parameters.Add(new SqlParameter("@Passport", passportTextBox.Text));
            command.Parameters.Add(new SqlParameter("@Address", addressTextBox.Text));
            command.Parameters.Add(new SqlParameter("@ID", id));

            try
            {
                con.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            finally
            {
                con.Close();
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }
    }
}
