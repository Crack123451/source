namespace TestNauka
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодировкаОтметокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.кодировкаОтметокToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.табелиСотрудниковToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxTimetables = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Search = new System.Windows.Forms.Button();
            this.comboBoxYears = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxAddress = new System.Windows.Forms.ListBox();
            this.listBoxRemoteWork = new System.Windows.Forms.ListBox();
            this.listBoxPosition = new System.Windows.Forms.ListBox();
            this.listBoxAge = new System.Windows.Forms.ListBox();
            this.listBoxBirthday = new System.Windows.Forms.ListBox();
            this.listBoxLastName = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxFirstName = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.testNaukaBaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.testNaukaBaseDataSet = new TestNauka.TestNaukaBaseDataSet();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testNaukaBaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.testNaukaBaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.кодировкаОтметокToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.добавитьToolStripMenuItem.Text = "Войти в базу";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click_1);
            // 
            // кодировкаОтметокToolStripMenuItem
            // 
            this.кодировкаОтметокToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кодировкаОтметокToolStripMenuItem1,
            this.табелиСотрудниковToolStripMenuItem});
            this.кодировкаОтметокToolStripMenuItem.Name = "кодировкаОтметокToolStripMenuItem";
            this.кодировкаОтметокToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.кодировкаОтметокToolStripMenuItem.Text = "Справка";
            // 
            // кодировкаОтметокToolStripMenuItem1
            // 
            this.кодировкаОтметокToolStripMenuItem1.Name = "кодировкаОтметокToolStripMenuItem1";
            this.кодировкаОтметокToolStripMenuItem1.Size = new System.Drawing.Size(187, 22);
            this.кодировкаОтметокToolStripMenuItem1.Text = "Кодировка отметок";
            this.кодировкаОтметокToolStripMenuItem1.Click += new System.EventHandler(this.кодировкаОтметокToolStripMenuItem1_Click);
            // 
            // табелиСотрудниковToolStripMenuItem
            // 
            this.табелиСотрудниковToolStripMenuItem.Name = "табелиСотрудниковToolStripMenuItem";
            this.табелиСотрудниковToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.табелиСотрудниковToolStripMenuItem.Text = "Табели сотрудников";
            this.табелиСотрудниковToolStripMenuItem.Click += new System.EventHandler(this.табелиСотрудниковToolStripMenuItem_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(201, 173);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxTimetables);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Search);
            this.groupBox1.Controls.Add(this.comboBoxYears);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMonth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 343);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Депаратменты";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // comboBoxTimetables
            // 
            this.comboBoxTimetables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTimetables.FormattingEnabled = true;
            this.comboBoxTimetables.Location = new System.Drawing.Point(6, 214);
            this.comboBoxTimetables.Name = "comboBoxTimetables";
            this.comboBoxTimetables.Size = new System.Drawing.Size(189, 21);
            this.comboBoxTimetables.TabIndex = 8;
            this.comboBoxTimetables.SelectedIndexChanged += new System.EventHandler(this.comboBoxTimetables_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Выберите табельный № сотрудника";
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(116, 263);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(79, 67);
            this.Search.TabIndex = 5;
            this.Search.Text = "Поиск";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // comboBoxYears
            // 
            this.comboBoxYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxYears.FormattingEnabled = true;
            this.comboBoxYears.Location = new System.Drawing.Point(6, 309);
            this.comboBoxYears.Name = "comboBoxYears";
            this.comboBoxYears.Size = new System.Drawing.Size(92, 21);
            this.comboBoxYears.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Выберите год";
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "Январь",
            "Февраль",
            "Март",
            "Апрель",
            "Май",
            "Июнь",
            "Июль",
            "Август",
            "Сентябрь",
            "Ноябрь",
            "Декабрь"});
            this.comboBoxMonth.Location = new System.Drawing.Point(6, 263);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMonth.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Выберите месяц";
            // 
            // listBoxAddress
            // 
            this.listBoxAddress.FormattingEnabled = true;
            this.listBoxAddress.Location = new System.Drawing.Point(12, 197);
            this.listBoxAddress.Name = "listBoxAddress";
            this.listBoxAddress.Size = new System.Drawing.Size(216, 17);
            this.listBoxAddress.TabIndex = 16;
            // 
            // listBoxRemoteWork
            // 
            this.listBoxRemoteWork.FormattingEnabled = true;
            this.listBoxRemoteWork.Location = new System.Drawing.Point(115, 103);
            this.listBoxRemoteWork.Name = "listBoxRemoteWork";
            this.listBoxRemoteWork.Size = new System.Drawing.Size(107, 17);
            this.listBoxRemoteWork.TabIndex = 15;
            // 
            // listBoxPosition
            // 
            this.listBoxPosition.FormattingEnabled = true;
            this.listBoxPosition.Location = new System.Drawing.Point(12, 160);
            this.listBoxPosition.Name = "listBoxPosition";
            this.listBoxPosition.Size = new System.Drawing.Size(216, 17);
            this.listBoxPosition.TabIndex = 14;
            // 
            // listBoxAge
            // 
            this.listBoxAge.FormattingEnabled = true;
            this.listBoxAge.Location = new System.Drawing.Point(115, 78);
            this.listBoxAge.Name = "listBoxAge";
            this.listBoxAge.Size = new System.Drawing.Size(107, 17);
            this.listBoxAge.TabIndex = 13;
            // 
            // listBoxBirthday
            // 
            this.listBoxBirthday.FormattingEnabled = true;
            this.listBoxBirthday.Location = new System.Drawing.Point(115, 53);
            this.listBoxBirthday.Name = "listBoxBirthday";
            this.listBoxBirthday.Size = new System.Drawing.Size(107, 17);
            this.listBoxBirthday.TabIndex = 12;
            // 
            // listBoxLastName
            // 
            this.listBoxLastName.FormattingEnabled = true;
            this.listBoxLastName.Location = new System.Drawing.Point(115, 28);
            this.listBoxLastName.Name = "listBoxLastName";
            this.listBoxLastName.Size = new System.Drawing.Size(107, 17);
            this.listBoxLastName.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Адрес проживания";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Удаленная работа";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 125);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Должность";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Возраст";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Дата рождения";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Имя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Фамилия";
            // 
            // listBoxFirstName
            // 
            this.listBoxFirstName.FormattingEnabled = true;
            this.listBoxFirstName.Location = new System.Drawing.Point(115, 3);
            this.listBoxFirstName.Name = "listBoxFirstName";
            this.listBoxFirstName.Size = new System.Drawing.Size(107, 17);
            this.listBoxFirstName.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxAddress);
            this.groupBox2.Controls.Add(this.listBoxPosition);
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(485, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(237, 223);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация о сотруднике";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxRemoteWork, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.listBoxAge, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listBoxBirthday, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxLastName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxFirstName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 150);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridViewCalendar);
            this.groupBox3.Location = new System.Drawing.Point(219, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(260, 341);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Календарь";
            // 
            // dataGridViewCalendar
            // 
            this.dataGridViewCalendar.AllowUserToAddRows = false;
            this.dataGridViewCalendar.AllowUserToDeleteRows = false;
            this.dataGridViewCalendar.AllowUserToOrderColumns = true;
            this.dataGridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewCalendar.Location = new System.Drawing.Point(0, 19);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.ReadOnly = true;
            this.dataGridViewCalendar.Size = new System.Drawing.Size(254, 318);
            this.dataGridViewCalendar.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "Отметка";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 110;
            // 
            // testNaukaBaseDataSetBindingSource
            // 
            this.testNaukaBaseDataSetBindingSource.DataSource = this.testNaukaBaseDataSet;
            this.testNaukaBaseDataSetBindingSource.Position = 0;
            // 
            // testNaukaBaseDataSet
            // 
            this.testNaukaBaseDataSet.DataSetName = "TestNaukaBaseDataSet";
            this.testNaukaBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 376);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Табель";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testNaukaBaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.testNaukaBaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem кодировкаОтметокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxYears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ComboBox comboBoxTimetables;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem кодировкаОтметокToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem табелиСотрудниковToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox listBoxAddress;
        private System.Windows.Forms.ListBox listBoxRemoteWork;
        private System.Windows.Forms.ListBox listBoxPosition;
        private System.Windows.Forms.ListBox listBoxAge;
        private System.Windows.Forms.ListBox listBoxBirthday;
        private System.Windows.Forms.ListBox listBoxLastName;
        private System.Windows.Forms.ListBox listBoxFirstName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource testNaukaBaseDataSetBindingSource;
        private TestNaukaBaseDataSet testNaukaBaseDataSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewCalendar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}

