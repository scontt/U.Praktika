namespace практика
{
    partial class SignIn
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
            this.inputCaptchaTextBox = new System.Windows.Forms.TextBox();
            this.checkCaptchaButton = new System.Windows.Forms.Button();
            this.captchaPictureBox = new System.Windows.Forms.PictureBox();
            this.genCaptchaButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.roleComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCaptchaTextBox
            // 
            this.inputCaptchaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCaptchaTextBox.Location = new System.Drawing.Point(226, 184);
            this.inputCaptchaTextBox.Name = "inputCaptchaTextBox";
            this.inputCaptchaTextBox.Size = new System.Drawing.Size(203, 26);
            this.inputCaptchaTextBox.TabIndex = 27;
            // 
            // checkCaptchaButton
            // 
            this.checkCaptchaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkCaptchaButton.Location = new System.Drawing.Point(12, 216);
            this.checkCaptchaButton.Name = "checkCaptchaButton";
            this.checkCaptchaButton.Size = new System.Drawing.Size(417, 42);
            this.checkCaptchaButton.TabIndex = 26;
            this.checkCaptchaButton.Text = "Проверить";
            this.checkCaptchaButton.UseVisualStyleBackColor = true;
            this.checkCaptchaButton.Click += new System.EventHandler(this.checkCaptchaButton_Click);
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Location = new System.Drawing.Point(12, 130);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(208, 80);
            this.captchaPictureBox.TabIndex = 25;
            this.captchaPictureBox.TabStop = false;
            // 
            // genCaptchaButton
            // 
            this.genCaptchaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.genCaptchaButton.Location = new System.Drawing.Point(226, 130);
            this.genCaptchaButton.Name = "genCaptchaButton";
            this.genCaptchaButton.Size = new System.Drawing.Size(203, 51);
            this.genCaptchaButton.TabIndex = 24;
            this.genCaptchaButton.Text = "Сгенерировать CAPTCHA";
            this.genCaptchaButton.UseVisualStyleBackColor = true;
            this.genCaptchaButton.Click += new System.EventHandler(this.genCaptchaButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(8, 482);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(421, 48);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signUpButton.Location = new System.Drawing.Point(8, 429);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(5);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(421, 45);
            this.signUpButton.TabIndex = 22;
            this.signUpButton.Text = "Регистрация";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(18, 381);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(396, 38);
            this.label4.TabIndex = 21;
            this.label4.Text = "Если у вас нет аккаунта, \r\nто можете зарегистрироваться:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.signInButton.Location = new System.Drawing.Point(11, 270);
            this.signInButton.Margin = new System.Windows.Forms.Padding(5);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(418, 44);
            this.signInButton.TabIndex = 20;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(90, 93);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(339, 26);
            this.passwordTextBox.TabIndex = 19;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.emailTextBox.Location = new System.Drawing.Point(90, 54);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(339, 26);
            this.emailTextBox.TabIndex = 18;
            // 
            // roleComboBox
            // 
            this.roleComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleComboBox.FormattingEnabled = true;
            this.roleComboBox.Location = new System.Drawing.Point(90, 15);
            this.roleComboBox.Margin = new System.Windows.Forms.Padding(5);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Size = new System.Drawing.Size(339, 28);
            this.roleComboBox.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(8, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Почта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Роль:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 546);
            this.Controls.Add(this.inputCaptchaTextBox);
            this.Controls.Add(this.checkCaptchaButton);
            this.Controls.Add(this.captchaPictureBox);
            this.Controls.Add(this.genCaptchaButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.roleComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignIn";
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignIn_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputCaptchaTextBox;
        private System.Windows.Forms.Button checkCaptchaButton;
        private System.Windows.Forms.PictureBox captchaPictureBox;
        private System.Windows.Forms.Button genCaptchaButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button signInButton;
        public System.Windows.Forms.TextBox passwordTextBox;
        public System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ComboBox roleComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}