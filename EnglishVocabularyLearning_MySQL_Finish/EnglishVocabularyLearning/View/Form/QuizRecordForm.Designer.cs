namespace EnglishVocabularyLearning
{
    partial class QuizRecordForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label3 = new System.Windows.Forms.Label();
			this.queryStudentExamBtn = new System.Windows.Forms.Button();
			this.Exam_MasterGrid = new System.Windows.Forms.DataGridView();
			this.測驗時間 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.分類 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.答對題數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.答錯題數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.測驗分數 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.studentCombo = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.queryCorrectRateBtn = new System.Windows.Forms.Button();
			this.categoryCombo = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.studentCombo2 = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.label6 = new System.Windows.Forms.Label();
			this.startDatePicker = new System.Windows.Forms.DateTimePicker();
			this.endDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label7 = new System.Windows.Forms.Label();
			this.Exam_DetailGrid = new System.Windows.Forms.DataGridView();
			this.題號 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.題目 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.中文 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.作答內容 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.是否正確 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.correctRateGrid = new System.Windows.Forms.DataGridView();
			this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.examDatePicker = new System.Windows.Forms.DateTimePicker();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Exam_MasterGrid)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Exam_DetailGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.correctRateGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(261, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(316, 47);
			this.label1.TabIndex = 1;
			this.label1.Text = "單字測驗紀錄一覽";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.tabControl1.Location = new System.Drawing.Point(9, 71);
			this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(798, 577);
			this.tabControl1.TabIndex = 2;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.examDatePicker);
			this.tabPage1.Controls.Add(this.Exam_DetailGrid);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.queryStudentExamBtn);
			this.tabPage1.Controls.Add(this.Exam_MasterGrid);
			this.tabPage1.Controls.Add(this.studentCombo);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
			this.tabPage1.Size = new System.Drawing.Size(790, 548);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "測驗主明細查詢";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(338, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 20);
			this.label3.TabIndex = 19;
			this.label3.Text = "測驗日期:";
			// 
			// queryStudentExamBtn
			// 
			this.queryStudentExamBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.queryStudentExamBtn.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
			this.queryStudentExamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.queryStudentExamBtn.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.queryStudentExamBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.queryStudentExamBtn.Location = new System.Drawing.Point(700, 22);
			this.queryStudentExamBtn.Margin = new System.Windows.Forms.Padding(2);
			this.queryStudentExamBtn.Name = "queryStudentExamBtn";
			this.queryStudentExamBtn.Size = new System.Drawing.Size(74, 34);
			this.queryStudentExamBtn.TabIndex = 18;
			this.queryStudentExamBtn.Text = "查詢";
			this.queryStudentExamBtn.UseVisualStyleBackColor = false;
			this.queryStudentExamBtn.Click += new System.EventHandler(this.queryStudentExamBtn_Click);
			// 
			// Exam_MasterGrid
			// 
			this.Exam_MasterGrid.AllowUserToAddRows = false;
			this.Exam_MasterGrid.AllowUserToDeleteRows = false;
			this.Exam_MasterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Exam_MasterGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
			this.Exam_MasterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Exam_MasterGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.測驗時間,
            this.分類,
            this.答對題數,
            this.答錯題數,
            this.測驗分數});
			this.Exam_MasterGrid.Location = new System.Drawing.Point(2, 75);
			this.Exam_MasterGrid.Margin = new System.Windows.Forms.Padding(2);
			this.Exam_MasterGrid.Name = "Exam_MasterGrid";
			this.Exam_MasterGrid.ReadOnly = true;
			this.Exam_MasterGrid.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Exam_MasterGrid.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.Exam_MasterGrid.RowTemplate.Height = 27;
			this.Exam_MasterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Exam_MasterGrid.Size = new System.Drawing.Size(786, 161);
			this.Exam_MasterGrid.TabIndex = 17;
			this.Exam_MasterGrid.SelectionChanged += new System.EventHandler(this.Exam_MasterGrid_SelectionChanged);
			// 
			// 測驗時間
			// 
			this.測驗時間.DataPropertyName = "測驗時間";
			this.測驗時間.HeaderText = "測驗時間";
			this.測驗時間.Name = "測驗時間";
			this.測驗時間.ReadOnly = true;
			// 
			// 分類
			// 
			this.分類.DataPropertyName = "分類";
			this.分類.HeaderText = "分類";
			this.分類.Name = "分類";
			this.分類.ReadOnly = true;
			// 
			// 答對題數
			// 
			this.答對題數.DataPropertyName = "答對題數";
			this.答對題數.HeaderText = "答對題數";
			this.答對題數.Name = "答對題數";
			this.答對題數.ReadOnly = true;
			// 
			// 答錯題數
			// 
			this.答錯題數.DataPropertyName = "答錯題數";
			this.答錯題數.HeaderText = "答錯題數";
			this.答錯題數.Name = "答錯題數";
			this.答錯題數.ReadOnly = true;
			// 
			// 測驗分數
			// 
			this.測驗分數.DataPropertyName = "測驗分數";
			this.測驗分數.HeaderText = "測驗分數";
			this.測驗分數.Name = "測驗分數";
			this.測驗分數.ReadOnly = true;
			// 
			// studentCombo
			// 
			this.studentCombo.BackColor = System.Drawing.SystemColors.Window;
			this.studentCombo.DataSource = this.studentBindingSource;
			this.studentCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.studentCombo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.studentCombo.FormattingEnabled = true;
			this.studentCombo.Location = new System.Drawing.Point(96, 26);
			this.studentCombo.Name = "studentCombo";
			this.studentCombo.Size = new System.Drawing.Size(192, 28);
			this.studentCombo.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(29, 29);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "受測者:";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.correctRateGrid);
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.endDatePicker);
			this.tabPage2.Controls.Add(this.startDatePicker);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.queryCorrectRateBtn);
			this.tabPage2.Controls.Add(this.categoryCombo);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Controls.Add(this.studentCombo2);
			this.tabPage2.Controls.Add(this.label4);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(790, 548);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "單字正確率統計";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// queryCorrectRateBtn
			// 
			this.queryCorrectRateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
			this.queryCorrectRateBtn.FlatAppearance.BorderColor = System.Drawing.Color.PaleGoldenrod;
			this.queryCorrectRateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.queryCorrectRateBtn.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.queryCorrectRateBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
			this.queryCorrectRateBtn.Location = new System.Drawing.Point(682, 25);
			this.queryCorrectRateBtn.Margin = new System.Windows.Forms.Padding(2);
			this.queryCorrectRateBtn.Name = "queryCorrectRateBtn";
			this.queryCorrectRateBtn.Size = new System.Drawing.Size(92, 79);
			this.queryCorrectRateBtn.TabIndex = 19;
			this.queryCorrectRateBtn.Text = "查詢";
			this.queryCorrectRateBtn.UseVisualStyleBackColor = false;
			this.queryCorrectRateBtn.Click += new System.EventHandler(this.queryCorrectRateBtn_Click);
			// 
			// categoryCombo
			// 
			this.categoryCombo.BackColor = System.Drawing.SystemColors.Window;
			this.categoryCombo.DataSource = this.categoryBindingSource;
			this.categoryCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categoryCombo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categoryCombo.FormattingEnabled = true;
			this.categoryCombo.Location = new System.Drawing.Point(451, 25);
			this.categoryCombo.Name = "categoryCombo";
			this.categoryCombo.Size = new System.Drawing.Size(208, 28);
			this.categoryCombo.TabIndex = 17;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(388, 28);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(57, 20);
			this.label5.TabIndex = 16;
			this.label5.Text = "分類：";
			// 
			// studentCombo2
			// 
			this.studentCombo2.BackColor = System.Drawing.SystemColors.Window;
			this.studentCombo2.DataSource = this.studentBindingSource;
			this.studentCombo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.studentCombo2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.studentCombo2.FormattingEnabled = true;
			this.studentCombo2.Location = new System.Drawing.Point(126, 25);
			this.studentCombo2.Name = "studentCombo2";
			this.studentCombo2.Size = new System.Drawing.Size(233, 28);
			this.studentCombo2.TabIndex = 15;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(47, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(73, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "受測者：";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(31, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(89, 20);
			this.label6.TabIndex = 20;
			this.label6.Text = "測驗區間：";
			// 
			// startDatePicker
			// 
			this.startDatePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.startDatePicker.Location = new System.Drawing.Point(126, 75);
			this.startDatePicker.Name = "startDatePicker";
			this.startDatePicker.Size = new System.Drawing.Size(233, 29);
			this.startDatePicker.TabIndex = 21;
			// 
			// endDatePicker
			// 
			this.endDatePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.endDatePicker.Location = new System.Drawing.Point(403, 75);
			this.endDatePicker.Name = "endDatePicker";
			this.endDatePicker.Size = new System.Drawing.Size(256, 29);
			this.endDatePicker.TabIndex = 22;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label7.Location = new System.Drawing.Point(369, 81);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 20);
			this.label7.TabIndex = 23;
			this.label7.Text = "～";
			// 
			// Exam_DetailGrid
			// 
			this.Exam_DetailGrid.AllowUserToAddRows = false;
			this.Exam_DetailGrid.AllowUserToDeleteRows = false;
			this.Exam_DetailGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.Exam_DetailGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.Exam_DetailGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.Exam_DetailGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.題號,
            this.題目,
            this.中文,
            this.作答內容,
            this.是否正確});
			this.Exam_DetailGrid.Location = new System.Drawing.Point(2, 241);
			this.Exam_DetailGrid.Name = "Exam_DetailGrid";
			this.Exam_DetailGrid.ReadOnly = true;
			this.Exam_DetailGrid.RowHeadersVisible = false;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Exam_DetailGrid.RowsDefaultCellStyle = dataGridViewCellStyle2;
			this.Exam_DetailGrid.RowTemplate.Height = 24;
			this.Exam_DetailGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.Exam_DetailGrid.Size = new System.Drawing.Size(786, 302);
			this.Exam_DetailGrid.TabIndex = 21;
			// 
			// 題號
			// 
			this.題號.DataPropertyName = "題號";
			this.題號.HeaderText = "題號";
			this.題號.Name = "題號";
			this.題號.ReadOnly = true;
			// 
			// 題目
			// 
			this.題目.DataPropertyName = "題目";
			this.題目.HeaderText = "題目";
			this.題目.Name = "題目";
			this.題目.ReadOnly = true;
			// 
			// 中文
			// 
			this.中文.DataPropertyName = "中文";
			this.中文.HeaderText = "中文";
			this.中文.Name = "中文";
			this.中文.ReadOnly = true;
			// 
			// 作答內容
			// 
			this.作答內容.DataPropertyName = "作答內容";
			this.作答內容.HeaderText = "作答內容";
			this.作答內容.Name = "作答內容";
			this.作答內容.ReadOnly = true;
			// 
			// 是否正確
			// 
			this.是否正確.DataPropertyName = "是否正確";
			this.是否正確.HeaderText = "是否正確";
			this.是否正確.Name = "是否正確";
			this.是否正確.ReadOnly = true;
			// 
			// correctRateGrid
			// 
			this.correctRateGrid.AllowUserToAddRows = false;
			this.correctRateGrid.AllowUserToDeleteRows = false;
			this.correctRateGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.correctRateGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.correctRateGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.correctRateGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
			this.correctRateGrid.Location = new System.Drawing.Point(8, 130);
			this.correctRateGrid.Name = "correctRateGrid";
			this.correctRateGrid.ReadOnly = true;
			this.correctRateGrid.RowHeadersVisible = false;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.correctRateGrid.RowsDefaultCellStyle = dataGridViewCellStyle6;
			this.correctRateGrid.RowTemplate.Height = 24;
			this.correctRateGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.correctRateGrid.Size = new System.Drawing.Size(776, 412);
			this.correctRateGrid.TabIndex = 24;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "English";
			this.dataGridViewTextBoxColumn2.HeaderText = "單字";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Chinese";
			this.dataGridViewTextBoxColumn3.HeaderText = "中文";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "CorrectRate";
			this.dataGridViewTextBoxColumn5.HeaderText = "正確率";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// examDatePicker
			// 
			this.examDatePicker.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.examDatePicker.Location = new System.Drawing.Point(421, 25);
			this.examDatePicker.Name = "examDatePicker";
			this.examDatePicker.Size = new System.Drawing.Size(251, 29);
			this.examDatePicker.TabIndex = 22;
			// 
			// QuizRecordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gold;
			this.ClientSize = new System.Drawing.Size(816, 659);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Name = "QuizRecordForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "單字測驗紀錄一覽";
			this.Load += new System.EventHandler(this.QuizRecordForm_Load);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.Exam_MasterGrid)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Exam_DetailGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.correctRateGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button queryStudentExamBtn;
        private System.Windows.Forms.DataGridView Exam_MasterGrid;
        private System.Windows.Forms.ComboBox studentCombo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn 測驗時間;
        private System.Windows.Forms.DataGridViewTextBoxColumn 分類;
        private System.Windows.Forms.DataGridViewTextBoxColumn 答對題數;
        private System.Windows.Forms.DataGridViewTextBoxColumn 答錯題數;
        private System.Windows.Forms.DataGridViewTextBoxColumn 測驗分數;
		private System.Windows.Forms.BindingSource studentBindingSource;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button queryCorrectRateBtn;
		private System.Windows.Forms.ComboBox categoryCombo;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox studentCombo2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView Exam_DetailGrid;
		private System.Windows.Forms.DataGridViewTextBoxColumn 題號;
		private System.Windows.Forms.DataGridViewTextBoxColumn 題目;
		private System.Windows.Forms.DataGridViewTextBoxColumn 中文;
		private System.Windows.Forms.DataGridViewTextBoxColumn 作答內容;
		private System.Windows.Forms.DataGridViewTextBoxColumn 是否正確;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker endDatePicker;
		private System.Windows.Forms.DateTimePicker startDatePicker;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridView correctRateGrid;
		private System.Windows.Forms.BindingSource categoryBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DateTimePicker examDatePicker;
	}
}