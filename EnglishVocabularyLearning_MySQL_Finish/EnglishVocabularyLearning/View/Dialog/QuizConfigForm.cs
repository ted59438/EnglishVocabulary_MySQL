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
	public partial class QuizConfigForm : Form
	{
		public Student quizStudent;

		public Category selectCategory
		{
			get
			{
				Category category = new Category();

				category.categoryID = categorySelect.SelectedValue.ToString();
				category.categoryName = categorySelect.GetItemText(categorySelect.SelectedItem);

				return category;
			}
		}


		public int selectQuizTime
		{
			get
			{
				return (quizTimeSelect.SelectedIndex + 1) * 60;
			}
		}

		public QuizConfigForm()
		{
			InitializeComponent();
		}

		private void QuizConfigForm_Load(object sender, EventArgs e)
		{
			categorySelect.DataSource = VocabularyHelper.getAllCategory();

			categorySelect.DisplayMember = "CategoryName";
			categorySelect.ValueMember = "CategoryID";

			quizTimeSelect.SelectedIndex = 0;
			categorySelect.SelectedItem = categorySelect.Items[0];
		}

		private void submitButton_Click(object sender, EventArgs e)
		{
			Student loginStudent = StudentHelper.loginStudent(usernameTextBox.Text, passwordTextBox.Text);
			if (loginStudent == null)
			{
				MessageBox.Show("帳號或密碼錯誤，請重新輸入", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.DialogResult = DialogResult.None;
			}
			else
			{
				quizStudent = loginStudent;
			}
		}
	}
}
