namespace MyWinForms
{
    partial class fmStudent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbInsUpd = new System.Windows.Forms.GroupBox();
            this.btDel = new System.Windows.Forms.Button();
            this.btUpd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.dtBd = new System.Windows.Forms.DateTimePicker();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.btSeacrh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIdSearch = new System.Windows.Forms.TextBox();
            this.gvStudent = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGenderReport = new System.Windows.Forms.ComboBox();
            this.btRepByGender = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.gbInsUpd.SuspendLayout();
            this.gbSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.gbInsUpd);
            this.panel2.Controls.Add(this.gbSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 92);
            this.panel2.TabIndex = 1;
            // 
            // gbInsUpd
            // 
            this.gbInsUpd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbInsUpd.Controls.Add(this.btDel);
            this.gbInsUpd.Controls.Add(this.btUpd);
            this.gbInsUpd.Controls.Add(this.label5);
            this.gbInsUpd.Controls.Add(this.label4);
            this.gbInsUpd.Controls.Add(this.label3);
            this.gbInsUpd.Controls.Add(this.label2);
            this.gbInsUpd.Controls.Add(this.btAdd);
            this.gbInsUpd.Controls.Add(this.dtBd);
            this.gbInsUpd.Controls.Add(this.cbGender);
            this.gbInsUpd.Controls.Add(this.tbFN);
            this.gbInsUpd.Controls.Add(this.tbLN);
            this.gbInsUpd.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbInsUpd.Location = new System.Drawing.Point(206, 0);
            this.gbInsUpd.Name = "gbInsUpd";
            this.gbInsUpd.Size = new System.Drawing.Size(508, 92);
            this.gbInsUpd.TabIndex = 4;
            this.gbInsUpd.TabStop = false;
            this.gbInsUpd.Text = "Добавление/изменение";
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(406, 65);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(75, 23);
            this.btDel.TabIndex = 12;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btUpd
            // 
            this.btUpd.Location = new System.Drawing.Point(406, 40);
            this.btUpd.Name = "btUpd";
            this.btUpd.Size = new System.Drawing.Size(75, 23);
            this.btUpd.TabIndex = 11;
            this.btUpd.Text = "Обновить";
            this.btUpd.UseVisualStyleBackColor = true;
            this.btUpd.Click += new System.EventHandler(this.btUpd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Пол";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Дата рождения";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия";
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(406, 14);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dtBd
            // 
            this.dtBd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBd.Location = new System.Drawing.Point(94, 63);
            this.dtBd.Name = "dtBd";
            this.dtBd.Size = new System.Drawing.Size(100, 20);
            this.dtBd.TabIndex = 5;
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.cbGender.Location = new System.Drawing.Point(272, 61);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(100, 21);
            this.cbGender.TabIndex = 4;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(272, 20);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(100, 20);
            this.tbFN.TabIndex = 3;
            // 
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(94, 20);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(100, 20);
            this.tbLN.TabIndex = 2;
            // 
            // gbSearch
            // 
            this.gbSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gbSearch.Controls.Add(this.btSeacrh);
            this.gbSearch.Controls.Add(this.label1);
            this.gbSearch.Controls.Add(this.tbIdSearch);
            this.gbSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbSearch.Location = new System.Drawing.Point(0, 0);
            this.gbSearch.Name = "gbSearch";
            this.gbSearch.Size = new System.Drawing.Size(206, 92);
            this.gbSearch.TabIndex = 3;
            this.gbSearch.TabStop = false;
            this.gbSearch.Text = "Поиск";
            // 
            // btSeacrh
            // 
            this.btSeacrh.Location = new System.Drawing.Point(78, 47);
            this.btSeacrh.Name = "btSeacrh";
            this.btSeacrh.Size = new System.Drawing.Size(100, 23);
            this.btSeacrh.TabIndex = 0;
            this.btSeacrh.Text = "Найти/обновить";
            this.btSeacrh.UseVisualStyleBackColor = true;
            this.btSeacrh.Click += new System.EventHandler(this.btSeacrh_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите ID";
            // 
            // tbIdSearch
            // 
            this.tbIdSearch.Location = new System.Drawing.Point(78, 17);
            this.tbIdSearch.Name = "tbIdSearch";
            this.tbIdSearch.Size = new System.Drawing.Size(100, 20);
            this.tbIdSearch.TabIndex = 1;
            // 
            // gvStudent
            // 
            this.gvStudent.AllowUserToAddRows = false;
            this.gvStudent.AllowUserToDeleteRows = false;
            this.gvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvStudent.Location = new System.Drawing.Point(0, 92);
            this.gvStudent.Name = "gvStudent";
            this.gvStudent.ReadOnly = true;
            this.gvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStudent.Size = new System.Drawing.Size(1077, 512);
            this.gvStudent.TabIndex = 0;
            this.gvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvStudent_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRepByGender);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbGenderReport);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox1.Location = new System.Drawing.Point(802, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Отчеты";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пол";
            // 
            // cbGenderReport
            // 
            this.cbGenderReport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGenderReport.FormattingEnabled = true;
            this.cbGenderReport.Items.AddRange(new object[] {
            "Все",
            "Мужской",
            "Женский"});
            this.cbGenderReport.Location = new System.Drawing.Point(34, 23);
            this.cbGenderReport.Name = "cbGenderReport";
            this.cbGenderReport.Size = new System.Drawing.Size(100, 21);
            this.cbGenderReport.TabIndex = 11;
            // 
            // btRepByGender
            // 
            this.btRepByGender.Location = new System.Drawing.Point(148, 22);
            this.btRepByGender.Name = "btRepByGender";
            this.btRepByGender.Size = new System.Drawing.Size(98, 23);
            this.btRepByGender.TabIndex = 13;
            this.btRepByGender.Text = "Отчет по полу";
            this.btRepByGender.UseVisualStyleBackColor = true;
            this.btRepByGender.Click += new System.EventHandler(this.btRepByGender_Click);
            // 
            // fmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 604);
            this.Controls.Add(this.gvStudent);
            this.Controls.Add(this.panel2);
            this.Name = "fmStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmStudent";
            this.Load += new System.EventHandler(this.fmStudent_Load);
            this.panel2.ResumeLayout(false);
            this.gbInsUpd.ResumeLayout(false);
            this.gbInsUpd.PerformLayout();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gvStudent;
        private System.Windows.Forms.GroupBox gbSearch;
        private System.Windows.Forms.Button btSeacrh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdSearch;
        private System.Windows.Forms.GroupBox gbInsUpd;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DateTimePicker dtBd;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.TextBox tbFN;
        private System.Windows.Forms.TextBox tbLN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btUpd;
        private System.Windows.Forms.Button btDel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRepByGender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGenderReport;
    }
}