namespace Laba3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.nameFilm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seans = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameSeans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateSeans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSeans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hallNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Format = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageLimits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.monthFilm = new System.Windows.Forms.MonthCalendar();
            this.timeFilm = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numberCinemaHall = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.sizeFilm = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ageRestriction = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.formatFilm = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.seans)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 572);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(114, 572);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "Отменить";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // nameFilm
            // 
            this.nameFilm.Location = new System.Drawing.Point(1028, 112);
            this.nameFilm.Margin = new System.Windows.Forms.Padding(2);
            this.nameFilm.Name = "nameFilm";
            this.nameFilm.Size = new System.Drawing.Size(200, 20);
            this.nameFilm.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1025, 86);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование фильма";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1025, 151);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Дата сеанса";
            // 
            // seans
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.seans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameSeans,
            this.DateSeans,
            this.TimeSeans,
            this.hallNumber,
            this.Format,
            this.TimeSize,
            this.Status,
            this.ageLimits});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.seans.DefaultCellStyle = dataGridViewCellStyle5;
            this.seans.Location = new System.Drawing.Point(11, 100);
            this.seans.Margin = new System.Windows.Forms.Padding(2);
            this.seans.Name = "seans";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.seans.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.seans.RowHeadersWidth = 42;
            this.seans.RowTemplate.Height = 24;
            this.seans.Size = new System.Drawing.Size(982, 455);
            this.seans.TabIndex = 7;
            this.seans.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "№";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 25;
            // 
            // NameSeans
            // 
            this.NameSeans.HeaderText = "Наименование фильма";
            this.NameSeans.MinimumWidth = 6;
            this.NameSeans.Name = "NameSeans";
            this.NameSeans.Width = 245;
            // 
            // DateSeans
            // 
            this.DateSeans.HeaderText = "Дата сеанса";
            this.DateSeans.MinimumWidth = 6;
            this.DateSeans.Name = "DateSeans";
            this.DateSeans.Width = 120;
            // 
            // TimeSeans
            // 
            this.TimeSeans.HeaderText = "Время";
            this.TimeSeans.MinimumWidth = 6;
            this.TimeSeans.Name = "TimeSeans";
            this.TimeSeans.Width = 85;
            // 
            // hallNumber
            // 
            this.hallNumber.HeaderText = "Номер зала";
            this.hallNumber.MinimumWidth = 6;
            this.hallNumber.Name = "hallNumber";
            this.hallNumber.Width = 65;
            // 
            // Format
            // 
            this.Format.HeaderText = "Формат";
            this.Format.Name = "Format";
            // 
            // TimeSize
            // 
            this.TimeSize.HeaderText = "Длительность";
            this.TimeSize.Name = "TimeSize";
            this.TimeSize.Width = 115;
            // 
            // Status
            // 
            this.Status.HeaderText = "Статус";
            this.Status.Name = "Status";
            // 
            // ageLimits
            // 
            this.ageLimits.HeaderText = "Возврастные ограничения";
            this.ageLimits.Name = "ageLimits";
            this.ageLimits.Width = 80;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1028, 341);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Время сеанса";
            // 
            // monthFilm
            // 
            this.monthFilm.Location = new System.Drawing.Point(1028, 172);
            this.monthFilm.Margin = new System.Windows.Forms.Padding(7);
            this.monthFilm.Name = "monthFilm";
            this.monthFilm.TabIndex = 9;
            // 
            // timeFilm
            // 
            this.timeFilm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeFilm.Location = new System.Drawing.Point(1031, 356);
            this.timeFilm.Margin = new System.Windows.Forms.Padding(2);
            this.timeFilm.Name = "timeFilm";
            this.timeFilm.ShowUpDown = true;
            this.timeFilm.Size = new System.Drawing.Size(116, 20);
            this.timeFilm.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1028, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Номер зала";
            // 
            // numberCinemaHall
            // 
            this.numberCinemaHall.FormattingEnabled = true;
            this.numberCinemaHall.Location = new System.Drawing.Point(1031, 405);
            this.numberCinemaHall.Name = "numberCinemaHall";
            this.numberCinemaHall.Size = new System.Drawing.Size(65, 21);
            this.numberCinemaHall.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(454, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Журнал сеансов";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(1024, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Ввод данных";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(67, 58);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker2.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1028, 470);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Длительность";
            // 
            // sizeFilm
            // 
            this.sizeFilm.Location = new System.Drawing.Point(1031, 486);
            this.sizeFilm.Name = "sizeFilm";
            this.sizeFilm.Size = new System.Drawing.Size(100, 20);
            this.sizeFilm.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1028, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Возрастные ограничения";
            // 
            // ageRestriction
            // 
            this.ageRestriction.Location = new System.Drawing.Point(1031, 537);
            this.ageRestriction.Name = "ageRestriction";
            this.ageRestriction.Size = new System.Drawing.Size(100, 20);
            this.ageRestriction.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1031, 572);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1117, 572);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // formatFilm
            // 
            this.formatFilm.FormattingEnabled = true;
            this.formatFilm.Location = new System.Drawing.Point(1031, 446);
            this.formatFilm.Name = "formatFilm";
            this.formatFilm.Size = new System.Drawing.Size(100, 21);
            this.formatFilm.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1028, 429);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Формат";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 610);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.formatFilm);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.ageRestriction);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.sizeFilm);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numberCinemaHall);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeFilm);
            this.Controls.Add(this.monthFilm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.seans);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nameFilm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Системный администратор(редактирование)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.seans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox nameFilm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView seans;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthFilm;
        private System.Windows.Forms.DateTimePicker timeFilm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox numberCinemaHall;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameSeans;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateSeans;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSeans;
        private System.Windows.Forms.DataGridViewTextBoxColumn hallNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Format;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageLimits;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox sizeFilm;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ageRestriction;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox formatFilm;
        private System.Windows.Forms.Label label10;
    }
}

