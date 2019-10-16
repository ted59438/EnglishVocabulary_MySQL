using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
	public class ExamHelper
	{
		public static DataTable getExam_DetailByExamID(string examID)
		{
			string sql = @"SELECT Exam_DetailID,
                                  Exam_Detail.OrderNumber AS 題號,
                                  Vocabulary.English AS 題目,
                                  Vocabulary.Chinese AS 中文,
                                  Exam_Detail.UserAnswer AS 作答內容,
                                  (CASE
                                     WHEN Exam_Detail.IsCorrect = 1 THEN '正確'
                                     ELSE '錯誤'
                                   END) AS 是否正確
                           FROM Exam_Detail
                           INNER JOIN Vocabulary
                           ON Exam_Detail.VocabularyID = Vocabulary.VocabularyID
                           WHERE ExamID = @ExamID
                           ORDER By Exam_Detail.OrderNumber";
			List<ParameterOBJ> parameters = new List<ParameterOBJ>()
			{
				new ParameterOBJ("ExamID", examID)
			};

			return DBHelper.queryDT(sql, parameters);
		}

		public static void insertExamResult(Exam_Master examMaster, List<Exam_Detail> examDetails)
		{
			string sql;
			List<ParameterOBJ> parameters;

			try
			{
				sql = @"INSERT 
						INTO exam_master (ExamID, StartDateTime, EndDateTime, CategoryID, StudentID, CorrectNumber, WrongNumber, Rate)
						VALUES (@ExamID, @StartDateTime, @EndDateTime, @CategoryID, @StudentID, @CorrectNumber, @WrongNumber, @Rate)";
				parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("ExamID", examMaster.examID),
					new ParameterOBJ("StartDateTime", examMaster.startDateTime),
					new ParameterOBJ("EndDateTime", examMaster.endDateTime),
					new ParameterOBJ("CategoryID", examMaster.categoryID),
					new ParameterOBJ("StudentID", examMaster.studentID),
					new ParameterOBJ("CorrectNumber", examMaster.correctNumber),
					new ParameterOBJ("WrongNumber", examMaster.wrongNumber),
					new ParameterOBJ("Rate", examMaster.rate)
				};

				DBHelper.queryNoneDT(sql, parameters);

				foreach (Exam_Detail detail in examDetails)
				{
					sql = @"INSERT
							INTO exam_detail (Exam_DetailID, ExamID, OrderNumber, VocabularyID, UserAnswer, IsCorrect)
							VALUES (@Exam_DetailID, @ExamID, @OrderNumber, @VocabularyID, @UserAnswer, @IsCorrect)";
					parameters = new List<ParameterOBJ>()
					{
						new ParameterOBJ("Exam_DetailID", detail.exam_DetailID),
						new ParameterOBJ("ExamID", detail.examID),
						new ParameterOBJ("OrderNumber", detail.orderNumber),
						new ParameterOBJ("VocabularyID", detail.vocabularyID),
						new ParameterOBJ("userAnswer", detail.UserAnswer),
						new ParameterOBJ("IsCorrect", detail.isCorrect)
					};
					DBHelper.queryNoneDT(sql, parameters);

				}
			}
			catch (Exception)
			{
				throw;
			}

		}
	}
}
