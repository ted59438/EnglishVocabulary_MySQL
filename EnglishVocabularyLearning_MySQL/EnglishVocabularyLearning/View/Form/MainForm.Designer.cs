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
            this.button2 = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(116, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(683, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "英文單字學習遊戲";
            // 
            // startQuiz
            // 
            this.startQuiz.BackColor = System.Drawing.Color.PaleVioletRed;
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.IndianRed;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(308, 401);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(320, 84);
            this.button2.TabIndex = 2;
            this.button2.Text = "測驗紀錄";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // showManagerButton
            // 
            this.showManagerButton.BackColor = System.Drawing.Color.Peru;
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
            this.ClientSize = new System.Drawing.Size(963, 722);
            this.Controls.Add(this.studentsIcon);
            this.Controls.Add(this.settingIcon);
            this.Controls.Add(this.showManagerButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startQuiz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showManagerButton;
        private System.Windows.Forms.PictureBox settingIcon;
        private System.Windows.Forms.PictureBox studentsIcon;
    }
}

