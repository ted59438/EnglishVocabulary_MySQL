using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabularyLearning
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void startQuiz_Click(object sender, EventArgs e)
		{
			try
			{
				DBHelper.testConnect();
			}
			catch (Exception)
			{
				MessageBox.Show("無法連線資料庫，請檢查連線設定!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (VocabularyHelper.getAllCategory().Rows.Count <= 0)
			{
				MessageBox.Show("尚未建立任何單字與分類!", "查無單字", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			QuizConfigForm quizConfig = new QuizConfigForm();
			DialogResult startQuiz = quizConfig.ShowDialog();

			if (startQuiz != DialogResult.OK)
			{
				return;
			}

			QuizForm quizForm = new QuizForm(quizConfig);
			quizForm.FormClosed += new FormClosedEventHandler(childFormClosed);
			quizForm.Show();
			this.Visible = false;

		}

		private void showManagerButton_Click(object sender, EventArgs e)
		{
			try
			{
				DBHelper.testConnect();
			}
			catch (Exception)
			{
				MessageBox.Show("無法連線資料庫，請檢查連線設定!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			VocabularyManager vocabularyManager = new VocabularyManager();
			if (Application.OpenForms["VocabularyManager"] == null)
			{
				vocabularyManager.Show();
			}
		}

		private void childFormClosed(Object sender, EventArgs e)
		{
			this.Visible = true;
		}

		#region Student Icon

		private void studentsIcon_MouseEnter(object sender, EventArgs e)
		{
			studentsIcon.Image = (Image)Properties.Resources.students_hover;
			studentsIcon.Cursor = Cursors.Hand;
		}

		private void studentsIcon_MouseLeave(object sender, EventArgs e)
		{
			studentsIcon.Image = (Image)Properties.Resources.students;
		}

		private void studentsIcon_Click(object sender, EventArgs e)
		{
			try
			{
				DBHelper.testConnect();
			}
			catch (Exception)
			{
				MessageBox.Show("無法連線資料庫，請檢查連線設定!", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			StudentManagement studentForm = new StudentManagement();
			studentForm.ShowDialog();
		}

		#endregion

		#region Setting Icon

		private void settingIcon_MouseEnter(object sender, EventArgs e)
		{
			settingIcon.Image = (Image)Properties.Resources.settings_hover;
			settingIcon.Cursor = Cursors.Hand;
		}

		private void settingIcon_MouseLeave(object sender, EventArgs e)
		{
			settingIcon.Image = (Image)Properties.Resources.settings;
		}

		private void settingIcon_Click(object sender, EventArgs e)
		{
			DBSettingForm settingForm = new DBSettingForm();
			settingForm.ShowDialog();
		}
        #endregion

        private void showQuizRecordBtn_Click(object sender, EventArgs e)
        {
            QuizRecordForm recordForm = new QuizRecordForm();

            if (Application.OpenForms["QuizRecordForm"] == null)
            {
                recordForm.Show();
            }
        }
    }
}
