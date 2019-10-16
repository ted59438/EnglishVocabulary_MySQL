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
            int checkCategoryCount = CommonProgramMethod.LoadCategory().Count;
            if (checkCategoryCount <= 0)
            {
                MessageBox.Show("尚未建立任何單字與分類!","查無單字",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

            QuizConfigForm quizConfig = new QuizConfigForm();
            DialogResult startQuiz = quizConfig.ShowDialog();
            if (startQuiz == DialogResult.OK)
            {
                QuizForm quizForm = new QuizForm(quizConfig);
                quizForm.FormClosed += new FormClosedEventHandler(childFormClosed);
                quizForm.Show();
                this.Visible = false;
            }

        }

        private void showManagerButton_Click(object sender, EventArgs e)
        {
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
    }
}
