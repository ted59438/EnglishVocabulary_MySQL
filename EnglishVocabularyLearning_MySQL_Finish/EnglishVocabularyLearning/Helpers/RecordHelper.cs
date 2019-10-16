using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
	public class RecordHelper
	{
		public static DataTable getCorrectRateRecord(string studentID, string categoryID, DateTime startDateTime, DateTime endDateTime)
		{
			string categoryClause = "";
			if (categoryID != "all")
			{
				categoryClause = "exam_master.CategoryID = @CategoryID AND";
			}

			string sql = string.Format(@" SELECT Vocabulary.English AS English,
											   vocabulary.Chinese AS Chinese,
											   AVG(IsCorrect) * 100 AS CorrectRate
										  FROM exam_master
										  INNER JOIN exam_detail
										  ON exam_master.ExamID = exam_detail.ExamID
										  INNER JOIN vocabulary
										  ON exam_detail.VocabularyID = vocabulary.VocabularyID
										  INNER JOIN category
										  ON vocabulary.CategoryID = category.CategoryID
										  INNER JOIN student
										  ON exam_master.StudentID = student.StudentID
										  WHERE exam_master.StudentID = @StudentID AND
											    {0}
											    exam_master.StartDateTime >= CAST(@StartDateTime AS DATE) AND
											    exam_master.EndDateTime <= DATE_ADD(CAST(@EndDateTime AS DATE), INTERVAL 1 DAY)
										  GROUP BY exam_master.StudentID,
												   Vocabulary.VocabularyID,
												   vocabulary.English,
												   vocabulary.Chinese
										  ORDER BY CorrectRate", categoryClause);

			List<ParameterOBJ> parameters = new List<ParameterOBJ>()
			{
				new ParameterOBJ("StudentID", studentID),
				new ParameterOBJ("CategoryID", categoryID),
				new ParameterOBJ("StartDateTime", startDateTime),
				new ParameterOBJ("EndDateTime", endDateTime)
			};
			return DBHelper.queryDT(sql, parameters);
		}

		public static DataTable getExamDateByStudentID(string studentID)
		{
			string sql = @"SELECT DISTINCT CAST(StartDateTime AS DATE) AS Exam_Date
                           FROM Exam_Master
                           WHERE StudentID = @StudentID";
			List<ParameterOBJ> parameters = new List<ParameterOBJ>()
			{
				new ParameterOBJ("StudentID", studentID)
			};

			return DBHelper.queryDT(sql, parameters);
		}

		public static DataTable getExam_MasterByStudentIDAndDate(string studentID, DateTime queryDate)
		{
			string sql = @"SELECT Exam_Master.ExamID,
                                  Exam_Master.StartDateTime AS 測驗時間,
                                  Category.CategoryName  AS 分類,
                                  Exam_Master.CorrectNumber AS 答對題數,
                                  Exam_Master.WrongNumber AS  答錯題數,
                                  Exam_Master.Rate AS 測驗分數
                           FROM Exam_Master
                           INNER JOIN Category
                           ON Exam_Master.CategoryID = Category.CategoryID
                           WHERE StudentID = @StudentID AND
                                 StartDateTime >= CAST(@QueryDate AS DATE) AND
                                 StartDateTime < DATE_ADD(CAST(@QueryDate AS DATE), INTERVAL 1 DAY)";
			List<ParameterOBJ> parameters = new List<ParameterOBJ>()
			{
				new ParameterOBJ("StudentID", studentID),
				new ParameterOBJ("QueryDate", queryDate)
			};

			return DBHelper.queryDT(sql, parameters);
		}
	}
}
