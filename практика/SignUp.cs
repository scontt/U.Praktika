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
using практика.cs;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace практика
{
    public partial class SignUp : Form
    {
        readonly string connectonString = DataBase.ConnectionString;

        public SignUp()
        {
            InitializeComponent();
            roleComboBox.Items.AddRange(new string[] { "Администратор", "Пользователь" });
            sexComboBox.Items.AddRange(new string[] { "Мужской", "Женский" });
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-zа-я]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)[0-9a-zа-я]@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            int admin;
            string email;
            string password;
            string login;
            if (roleComboBox.Text == "Администратор") admin = 1;
            else if (roleComboBox.Text == "Пользователь") admin = 0;
            else
            {
                MessageBox.Show("Роль не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (emailTextBox.Text != "")
            {
                pattern = @"([\$\@#%\^!]+?)";
                if (!Regex.IsMatch(emailTextBox.Text, pattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Некорректный email - не содержит по крайней мере один из следующих символов: ! @ # $ % ^",
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pattern = @"([0-9]+?)";
                if (!Regex.IsMatch(emailTextBox.Text, pattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Некорректный email - не содержит по крайней мере одну цифру", 
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                pattern = @"([A-ZА-Я]+?)"; //{6,20}[\w]*
                if (!Regex.IsMatch(emailTextBox.Text, pattern, RegexOptions.IgnoreCase))
                {
                    MessageBox.Show("Некорректный email - не содержит по крайней мере одну заглавную букву", 
                        "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            { 
                MessageBox.Show("Введите email"); 
                return; 
            }

            if (firstNameTextBox.Text.Length != 0 || lastNameTextbox.Text.Length != 0 || sexComboBox.Text.Length != 0 ||
                    passwordTextBox.Text.Length != 0 || confirmPasswordTextBox.Text.Length != 0 || phoneTextBox.Text.Length != 0 ||
                    passportTextBox.Text.Length != 0 || addressTextBox.Text.Length != 0)
            {
                login = Cryptography.Encrypt(loginTextBox.Text);
                email = Cryptography.Encrypt(emailTextBox.Text);
                password = Cryptography.Encrypt(passwordTextBox.Text);
            }
            else
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "select Login from Users " +
                "where Login = @Login";
            SqlConnection conn = new SqlConnection(connectonString);

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add(new SqlParameter("@Login", login));

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже зарегестрирован", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (conn = new SqlConnection(connectonString))
            {
                string name = firstNameTextBox.Text + " " + lastNameTextbox.Text;
                query = "insert into Users(Login, Name, Phone, Email, Passport, Address, Password, Admin, Sex) " +
                    "values(@Login, @Name, @Phone, @Email, @Passport, @Address, @Password, @Admin, @Sex)";

                cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Login", login));
                cmd.Parameters.Add(new SqlParameter("@Name", name));
                cmd.Parameters.Add(new SqlParameter("@Phone", phoneTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", email));
                cmd.Parameters.Add(new SqlParameter("@Passport", passportTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Address", addressTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Password", password));
                cmd.Parameters.Add(new SqlParameter("@Admin", admin));
                cmd.Parameters.Add(new SqlParameter("@Sex", sexComboBox.Text));
                conn.Open();
                cmd.ExecuteNonQuery();
            }

            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void phoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar)) return;
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != '+') e.Handled = true;
            if (e.KeyChar == '+' && phoneTextBox.Text.Length > 0) e.Handled = true;
        }

        private void passportTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void sexComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
