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
	public partial class StudentManagement : Form
	{
		public StudentManagement()
		{
			InitializeComponent();
		}

		private void StudentManagement_Load(object sender, EventArgs e)
		{
			getAllStudentFromDB();
		}

		private void getAllStudentFromDB()
		{
			studentsGridView.DataSource = StudentHelper.getStudents();

			studentsGridView.Columns["StudentID"].Visible = false;
			studentsGridView.Columns["Password"].Visible = false;

			studentsGridView.ClearSelection();
			studentNameTextBox.Text = studentUsernameTextBox.Text = studentPasswordTextBox.Text = "";
			studentBirthdatePicker.Value = DateTime.Today;
		}

		private void studentsGridView_SelectionChanged(object sender, EventArgs e)
		{
			try
			{
				int currentRowIndex = studentsGridView.CurrentRow.Index;
				Student selectStudent = getStudentFromGridView(currentRowIndex);

				bindStudentDataToTopFiled(selectStudent);
			}
			catch (Exception)
			{
				studentNameTextBox.Text = studentUsernameTextBox.Text = studentPasswordTextBox.Text = "";
				studentBirthdatePicker.Value = DateTime.Now;
			}
		}

		private Student getStudentFromGridView(int index)
		{
			DataGridViewRow studentRow = studentsGridView.Rows[index];

			Student student = new Student();

			student.studentID = Convert.ToString(studentRow.Cells["StudentID"].Value);
			student.username = Convert.ToString(studentRow.Cells["Username"].Value);
			student.password = Convert.ToString(studentRow.Cells["Password"].Value);
			student.realName = Convert.ToString(studentRow.Cells["RealName"].Value);
			student.birthdate = Convert.ToDateTime(studentRow.Cells["Birthdate"].Value);

			return student;
		}

		private void bindStudentDataToTopFiled(Student student)
		{
			studentNameTextBox.Text = student.realName;
			studentUsernameTextBox.Text = student.username;
			studentBirthdatePicker.Value = student.birthdate;
		}

		private void insertBtn_Click(object sender, EventArgs e)
		{
			Student insertStudent = getStudentFromTopFiled();
			insertStudent.studentID = Guid.NewGuid().ToString();

			try
			{
				StudentHelper.insertStudent(insertStudent);
				getAllStudentFromDB();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void editBtn_Click(object sender, EventArgs e)
		{
			if (studentsGridView.CurrentRow == null)
			{
				return;
			}

			Student editStudent = getStudentFromTopFiled();
			editStudent.studentID = studentsGridView.CurrentRow.Cells["StudentID"].Value.ToString();

			try
			{
				StudentHelper.editStudent(editStudent);
				getAllStudentFromDB();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void resetPasswordBtn_Click(object sender, EventArgs e)
		{
			if (studentsGridView.CurrentRow == null)
			{
				return;
			}

			Student resetStudent = getStudentFromTopFiled();
			resetStudent.studentID = studentsGridView.CurrentRow.Cells["StudentID"].Value.ToString();

			try
			{
				StudentHelper.resetStudentPassword(resetStudent);
				getAllStudentFromDB();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void deleteBtn_Click(object sender, EventArgs e)
		{
			if (studentsGridView.CurrentRow == null)
			{
				return;
			}

			Student deleteStudent = getStudentFromTopFiled();
			deleteStudent.studentID = studentsGridView.CurrentRow.Cells["StudentID"].Value.ToString();

			try
			{
				StudentHelper.deleteStudent(deleteStudent);
				getAllStudentFromDB();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void deleteAllStudentStripItem_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection allSelectedRow = studentsGridView.SelectedRows;
			for (int i = studentsGridView.SelectedRows.Count - 1; i >= 0; i--)
			{
				Student student = getStudentFromGridView(studentsGridView.SelectedRows[i].Index);

				try
				{
					StudentHelper.deleteStudent(student);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}

			getAllStudentFromDB();
		}

		private Student getStudentFromTopFiled()
		{
			Student student = new Student();

			student.realName = studentNameTextBox.Text;
			student.username = studentUsernameTextBox.Text;
			student.password = studentPasswordTextBox.Text;
			student.birthdate = studentBirthdatePicker.Value;

			return student;
		}
	}
}
