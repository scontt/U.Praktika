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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.captchaPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // inputCaptchaTextBox
            // 
            this.inputCaptchaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inputCaptchaTextBox.Location = new System.Drawing.Point(265, 166);
            this.inputCaptchaTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.inputCaptchaTextBox.Name = "inputCaptchaTextBox";
            this.inputCaptchaTextBox.Size = new System.Drawing.Size(236, 30);
            this.inputCaptchaTextBox.TabIndex = 27;
            // 
            // checkCaptchaButton
            // 
            this.checkCaptchaButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.checkCaptchaButton.Location = new System.Drawing.Point(15, 203);
            this.checkCaptchaButton.Margin = new System.Windows.Forms.Padding(4);
            this.checkCaptchaButton.Name = "checkCaptchaButton";
            this.checkCaptchaButton.Size = new System.Drawing.Size(486, 49);
            this.checkCaptchaButton.TabIndex = 26;
            this.checkCaptchaButton.Text = "Проверить";
            this.checkCaptchaButton.UseVisualStyleBackColor = true;
            this.checkCaptchaButton.Click += new System.EventHandler(this.checkCaptchaButton_Click);
            // 
            // captchaPictureBox
            // 
            this.captchaPictureBox.Location = new System.Drawing.Point(15, 104);
            this.captchaPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.captchaPictureBox.Name = "captchaPictureBox";
            this.captchaPictureBox.Size = new System.Drawing.Size(242, 92);
            this.captchaPictureBox.TabIndex = 25;
            this.captchaPictureBox.TabStop = false;
            // 
            // genCaptchaButton
            // 
            this.genCaptchaButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.genCaptchaButton.Location = new System.Drawing.Point(265, 104);
            this.genCaptchaButton.Margin = new System.Windows.Forms.Padding(4);
            this.genCaptchaButton.Name = "genCaptchaButton";
            this.genCaptchaButton.Size = new System.Drawing.Size(237, 59);
            this.genCaptchaButton.TabIndex = 24;
            this.genCaptchaButton.Text = "Сгенерировать CAPTCHA";
            this.genCaptchaButton.UseVisualStyleBackColor = true;
            this.genCaptchaButton.Click += new System.EventHandler(this.genCaptchaButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Tomato;
            this.exitButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitButton.Location = new System.Drawing.Point(10, 451);
            this.exitButton.Margin = new System.Windows.Forms.Padding(4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(491, 55);
            this.exitButton.TabIndex = 23;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.signUpButton.Location = new System.Drawing.Point(11, 389);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(6);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(491, 52);
            this.signUpButton.TabIndex = 22;
            this.signUpButton.Text = "Регистрация";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(30, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(462, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Еще не зарегистрированы?";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.signInButton.Location = new System.Drawing.Point(14, 265);
            this.signInButton.Margin = new System.Windows.Forms.Padding(6);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(487, 51);
            this.signInButton.TabIndex = 20;
            this.signInButton.Text = "Войти";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordTextBox.Location = new System.Drawing.Point(108, 61);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(393, 30);
            this.passwordTextBox.TabIndex = 19;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(108, 16);
            this.loginTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(393, 30);
            this.loginTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label3.Location = new System.Drawing.Point(18, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.Location = new System.Drawing.Point(18, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Логин:";
            // 
            // SignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 524);
            this.Controls.Add(this.inputCaptchaTextBox);
            this.Controls.Add(this.checkCaptchaButton);
            this.Controls.Add(this.captchaPictureBox);
            this.Controls.Add(this.genCaptchaButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        public System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}