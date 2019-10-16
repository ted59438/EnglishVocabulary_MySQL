namespace EnglishVocabularyLearning
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.questionChineseLabel = new System.Windows.Forms.Label();
            this.questionEnglishLabel = new System.Windows.Forms.Label();
            this.showCategoryLabel = new System.Windows.Forms.Label();
            this.showQuizTimeLabel = new System.Windows.Forms.Label();
            this.vocabularyPanel = new System.Windows.Forms.Panel();
            this.submitAnswerButton = new System.Windows.Forms.Button();
            this.closeQuizButton = new System.Windows.Forms.Button();
            this.quizCountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.correctNumsLabel = new System.Windows.Forms.Label();
            this.wrongNumsLabel = new System.Windows.Forms.Label();
            this.quizNumsLabel = new System.Windows.Forms.Label();
            this.nextTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // questionChineseLabel
            // 
            this.questionChineseLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionChineseLabel.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.questionChineseLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.questionChineseLabel.Location = new System.Drawing.Point(129, 56);
            this.questionChineseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionChineseLabel.Name = "questionChineseLabel";
            this.questionChineseLabel.Size = new System.Drawing.Size(597, 90);
            this.questionChineseLabel.TabIndex = 0;
            this.questionChineseLabel.Text = "中文 (詞性)";
            this.questionChineseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionEnglishLabel
            // 
            this.questionEnglishLabel.BackColor = System.Drawing.Color.Transparent;
            this.questionEnglishLabel.Font = new System.Drawing.Font("微軟正黑體", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.questionEnglishLabel.ForeColor = System.Drawing.Color.Yellow;
            this.questionEnglishLabel.Location = new System.Drawing.Point(59, 159);
            this.questionEnglishLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionEnglishLabel.Name = "questionEnglishLabel";
            this.questionEnglishLabel.Size = new System.Drawing.Size(743, 105);
            this.questionEnglishLabel.TabIndex = 1;
            this.questionEnglishLabel.Text = "_ _ _ _ _";
            this.questionEnglishLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showCategoryLabel
            // 
            this.showCategoryLabel.AutoSize = true;
            this.showCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.showCategoryLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showCategoryLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.showCategoryLabel.Location = new System.Drawing.Point(28, 600);
            this.showCategoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showCategoryLabel.Name = "showCategoryLabel";
            this.showCategoryLabel.Size = new System.Drawing.Size(115, 30);
            this.showCategoryLabel.TabIndex = 2;
            this.showCategoryLabel.Text = "單字分類:";
            // 
            // showQuizTimeLabel
            // 
            this.showQuizTimeLabel.BackColor = System.Drawing.Color.Transparent;
            this.showQuizTimeLabel.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.showQuizTimeLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.showQuizTimeLabel.Location = new System.Drawing.Point(553, 600);
            this.showQuizTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.showQuizTimeLabel.Name = "showQuizTimeLabel";
            this.showQuizTimeLabel.Size = new System.Drawing.Size(276, 30);
            this.showQuizTimeLabel.TabIndex = 3;
            this.showQuizTimeLabel.Text = "剩餘時間: 1 分 30 秒";
            this.showQuizTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // vocabularyPanel
            // 
            this.vocabularyPanel.BackColor = System.Drawing.Color.Transparent;
            this.vocabularyPanel.Location = new System.Drawing.Point(61, 300);
            this.vocabularyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.vocabularyPanel.Name = "vocabularyPanel";
            this.vocabularyPanel.Size = new System.Drawing.Size(740, 128);
            this.vocabularyPanel.TabIndex = 4;
            // 
            // submitAnswerButton
            // 
            this.submitAnswerButton.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.submitAnswerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submitAnswerButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.submitAnswerButton.ForeColor = System.Drawing.Color.SaddleBrown;
            this.submitAnswerButton.Location = new System.Drawing.Point(89, 472);
            this.submitAnswerButton.Margin = new System.Windows.Forms.Padding(4);
            this.submitAnswerButton.Name = "submitAnswerButton";
            this.submitAnswerButton.Size = new System.Drawing.Size(137, 80);
            this.submitAnswerButton.TabIndex = 5;
            this.submitAnswerButton.Text = "送出答案";
            this.submitAnswerButton.UseVisualStyleBackColor = false;
            this.submitAnswerButton.Click += new System.EventHandler(this.submitAnswerButton_Click);
            // 
            // closeQuizButton
            // 
            this.closeQuizButton.BackColor = System.Drawing.Color.Wheat;
            this.closeQuizButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeQuizButton.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.closeQuizButton.ForeColor = System.Drawing.Color.DarkRed;
            this.closeQuizButton.Location = new System.Drawing.Point(252, 472);
            this.closeQuizButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeQuizButton.Name = "closeQuizButton";
            this.closeQuizButton.Size = new System.Drawing.Size(141, 80);
            this.closeQuizButton.TabIndex = 6;
            this.closeQuizButton.Text = "放棄測驗";
            this.closeQuizButton.UseVisualStyleBackColor = false;
            this.closeQuizButton.Click += new System.EventHandler(this.closeQuizButton_Click);
            // 
            // quizCountDownTimer
            // 
            this.quizCountDownTimer.Enabled = true;
            this.quizCountDownTimer.Interval = 1000;
            this.quizCountDownTimer.Tick += new System.EventHandler(this.quizCountDownTimer_Tick);
            // 
            // correctNumsLabel
            // 
            this.correctNumsLabel.BackColor = System.Drawing.Color.Transparent;
            this.correctNumsLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.correctNumsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.correctNumsLabel.Location = new System.Drawing.Point(553, 500);
            this.correctNumsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.correctNumsLabel.Name = "correctNumsLabel";
            this.correctNumsLabel.Size = new System.Drawing.Size(265, 29);
            this.correctNumsLabel.TabIndex = 7;
            this.correctNumsLabel.Text = "答對題數: 00";
            this.correctNumsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // wrongNumsLabel
            // 
            this.wrongNumsLabel.BackColor = System.Drawing.Color.Transparent;
            this.wrongNumsLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.wrongNumsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.wrongNumsLabel.Location = new System.Drawing.Point(559, 539);
            this.wrongNumsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wrongNumsLabel.Name = "wrongNumsLabel";
            this.wrongNumsLabel.Size = new System.Drawing.Size(260, 25);
            this.wrongNumsLabel.TabIndex = 8;
            this.wrongNumsLabel.Text = "答錯題數: 00";
            this.wrongNumsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // quizNumsLabel
            // 
            this.quizNumsLabel.BackColor = System.Drawing.Color.Transparent;
            this.quizNumsLabel.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.quizNumsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.quizNumsLabel.Location = new System.Drawing.Point(553, 460);
            this.quizNumsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quizNumsLabel.Name = "quizNumsLabel";
            this.quizNumsLabel.Size = new System.Drawing.Size(265, 25);
            this.quizNumsLabel.TabIndex = 9;
            this.quizNumsLabel.Text = "正在做答 / 總題數: 00 / 00";
            this.quizNumsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nextTimer
            // 
            this.nextTimer.Interval = 500;
            this.nextTimer.Tick += new System.EventHandler(this.nextTimer_Tick);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(859, 652);
            this.Controls.Add(this.quizNumsLabel);
            this.Controls.Add(this.wrongNumsLabel);
            this.Controls.Add(this.correctNumsLabel);
            this.Controls.Add(this.closeQuizButton);
            this.Controls.Add(this.submitAnswerButton);
            this.Controls.Add(this.vocabularyPanel);
            this.Controls.Add(this.showQuizTimeLabel);
            this.Controls.Add(this.showCategoryLabel);
            this.Controls.Add(this.questionEnglishLabel);
            this.Controls.Add(this.questionChineseLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuizForm";
            this.Load += new System.EventHandler(this.QuizForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionChineseLabel;
        private System.Windows.Forms.Label questionEnglishLabel;
        private System.Windows.Forms.Label showCategoryLabel;
        private System.Windows.Forms.Label showQuizTimeLabel;
        private System.Windows.Forms.Panel vocabularyPanel;
        private System.Windows.Forms.Button submitAnswerButton;
        private System.Windows.Forms.Button closeQuizButton;
        private System.Windows.Forms.Timer quizCountDownTimer;
        private System.Windows.Forms.Label correctNumsLabel;
        private System.Windows.Forms.Label wrongNumsLabel;
        private System.Windows.Forms.Label quizNumsLabel;
        private System.Windows.Forms.Timer nextTimer;
    }
}