using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using практика.Connection;
using практика.cs;
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
            signInButton.Enabled = true;
            passwordTextBox.UseSystemPasswordChar = true;

            loginTextBox.Text = "admin";
            passwordTextBox.Text = "admin";
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
            string login = Cryptography.Encrypt(loginTextBox.Text);
            string password = Cryptography.Encrypt(passwordTextBox.Text);
            int id = 0;
            int admin = 0;
            DataTable dataTable = new DataTable();
            DataRow row;

            string query = "select Email, Password, Admin, ID from Users " +
                "where Login = @Login and Password = @Password";
            SqlConnection conn = new SqlConnection(connectonString);

            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.Add(new SqlParameter("@Login", login));
            cmd.Parameters.Add(new SqlParameter("@Password", password));

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
                MainForm mainForm = new MainForm(id);
                mainForm.ShowDialog();

                tries++;
            }
            else if (tries == 3)
            {
                MessageBox.Show("Превышено максимальное количество попыток входа", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
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
