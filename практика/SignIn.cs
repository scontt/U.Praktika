using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика.Connection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace практика
{
    public partial class SignIn : Form
    {
        int cap = 0;
        int tries = 0;
        readonly string connectonString = DataBase.ConnectionString;

        public SignIn()
        {
            InitializeComponent();
            roleComboBox.Items.AddRange(new string[] { "Администратор", "Пользователь" });
            signInButton.Enabled = false;
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            SignUp signUp = new SignUp();
            signUp.ShowDialog();
            Show();
        }

        private void genCaptchaButton_Click(object sender, EventArgs e)
        {
            Random r1 = new Random();
            cap = r1.Next(10000, 99999);
            var image = new Bitmap(this.captchaPictureBox.Width, this.captchaPictureBox.Height);
            var font = new Font("Georgia", 45, FontStyle.Bold, GraphicsUnit.Pixel);
            var graphics = Graphics.FromImage(image);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(0, 0, this.captchaPictureBox.Width, this.captchaPictureBox.Height);
            HatchBrush hatchBrush = new HatchBrush(HatchStyle.SmallConfetti, Color.White, Color.LightBlue);
            graphics.FillRectangle(hatchBrush, rect);
            graphics.DrawString(cap.ToString(), font, Brushes.Black, new Point(0, 0));
            captchaPictureBox.Image = image;
        }

        private void checkCaptchaButton_Click(object sender, EventArgs e)
        {
            if (inputCaptchaTextBox.Text == cap.ToString()) signInButton.Enabled = true;
            else MessageBox.Show("Попробуйте еще раз");
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            //byte admin;
            //var email = Hash.HashValue(emailTextBox.Text);
            //var password = Hash.HashValue(passwordTextBox.Text);
            string email;
            string password;
            int id = 0, admin = 0;
            DataTable dataTable = new DataTable();
            DataRow row;

            //if (roleComboBox.Text == "Администратор") admin = 1;
            //else if (roleComboBox.Text == "Пользователь") admin = 0;
            //else
            //{
            //    MessageBox.Show("Роль не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            string query = "select Email, Password, Admin, ID from Users " +
                "where Email = @email and Password = @password";
            SqlConnection conn = new SqlConnection(connectonString);

            SqlCommand cmd = new SqlCommand(query, conn);
            //cmd.Parameters.Add(new SqlParameter("@email", email));
            //cmd.Parameters.Add(new SqlParameter("@password", password));
            //cmd.Parameters.Add(new SqlParameter("@admin", admin));

            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                row = dataTable.Rows[0];
                admin = Convert.ToInt32(row["Admin"]);
                id = Convert.ToInt32(row["ID"]);
            }

            if(dataTable.Rows.Count == 1 && tries < 3)
            {
                Hide();
                //roleComboBox.Text == "Администратор"
                if (admin == 1)
                {
                    AdminForm adminForm = new AdminForm(id);
                    adminForm.ShowDialog();
                }
                else
                {
                    MainForm mainForm = new MainForm(id);
                    mainForm.ShowDialog();
                }
                tries++;
            }
            else if (tries == 3)
            {
                MessageBox.Show("Превышено максимальное количество попыток входа\nПошел нахуй");
                Application.Exit();
            }
            else
            {
                MessageBox.Show($"Неверный email или пароль\nОсталось попыток: {3 - tries}");
                tries++;
            }

        }
    }
}
