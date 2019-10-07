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
    public partial class QuizForm : Form
    {
        QuizConfigForm quizConfig;

        #region 變數宣告

        #region 問題資料
        private string quizCategory;
        private List<string> allVocabulary;
        private string questionChinese;
        private string questionEnglish;
        private string questiondifficulty;
        #endregion

        #region 作答欄位
        private TextBox[] vocabularyTextBoxs;
        private int nowFoucsTextBox = 0;
        #endregion

        #region 作答情形計數
        private Dictionary<string, string> answerSituation;
        private int totalQuizNum;
        private int currentQuizNum;
        private int correctCount;
        private int wrongCount;
        private int quizTime;
        #endregion

        #endregion

        #region 函式、方法

        #region 測驗視窗初始化

        public QuizForm(QuizConfigForm quizConfig)
        {
            InitializeComponent();
            this.quizConfig = quizConfig;
        }

        private void QuizForm_Load(object sender, EventArgs e)
        {
            initQuizAndVocabulary();
            initQuizCountAndNums();
            getVocabularyQuestion();
            createTextBoxs();
            putVocabularyQuestion();
            setQuizTimeLabelText(quizTime);
        }

        #endregion

        #region 單字、計數資料初始化
        private void initQuizAndVocabulary()
        {
            quizCategory = quizConfig.selectCategory;
            quizTime = quizConfig.selectQuizTime;
            showCategoryLabel.Text = string.Format("分類: {0}", quizCategory);
            allVocabulary = CommonProgramMethod.getAllVocabulary(quizCategory).ToList();
        }

        private void initQuizCountAndNums()
        {
            answerSituation = new Dictionary<string, string>();
            totalQuizNum = allVocabulary.Count();
            correctCount = 0;
            wrongCount = 0;
        }
        #endregion

        #region 取得新的單字並更新畫面
        private void getVocabularyQuestion()
        {
            Random rnd = new Random();
            int questionIndex = rnd.Next(0, allVocabulary.Count);
            questionEnglish = allVocabulary[questionIndex].Split(',')[0];
            questionChinese = allVocabulary[questionIndex].Split(',')[1];
            questiondifficulty = allVocabulary[questionIndex].Split(',')[2];

            allVocabulary.RemoveAt(questionIndex);

            currentQuizNum++;
        }

        private void createTextBoxs()
        {
            int x = 20, y = 15;

            vocabularyPanel.Controls.Clear();
            vocabularyTextBoxs = new TextBox[questionEnglish.Length];
            for (int i = 0; i < vocabularyTextBoxs.GetLength(0); i++)
            {
                vocabularyTextBoxs[i] = new TextBox();
                vocabularyTextBoxs[i].Width = 400 / questionEnglish.Length;
                vocabularyTextBoxs[i].Height = 40;
                vocabularyTextBoxs[i].Location = new Point(x, y);
                vocabularyTextBoxs[i].BackColor = SystemColors.ControlLight;
                vocabularyTextBoxs[i].ForeColor = Color.Black;
                vocabularyTextBoxs[i].Font = new Font("微軟正黑體", 20, FontStyle.Bold);
                vocabularyTextBoxs[i].TextAlign = HorizontalAlignment.Center;
                vocabularyTextBoxs[i].MaxLength = 1;

                vocabularyTextBoxs[i].KeyPress += new KeyPressEventHandler(inputTextBox);
                vocabularyPanel.Controls.Add(vocabularyTextBoxs[i]);

                // 總長-頭尾-最後一格的寬度 / 格數-1
                x += (vocabularyPanel.Width - 40 - vocabularyTextBoxs[i].Width) / (vocabularyTextBoxs.GetLength(0) - 1);
            }
            nowFoucsTextBox = 0;
            vocabularyTextBoxs[nowFoucsTextBox].Focus();
        }

        private void putVocabularyQuestion()
        {
            quizNumsLabel.Text = string.Format("正在做答 / 總題數: {0:00} / {1:00}", currentQuizNum, totalQuizNum);
            questionChineseLabel.Text = string.Format("{0}  ({1}.)", questionChinese, questiondifficulty);
            questionEnglishLabel.Text = "";
            for (int i = 0; i < questionEnglish.Length; i++)
            {
                if (i == 0)
                    questionEnglishLabel.Text += questionEnglish[i];
                else
                    questionEnglishLabel.Text += " _ ";
            }
        }
        #endregion

        #region 輸入完畢換到下一個欄位
        private void inputTextBox(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) && nowFoucsTextBox < vocabularyTextBoxs.GetLength(0) - 1)
            {
                nowFoucsTextBox++;
                vocabularyTextBoxs[nowFoucsTextBox].Focus();
            }

            else if (e.KeyChar == 8 && nowFoucsTextBox > 0 && vocabularyTextBoxs[nowFoucsTextBox].Text == "")
            {
                nowFoucsTextBox--;
                vocabularyTextBoxs[nowFoucsTextBox].Focus();
            }
            else if (e.KeyChar != 8 && char.IsLetter(e.KeyChar) == false)
                e.Handled = true;

            else if (nowFoucsTextBox == vocabularyTextBoxs.GetLength(0) - 1)
            {
                submitAnswerButton.BackColor = Color.MistyRose;
                submitAnswerButton.Focus();
            }
        }
        #endregion

        #region 測驗時間倒數
        private void quizCountDownTimer_Tick(object sender, EventArgs e)
        {
            quizTime--;
            setQuizTimeLabelText(quizTime);
            if (quizTime == 0)
                quizCountDownTimer.Enabled = false;
        }

        private void setQuizTimeLabelText(int second)
        {
            TimeSpan quizTime = TimeSpan.FromSeconds(second);
            if (quizTime.TotalSeconds >= 60)
                showQuizTimeLabel.Text = string.Format("剩餘時間: {0}", quizTime.ToString(@"mm' 分 'ss' 秒'"));
            else
                showQuizTimeLabel.Text = string.Format("剩餘時間: {0}", quizTime.ToString(@"ss' 秒'"));
        }
        #endregion

        #region 核對答案並切換到下一題
        private void submitAnswerButton_Click(object sender, EventArgs e)
        {
            string userAns = "";
            questionEnglishLabel.Text = questionEnglish;

            submitAnswerButton.Enabled = false;
            submitAnswerButton.BackColor = Color.Khaki;
            for (int i = 0; i < questionEnglish.Length; i++)
            {
                userAns += vocabularyTextBoxs[i].Text;
            }

            if (userAns == questionEnglish)
            {
                correctCount++;
                answerSituation.Add(questionEnglish, "答對");
                submitAnswerButton.Text = "答對";
                correctNumsLabel.Text = string.Format("答對題數: {0:00}", correctCount);
            }
            else
            {
                wrongCount++;
                answerSituation.Add(questionEnglish, "答錯");
                submitAnswerButton.Text = "答錯";
                wrongNumsLabel.Text = string.Format("答錯題數: {0:00}", wrongCount);
            }
            nextTimer.Enabled = true;
        }

        private void nextTimer_Tick(object sender, EventArgs e)
        {
            nextTimer.Enabled = false;
            if (allVocabulary.Count > 0)
            {
                getVocabularyQuestion();
                createTextBoxs();
                putVocabularyQuestion();
            }
            else if (allVocabulary.Count == 0)
            {
                finishQuiz();
            }
            submitAnswerButton.Enabled = true;
            submitAnswerButton.Text = "送出答案";
        }
        #endregion

        #region 完成作答，結算成績
        private void finishQuiz()
        {
            QuizResultData quizResult = new QuizResultData(quizCategory,answerSituation,correctCount,wrongCount);
            QuizRecordForm recordForm = new QuizRecordForm();
            quizCountDownTimer.Enabled = false;
            recordForm.setQuizResultData(quizResult);
            recordForm.ShowDialog();
            this.Close();
        }
        #endregion

        #region 放棄測驗
        private void closeQuizButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #endregion

    }
}
