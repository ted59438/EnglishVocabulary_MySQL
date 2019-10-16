using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace EnglishVocabularyLearning
{
    static class CommonProgramMethod
    {
        public static readonly string vocabularyFileDirectoryPath = Directory.GetCurrentDirectory() + "\\vocabulary\\";
        public static readonly string quizRecordFileDirectoryPath = Directory.GetCurrentDirectory() + "\\quizRecord\\";

        #region 讀取檔案、內容的程式方法
        public static string[] GetAllFilesName(string path, string fileName)
        {
            try
            {
                string[] files = Directory.GetFiles(path, fileName);
                for (int i = 0; i < files.Length; i++)
                {
                    files[i] = Path.GetFileNameWithoutExtension(files[i]);
                }
                return files;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static string[] getTxtFileContentByLine(string path, string filesName)
        {
            string filePath = path + filesName + ".txt";
            string[] lines = File.ReadAllLines(filePath, Encoding.Default);

            return lines;
        }
        #endregion

        #region 讀取單字分類
        public static List<string> LoadCategory()
        {
            List<string> categorys = new List<string>();

            string fileName = "*.txt";
            if (!Directory.Exists(vocabularyFileDirectoryPath))
                Directory.CreateDirectory(vocabularyFileDirectoryPath);
            categorys = GetAllFilesName(vocabularyFileDirectoryPath, fileName).ToList<string>();
            return categorys;
        }
        #endregion

        #region 讀取所有單字
        public static List<string> getAllVocabulary(string categoryName)
        {
            return getTxtFileContentByLine(vocabularyFileDirectoryPath, categoryName).ToList<string>();
        }
        #endregion
    }
}
