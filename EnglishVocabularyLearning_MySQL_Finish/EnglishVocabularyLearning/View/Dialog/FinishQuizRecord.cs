using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace EnglishVocabularyLearning
{
	public partial class FinishQuizRecord : Form
	{
		Category quizCategory;
		Exam_Master examMaster;
		List<Exam_Detail> examDetails;

		public FinishQuizRecord(Exam_Master examMaster, List<Exam_Detail> examDetails, Category quizCategory)
		{
			InitializeComponent();

			this.examMaster = examMaster;
			this.examDetails = examDetails;
			this.quizCategory = quizCategory;
		}

		private void QuizRecordForm_Load(object sender, EventArgs e)
		{
			loadQuizRecord();
			saveQuizRecord();
		}

		private void loadQuizRecord()
		{
			int totalQuizNum = examMaster.correctNumber + examMaster.wrongNumber;
			examMaster.rate = (double)examMaster.correctNumber / totalQuizNum * 100;

			quizCategoryLabel.Text = quizCategory.categoryName;
			quizTimeLabel.Text = examMaster.endDateTime.ToString("HH:mm:ss");
			quizNumLabel.Text = string.Format("{0}/{1}", examMaster.correctNumber, totalQuizNum);
			resultRateLabel.Text = string.Format("{0:0.00}%", examMaster.rate);
		}

		private void saveQuizRecord()
		{
			try
			{
				ExamHelper.insertExamResult(examMaster, examDetails);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void backButton_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
