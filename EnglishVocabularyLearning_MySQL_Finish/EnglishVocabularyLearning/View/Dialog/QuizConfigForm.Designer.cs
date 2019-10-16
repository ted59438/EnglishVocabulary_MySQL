namespace EnglishVocabularyLearning
{
    partial class QuizConfigForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.quizTimeSelect = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.categorySelect = new System.Windows.Forms.ComboBox();
			this.submitButton = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Location = new System.Drawing.Point(20, 136);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(105, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "測驗時間：";
			// 
			// quizTimeSelect
			// 
			this.quizTimeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.quizTimeSelect.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.quizTimeSelect.FormattingEnabled = true;
			this.quizTimeSelect.Items.AddRange(new object[] {
            "1分鐘",
            "2分鐘",
            "3分鐘"});
			this.quizTimeSelect.Location = new System.Drawing.Point(132, 133);
			this.quizTimeSelect.Name = "quizTimeSelect";
			this.quizTimeSelect.Size = new System.Drawing.Size(208, 32);
			this.quizTimeSelect.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(20, 191);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 24);
			this.label2.TabIndex = 2;
			this.label2.Text = "測驗分類：";
			// 
			// categorySelect
			// 
			this.categorySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.categorySelect.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categorySelect.FormattingEnabled = true;
			this.categorySelect.Items.AddRange(new object[] {
            "1分鐘",
            "2分鐘",
            "3分鐘"});
			this.categorySelect.Location = new System.Drawing.Point(132, 188);
			this.categorySelect.Name = "categorySelect";
			this.categorySelect.Size = new System.Drawing.Size(208, 32);
			this.categorySelect.TabIndex = 3;
			// 
			// submitButton
			// 
			this.submitButton.BackColor = System.Drawing.Color.DimGray;
			this.submitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.submitButton.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.submitButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.submitButton.Location = new System.Drawing.Point(29, 246);
			this.submitButton.Name = "submitButton";
			this.submitButton.Size = new System.Drawing.Size(136, 35);
			this.submitButton.TabIndex = 4;
			this.submitButton.Text = "開始測驗";
			this.submitButton.UseVisualStyleBackColor = false;
			this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.DimGray;
			this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.button2.Location = new System.Drawing.Point(213, 246);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(127, 35);
			this.button2.TabIndex = 5;
			this.button2.Text = "返回主畫面";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label3.Location = new System.Drawing.Point(20, 30);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 24);
			this.label3.TabIndex = 6;
			this.label3.Text = "學生帳號：";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.usernameTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.usernameTextBox.Location = new System.Drawing.Point(132, 27);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(207, 33);
			this.usernameTextBox.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label4.Location = new System.Drawing.Point(20, 81);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 24);
			this.label4.TabIndex = 8;
			this.label4.Text = "學生密碼：";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.passwordTextBox.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.passwordTextBox.Location = new System.Drawing.Point(133, 78);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(207, 33);
			this.passwordTextBox.TabIndex = 9;
			// 
			// QuizConfigForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(366, 304);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.submitButton);
			this.Controls.Add(this.categorySelect);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.quizTimeSelect);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.Name = "QuizConfigForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "QuizConfigForm";
			this.Load += new System.EventHandler(this.QuizConfigForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox quizTimeSelect;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox categorySelect;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTextBox;
	}
}