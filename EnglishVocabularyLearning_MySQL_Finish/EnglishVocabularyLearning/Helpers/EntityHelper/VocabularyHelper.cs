using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
	public class VocabularyHelper
	{
		public static DataTable getAllCategory()
		{
			try
			{
				string sql = @" SELECT *
								FROM Category";
				return DBHelper.queryDT(sql);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static DataTable getAllVocabulary(string CategoryID)
		{
			try
			{
				string sql = @" SELECT English,
									   Chinese,
									   PartOfSpeech,
									   VocabularyID
								FROM Vocabulary
								WHERE CategoryID = @CategoryID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("CategoryID", CategoryID)
				};

				return DBHelper.queryDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}

        public static DataTable getSomeVocabulary(string CategoryID, int dataNumber)
        {
            try
            {
                string sql = @" SELECT English,
									   Chinese,
									   PartOfSpeech,
									   VocabularyID
								FROM Vocabulary
								WHERE CategoryID = @CategoryID
                                ORDER BY RAND()
                                LIMIT @dataNumber";
                List<ParameterOBJ> parameters = new List<ParameterOBJ>()
                {
                    new ParameterOBJ("CategoryID", CategoryID),
                    new ParameterOBJ("dataNumber", dataNumber)
                };

                return DBHelper.queryDT(sql, parameters);
            }
            catch (Exception)
            {
                throw;
            }
        }

		public static List<Vocabulary> getVocabularysByCategory(string categoryID)
		{
			DataTable allVocabularyDT = getSomeVocabulary(categoryID, 5);

			List<Vocabulary> vocabularys = new List<Vocabulary>();
			foreach (DataRow vocabularyRow in allVocabularyDT.Rows)
			{
				Vocabulary vocabulary = new Vocabulary();

				vocabulary.vocabularyID = vocabularyRow["VocabularyID"].ToString();
				vocabulary.categoryID = categoryID;
				vocabulary.english = vocabularyRow["English"].ToString();
				vocabulary.chinese = vocabularyRow["Chinese"].ToString();
				vocabulary.partOfSpeech = vocabularyRow["PartOfSpeech"].ToString();

				vocabularys.Add(vocabulary);
			}

			return vocabularys;
		}

		public static void insertVocabulary(Vocabulary vocabulary)
		{
			try
			{
				string sql = @"INSERT
							   INTO Vocabulary(VocabularyID, CategoryID, English, Chinese, PartOfSpeech)
							   VALUES(@VocabularyID, @CategoryID, @English, @Chinese, @PartOfSpeech)";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("VocabularyID", vocabulary.vocabularyID),
					new ParameterOBJ("CategoryID", vocabulary.categoryID),
					new ParameterOBJ("English", vocabulary.english),
					new ParameterOBJ("Chinese", vocabulary.chinese),
					new ParameterOBJ("PartOfSpeech", vocabulary.partOfSpeech)
				};
				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static void editVocabulary(Vocabulary vocabulary)
		{
			try
			{
				string sql = @"UPDATE Vocabulary
							   SET English = @English,
								   Chinese = @Chinese,
								   PartOfSpeech = @PartOfSpeech
							   WHERE VocabularyID = @VocabularyID AND
									 CategoryID =   @CategoryID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("English", vocabulary.english),
					new ParameterOBJ("Chinese", vocabulary.chinese),
					new ParameterOBJ("PartOfSpeech", vocabulary.partOfSpeech),
					new ParameterOBJ("VocabularyID", vocabulary.vocabularyID),
					new ParameterOBJ("CategoryID", vocabulary.categoryID)
				};
				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception)
			{
				throw;
			}
		}

		public static void deleteVocabulary(Vocabulary vocabulary)
		{
			try
			{
				string sql = @"DELETE 
							   FROM Vocabulary
							   WHERE VocabularyID = @VocabularyID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("VocabularyID", vocabulary.vocabularyID)
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
