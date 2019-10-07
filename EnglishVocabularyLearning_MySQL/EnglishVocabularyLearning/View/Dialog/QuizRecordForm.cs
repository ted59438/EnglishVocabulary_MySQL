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
    public partial class QuizRecordForm : Form
    {
        private QuizResultData quizResult;

        Guid quizRecordGuid;
        string currentDate;
        string currentTime;

        string quizCategory;
        int totalQuizNum;
        int correctNum;
        int wrongNum;
        double rate;

        public QuizRecordForm()
        {
            InitializeComponent();
        }

        public void setQuizResultData(QuizResultData quizResult)
        {
            this.quizResult = quizResult;            
        }

        private void QuizRecordForm_Load(object sender, EventArgs e)
        {
            loadQuizRecord();
            saveQuizRecord();
        }

        private void loadQuizRecord()
        {
            quizRecordGuid = Guid.NewGuid();
            currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            currentTime = DateTime.Now.ToString("HH:mm:ss");

            quizCategory = quizResult.getQuizCategory();
            totalQuizNum = quizResult.getCorrectNum() + quizResult.getWrongNum();
            correctNum = quizResult.getCorrectNum();
            wrongNum = quizResult.getWrongNum();
            rate = (double)correctNum / totalQuizNum * 100;

            quizCategoryLabel.Text = quizCategory;
            quizTimeLabel.Text = quizResult.getQuizDateTime().ToString("tt' 'HH:mm");
            quizNumLabel.Text = string.Format("{0}/{1}", correctNum, totalQuizNum);
            resultRateLabel.Text = string.Format("{0:0.00}%", rate);
        }
        
        private void saveQuizRecord()
        { 
            StreamWriter fileWriter;

            if (!Directory.Exists(CommonProgramMethod.quizRecordFileDirectoryPath))
                Directory.CreateDirectory(CommonProgramMethod.quizRecordFileDirectoryPath);
            
            if (!File.Exists(CommonProgramMethod.quizRecordFileDirectoryPath + currentDate + ".txt"))
            {
                File.Create(CommonProgramMethod.quizRecordFileDirectoryPath + currentDate + ".txt").Dispose();
            }

            fileWriter = new StreamWriter(CommonProgramMethod.quizRecordFileDirectoryPath + currentDate + ".txt", true, Encoding.Default);
            fileWriter.WriteLine(string.Format("{0};{1};{2};{3};{4};{5};{6};{7}", quizRecordGuid,currentDate, currentTime, quizCategory, totalQuizNum, correctNum, wrongNum, rate));
            fileWriter.Close();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
