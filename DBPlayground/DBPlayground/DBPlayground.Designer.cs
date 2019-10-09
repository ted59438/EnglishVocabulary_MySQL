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
            this.selectStudentCombo = new System.Windows.Forms.ComboBox();
            this.queryOneStudentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dbNameInput
            // 
            this.dbNameInput.Location = new System.Drawing.Point(165, 76);
            this.dbNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbNameInput.Name = "dbNameInput";
            this.dbNameInput.Size = new System.Drawing.Size(205, 25);
            this.dbNameInput.TabIndex = 1;
            this.dbNameInput.Text = "ithome2019_englishvocabulary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(29, 78);
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
            this.label2.Location = new System.Drawing.Point(29, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "密碼：";
            // 
            // dbPasswordInput
            // 
            this.dbPasswordInput.Location = new System.Drawing.Point(165, 171);
            this.dbPasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbPasswordInput.Name = "dbPasswordInput";
            this.dbPasswordInput.PasswordChar = '*';
            this.dbPasswordInput.Size = new System.Drawing.Size(205, 25);
            this.dbPasswordInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(29, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "伺服器位置：";
            // 
            // serverNameInput
            // 
            this.serverNameInput.Location = new System.Drawing.Point(165, 31);
            this.serverNameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.serverNameInput.Name = "serverNameInput";
            this.serverNameInput.Size = new System.Drawing.Size(205, 25);
            this.serverNameInput.TabIndex = 0;
            this.serverNameInput.Text = "localhost";
            // 
            // connectBtn
            // 
            this.connectBtn.BackColor = System.Drawing.Color.Khaki;
            this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.connectBtn.Location = new System.Drawing.Point(33, 214);
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
            this.label4.Location = new System.Drawing.Point(29, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "帳號：";
            // 
            // dbUsernameInput
            // 
            this.dbUsernameInput.Location = new System.Drawing.Point(165, 122);
            this.dbUsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbUsernameInput.Name = "dbUsernameInput";
            this.dbUsernameInput.Size = new System.Drawing.Size(205, 25);
            this.dbUsernameInput.TabIndex = 2;
            this.dbUsernameInput.Text = "root";
            // 
            // queryResultGrid
            // 
            this.queryResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.queryResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.queryResultGrid.Location = new System.Drawing.Point(407, 78);
            this.queryResultGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryResultGrid.Name = "queryResultGrid";
            this.queryResultGrid.RowTemplate.Height = 27;
            this.queryResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.queryResultGrid.Size = new System.Drawing.Size(501, 184);
            this.queryResultGrid.TabIndex = 7;
            // 
            // queryStudentBtn
            // 
            this.queryStudentBtn.BackColor = System.Drawing.Color.Wheat;
            this.queryStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.queryStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.queryStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.queryStudentBtn.Location = new System.Drawing.Point(198, 214);
            this.queryStudentBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.queryStudentBtn.Name = "queryStudentBtn";
            this.queryStudentBtn.Size = new System.Drawing.Size(174, 48);
            this.queryStudentBtn.TabIndex = 10;
            this.queryStudentBtn.Text = "取得所有學生資料";
            this.queryStudentBtn.UseVisualStyleBackColor = false;
            this.queryStudentBtn.Click += new System.EventHandler(this.queryStudentBtn_Click);
            // 
            // selectStudentCombo
            // 
            this.selectStudentCombo.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.selectStudentCombo.FormattingEnabled = true;
            this.selectStudentCombo.Location = new System.Drawing.Point(407, 31);
            this.selectStudentCombo.Name = "selectStudentCombo";
            this.selectStudentCombo.Size = new System.Drawing.Size(322, 33);
            this.selectStudentCombo.TabIndex = 11;
            // 
            // queryOneStudentBtn
            // 
            this.queryOneStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.queryOneStudentBtn.Location = new System.Drawing.Point(762, 31);
            this.queryOneStudentBtn.Name = "queryOneStudentBtn";
            this.queryOneStudentBtn.Size = new System.Drawing.Size(146, 33);
            this.queryOneStudentBtn.TabIndex = 12;
            this.queryOneStudentBtn.Text = "取得學生資訊";
            this.queryOneStudentBtn.UseVisualStyleBackColor = true;
            this.queryOneStudentBtn.Click += new System.EventHandler(this.queryOneStudentBtn_Click);
            // 
            // DBPlayground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 292);
            this.Controls.Add(this.queryOneStudentBtn);
            this.Controls.Add(this.selectStudentCombo);
            this.Controls.Add(this.queryStudentBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dbUsernameInput);
            this.Controls.Add(this.queryResultGrid);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.serverNameInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dbPasswordInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbNameInput);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DBPlayground";
            this.Text = "DB Playground";
            ((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ComboBox selectStudentCombo;
        private System.Windows.Forms.Button queryOneStudentBtn;
    }
}

