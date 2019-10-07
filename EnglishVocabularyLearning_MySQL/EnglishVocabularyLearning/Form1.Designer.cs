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
            this.label1 = new System.Windows.Forms.Label();
            this.startQuiz = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.showManagerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(153, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "英文單字學習遊戲";
            // 
            // startQuiz
            // 
            this.startQuiz.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startQuiz.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.startQuiz.FlatAppearance.BorderSize = 5;
            this.startQuiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startQuiz.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.startQuiz.ForeColor = System.Drawing.Color.Salmon;
            this.startQuiz.Location = new System.Drawing.Point(231, 199);
            this.startQuiz.Name = "startQuiz";
            this.startQuiz.Size = new System.Drawing.Size(240, 67);
            this.startQuiz.TabIndex = 1;
            this.startQuiz.Text = "開始測驗";
            this.startQuiz.UseVisualStyleBackColor = false;
            this.startQuiz.Click += new System.EventHandler(this.startQuiz_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.BorderSize = 5;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.button2.Location = new System.Drawing.Point(231, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "測驗紀錄";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // showManagerButton
            // 
            this.showManagerButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.showManagerButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.showManagerButton.FlatAppearance.BorderSize = 5;
            this.showManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showManagerButton.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showManagerButton.ForeColor = System.Drawing.Color.Peru;
            this.showManagerButton.Location = new System.Drawing.Point(231, 450);
            this.showManagerButton.Name = "showManagerButton";
            this.showManagerButton.Size = new System.Drawing.Size(240, 67);
            this.showManagerButton.TabIndex = 3;
            this.showManagerButton.Text = "單字管理";
            this.showManagerButton.UseVisualStyleBackColor = false;
            this.showManagerButton.Click += new System.EventHandler(this.showManagerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(722, 578);
            this.Controls.Add(this.showManagerButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startQuiz);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startQuiz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button showManagerButton;
    }
}

