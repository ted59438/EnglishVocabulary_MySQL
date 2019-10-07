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
        public string selectCategory
        {
            get{
                return categorySelect.SelectedValue.ToString();
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
            categorySelect.DataSource = CommonProgramMethod.LoadCategory();
            quizTimeSelect.SelectedIndex = 0;
            categorySelect.SelectedItem = categorySelect.Items[0];
        }
    }
}
