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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.flatsPage = new System.Windows.Forms.TabPage();
            this.rentorsPage = new System.Windows.Forms.TabPage();
            this.landsPage = new System.Windows.Forms.TabPage();
            this.requestPage = new System.Windows.Forms.TabPage();
            this.officesPage = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.flatsPage);
            this.tabControl1.Controls.Add(this.rentorsPage);
            this.tabControl1.Controls.Add(this.landsPage);
            this.tabControl1.Controls.Add(this.requestPage);
            this.tabControl1.Controls.Add(this.officesPage);
            this.tabControl1.Location = new System.Drawing.Point(2, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1028, 609);
            this.tabControl1.TabIndex = 0;
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
            this.rentorsPage.Size = new System.Drawing.Size(1020, 583);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 610);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Недвижимость";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage flatsPage;
        private System.Windows.Forms.TabPage rentorsPage;
        private System.Windows.Forms.TabPage landsPage;
        private System.Windows.Forms.TabPage requestPage;
        private System.Windows.Forms.TabPage officesPage;
    }
}

