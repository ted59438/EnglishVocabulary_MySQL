using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
    public class QuizResultData
    {
        private Guid quizGuid;
        private DateTime quizDateTime;
        private string quizCategory;
        private int correctNum;
        private int wrongNum;
        private Dictionary<string, string> answerSituation;

        public QuizResultData(string quizCategory, Dictionary<string,string> answerSituation ,int correctNum, int wrongNum)
        {
            quizGuid = Guid.NewGuid();
            quizDateTime = DateTime.Now;

            this.quizCategory = quizCategory;
            this.answerSituation = answerSituation;
            this.correctNum = correctNum;
            this.wrongNum = wrongNum;
        }

        public Guid getQuizGuid()
        {
            return this.quizGuid;
        }
        public DateTime getQuizDateTime()
        {
            return this.quizDateTime;
        }

        public string getQuizCategory()
        {
            return this.quizCategory;
        }
        public int getCorrectNum()
        {
            return this.correctNum;
        }
        public int getWrongNum()
        {
            return this.wrongNum;
        }

    }
}
