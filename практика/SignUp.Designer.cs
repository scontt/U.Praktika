namespace практика
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lastNameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.confirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.passportTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Tomato;
            this.cancelButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelButton.Location = new System.Drawing.Point(13, 645);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(539, 53);
            this.cancelButton.TabIndex = 43;
            this.cancelButton.Text = "Назад";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(210, 517);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(342, 31);
            this.roleComboBox.TabIndex = 42;
            this.roleComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sexComboBox_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(138, 520);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 23);
            this.label9.TabIndex = 41;
            this.label9.Text = "Роль:";
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Location = new System.Drawing.Point(17, 582);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(535, 53);
            this.signUpButton.TabIndex = 39;
            this.signUpButton.Text = "Зарегистрироваться";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(2, 426);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 36;
            this.label7.Text = "Паспортные данные:";
            // 
            // lastNameTextbox
            // 
            this.lastNameTextbox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lastNameTextbox.Location = new System.Drawing.Point(210, 273);
            this.lastNameTextbox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.lastNameTextbox.Name = "lastNameTextbox";
            this.lastNameTextbox.Size = new System.Drawing.Size(342, 32);
            this.lastNameTextbox.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(99, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Фамилия:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstNameTextBox.Location = new System.Drawing.Point(210, 223);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(342, 32);
            this.firstNameTextBox.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(142, 226);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Имя:";
            // 
            // confirmPasswordTextBox
            // 
            this.confirmPasswordTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.confirmPasswordTextBox.Location = new System.Drawing.Point(210, 171);
            this.confirmPasswordTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.confirmPasswordTextBox.Name = "confirmPasswordTextBox";
            this.confirmPasswordTextBox.Size = new System.Drawing.Size(342, 32);
            this.confirmPasswordTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(19, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "Повторить пароль:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(210, 120);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(342, 32);
            this.passwordTextBox.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(115, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 26;
            this.label2.Text = "Пароль:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(210, 69);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(342, 32);
            this.emailTextBox.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Email:";
            // 
            // passportTextBox
            // 
            this.passportTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passportTextBox.Location = new System.Drawing.Point(210, 423);
            this.passportTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.passportTextBox.Name = "passportTextBox";
            this.passportTextBox.Size = new System.Drawing.Size(342, 32);
            this.passportTextBox.TabIndex = 44;
            this.passportTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passportTextBox_KeyPress);
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressTextBox.Location = new System.Drawing.Point(210, 470);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(342, 32);
            this.addressTextBox.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(126, 473);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Адрес:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(105, 378);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 23);
            this.label8.TabIndex = 32;
            this.label8.Text = "Телефон:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneTextBox.Location = new System.Drawing.Point(210, 375);
            this.phoneTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(342, 32);
            this.phoneTextBox.TabIndex = 33;
            this.phoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneTextBox_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(144, 328);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 23);
            this.label10.TabIndex = 32;
            this.label10.Text = "Пол:";
            // 
            // sexComboBox
            // 
            this.sexComboBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Location = new System.Drawing.Point(210, 325);
            this.sexComboBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(342, 31);
            this.sexComboBox.TabIndex = 42;
            this.sexComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sexComboBox_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(125, 25);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 23);
            this.label11.TabIndex = 24;
            this.label11.Text = "Логин:";
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(210, 22);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(342, 32);
            this.loginTextBox.TabIndex = 25;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 709);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.passportTextBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.sexComboBox);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lastNameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.confirmPasswordTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SignUp";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox lastNameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox confirmPasswordTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox passportTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox loginTextBox;
    }
}