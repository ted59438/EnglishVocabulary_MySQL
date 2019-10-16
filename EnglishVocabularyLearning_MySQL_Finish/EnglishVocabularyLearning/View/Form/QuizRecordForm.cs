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
	public partial class QuizRecordForm : Form
	{
		public QuizRecordForm()
		{
			InitializeComponent();
		}

		private void QuizRecordForm_Load(object sender, EventArgs e)
		{
			loadBindingSources();
			setComboDataSources();
		}

		private void loadBindingSources()
		{
			studentBindingSource.DataSource = StudentHelper.getStudents();

			DataTable categorysDT = VocabularyHelper.getAllCategory();

			DataRow newRow = categorysDT.NewRow();
			newRow["CategoryID"] = "all";
			newRow["CategoryName"] = "全部";

			categorysDT.Rows.InsertAt(newRow, 0);
			categoryBindingSource.DataSource = categorysDT;
		}

		private void setComboDataSources()
		{
			studentCombo2.DisplayMember = studentCombo.DisplayMember = "RealName";
			studentCombo2.ValueMember = studentCombo.ValueMember = "StudentID";

			categoryCombo.DisplayMember = "CategoryName";
			categoryCombo.ValueMember = "CategoryID";
		}

		private void queryStudentExamBtn_Click(object sender, EventArgs e)
		{
			if (studentCombo.SelectedValue == null || examDatePicker.Value == null)
			{
				return;
			}

			string selectStudentID = studentCombo.SelectedValue.ToString();
			DateTime examDate = examDatePicker.Value;

			Exam_MasterGrid.DataSource = RecordHelper.getExam_MasterByStudentIDAndDate(selectStudentID, examDate);
			Exam_MasterGrid.Columns["ExamID"].Visible = false;
		}

		private void Exam_MasterGrid_SelectionChanged(object sender, EventArgs e)
		{
			if (Exam_MasterGrid.CurrentRow == null)
			{
				return;
			}

			string examID = Exam_MasterGrid.CurrentRow.Cells["ExamID"].Value.ToString();
			Exam_DetailGrid.DataSource = ExamHelper.getExam_DetailByExamID(examID);

			Exam_DetailGrid.Columns["Exam_DetailID"].Visible = false;

		}

		private void queryCorrectRateBtn_Click(object sender, EventArgs e)
		{
			if (studentCombo2.SelectedValue == null || categoryCombo.SelectedValue == null)
			{
				return;
			}

			string studentID = studentCombo2.SelectedValue.ToString();
			string categoryID = categoryCombo.SelectedValue.ToString();
			DateTime startDate = startDatePicker.Value;
			DateTime endDate = endDatePicker.Value;

			correctRateGrid.DataSource = RecordHelper.getCorrectRateRecord(studentID, categoryID, startDate, endDate);

		}
	}
}
