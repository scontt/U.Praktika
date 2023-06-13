using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using практика.Connection;
using практика.cs;
using практика.db;

namespace практика
{
    public partial class MainForm : Form
    {
        static readonly string connectionString = DataBase.ConnectionString;

        string eventName = string.Empty;
        string query;
        string name = string.Empty;
        string sex = string.Empty;
        string eventTime = string.Empty;
        int id, eventId, admin = 0;
        DateTime eventDateTime;
        SqlDataAdapter dataAdapter;
        SqlConnection con = new SqlConnection(connectionString);
        //DataTable dataTable = new DataTable();
        DataSet agency = new DataSet();
        DataRow row;

        public MainForm()
        {
            InitializeComponent();
           // InitializeGMapControl();
        }

        public MainForm(int id)
        {
            InitializeComponent();

            this.id = id;
           // InitializeGMapControl();

            #region dataset

            agency.Tables.Add("User");

           
            agency.Tables["User"].Columns.Add("ID", typeof(Int32));
            agency.Tables["User"].Columns.Add("FirstName", typeof(String));
            agency.Tables["User"].Columns.Add("Phone", typeof(String));
            agency.Tables["User"].Columns.Add("Passport", typeof(String));
            agency.Tables["User"].Columns.Add("Address", typeof(String));
            agency.Tables["User"].Columns.Add("Admin", typeof(Byte));
            agency.Tables["User"].Columns.Add("Email", typeof(String));
            agency.Tables["User"].Columns.Add("Password", typeof(String));
            agency.Tables["User"].Columns.Add("Sex", typeof(String));
            agency.Tables["User"].Columns.Add("Login", typeof(String));
            agency.Tables["User"].Columns.Add("SecondName", typeof(String));

            #endregion

            #region Главная
            int hour = DateTime.Now.Hour;
            string greetingText = string.Empty;

            if (hour >= 0 && hour < 6) greetingText = "Доброй ночи, ";
            else if (hour >= 6 && hour < 12) greetingText = "Доброе утро, ";
            else if (hour >= 12 && hour < 18) greetingText = "Добрый день, ";
            else if (hour >= 18 && hour < 24) greetingText = "Добрый вечер, ";

            query = "select * from Users where ID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            dataAdapter.Fill(agency.Tables["User"]);


            DataRow row;
            if (agency.Tables["User"].Rows.Count == 1)
            {
                row = agency.Tables["User"].Rows[0];
                name = row["FirstName"].ToString();
                sex = row["Sex"].ToString();
                admin = Convert.ToInt32(row["Admin"]);
            }

            var sb = new StringBuilder(greetingText);
            sb.Append(name);

            greetingLabel.Text = sb.ToString();
            #endregion

            #region Мероприятие
            
            row = Event.GetLastEvent();

            eventId = Convert.ToInt32(row["ID"]);
            eventDateTime = Convert.ToDateTime(row["EventDate"]);
            eventName = row["Name"].ToString();

            #endregion

            if (admin == 0) tabControl1.TabPages.Remove(usersPage);
            else
            {
                agency.Tables.Add("AllUsers");

                agency.Tables["AllUsers"].Columns.Add("ID", typeof(Int32));
                agency.Tables["AllUsers"].Columns.Add("FirstName", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Phone", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Passport", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Address", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Admin", typeof(Byte));
                agency.Tables["AllUsers"].Columns.Add("Email", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Password", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Sex", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("Login", typeof(String));
                agency.Tables["AllUsers"].Columns.Add("SecondName", typeof(String));

                query = "select * from Users where ID <> @ID";

                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@ID", id));

                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(agency.Tables["AllUsers"]);

                dataGridView1.DataSource = agency.Tables["AllUsers"];
            }

        }
       /* private void InitializeGMapControl()
        {
            gMapControl1 = new GMapControl();
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(56.0153, 92.8932);
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 16;
            gMapControl1.Zoom = 11;
            gMapControl1.ShowCenter = false;
            gMapControl1.ShowTileGridLines = false;
            gMapControl1.CanDragMap = true;
            gMapControl1.MouseWheelZoomEnabled = true;

            tabControl1.TabPages[0].Controls.Add(gMapControl1); // Добавляем GMapControl на первую вкладку
        }
       */

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Профиль

            if (tabControl1.SelectedIndex == 4)
            {
                row = agency.Tables["User"].Rows[0];

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
                "Passport = @Passport," +
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
                UpdateUserTable();
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void buttonprod_Click(object sender, EventArgs e)
        {
            Hide();
            Sale sale = new Sale();
            sale.ShowDialog();
            Show();
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void buttonpriob_Click(object sender, EventArgs e)
        {
            Hide();
            Purchase purchase = new Purchase();
            purchase.ShowDialog();
            Show();
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            if(eventNameTextBox.Text.Length != 0 || eventDateTextBox.Text.Length != 0 ||
                eventTypeTextBox.Text.Length != 0 || eventDescriptionRichTextBox.Text.Length != 0)
            {
                query = "update EventsT set " +
                    "Name = @Name, " +
                    "Description = @Description, " +
                    "Type = @Type, " +
                    "EventDate = @EventDate " +
                    "where ID = @ID";

                try
                {
                    DateTime eventDate = Convert.ToDateTime(eventDateTextBox.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", eventNameTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Description", eventDescriptionRichTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Type", eventTypeTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@EventDate", eventDate));
                    cmd.Parameters.Add(new SqlParameter("@ID", eventId));
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Мероприятие успешно изменено", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                finally 
                {
                    con.Close();
                    updateEvent(sender, e);
                }
            }
        }

        private void scheduleEventButton_Click(object sender, EventArgs e)
        {
            if (eventNameTextBox.Text.Length != 0 || eventDateTextBox.Text.Length != 0 ||
                eventTypeTextBox.Text.Length != 0 || eventDescriptionRichTextBox.Text.Length != 0)
            {
                query = "insert into EventsT(Name, Description, Type, EventDate) " +
                    "values(@Name, @Description, @Type, @Date)";

                using(con = new SqlConnection(connectionString))
                {
                    DateTime eventDate = Convert.ToDateTime(eventDateTextBox.Text);

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", eventNameTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Description", eventDescriptionRichTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Type", eventTypeTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Date", eventDate));

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Мероприятие успешно запланировано", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    updateEvent(sender, e);
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            double days = eventDateTime.Subtract(currentTime).TotalDays; // разность дней события от текущей даты
            double hours = eventDateTime.Subtract(currentTime).TotalHours; // разность часов события от текущего времени
            double mins = eventDateTime.Subtract(currentTime).TotalMinutes; // разность минут события от текущего времени
            int daysInt = (int)days; // количество дней
            int hoursInt = (int)hours - (daysInt * 24); // количество часов
            int minsInt = (int)mins - (int)hours * 60; // количество минут
            eventTime = $"{daysInt} дней {hoursInt} часов {minsInt} минут";
            eventStatusLabel.Text = "Осталось " + daysInt.ToString() + " дней, " + hoursInt.ToString() + " часов, " + minsInt.ToString()
            + " минут до события " + eventName;

            eventNameLabel.Text = $"{eventName} начнется через {eventTime}";
        }

        private void updateEvent(object sender, EventArgs e)
        {
            row = Event.GetLastEvent();
            eventName = row["Name"].ToString();
            eventDateTime = Convert.ToDateTime(row["EventDate"]);
        }

        private void UpdateUserTable()
        {
            query = "select * from Users where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            agency.Tables["User"].Clear();
            dataAdapter.Fill(agency.Tables["User"]);
        }
    }

}
