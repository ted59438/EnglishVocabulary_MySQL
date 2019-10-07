namespace EnglishVocabularyLearning
{
	partial class VocabularyManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.categorySelector = new System.Windows.Forms.ComboBox();
            this.addCategoryButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.showVocabularyView = new System.Windows.Forms.DataGridView();
            this.English = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Translate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.difficulty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vocabularyGridContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteStripItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteVocabularyBtn = new System.Windows.Forms.Button();
            this.editVocabularyBtn = new System.Windows.Forms.Button();
            this.insertVocabularyBtn = new System.Windows.Forms.Button();
            this.partOfSpeechInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chineseInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vocabularyInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.editCategoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.showVocabularyView)).BeginInit();
            this.vocabularyGridContextMenuStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categorySelector
            // 
            this.categorySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categorySelector.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.categorySelector.FormattingEnabled = true;
            this.categorySelector.Location = new System.Drawing.Point(48, 68);
            this.categorySelector.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.categorySelector.Name = "categorySelector";
            this.categorySelector.Size = new System.Drawing.Size(416, 32);
            this.categorySelector.TabIndex = 2;
            // 
            // addCategoryButton
            // 
            this.addCategoryButton.BackColor = System.Drawing.Color.DimGray;
            this.addCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addCategoryButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.addCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addCategoryButton.Location = new System.Drawing.Point(496, 60);
            this.addCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addCategoryButton.Name = "addCategoryButton";
            this.addCategoryButton.Size = new System.Drawing.Size(121, 46);
            this.addCategoryButton.TabIndex = 3;
            this.addCategoryButton.Text = "新增分類";
            this.addCategoryButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "請選擇單字分類:";
            // 
            // showVocabularyView
            // 
            this.showVocabularyView.AllowUserToAddRows = false;
            this.showVocabularyView.AllowUserToDeleteRows = false;
            this.showVocabularyView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showVocabularyView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.showVocabularyView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.showVocabularyView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.showVocabularyView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showVocabularyView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.English,
            this.Translate,
            this.difficulty});
            this.showVocabularyView.ContextMenuStrip = this.vocabularyGridContextMenuStrip;
            this.showVocabularyView.EnableHeadersVisualStyles = false;
            this.showVocabularyView.Location = new System.Drawing.Point(48, 280);
            this.showVocabularyView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showVocabularyView.Name = "showVocabularyView";
            this.showVocabularyView.ReadOnly = true;
            this.showVocabularyView.RowHeadersVisible = false;
            this.showVocabularyView.RowTemplate.Height = 24;
            this.showVocabularyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.showVocabularyView.Size = new System.Drawing.Size(857, 516);
            this.showVocabularyView.TabIndex = 5;
            // 
            // English
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.English.DefaultCellStyle = dataGridViewCellStyle2;
            this.English.HeaderText = "單字";
            this.English.Name = "English";
            this.English.ReadOnly = true;
            // 
            // Translate
            // 
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Translate.DefaultCellStyle = dataGridViewCellStyle3;
            this.Translate.HeaderText = "中文";
            this.Translate.Name = "Translate";
            this.Translate.ReadOnly = true;
            // 
            // difficulty
            // 
            this.difficulty.HeaderText = "詞性";
            this.difficulty.Name = "difficulty";
            this.difficulty.ReadOnly = true;
            // 
            // vocabularyGridContextMenuStrip
            // 
            this.vocabularyGridContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.vocabularyGridContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteStripItem});
            this.vocabularyGridContextMenuStrip.Name = "vocabularyGridContextMenuStrip";
            this.vocabularyGridContextMenuStrip.Size = new System.Drawing.Size(184, 28);
            // 
            // deleteStripItem
            // 
            this.deleteStripItem.Name = "deleteStripItem";
            this.deleteStripItem.Size = new System.Drawing.Size(183, 24);
            this.deleteStripItem.Text = "刪除選擇的單字";
            // 
            // deleteCategoryButton
            // 
            this.deleteCategoryButton.BackColor = System.Drawing.Color.DimGray;
            this.deleteCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteCategoryButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deleteCategoryButton.Location = new System.Drawing.Point(784, 60);
            this.deleteCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteCategoryButton.Name = "deleteCategoryButton";
            this.deleteCategoryButton.Size = new System.Drawing.Size(121, 46);
            this.deleteCategoryButton.TabIndex = 6;
            this.deleteCategoryButton.Text = "刪除分類";
            this.deleteCategoryButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.deleteVocabularyBtn);
            this.groupBox1.Controls.Add(this.editVocabularyBtn);
            this.groupBox1.Controls.Add(this.insertVocabularyBtn);
            this.groupBox1.Controls.Add(this.partOfSpeechInput);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.chineseInput);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.vocabularyInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(48, 116);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(857, 142);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "單字資訊";
            // 
            // deleteVocabularyBtn
            // 
            this.deleteVocabularyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.deleteVocabularyBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.deleteVocabularyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteVocabularyBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.deleteVocabularyBtn.ForeColor = System.Drawing.Color.White;
            this.deleteVocabularyBtn.Location = new System.Drawing.Point(697, 92);
            this.deleteVocabularyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deleteVocabularyBtn.Name = "deleteVocabularyBtn";
            this.deleteVocabularyBtn.Size = new System.Drawing.Size(137, 34);
            this.deleteVocabularyBtn.TabIndex = 8;
            this.deleteVocabularyBtn.Text = "刪除單字";
            this.deleteVocabularyBtn.UseVisualStyleBackColor = false;
            // 
            // editVocabularyBtn
            // 
            this.editVocabularyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editVocabularyBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.editVocabularyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editVocabularyBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editVocabularyBtn.ForeColor = System.Drawing.Color.White;
            this.editVocabularyBtn.Location = new System.Drawing.Point(357, 92);
            this.editVocabularyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editVocabularyBtn.Name = "editVocabularyBtn";
            this.editVocabularyBtn.Size = new System.Drawing.Size(137, 34);
            this.editVocabularyBtn.TabIndex = 7;
            this.editVocabularyBtn.Text = "修改單字";
            this.editVocabularyBtn.UseVisualStyleBackColor = false;
            // 
            // insertVocabularyBtn
            // 
            this.insertVocabularyBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.insertVocabularyBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.insertVocabularyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.insertVocabularyBtn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.insertVocabularyBtn.ForeColor = System.Drawing.Color.White;
            this.insertVocabularyBtn.Location = new System.Drawing.Point(37, 92);
            this.insertVocabularyBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.insertVocabularyBtn.Name = "insertVocabularyBtn";
            this.insertVocabularyBtn.Size = new System.Drawing.Size(137, 34);
            this.insertVocabularyBtn.TabIndex = 6;
            this.insertVocabularyBtn.Text = "新增單字";
            this.insertVocabularyBtn.UseVisualStyleBackColor = false;
            // 
            // partOfSpeechInput
            // 
            this.partOfSpeechInput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.partOfSpeechInput.Location = new System.Drawing.Point(720, 44);
            this.partOfSpeechInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.partOfSpeechInput.Name = "partOfSpeechInput";
            this.partOfSpeechInput.Size = new System.Drawing.Size(99, 29);
            this.partOfSpeechInput.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(649, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "詞性：";
            // 
            // chineseInput
            // 
            this.chineseInput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chineseInput.Location = new System.Drawing.Point(448, 44);
            this.chineseInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chineseInput.Name = "chineseInput";
            this.chineseInput.Size = new System.Drawing.Size(173, 29);
            this.chineseInput.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(377, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "中文：";
            // 
            // vocabularyInput
            // 
            this.vocabularyInput.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.vocabularyInput.Location = new System.Drawing.Point(104, 44);
            this.vocabularyInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.vocabularyInput.Name = "vocabularyInput";
            this.vocabularyInput.Size = new System.Drawing.Size(247, 29);
            this.vocabularyInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(33, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "單字：";
            // 
            // editCategoryButton
            // 
            this.editCategoryButton.BackColor = System.Drawing.Color.DimGray;
            this.editCategoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editCategoryButton.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.editCategoryButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.editCategoryButton.Location = new System.Drawing.Point(639, 60);
            this.editCategoryButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editCategoryButton.Name = "editCategoryButton";
            this.editCategoryButton.Size = new System.Drawing.Size(121, 46);
            this.editCategoryButton.TabIndex = 1;
            this.editCategoryButton.Text = "修改分類";
            this.editCategoryButton.UseVisualStyleBackColor = false;
            // 
            // VocabularyManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(952, 820);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.deleteCategoryButton);
            this.Controls.Add(this.showVocabularyView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addCategoryButton);
            this.Controls.Add(this.categorySelector);
            this.Controls.Add(this.editCategoryButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VocabularyManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "單字管理";
            ((System.ComponentModel.ISupportInitialize)(this.showVocabularyView)).EndInit();
            this.vocabularyGridContextMenuStrip.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox categorySelector;
		private System.Windows.Forms.Button addCategoryButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView showVocabularyView;
		private System.Windows.Forms.Button deleteCategoryButton;
		private System.Windows.Forms.DataGridViewTextBoxColumn English;
		private System.Windows.Forms.DataGridViewTextBoxColumn Translate;
		private System.Windows.Forms.DataGridViewTextBoxColumn difficulty;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox partOfSpeechInput;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox chineseInput;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox vocabularyInput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button deleteVocabularyBtn;
		private System.Windows.Forms.Button editVocabularyBtn;
		private System.Windows.Forms.Button insertVocabularyBtn;
		private System.Windows.Forms.Button editCategoryButton;
		private System.Windows.Forms.ContextMenuStrip vocabularyGridContextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem deleteStripItem;
	}
}