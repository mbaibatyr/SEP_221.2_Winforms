namespace MyWinForms
{
    partial class Form1
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
            this.cbCIty = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdffdsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sdfgdfgToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dgCity = new System.Windows.Forms.DataGridView();
            this.btCityLoad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCity)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCIty
            // 
            this.cbCIty.DisplayMember = "name";
            this.cbCIty.FormattingEnabled = true;
            this.cbCIty.Location = new System.Drawing.Point(41, 143);
            this.cbCIty.Name = "cbCIty";
            this.cbCIty.Size = new System.Drawing.Size(198, 21);
            this.cbCIty.TabIndex = 0;
            this.cbCIty.ValueMember = "id";
            this.cbCIty.SelectedIndexChanged += new System.EventHandler(this.cbCIty_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 54);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "TestConnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Country";
            // 
            // cbCountry
            // 
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(41, 54);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(198, 21);
            this.cbCountry.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "City";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // sdffdsToolStripMenuItem
            // 
            this.sdffdsToolStripMenuItem.Name = "sdffdsToolStripMenuItem";
            this.sdffdsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sdffdsToolStripMenuItem.Text = "sdffds";
            // 
            // sdfgdfgToolStripMenuItem
            // 
            this.sdfgdfgToolStripMenuItem.Name = "sdfgdfgToolStripMenuItem";
            this.sdfgdfgToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sdfgdfgToolStripMenuItem.Text = "sdfgdfg";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(584, 55);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(689, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '#';
            this.textBox1.Size = new System.Drawing.Size(128, 20);
            this.textBox1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(842, 55);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dgCity
            // 
            this.dgCity.AllowUserToAddRows = false;
            this.dgCity.AllowUserToDeleteRows = false;
            this.dgCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCity.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgCity.Location = new System.Drawing.Point(0, 319);
            this.dgCity.Name = "dgCity";
            this.dgCity.ReadOnly = true;
            this.dgCity.Size = new System.Drawing.Size(1007, 260);
            this.dgCity.TabIndex = 10;
            // 
            // btCityLoad
            // 
            this.btCityLoad.Location = new System.Drawing.Point(40, 276);
            this.btCityLoad.Name = "btCityLoad";
            this.btCityLoad.Size = new System.Drawing.Size(172, 23);
            this.btCityLoad.TabIndex = 11;
            this.btCityLoad.Text = "Загрузить в таблицу";
            this.btCityLoad.UseVisualStyleBackColor = true;
            this.btCityLoad.Click += new System.EventHandler(this.btCityLoad_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 579);
            this.Controls.Add(this.btCityLoad);
            this.Controls.Add(this.dgCity);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cbCIty);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbCIty;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdffdsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sdfgdfgToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dgCity;
        private System.Windows.Forms.Button btCityLoad;
    }
}

