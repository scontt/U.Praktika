namespace практика
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainPage = new System.Windows.Forms.TabPage();
            this.greetingLabel = new System.Windows.Forms.Label();
            this.flatsPage = new System.Windows.Forms.TabPage();
            this.rentorsPage = new System.Windows.Forms.TabPage();
            this.landsPage = new System.Windows.Forms.TabPage();
            this.requestPage = new System.Windows.Forms.TabPage();
            this.officesPage = new System.Windows.Forms.TabPage();
            this.accountPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.showPasswordButton = new System.Windows.Forms.Button();
            this.changeProfileButton = new System.Windows.Forms.Button();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.sexTextBox = new System.Windows.Forms.TextBox();
            this.secondNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passportLabel = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.sexLabel = new System.Windows.Forms.Label();
            this.secondNameLable = new System.Windows.Forms.Label();
            this.firstNameLable = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.eventStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1.SuspendLayout();
            this.mainPage.SuspendLayout();
            this.accountPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.mainPage);
            this.tabControl1.Controls.Add(this.flatsPage);
            this.tabControl1.Controls.Add(this.rentorsPage);
            this.tabControl1.Controls.Add(this.landsPage);
            this.tabControl1.Controls.Add(this.requestPage);
            this.tabControl1.Controls.Add(this.officesPage);
            this.tabControl1.Controls.Add(this.accountPage);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 581);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // mainPage
            // 
            this.mainPage.Controls.Add(this.greetingLabel);
            this.mainPage.Location = new System.Drawing.Point(4, 22);
            this.mainPage.Name = "mainPage";
            this.mainPage.Size = new System.Drawing.Size(1020, 583);
            this.mainPage.TabIndex = 6;
            this.mainPage.Text = "Главная";
            this.mainPage.UseVisualStyleBackColor = true;
            // 
            // greetingLabel
            // 
            this.greetingLabel.AutoSize = true;
            this.greetingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.greetingLabel.Location = new System.Drawing.Point(17, 27);
            this.greetingLabel.Name = "greetingLabel";
            this.greetingLabel.Size = new System.Drawing.Size(175, 31);
            this.greetingLabel.TabIndex = 0;
            this.greetingLabel.Text = "Приветствие";
            // 
            // flatsPage
            // 
            this.flatsPage.Location = new System.Drawing.Point(4, 22);
            this.flatsPage.Name = "flatsPage";
            this.flatsPage.Padding = new System.Windows.Forms.Padding(3);
            this.flatsPage.Size = new System.Drawing.Size(1020, 583);
            this.flatsPage.TabIndex = 0;
            this.flatsPage.Text = "Картотека квартир";
            this.flatsPage.UseVisualStyleBackColor = true;
            // 
            // rentorsPage
            // 
            this.rentorsPage.Location = new System.Drawing.Point(4, 22);
            this.rentorsPage.Name = "rentorsPage";
            this.rentorsPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentorsPage.Size = new System.Drawing.Size(1020, 555);
            this.rentorsPage.TabIndex = 1;
            this.rentorsPage.Text = "Список арендаторов";
            this.rentorsPage.UseVisualStyleBackColor = true;
            // 
            // landsPage
            // 
            this.landsPage.Location = new System.Drawing.Point(4, 22);
            this.landsPage.Name = "landsPage";
            this.landsPage.Size = new System.Drawing.Size(1020, 583);
            this.landsPage.TabIndex = 2;
            this.landsPage.Text = "Список арендодателей";
            this.landsPage.UseVisualStyleBackColor = true;
            // 
            // requestPage
            // 
            this.requestPage.Location = new System.Drawing.Point(4, 22);
            this.requestPage.Name = "requestPage";
            this.requestPage.Size = new System.Drawing.Size(1020, 583);
            this.requestPage.TabIndex = 3;
            this.requestPage.Text = "Заявки";
            this.requestPage.UseVisualStyleBackColor = true;
            // 
            // officesPage
            // 
            this.officesPage.Location = new System.Drawing.Point(4, 22);
            this.officesPage.Name = "officesPage";
            this.officesPage.Size = new System.Drawing.Size(1020, 583);
            this.officesPage.TabIndex = 4;
            this.officesPage.Text = "Офисы";
            this.officesPage.UseVisualStyleBackColor = true;
            // 
            // accountPage
            // 
            this.accountPage.Controls.Add(this.button2);
            this.accountPage.Controls.Add(this.exitButton);
            this.accountPage.Controls.Add(this.button1);
            this.accountPage.Controls.Add(this.showPasswordButton);
            this.accountPage.Controls.Add(this.changeProfileButton);
            this.accountPage.Controls.Add(this.passportTextBox);
            this.accountPage.Controls.Add(this.label28);
            this.accountPage.Controls.Add(this.addressTextBox);
            this.accountPage.Controls.Add(this.emailTextBox);
            this.accountPage.Controls.Add(this.phoneTextBox);
            this.accountPage.Controls.Add(this.sexTextBox);
            this.accountPage.Controls.Add(this.secondNameTextBox);
            this.accountPage.Controls.Add(this.firstNameTextBox);
            this.accountPage.Controls.Add(this.passwordTextBox);
            this.accountPage.Controls.Add(this.loginTextBox);
            this.accountPage.Controls.Add(this.label26);
            this.accountPage.Controls.Add(this.groupBox2);
            this.accountPage.Controls.Add(this.label24);
            this.accountPage.Controls.Add(this.label1);
            this.accountPage.Controls.Add(this.label22);
            this.accountPage.Controls.Add(this.label12);
            this.accountPage.Controls.Add(this.label15);
            this.accountPage.Controls.Add(this.label13);
            this.accountPage.Controls.Add(this.label14);
            this.accountPage.Location = new System.Drawing.Point(4, 22);
            this.accountPage.Name = "accountPage";
            this.accountPage.Size = new System.Drawing.Size(1020, 555);
            this.accountPage.TabIndex = 5;
            this.accountPage.Text = "Профиль";
            this.accountPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(6, 509);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(352, 35);
            this.button2.TabIndex = 6;
            this.button2.Text = "Выйти из учетной записи";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.MistyRose;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(672, 509);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(341, 35);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(6, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Удалить учетную запись";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // showPasswordButton
            // 
            this.showPasswordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showPasswordButton.Location = new System.Drawing.Point(6, 427);
            this.showPasswordButton.Name = "showPasswordButton";
            this.showPasswordButton.Size = new System.Drawing.Size(352, 35);
            this.showPasswordButton.TabIndex = 5;
            this.showPasswordButton.Text = "Показать пароль";
            this.showPasswordButton.UseVisualStyleBackColor = true;
            // 
            // changeProfileButton
            // 
            this.changeProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeProfileButton.Location = new System.Drawing.Point(367, 509);
            this.changeProfileButton.Name = "changeProfileButton";
            this.changeProfileButton.Size = new System.Drawing.Size(298, 35);
            this.changeProfileButton.TabIndex = 4;
            this.changeProfileButton.Text = "Изменить данные";
            this.changeProfileButton.UseVisualStyleBackColor = true;
            this.changeProfileButton.Click += new System.EventHandler(this.changeProfileButton_Click);
            // 
            // passportTextBox
            // 
            this.passportTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportTextBox.Location = new System.Drawing.Point(368, 467);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(297, 29);
            this.passportTextBox.TabIndex = 3;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(364, 444);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(169, 20);
            this.label28.TabIndex = 0;
            this.label28.Text = "Паспортные данные:";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(368, 412);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(297, 29);
            this.addressTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(367, 357);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(297, 29);
            this.emailTextBox.TabIndex = 3;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(368, 301);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(297, 29);
            this.phoneTextBox.TabIndex = 3;
            // 
            // sexTextBox
            // 
            this.sexTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexTextBox.Location = new System.Drawing.Point(368, 246);
            this.sexTextBox.Name = "sexTextBox";
            this.sexTextBox.Size = new System.Drawing.Size(297, 29);
            this.sexTextBox.TabIndex = 3;
            // 
            // secondNameTextBox
            // 
            this.secondNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondNameTextBox.Location = new System.Drawing.Point(368, 191);
            this.secondNameTextBox.Name = "secondNameTextBox";
            this.secondNameTextBox.Size = new System.Drawing.Size(297, 29);
            this.secondNameTextBox.TabIndex = 3;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(368, 136);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(297, 29);
            this.firstNameTextBox.TabIndex = 3;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(368, 81);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(297, 29);
            this.passwordTextBox.TabIndex = 3;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(368, 26);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(297, 29);
            this.loginTextBox.TabIndex = 3;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(364, 389);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(61, 20);
            this.label26.TabIndex = 0;
            this.label26.Text = "Адрес:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.passportLabel);
            this.groupBox2.Controls.Add(this.label27);
            this.groupBox2.Controls.Add(this.addressLabel);
            this.groupBox2.Controls.Add(this.emailLabel);
            this.groupBox2.Controls.Add(this.phoneLabel);
            this.groupBox2.Controls.Add(this.sexLabel);
            this.groupBox2.Controls.Add(this.secondNameLable);
            this.groupBox2.Controls.Add(this.firstNameLable);
            this.groupBox2.Controls.Add(this.passwordLabel);
            this.groupBox2.Controls.Add(this.loginLabel);
            this.groupBox2.Controls.Add(this.label25);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(6, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 418);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ваши данные:";
            // 
            // passportLabel
            // 
            this.passportLabel.AutoSize = true;
            this.passportLabel.Location = new System.Drawing.Point(147, 360);
            this.passportLabel.Name = "passportLabel";
            this.passportLabel.Size = new System.Drawing.Size(148, 25);
            this.passportLabel.TabIndex = 1;
            this.passportLabel.Text = "passportLabel";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(6, 335);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(135, 50);
            this.label27.TabIndex = 0;
            this.label27.Text = "Паспортные\r\nданные:";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(147, 292);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(142, 25);
            this.addressLabel.TabIndex = 1;
            this.addressLabel.Text = "addressLabel";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(147, 256);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(116, 25);
            this.emailLabel.TabIndex = 1;
            this.emailLabel.Text = "emailLabel";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(147, 220);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(125, 25);
            this.phoneLabel.TabIndex = 1;
            this.phoneLabel.Text = "phoneLabel";
            // 
            // sexLabel
            // 
            this.sexLabel.AutoSize = true;
            this.sexLabel.Location = new System.Drawing.Point(147, 186);
            this.sexLabel.Name = "sexLabel";
            this.sexLabel.Size = new System.Drawing.Size(99, 25);
            this.sexLabel.TabIndex = 1;
            this.sexLabel.Text = "sexLabel";
            // 
            // secondNameLable
            // 
            this.secondNameLable.AutoSize = true;
            this.secondNameLable.Location = new System.Drawing.Point(147, 149);
            this.secondNameLable.Name = "secondNameLable";
            this.secondNameLable.Size = new System.Drawing.Size(191, 25);
            this.secondNameLable.TabIndex = 1;
            this.secondNameLable.Text = "secondNameLable";
            // 
            // firstNameLable
            // 
            this.firstNameLable.AutoSize = true;
            this.firstNameLable.Location = new System.Drawing.Point(147, 112);
            this.firstNameLable.Name = "firstNameLable";
            this.firstNameLable.Size = new System.Drawing.Size(156, 25);
            this.firstNameLable.TabIndex = 1;
            this.firstNameLable.Text = "firstNameLable";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(147, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(157, 25);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "passwordLabel";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Location = new System.Drawing.Point(147, 39);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(111, 25);
            this.loginLabel.TabIndex = 1;
            this.loginLabel.Text = "loginLabel";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 292);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(79, 25);
            this.label25.TabIndex = 0;
            this.label25.Text = "Адрес:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 256);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(78, 25);
            this.label23.TabIndex = 0;
            this.label23.Text = "E-mail:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 220);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(108, 25);
            this.label21.TabIndex = 0;
            this.label21.Text = "Телефон:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 186);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "Пол:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 149);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(110, 25);
            this.label17.TabIndex = 0;
            this.label17.Text = "Фамилия:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 112);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 25);
            this.label18.TabIndex = 0;
            this.label18.Text = "Имя:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 74);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "Пароль:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 39);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(77, 25);
            this.label20.TabIndex = 0;
            this.label20.Text = "Логин:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(364, 333);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(57, 20);
            this.label24.TabIndex = 0;
            this.label24.Text = "E-mail:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(364, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(364, 278);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 20);
            this.label22.TabIndex = 0;
            this.label22.Text = "Телефон:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(364, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(71, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Пароль:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(364, 223);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 0;
            this.label15.Text = "Пол:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(364, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Имя:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(364, 168);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Фамилия:";
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 588);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1031, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // eventStatusLabel
            // 
            this.eventStatusLabel.Name = "eventStatusLabel";
            this.eventStatusLabel.Size = new System.Drawing.Size(96, 17);
            this.eventStatusLabel.Text = "eventStatusLabel";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 610);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Недвижимость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.mainPage.ResumeLayout(false);
            this.mainPage.PerformLayout();
            this.accountPage.ResumeLayout(false);
            this.accountPage.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage flatsPage;
        private System.Windows.Forms.TabPage rentorsPage;
        private System.Windows.Forms.TabPage landsPage;
        private System.Windows.Forms.TabPage requestPage;
        private System.Windows.Forms.TabPage officesPage;
        private System.Windows.Forms.TabPage accountPage;
        private System.Windows.Forms.TabPage mainPage;
        private System.Windows.Forms.Label greetingLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label sexLabel;
        private System.Windows.Forms.Label secondNameLable;
        private System.Windows.Forms.Label firstNameLable;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label passportLabel;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox sexTextBox;
        private System.Windows.Forms.TextBox secondNameTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button showPasswordButton;
        private System.Windows.Forms.Button changeProfileButton;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel eventStatusLabel;
    }
}

