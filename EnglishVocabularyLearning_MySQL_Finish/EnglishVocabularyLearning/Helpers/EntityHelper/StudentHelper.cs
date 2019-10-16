using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
	public class StudentHelper
	{
		public static DataTable getStudents()
		{
			try
			{
				string sql = @"SELECT *
							   FROM student";

				return DBHelper.queryDT(sql);
			}
			catch (Exception)
			{
				throw;
			}

		}

		public static Student loginStudent(string username, string password)
		{
			string sql = @"SELECT *
						   FROM Student
						   WHERE Username = @Username AND
								 Password = SHA2(@Password, 256)";

			List<ParameterOBJ> parameters = new List<ParameterOBJ>()
			{
				new ParameterOBJ("Username", username),
				new ParameterOBJ("Password", password)
			};
			DataTable queryResult = DBHelper.queryDT(sql, parameters);

			if (queryResult.Rows.Count > 0)
			{
				Student student = new Student();

				student.studentID = queryResult.Rows[0]["StudentID"].ToString();
				student.realName = queryResult.Rows[0]["RealName"].ToString();
				student.birthdate = Convert.ToDateTime(queryResult.Rows[0]["Birthdate"].ToString());
				student.username = queryResult.Rows[0]["Username"].ToString();
				student.password = queryResult.Rows[0]["Password"].ToString();

				return student;
			}
			else
			{
				return null;
			}
		}

		public static void insertStudent(Student student)
		{
			try
			{
				string sql = @"INSERT
                               INTO Student (StudentID, Username, Password, RealName, Birthdate)
                               VALUES (@StudentID,  @Username, SHA2(@Password, 256), @RealName, @Birthdate)";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("StudentID", student.studentID),
					new ParameterOBJ("Username", student.username),
					new ParameterOBJ("Password", student.password),
					new ParameterOBJ("RealName", student.realName),
					new ParameterOBJ("Birthdate", student.birthdate)
				};
				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static void editStudent(Student student)
		{
			try
			{
				string sql = @"UPDATE Student
                               SET Username = @Username,
                                   RealName = @RealName,
                                   Birthdate = @Birthdate
                               WHERE StudentID = @StudentID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("Username", student.username),
					new ParameterOBJ("RealName", student.realName),
					new ParameterOBJ("Birthdate", student.birthdate),
					new ParameterOBJ("StudentID", student.studentID)
				};

				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static void resetStudentPassword(Student student)
		{
			try
			{
				string sql = @"UPDATE Student
                               SET Password = SHA2(@Password, 256)
                               WHERE StudentID = @StudentID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("Password", student.password),
					new ParameterOBJ("StudentID", student.studentID)
				};

				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static void deleteStudent(Student student)
		{
			try
			{
				string sql = @" DELETE
								FROM Student
								WHERE StudentID = @StudentID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("StudentID", student.studentID)
				};
				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}
