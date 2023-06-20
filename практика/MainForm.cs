using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
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
        int id, eventId, index = 0, admin = 0;
        int animationStep = 0;
        int animationDuration = 20;
        DateTime eventDateTime;
        SqlDataAdapter dataAdapter;
        SqlConnection con = new SqlConnection(connectionString);
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
            LoadFlats();
            this.id = id;
            SqlCommand cmd;

            carouselPanel.AutoScroll = true;
            carouselPanel.WrapContents = false;
            timer.Interval = 10;
            timer.Tick += CarouselTimer_Tick;
            timer.Start();
            // InitializeGMapControl();

            dealsDataGridView.DataSource = GetDeals();
            dealsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dealsDataGridView.AllowUserToAddRows = false;

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


            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@ID", id));
                SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(agency.Tables["User"]);
            }

            DataRow row;
            if (agency.Tables["User"].Rows.Count == 1)
            {
                row = agency.Tables["User"].Rows[0];
                name = row["FirstName"].ToString();
                sex = row["Sex"].ToString();
                admin = Convert.ToInt32(row["Admin"]);
            }

            var sb = new StringBuilder(greetingText);

            if (sex == "Мужской")
            {
                sb.Append("уважаемый ");
            }
            else if (sex == "Женский")
            {
                sb.Append("уважаемая ");
            }

            sb.Append(name);

            greetingLabel.Text = sb.ToString();
            #endregion

            #region Мероприятие

            row = Event.GetLastEvent();

            eventId = Convert.ToInt32(row["ID"]);
            eventDateTime = Convert.ToDateTime(row["EventDate"]);
            eventName = row["Name"].ToString();

            #endregion

            usersDataGridView.AllowUserToAddRows = false;

            if (admin == 0)
            {
                mainTabControl.TabPages.Remove(eventPage);
                mainTabControl.TabPages.Remove(infoPage);
            }
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

                query = "select * from Users";

                using (con = new SqlConnection(connectionString))
                {
                    con.Open();

                    cmd = new SqlCommand(query, con);

                    dataAdapter = new SqlDataAdapter(cmd);
                    dataAdapter.Fill(agency.Tables["AllUsers"]);
                }

                usersDataGridView.DataSource = agency.Tables["AllUsers"];

                DataTable dt = GetTable("Flats");
                flatsDataGridView.DataSource = dt;
            }

            usersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            agency.Tables.Add(GetTable("Users"));
            bindingSource1.DataSource = agency.Tables["Table1"];
            usersDataGridView.DataSource = bindingSource1.DataSource;

            query = "select * from Flats where UserId = @Id";
            DataTable flatsTable = new DataTable();
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@Id", id));

                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(flatsTable);
            }
            if (flatsTable.Rows.Count > 0)
            {
                foreach (DataRow r in flatsTable.Rows)
                {
                    treeView1.Nodes["Продажа"].Nodes.Add(r.Field<string>("Address"));
                }
            }

            //query = "select * from Trade where "
            //requestsListBox.Items.Add();

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

            if (mainTabControl.SelectedIndex == 4)
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
                UpdateActiveUserTable();
                tabControl1_SelectedIndexChanged(sender, e);
            }
        }

        private void editEventButton_Click(object sender, EventArgs e)
        {
            if(eventNameTextBox.Text.Length != 0 || eventDateTextBox.Text.Length != 0 || 
                eventDescriptionRichTextBox.Text.Length != 0)
            {
                query = "update EventsT set " +
                    "Name = @Name, " +
                    "Description = @Description, " +
                    "EventDate = @EventDate " +
                    "where ID = @ID";

                try
                {
                    DateTime eventDate = Convert.ToDateTime(eventDateTextBox.Text);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", eventNameTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Description", eventDescriptionRichTextBox.Text));
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
                eventDescriptionRichTextBox.Text.Length != 0)
            {
                query = "insert into EventsT(Name, Description, Type, EventDate) " +
                    "values(@Name, @Description, @Date)";

                using(con = new SqlConnection(connectionString))
                {
                    DateTime eventDate = Convert.ToDateTime(eventDateTextBox.Text);

                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.Add(new SqlParameter("@Name", eventNameTextBox.Text));
                    cmd.Parameters.Add(new SqlParameter("@Description", eventDescriptionRichTextBox.Text));
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
            double days = eventDateTime.Subtract(currentTime).TotalDays;
            double hours = eventDateTime.Subtract(currentTime).TotalHours;
            double mins = eventDateTime.Subtract(currentTime).TotalMinutes;
            int daysInt = (int)days;
            int hoursInt = (int)hours - (daysInt * 24);
            int minsInt = (int)mins - (int)hours * 60;
            eventTime = $"{daysInt} дней {hoursInt} часов {minsInt} минут";
            eventStatusLabel.Text = "Осталось " + daysInt.ToString() + " дней, " + hoursInt.ToString() + " часов, " + minsInt.ToString()
            + " минут до события " + eventName;

            eventNameLabel.Text = $"{eventName} начнется через {eventTime}";
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            Sell sell = new Sell(id);
            sell.ShowDialog();
            Show();
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            FlatsForm purchase = new FlatsForm(id);
            purchase.ShowDialog();
            Show();
        }

        private void flatsDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (flatsDataGridView.CurrentCell != null)
            {
                int rowIndex = flatsDataGridView.CurrentCell.RowIndex;

                int flatId = Convert.ToInt32(flatsDataGridView.Rows[rowIndex].Cells[0].Value);
                flatPhotoPictureBox.Image = GetFlatImage(flatId);
                infoAddressTextBox.Text = flatsDataGridView.Rows[rowIndex].Cells["Address"].Value.ToString();
                infoAreaTextBox.Text = flatsDataGridView.Rows[rowIndex].Cells["Area"].Value.ToString();
                infoPriceTextBox.Text = flatsDataGridView.Rows[rowIndex].Cells["Price"].Value.ToString();
                infoFloorTextBox.Text = flatsDataGridView.Rows[rowIndex].Cells["Level"].Value.ToString();
                infoRoomsAmountTextBox.Text = flatsDataGridView.Rows[rowIndex].Cells["RoomsAmount"].Value.ToString();
            }
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            int rowIndex = flatsDataGridView.CurrentCell.RowIndex;
            int flatId = Convert.ToInt32(flatsDataGridView.Rows[rowIndex].Cells["ID"].Value);

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                string query = "update Flats set Image = @Image where ID = @Id";
                SqlCommand command = new SqlCommand(query, con);
                command.Parameters.Add(new SqlParameter("@Id", flatId));
                command.Parameters.Add(new SqlParameter("@Image", SqlDbType.Image, 1000000));
                command.Parameters["@Image"].Value = imageBytes;
                command.ExecuteNonQuery();
            }
        }

        private void searchUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"(FirstName + SecondName) like '%{userInfoSearchUserTextBox.Text.Trim()}%'";
                DataRowCollection allRows = agency.Tables["AllUsers"].Rows;
                DataRow[] searchedRows = agency.Tables["AllUsers"].Select(query);
                if (searchedRows.Length == 0)
                {
                    usersDataGridView.CurrentCell = default;
                    MessageBox.Show("Результатов не найдено", "Поиск");
                    return;
                }
                int rowIndex = allRows.IndexOf(searchedRows[index]);
                usersDataGridView.CurrentCell = usersDataGridView[0, rowIndex];
                index++;
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Поиск закончен", "Поиск");
                index = 0;
                return;
            }
        }

        private void infoEditFlatButton_Click(object sender, EventArgs e)
        {
            int rowIndex = flatsDataGridView.CurrentCell.RowIndex;
            int flatId = Convert.ToInt32(flatsDataGridView.Rows[rowIndex].Cells[0].Value);

            query = "update Flats set " +
                "Address = @Address, " +
                "Area = @Area, " +
                "Price = @Price, " +
                "Level = @Level, " +
                "RoomsAmount = @RoomsAmount " +
                "where ID = @Id";
            
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.Add(new SqlParameter("@Address", infoAddressTextBox.Text));
                command.Parameters.Add(new SqlParameter("@Area", Convert.ToInt32(infoAreaTextBox.Text)));
                command.Parameters.Add(new SqlParameter("@Price", Convert.ToInt32(infoPriceTextBox.Text)));
                command.Parameters.Add(new SqlParameter("@Level", Convert.ToInt32(infoFloorTextBox.Text)));
                command.Parameters.Add(new SqlParameter("@RoomsAmount", Convert.ToInt32(infoRoomsAmountTextBox.Text)));
                command.Parameters.Add(new SqlParameter("@Id", flatId));

                command.ExecuteNonQuery();
                MessageBox.Show("Данные успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataTable dt = GetTable("Flats");
            flatsDataGridView.DataSource = dt;
        }

        private void updateEvent(object sender, EventArgs e)
        {
            row = Event.GetLastEvent();
            eventName = row["Name"].ToString();
            eventDateTime = Convert.ToDateTime(row["EventDate"]);
        }

        private void deleteFlatButton_Click(object sender, EventArgs e)
        {
            DialogResult result = 
                MessageBox.Show("Вы действительно хотите удалить эту квартиру?", "Удаление", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            int rowIndex = flatsDataGridView.CurrentCell.RowIndex;
            int flatId = Convert.ToInt32(flatsDataGridView.Rows[rowIndex].Cells[0].Value);

            query = "delete from Flats where ID = @Id";

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@Id", flatId));

                cmd.ExecuteNonQuery();
                MessageBox.Show("Квартира успешно удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataTable dt = GetTable("Flats");
            flatsDataGridView.DataSource = dt;
        }

        private void usersDataGridView_CurrentCellChanged(object sender, EventArgs e)
        {
            if (usersDataGridView.CurrentCell != null)
            {
                int gridRow = usersDataGridView.CurrentCell.RowIndex;

                userInfoSecondNameTextBox.Text = usersDataGridView.Rows[gridRow].Cells["SecondName"].Value.ToString();
                userInfoFirstNameTextBox.Text = usersDataGridView.Rows[gridRow].Cells["FirstName"].Value.ToString();
                userInfoPhoneTextBox.Text = usersDataGridView.Rows[gridRow].Cells["Phone"].Value.ToString();
                userInfoPassportTextBox.Text = usersDataGridView.Rows[gridRow].Cells["Passport"].Value.ToString();
                userInfoAddressTextBox.Text = usersDataGridView.Rows[gridRow].Cells["Address"].Value.ToString();
                userInfoEmailTextBox.Text = usersDataGridView.Rows[gridRow].Cells["Email"].Value.ToString();
                userInfoLoginTextBox.Text = usersDataGridView.Rows[gridRow].Cells["Login"].Value.ToString();
                userInfoSexComboBox.Text = usersDataGridView.Rows[gridRow].Cells["Sex"].Value.ToString();
            }
        }

        private void userInfoEditUserButton_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show("Вы действительно хотите изменить данные этого пользователя?", "Удаление",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            int gridRow = usersDataGridView.CurrentCell.RowIndex;
            int userId = Convert.ToInt32(usersDataGridView.Rows[gridRow].Cells["ID"].Value);

            query = "update Users set " +
                "SecondName = @SecondName, " +
                "FirstName = @FirstName, " +
                "Phone = @Phone, " +
                "Passport = @Passport, " +
                "Address = @Address, " +
                "Email = @Email, " +
                "Login = @Login, " +
                "Sex = @Sex " +
                "where ID = @Id";

            using (con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@SecondName", userInfoSecondNameTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@FirstName", userInfoFirstNameTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Phone", userInfoPhoneTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Passport", userInfoPassportTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Address", userInfoAddressTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Email", userInfoEmailTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Login", userInfoLoginTextBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Sex", userInfoSexComboBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Id", userId));

                cmd.ExecuteNonQuery();

                MessageBox.Show("Данные успешно изменены", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataTable dt = GetTable("Users");
            usersDataGridView.DataSource = dt;
        }

        private void UpdateActiveUserTable()
        {
            query = "select * from Users where ID = @ID";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Add(new SqlParameter("@ID", id));
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            agency.Tables["User"].Clear();
            dataAdapter.Fill(agency.Tables["User"]);
        }

        private Image GetFlatImage(int id)
        {
            query = "select Image from Flats where ID = @Id";

            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                DataTable dataTable = new DataTable();
                dataAdapter = new SqlDataAdapter(cmd);

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

        private DataTable GetTable(string tableName)
        {
            using (con = new SqlConnection(connectionString))
            {
                DataTable dataTable = new DataTable();
                query = $"select * from {tableName}";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                dataAdapter = new SqlDataAdapter(cmd);
                dataAdapter.Fill(dataTable);
                return dataTable;
            }
        }

        private void LoadFlats()
        {
            DataTable flatsTable = GetTable("Flats");
            
            for (int i = 0; i < flatsTable.Rows.Count; i++)
            {
                Flats flat = new Flats
                {
                    Id = flatsTable.Rows[i].Field<int>("ID"),
                    Area = flatsTable.Rows[i].Field<int>("Area"),
                    Price = flatsTable.Rows[i].Field<int>("Price"),
                    Level = flatsTable.Rows[i].Field<int>("Level"),
                    RoomsAmount = flatsTable.Rows[i].Field<int>("RoomsAmount"),
                    FlatTypeId = flatsTable.Rows[i].Field<int>("FlatTypeId"),
                    UserId = flatsTable.Rows[i].Field<int>("UserId"),
                    PublishDate = flatsTable.Rows[i].Field<DateTime>("PublishDate"),
                    Image = GetFlatImage(flatsTable.Rows[i].Field<int>("ID"))
                };

                if (flat.Image != null)
                {
                    Image image = flat.Image;
                    AddImageToCarousel(image, flat);
                }
            }
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = $"Sex = '{sexFilterComboBox.Text}'";
            usersDataGridView.DataSource = bindingSource1.DataSource;
        }

        private void cancelFilterButton_Click(object sender, EventArgs e)
        {
            bindingSource1.Filter = default;
            usersDataGridView.DataSource = bindingSource1.DataSource;
        }

        private void xmlExportButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("../../users.xml"))
            {
                agency.Tables["Table1"].WriteXml(writer);
                MessageBox.Show("XML-файл успешно экспортирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xmlImportButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите импортировать файл?", "Импорт", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;
            var dataSet = new DataSet();
            if (File.Exists("../../users.xml"))
            {
                usersDataGridView.DataSource = null;
                usersDataGridView.Rows.Clear();
                dataSet.ReadXml("../../users.xml");
                usersDataGridView.DataSource = dataSet.Tables[0];
                MessageBox.Show("XML-файл успешно импортирован", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void AddImageToCarousel(Image image, Flats flat)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 150;
            pictureBox.Height = 150;

            pictureBox.Tag = flat;

            pictureBox.Click += PictureBox_Click;

            carouselPanel.Controls.Add(pictureBox);
        }

        private void saveDealButton_Click(object sender, EventArgs e)
        {
            int rowIndex = dealsDataGridView.CurrentCell.RowIndex;
            int selectedRowID = Convert.ToInt32(dealsDataGridView.Rows[rowIndex].Cells["ID"].Value);

            query = "select * from Trade where ID = @Id";
            string dealString = string.Empty;
            var sb = new StringBuilder(dealString);
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.Add(new SqlParameter("@Id", selectedRowID));
                sb.AppendLine("ID\tUserId\tFlatId\tPaymentType\tTradeDate\t\tTradeType\n");

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sb.Append(reader["ID"].ToString() + "\t");
                    sb.Append(reader["UserId"].ToString() + "\t");
                    sb.Append(reader["FlatId"].ToString() + "\t");
                    sb.Append(reader["PaymentType"].ToString() + "\t");
                    sb.Append(reader["TradeDate"].ToString() + "\t");
                    sb.Append(reader["TradeType"].ToString() + "\t");
                    //dealString += reader["ID"].ToString() + "\t";
                    //dealString += reader["UserId"].ToString() + "\t";
                    //dealString += reader["FlatId"].ToString() + "\t";
                    //dealString += reader["PaymentType"].ToString() + "\t";
                    //dealString += reader["TradeDate"].ToString() + "\t";
                    //dealString += reader["TradeType"].ToString();
                }
            }
            string fileName = "../../покупка.txt";
            var fs = new FileStream(fileName, FileMode.Create);
            using (StreamWriter writer = new StreamWriter(fs, Encoding.Default))
            {
                writer.Write(sb.ToString());
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = (PictureBox)sender;
            Flats selectedTovar = (Flats)pictureBox.Tag;

            Purchase purchase = new Purchase(selectedTovar.Id);

            purchase.ShowDialog();
        }

        private void CarouselTimer_Tick(object sender, EventArgs e)
        {
            // Проверяем, если есть элементы в карусели
            if (carouselPanel.Controls.Count > 0)
            {
                // Получаем горизонтальную прокрутку панели
                int scrollPosition = carouselPanel.HorizontalScroll.Value;
                int maxScrollPosition = carouselPanel.HorizontalScroll.Maximum;
                int scrollStep = 10; // Шаг прокрутки (значение получено с помощью trackBar)

                // Проверяем, если прокрутка достигла конца
                if (scrollPosition + carouselPanel.Width == maxScrollPosition)
                {
                    if (carouselPanel.Controls.Count > 0)
                    {
                        // Получаем первый элемент
                        Control firstItem = carouselPanel.Controls[0];

                        // Удаляем первый элемент из начала списка
                        carouselPanel.Controls.RemoveAt(0);

                        // Добавляем первый элемент в конец списка
                        carouselPanel.Controls.Add(firstItem);
                    }

                    // Устанавливаем прокрутку в начало
                    carouselPanel.HorizontalScroll.Value = 0;
                }
                else
                {

                    // Плавно изменяем прокрутку на каждом шаге таймера
                    if (animationStep < animationDuration)
                    {
                        // Вычисляем новое значение прокрутки с учетом анимации
                        int newScrollPosition = scrollPosition + (scrollStep * animationStep / animationDuration);

                        // Устанавливаем новое значение прокрутки
                        carouselPanel.HorizontalScroll.Value = newScrollPosition;

                        // Увеличиваем счетчик шагов анимации
                        animationStep++;
                    }
                    else
                    {
                        // Прокручиваем панель на шаг прокрутки
                        carouselPanel.HorizontalScroll.Value += scrollStep;
                    }
                }
            }
        }

        public DataTable GetDeals()
        {
            query = "select * from Trade";
            DataTable dataTable = new DataTable();
            using (con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand command = new SqlCommand(query, con);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                dataAdapter.Fill(dataTable);
            }
            return dataTable;
        }
    }
}
