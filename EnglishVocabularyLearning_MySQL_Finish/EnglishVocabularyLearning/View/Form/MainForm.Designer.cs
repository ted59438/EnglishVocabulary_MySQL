namespace EnglishVocabularyLearning
{
    partial class Form1
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.startQuiz = new System.Windows.Forms.Button();
            this.showQuizRecordBtn = new System.Windows.Forms.Button();
            this.showManagerButton = new System.Windows.Forms.Button();
            this.studentsIcon = new System.Windows.Forms.PictureBox();
            this.settingIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.studentsIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(176)))), ((int)(((byte)(65)))));
            this.label1.Location = new System.Drawing.Point(116, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "英文單字學習遊戲";
            // 
            // startQuiz
            // 
            this.startQuiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(227)))), ((int)(((byte)(96)))), ((int)(((byte)(158)))));
            this.startQuiz.FlatAppearance.BorderSize = 0;
            this.startQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startQuiz.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startQuiz.ForeColor = System.Drawing.Color.White;
            this.startQuiz.Location = new System.Drawing.Point(308, 249);
            this.startQuiz.Margin = new System.Windows.Forms.Padding(4);
            this.startQuiz.Name = "startQuiz";
            this.startQuiz.Size = new System.Drawing.Size(320, 84);
            this.startQuiz.TabIndex = 1;
            this.startQuiz.Text = "開始測驗";
            this.startQuiz.UseVisualStyleBackColor = false;
            this.startQuiz.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // showQuizRecordBtn
            // 
            this.showQuizRecordBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(235)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            this.showQuizRecordBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.showQuizRecordBtn.FlatAppearance.BorderSize = 0;
            this.showQuizRecordBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showQuizRecordBtn.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showQuizRecordBtn.ForeColor = System.Drawing.Color.White;
            this.showQuizRecordBtn.Location = new System.Drawing.Point(308, 401);
            this.showQuizRecordBtn.Margin = new System.Windows.Forms.Padding(4);
            this.showQuizRecordBtn.Name = "showQuizRecordBtn";
            this.showQuizRecordBtn.Size = new System.Drawing.Size(320, 84);
            this.showQuizRecordBtn.TabIndex = 2;
            this.showQuizRecordBtn.Text = "測驗紀錄";
            this.showQuizRecordBtn.UseVisualStyleBackColor = false;
            this.showQuizRecordBtn.Click += new System.EventHandler(this.showQuizRecordBtn_Click);
            // 
            // showManagerButton
            // 
            this.showManagerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(248)))), ((int)(((byte)(157)))), ((int)(((byte)(82)))));
            this.showManagerButton.FlatAppearance.BorderSize = 0;
            this.showManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showManagerButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showManagerButton.ForeColor = System.Drawing.Color.White;
            this.showManagerButton.Location = new System.Drawing.Point(308, 545);
            this.showManagerButton.Margin = new System.Windows.Forms.Padding(4);
            this.showManagerButton.Name = "showManagerButton";
            this.showManagerButton.Size = new System.Drawing.Size(320, 84);
            this.showManagerButton.TabIndex = 3;
            this.showManagerButton.Text = "單字管理";
            this.showManagerButton.UseVisualStyleBackColor = false;
            this.showManagerButton.Click += new System.EventHandler(this.showManagerButton_Click);
            // 
            // studentsIcon
            // 
            this.studentsIcon.BackColor = System.Drawing.Color.Transparent;
            this.studentsIcon.Image = global::EnglishVocabularyLearning.Properties.Resources.students;
            this.studentsIcon.Location = new System.Drawing.Point(817, 651);
            this.studentsIcon.Name = "studentsIcon";
            this.studentsIcon.Size = new System.Drawing.Size(67, 50);
            this.studentsIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentsIcon.TabIndex = 6;
            this.studentsIcon.TabStop = false;
            this.studentsIcon.Click += new System.EventHandler(this.studentsIcon_Click);
            this.studentsIcon.MouseEnter += new System.EventHandler(this.studentsIcon_MouseEnter);
            this.studentsIcon.MouseLeave += new System.EventHandler(this.studentsIcon_MouseLeave);
            // 
            // settingIcon
            // 
            this.settingIcon.BackColor = System.Drawing.Color.Transparent;
            this.settingIcon.Image = ((System.Drawing.Image)(resources.GetObject("settingIcon.Image")));
            this.settingIcon.Location = new System.Drawing.Point(890, 651);
            this.settingIcon.Name = "settingIcon";
            this.settingIcon.Size = new System.Drawing.Size(61, 50);
            this.settingIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingIcon.TabIndex = 5;
            this.settingIcon.TabStop = false;
            this.settingIcon.Click += new System.EventHandler(this.settingIcon_Click);
            this.settingIcon.MouseEnter += new System.EventHandler(this.settingIcon_MouseEnter);
            this.settingIcon.MouseLeave += new System.EventHandler(this.settingIcon_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(963, 722);
            this.Controls.Add(this.studentsIcon);
            this.Controls.Add(this.settingIcon);
            this.Controls.Add(this.showManagerButton);
            this.Controls.Add(this.showQuizRecordBtn);
            this.Controls.Add(this.startQuiz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "英文單字學習遊戲";
            ((System.ComponentModel.ISupportInitialize)(this.studentsIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startQuiz;
        private System.Windows.Forms.Button showQuizRecordBtn;
        private System.Windows.Forms.Button showManagerButton;
        private System.Windows.Forms.PictureBox settingIcon;
        private System.Windows.Forms.PictureBox studentsIcon;
    }
}

