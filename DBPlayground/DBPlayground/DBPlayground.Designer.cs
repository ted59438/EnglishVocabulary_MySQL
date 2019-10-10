namespace DBPlayground
{
    partial class DBPlayground
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.dbNameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dbPasswordInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serverNameInput = new System.Windows.Forms.TextBox();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dbUsernameInput = new System.Windows.Forms.TextBox();
            this.queryResultGrid = new System.Windows.Forms.DataGridView();
            this.queryStudentBtn = new System.Windows.Forms.Button();
            this.studentNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.studentUsernameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.studentPasswordTextBox = new System.Windows.Forms.TextBox();
            this.insertStudentBtn = new System.Windows.Forms.Button();
            this.editStudentBtn = new System.Windows.Forms.Button();
            this.deleteStudentBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.studentBirthdatePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbNameInput
            // 
            this.dbNameInput.Location = new System.Drawing.Point(153, 79);
            this.dbNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbNameInput.Name = "dbNameInput";
            this.dbNameInput.Size = new System.Drawing.Size(189, 27);
            this.dbNameInput.TabIndex = 1;
            this.dbNameInput.Text = "ithome2019_englishvocabulary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "使用資料庫：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(72, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼：";
            // 
            // dbPasswordInput
            // 
            this.dbPasswordInput.Location = new System.Drawing.Point(153, 174);
            this.dbPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbPasswordInput.Name = "dbPasswordInput";
            this.dbPasswordInput.PasswordChar = '*';
            this.dbPasswordInput.Size = new System.Drawing.Size(189, 27);
            this.dbPasswordInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(15, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "伺服器位置：";
            // 
            // serverNameInput
            // 
            this.serverNameInput.Location = new System.Drawing.Point(153, 34);
            this.serverNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverNameInput.Name = "serverNameInput";
            this.serverNameInput.Size = new System.Drawing.Size(189, 27);
            this.serverNameInput.TabIndex = 0;
            this.serverNameInput.Text = "localhost";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Khaki;
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connectBtn.Location = new System.Drawing.Point(19, 224);
            this.connectBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(134, 48);
            this.connectBtn.TabIndex = 4;
            this.connectBtn.Text = "測試連線";
            this.connectBtn.UseVisualStyleBackColor = false;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(72, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "帳號：";
            // 
            // dbUsernameInput
            // 
            this.dbUsernameInput.Location = new System.Drawing.Point(153, 125);
            this.dbUsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbUsernameInput.Name = "dbUsernameInput";
            this.dbUsernameInput.Size = new System.Drawing.Size(189, 27);
            this.dbUsernameInput.TabIndex = 2;
            this.dbUsernameInput.Text = "root";
            // 
            // queryResultGrid
            // 
            this.queryResultGrid.AllowUserToAddRows = false;
            this.queryResultGrid.AllowUserToDeleteRows = false;
            this.queryResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queryResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResultGrid.Location = new System.Drawing.Point(22, 311);
            this.queryResultGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryResultGrid.Name = "queryResultGrid";
            this.queryResultGrid.ReadOnly = true;
            this.queryResultGrid.RowTemplate.Height = 27;
            this.queryResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queryResultGrid.Size = new System.Drawing.Size(769, 266);
            this.queryResultGrid.TabIndex = 7;
            this.queryResultGrid.SelectionChanged += new System.EventHandler(this.queryResultGrid_SelectionChanged);
            // 
            // queryStudentBtn
            // 
            this.queryStudentBtn.BackColor = System.Drawing.Color.Wheat;
            this.queryStudentBtn.Enabled = false;
            this.queryStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.queryStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.queryStudentBtn.Location = new System.Drawing.Point(170, 224);
            this.queryStudentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryStudentBtn.Name = "queryStudentBtn";
            this.queryStudentBtn.Size = new System.Drawing.Size(174, 48);
            this.queryStudentBtn.TabIndex = 10;
            this.queryStudentBtn.Text = "取得所有學生資料";
            this.queryStudentBtn.UseVisualStyleBackColor = false;
            this.queryStudentBtn.Click += new System.EventHandler(this.queryStudentBtn_Click);
            // 
            // studentNameTextBox
            // 
            this.studentNameTextBox.Location = new System.Drawing.Point(99, 32);
            this.studentNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentNameTextBox.Name = "studentNameTextBox";
            this.studentNameTextBox.Size = new System.Drawing.Size(282, 27);
            this.studentNameTextBox.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(16, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 24);
            this.label5.TabIndex = 14;
            this.label5.Text = "姓名：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(16, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "帳號：";
            // 
            // studentUsernameTextBox
            // 
            this.studentUsernameTextBox.Location = new System.Drawing.Point(99, 126);
            this.studentUsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentUsernameTextBox.Name = "studentUsernameTextBox";
            this.studentUsernameTextBox.Size = new System.Drawing.Size(282, 27);
            this.studentUsernameTextBox.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(16, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 24);
            this.label7.TabIndex = 17;
            this.label7.Text = "生日：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(16, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "密碼：";
            // 
            // studentPasswordTextBox
            // 
            this.studentPasswordTextBox.Location = new System.Drawing.Point(99, 176);
            this.studentPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.studentPasswordTextBox.Name = "studentPasswordTextBox";
            this.studentPasswordTextBox.PasswordChar = '*';
            this.studentPasswordTextBox.Size = new System.Drawing.Size(282, 27);
            this.studentPasswordTextBox.TabIndex = 20;
            // 
            // insertStudentBtn
            // 
            this.insertStudentBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.insertStudentBtn.Enabled = false;
            this.insertStudentBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.insertStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertStudentBtn.Location = new System.Drawing.Point(11, 224);
            this.insertStudentBtn.Name = "insertStudentBtn";
            this.insertStudentBtn.Size = new System.Drawing.Size(112, 45);
            this.insertStudentBtn.TabIndex = 21;
            this.insertStudentBtn.Text = "新增學生";
            this.insertStudentBtn.UseVisualStyleBackColor = false;
            this.insertStudentBtn.Click += new System.EventHandler(this.insertStudentBtn_Click);
            // 
            // editStudentBtn
            // 
            this.editStudentBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.editStudentBtn.Enabled = false;
            this.editStudentBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.editStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editStudentBtn.Location = new System.Drawing.Point(140, 224);
            this.editStudentBtn.Name = "editStudentBtn";
            this.editStudentBtn.Size = new System.Drawing.Size(107, 45);
            this.editStudentBtn.TabIndex = 22;
            this.editStudentBtn.Text = "修改學生";
            this.editStudentBtn.UseVisualStyleBackColor = false;
            // 
            // deleteStudentBtn
            // 
            this.deleteStudentBtn.BackColor = System.Drawing.Color.PowderBlue;
            this.deleteStudentBtn.Enabled = false;
            this.deleteStudentBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.deleteStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteStudentBtn.Location = new System.Drawing.Point(267, 224);
            this.deleteStudentBtn.Name = "deleteStudentBtn";
            this.deleteStudentBtn.Size = new System.Drawing.Size(114, 45);
            this.deleteStudentBtn.TabIndex = 23;
            this.deleteStudentBtn.Text = "刪除學生";
            this.deleteStudentBtn.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.queryStudentBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dbUsernameInput);
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Controls.Add(this.serverNameInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dbPasswordInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dbNameInput);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 285);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "連線資訊";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.studentBirthdatePicker);
            this.groupBox2.Controls.Add(this.deleteStudentBtn);
            this.groupBox2.Controls.Add(this.editStudentBtn);
            this.groupBox2.Controls.Add(this.insertStudentBtn);
            this.groupBox2.Controls.Add(this.studentPasswordTextBox);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.studentUsernameTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.studentNameTextBox);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(394, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 284);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "學生資訊";
            // 
            // studentBirthdatePicker
            // 
            this.studentBirthdatePicker.Location = new System.Drawing.Point(99, 76);
            this.studentBirthdatePicker.Name = "studentBirthdatePicker";
            this.studentBirthdatePicker.Size = new System.Drawing.Size(282, 27);
            this.studentBirthdatePicker.TabIndex = 24;
            // 
            // DBPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 599);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.queryResultGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DBPlayground";
            this.Text = "DB Playground";
            ((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox dbNameInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dbPasswordInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox serverNameInput;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dbUsernameInput;
        private System.Windows.Forms.DataGridView queryResultGrid;
		private System.Windows.Forms.Button queryStudentBtn;
        private System.Windows.Forms.TextBox studentNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox studentUsernameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox studentPasswordTextBox;
        private System.Windows.Forms.Button insertStudentBtn;
        private System.Windows.Forms.Button editStudentBtn;
        private System.Windows.Forms.Button deleteStudentBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker studentBirthdatePicker;
    }
}

