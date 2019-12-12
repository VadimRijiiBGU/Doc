namespace WindowsFormsApp1
{
    partial class DocForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.generateCountTextBox = new System.Windows.Forms.TextBox();
            this.createDoc = new System.Windows.Forms.Button();
            this.openDoc = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.generateCountLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AttestateNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DisciplineName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // generateCountTextBox
            // 
            this.generateCountTextBox.Location = new System.Drawing.Point(174, 241);
            this.generateCountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.generateCountTextBox.Name = "generateCountTextBox";
            this.generateCountTextBox.Size = new System.Drawing.Size(200, 22);
            this.generateCountTextBox.TabIndex = 0;
            // 
            // createDoc
            // 
            this.createDoc.Location = new System.Drawing.Point(14, 458);
            this.createDoc.Margin = new System.Windows.Forms.Padding(4);
            this.createDoc.Name = "createDoc";
            this.createDoc.Size = new System.Drawing.Size(183, 48);
            this.createDoc.TabIndex = 2;
            this.createDoc.Text = "Create doc";
            this.createDoc.UseVisualStyleBackColor = true;
            this.createDoc.Click += new System.EventHandler(this.createDoc_Click);
            // 
            // openDoc
            // 
            this.openDoc.Location = new System.Drawing.Point(13, 14);
            this.openDoc.Margin = new System.Windows.Forms.Padding(4);
            this.openDoc.Name = "openDoc";
            this.openDoc.Size = new System.Drawing.Size(183, 48);
            this.openDoc.TabIndex = 5;
            this.openDoc.Text = "Open doc";
            this.openDoc.UseVisualStyleBackColor = true;
            this.openDoc.Click += new System.EventHandler(this.openDoc_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(174, 111);
            this.numberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(200, 22);
            this.numberTextBox.TabIndex = 8;
            this.numberTextBox.TextChanged += new System.EventHandler(this.numberTextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(174, 190);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(200, 22);
            this.nameTextBox.TabIndex = 10;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(13, 116);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(58, 17);
            this.numberLabel.TabIndex = 11;
            this.numberLabel.Text = "Number";
            this.numberLabel.Click += new System.EventHandler(this.numberLabel_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(174, 153);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2019, 11, 14, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(12, 158);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(38, 17);
            this.dateLabel.TabIndex = 13;
            this.dateLabel.Text = "Date";
            this.dateLabel.Click += new System.EventHandler(this.dateLabel_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 190);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(45, 17);
            this.nameLabel.TabIndex = 14;
            this.nameLabel.Text = "Name";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // generateCountLabel
            // 
            this.generateCountLabel.AutoSize = true;
            this.generateCountLabel.Location = new System.Drawing.Point(12, 244);
            this.generateCountLabel.Name = "generateCountLabel";
            this.generateCountLabel.Size = new System.Drawing.Size(107, 17);
            this.generateCountLabel.TabIndex = 18;
            this.generateCountLabel.Text = "Generate count";
            this.generateCountLabel.Click += new System.EventHandler(this.generateCountLabel_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AttestateNum,
            this.DisciplineName,
            this.Result,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(399, 14);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(732, 505);
            this.dataGridView1.TabIndex = 19;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.ColumnWidthChanged += new System.Windows.Forms.DataGridViewColumnEventHandler(this.dataGridView1_ColumnWidthChanged);
            this.dataGridView1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dataGridView1_Scroll);
            // 
            // AttestateNum
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.AttestateNum.DefaultCellStyle = dataGridViewCellStyle5;
            this.AttestateNum.Frozen = true;
            this.AttestateNum.HeaderText = "№ дисциплины";
            this.AttestateNum.MinimumWidth = 120;
            this.AttestateNum.Name = "AttestateNum";
            this.AttestateNum.Width = 120;
            // 
            // DisciplineName
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.DisciplineName.DefaultCellStyle = dataGridViewCellStyle6;
            this.DisciplineName.Frozen = true;
            this.DisciplineName.HeaderText = "Название дисциплины";
            this.DisciplineName.MinimumWidth = 6;
            this.DisciplineName.Name = "DisciplineName";
            this.DisciplineName.Width = 125;
            // 
            // Result
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Result.DefaultCellStyle = dataGridViewCellStyle7;
            this.Result.Frozen = true;
            this.Result.HeaderText = "Результат";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.Width = 125;
            // 
            // Date
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Date.DefaultCellStyle = dataGridViewCellStyle8;
            this.Date.Frozen = true;
            this.Date.HeaderText = "Дата";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(76, 298);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(185, 49);
            this.generate.TabIndex = 21;
            this.generate.Text = "Generate ";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // DocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 519);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.generateCountLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.openDoc);
            this.Controls.Add(this.createDoc);
            this.Controls.Add(this.generateCountTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DocForm";
            this.Text = "VadimRijiiBGU";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox generateCountTextBox;
        private System.Windows.Forms.Button createDoc;
        private System.Windows.Forms.Button openDoc;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label generateCountLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AttestateNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DisciplineName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
    }
}

