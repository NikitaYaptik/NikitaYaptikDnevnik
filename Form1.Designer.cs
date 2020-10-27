namespace Dnevnichochek
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.StudentRecordDataGridView = new System.Windows.Forms.DataGridView();
            this.txtStudent = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtRollNumber = new System.Windows.Forms.Label();
            this.txtRollNumber1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.Label();
            this.txtFatherName1 = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.Label();
            this.txtMobile1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtZadanie = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtOsenka = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.BackColor = System.Drawing.Color.AliceBlue;
            this.txtStudentName.Location = new System.Drawing.Point(170, 12);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(495, 20);
            this.txtStudentName.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tomato;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Gray;
            this.button1.Location = new System.Drawing.Point(167, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StudentRecordDataGridView
            // 
            this.StudentRecordDataGridView.BackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.StudentRecordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentRecordDataGridView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.StudentRecordDataGridView.Location = new System.Drawing.Point(157, 178);
            this.StudentRecordDataGridView.Name = "StudentRecordDataGridView";
            this.StudentRecordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StudentRecordDataGridView.Size = new System.Drawing.Size(612, 146);
            this.StudentRecordDataGridView.TabIndex = 2;
            this.StudentRecordDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentRecordDataGridView_CellClick);
            // 
            // txtStudent
            // 
            this.txtStudent.AutoSize = true;
            this.txtStudent.BackColor = System.Drawing.Color.SpringGreen;
            this.txtStudent.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStudent.ForeColor = System.Drawing.Color.Gray;
            this.txtStudent.Location = new System.Drawing.Point(36, 15);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(42, 17);
            this.txtStudent.TabIndex = 3;
            this.txtStudent.Text = "Имя:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Tomato;
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(294, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Изменить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Tomato;
            this.button3.Cursor = System.Windows.Forms.Cursors.Default;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(422, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Удалить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Tomato;
            this.button4.Cursor = System.Windows.Forms.Cursors.Default;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Old English Text MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(546, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(107, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Очистить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtRollNumber
            // 
            this.txtRollNumber.AutoSize = true;
            this.txtRollNumber.BackColor = System.Drawing.Color.SpringGreen;
            this.txtRollNumber.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRollNumber.ForeColor = System.Drawing.Color.Gray;
            this.txtRollNumber.Location = new System.Drawing.Point(36, 100);
            this.txtRollNumber.Name = "txtRollNumber";
            this.txtRollNumber.Size = new System.Drawing.Size(66, 17);
            this.txtRollNumber.TabIndex = 8;
            this.txtRollNumber.Text = "Группа:";
            // 
            // txtRollNumber1
            // 
            this.txtRollNumber1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtRollNumber1.Location = new System.Drawing.Point(170, 97);
            this.txtRollNumber1.Name = "txtRollNumber1";
            this.txtRollNumber1.Size = new System.Drawing.Size(495, 20);
            this.txtRollNumber1.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(36, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Адрес:";
            // 
            // txtAddress1
            // 
            this.txtAddress1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtAddress1.Location = new System.Drawing.Point(170, 64);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(495, 20);
            this.txtAddress1.TabIndex = 9;
            // 
            // txtFatherName
            // 
            this.txtFatherName.AutoSize = true;
            this.txtFatherName.BackColor = System.Drawing.Color.SpringGreen;
            this.txtFatherName.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFatherName.ForeColor = System.Drawing.Color.Gray;
            this.txtFatherName.Location = new System.Drawing.Point(36, 41);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(79, 17);
            this.txtFatherName.TabIndex = 12;
            this.txtFatherName.Text = "Фамилия:";
            // 
            // txtFatherName1
            // 
            this.txtFatherName1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtFatherName1.Location = new System.Drawing.Point(170, 38);
            this.txtFatherName1.Name = "txtFatherName1";
            this.txtFatherName1.Size = new System.Drawing.Size(495, 20);
            this.txtFatherName1.TabIndex = 11;
            // 
            // txtMobile
            // 
            this.txtMobile.AutoSize = true;
            this.txtMobile.BackColor = System.Drawing.Color.SpringGreen;
            this.txtMobile.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobile.ForeColor = System.Drawing.Color.Gray;
            this.txtMobile.Location = new System.Drawing.Point(36, 126);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(49, 17);
            this.txtMobile.TabIndex = 14;
            this.txtMobile.Text = "Дата:";
            // 
            // txtMobile1
            // 
            this.txtMobile1.BackColor = System.Drawing.Color.AliceBlue;
            this.txtMobile1.Location = new System.Drawing.Point(170, 123);
            this.txtMobile1.Name = "txtMobile1";
            this.txtMobile1.Size = new System.Drawing.Size(495, 20);
            this.txtMobile1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SpringGreen;
            this.label1.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(36, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Дневник:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SpringGreen;
            this.label2.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(9, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Данные студента:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label5.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(193, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Задание:";
            // 
            // txtZadanie
            // 
            this.txtZadanie.BackColor = System.Drawing.Color.AliceBlue;
            this.txtZadanie.Location = new System.Drawing.Point(275, 152);
            this.txtZadanie.Name = "txtZadanie";
            this.txtZadanie.Size = new System.Drawing.Size(76, 20);
            this.txtZadanie.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("Jokerman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(371, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Оценка:";
            // 
            // txtOsenka
            // 
            this.txtOsenka.BackColor = System.Drawing.Color.AliceBlue;
            this.txtOsenka.Location = new System.Drawing.Point(453, 152);
            this.txtOsenka.Name = "txtOsenka";
            this.txtOsenka.Size = new System.Drawing.Size(76, 20);
            this.txtOsenka.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(980, 745);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtOsenka);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtZadanie);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtMobile1);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtFatherName1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.txtRollNumber);
            this.Controls.Add(this.txtRollNumber1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtStudent);
            this.Controls.Add(this.StudentRecordDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtStudentName);
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dnevnik";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentRecordDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView StudentRecordDataGridView;
        private System.Windows.Forms.Label txtStudent;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label txtRollNumber;
        private System.Windows.Forms.TextBox txtRollNumber1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.Label txtFatherName;
        private System.Windows.Forms.TextBox txtFatherName1;
        private System.Windows.Forms.Label txtMobile;
        private System.Windows.Forms.TextBox txtMobile1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtZadanie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtOsenka;
    }
}

