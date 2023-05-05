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
            this.gvStudent = new System.Windows.Forms.DataGridView();
            this.btSeacrh = new System.Windows.Forms.Button();
            this.tbIdSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSearch = new System.Windows.Forms.GroupBox();
            this.gbInsUpd = new System.Windows.Forms.GroupBox();
            this.tbLN = new System.Windows.Forms.TextBox();
            this.tbFN = new System.Windows.Forms.TextBox();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.dtBd = new System.Windows.Forms.DateTimePicker();
            this.btAdd = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).BeginInit();
            this.gbSearch.SuspendLayout();
            this.gbInsUpd.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.radioButton2);
            this.panel2.Controls.Add(this.radioButton1);
            this.panel2.Controls.Add(this.gbInsUpd);
            this.panel2.Controls.Add(this.gbSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1077, 92);
            this.panel2.TabIndex = 1;
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
            // tbIdSearch
            // 
            this.tbIdSearch.Location = new System.Drawing.Point(78, 17);
            this.tbIdSearch.Name = "tbIdSearch";
            this.tbIdSearch.Size = new System.Drawing.Size(100, 20);
            this.tbIdSearch.TabIndex = 1;
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
            // gbInsUpd
            // 
            this.gbInsUpd.BackColor = System.Drawing.SystemColors.ButtonFace;
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
            // tbLN
            // 
            this.tbLN.Location = new System.Drawing.Point(94, 20);
            this.tbLN.Name = "tbLN";
            this.tbLN.Size = new System.Drawing.Size(100, 20);
            this.tbLN.TabIndex = 2;
            // 
            // tbFN
            // 
            this.tbFN.Location = new System.Drawing.Point(272, 20);
            this.tbFN.Name = "tbFN";
            this.tbFN.Size = new System.Drawing.Size(100, 20);
            this.tbFN.TabIndex = 3;
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
            // dtBd
            // 
            this.dtBd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtBd.Location = new System.Drawing.Point(94, 63);
            this.dtBd.Name = "dtBd";
            this.dtBd.Size = new System.Drawing.Size(100, 20);
            this.dtBd.TabIndex = 5;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(406, 60);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(816, 24);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(816, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvStudent)).EndInit();
            this.gbSearch.ResumeLayout(false);
            this.gbSearch.PerformLayout();
            this.gbInsUpd.ResumeLayout(false);
            this.gbInsUpd.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}