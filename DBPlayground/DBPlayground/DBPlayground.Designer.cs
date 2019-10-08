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
			((System.ComponentModel.ISupportInitialize)(this.queryResultGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dbNameInput
			// 
			this.dbNameInput.Location = new System.Drawing.Point(124, 61);
			this.dbNameInput.Margin = new System.Windows.Forms.Padding(2);
			this.dbNameInput.Name = "dbNameInput";
			this.dbNameInput.Size = new System.Drawing.Size(155, 22);
			this.dbNameInput.TabIndex = 1;
			this.dbNameInput.Text = "ithome2019_englishvocabulary";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label1.Location = new System.Drawing.Point(22, 62);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 19);
			this.label1.TabIndex = 1;
			this.label1.Text = "使用資料庫：";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label2.Location = new System.Drawing.Point(22, 134);
			this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "密碼：";
			// 
			// dbPasswordInput
			// 
			this.dbPasswordInput.Location = new System.Drawing.Point(124, 137);
			this.dbPasswordInput.Margin = new System.Windows.Forms.Padding(2);
			this.dbPasswordInput.Name = "dbPasswordInput";
			this.dbPasswordInput.PasswordChar = '*';
			this.dbPasswordInput.Size = new System.Drawing.Size(155, 22);
			this.dbPasswordInput.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.label3.Location = new System.Drawing.Point(22, 28);
			this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 19);
			this.label3.TabIndex = 4;
			this.label3.Text = "伺服器位置：";
			// 
			// serverNameInput
			// 
			this.serverNameInput.Location = new System.Drawing.Point(124, 25);
			this.serverNameInput.Margin = new System.Windows.Forms.Padding(2);
			this.serverNameInput.Name = "serverNameInput";
			this.serverNameInput.Size = new System.Drawing.Size(155, 22);
			this.serverNameInput.TabIndex = 0;
			this.serverNameInput.Text = "localhost";
			// 
			// connectBtn
			// 
			this.connectBtn.BackColor = System.Drawing.Color.Khaki;
			this.connectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.connectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.connectBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.connectBtn.Location = new System.Drawing.Point(25, 171);
			this.connectBtn.Margin = new System.Windows.Forms.Padding(2);
			this.connectBtn.Name = "connectBtn";
			this.connectBtn.Size = new System.Drawing.Size(107, 38);
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
			this.label4.Location = new System.Drawing.Point(22, 98);
			this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(54, 19);
			this.label4.TabIndex = 9;
			this.label4.Text = "帳號：";
			// 
			// dbUsernameInput
			// 
			this.dbUsernameInput.Location = new System.Drawing.Point(124, 98);
			this.dbUsernameInput.Margin = new System.Windows.Forms.Padding(2);
			this.dbUsernameInput.Name = "dbUsernameInput";
			this.dbUsernameInput.Size = new System.Drawing.Size(155, 22);
			this.dbUsernameInput.TabIndex = 2;
			this.dbUsernameInput.Text = "root";
			// 
			// queryResultGrid
			// 
			this.queryResultGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.queryResultGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.queryResultGrid.Location = new System.Drawing.Point(305, 25);
			this.queryResultGrid.Margin = new System.Windows.Forms.Padding(2);
			this.queryResultGrid.Name = "queryResultGrid";
			this.queryResultGrid.RowTemplate.Height = 27;
			this.queryResultGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.queryResultGrid.Size = new System.Drawing.Size(376, 185);
			this.queryResultGrid.TabIndex = 7;
			// 
			// queryStudentBtn
			// 
			this.queryStudentBtn.BackColor = System.Drawing.Color.Wheat;
			this.queryStudentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.queryStudentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.queryStudentBtn.Font = new System.Drawing.Font("微軟正黑體", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.queryStudentBtn.Location = new System.Drawing.Point(168, 171);
			this.queryStudentBtn.Margin = new System.Windows.Forms.Padding(2);
			this.queryStudentBtn.Name = "queryStudentBtn";
			this.queryStudentBtn.Size = new System.Drawing.Size(111, 38);
			this.queryStudentBtn.TabIndex = 10;
			this.queryStudentBtn.Text = "取得學生資料";
			this.queryStudentBtn.UseVisualStyleBackColor = false;
			this.queryStudentBtn.Click += new System.EventHandler(this.queryStudentBtn_Click);
			// 
			// DBPlayground
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(712, 233);
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
			this.Margin = new System.Windows.Forms.Padding(2);
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
	}
}

