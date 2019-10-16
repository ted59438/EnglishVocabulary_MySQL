using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace EnglishVocabularyLearning
{
	public partial class VocabularyManager : Form
	{
		List<string> allVocabulary = new List<string>();
		HashSet<int> unsaveRows = new HashSet<int>();

		public VocabularyManager()
		{
			InitializeComponent();
		}

		#region 單字分類

		#region 載入所有單字分類

		private void VocabularyManager_Load(object sender, EventArgs e)
		{
			LoadCategoryToSelector();
			LoadVocabularyToGridView();
		}

		public void LoadCategoryToSelector()
		{
			try
			{
				categorySelector.DataSource = VocabularyHelper.getAllCategory();

				categorySelector.DisplayMember = "CategoryName";
				categorySelector.ValueMember = "CategoryID";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}
		public void RefreshCatgorySelector()
		{
			int selectIndex = categorySelector.SelectedIndex;
			LoadCategoryToSelector();
			categorySelector.SelectedIndex = selectIndex;
		}

		#endregion

		#region 單字分類 - 新增、修改、刪除
		private void addCategoryButton_Click(object sender, EventArgs e)
		{
            string sql;
            List<ParameterOBJ> parameters;

            TextInputBox inputDialog = new TextInputBox("請輸入要新增的分類");
			if (!(inputDialog.ShowDialog() == DialogResult.OK) || string.IsNullOrEmpty(inputDialog.inputText))
			{
				return;
			}
			string appendCategory = inputDialog.inputText;

            try
            {
                sql = @"SELECT COUNT(CategoryID)
                        FROM Category
                        WHERE  CategoryName = @CategoryName";
                parameters = new List<ParameterOBJ>()
                {
                    new ParameterOBJ("CategoryName", appendCategory)
                };

                if (DBHelper.queryScalar(sql, parameters) != 0)
                {
                    MessageBox.Show(string.Format("分類 {0} 已存在！", appendCategory), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

			try
			{
				sql = @"INSERT
						INTO Category (CategoryID, CategoryName)
						VALUES (@CategoryID, @CategoryName)";
				parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("CategoryID", Guid.NewGuid()),
					new ParameterOBJ("CategoryName", appendCategory)
				};
				DBHelper.queryNoneDT(sql, parameters);

				LoadCategoryToSelector();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void editCategoryButton_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(categorySelector.Text))
			{
				return;
			}

			TextInputBox inputDialog = new TextInputBox("修改分類名稱", categorySelector.Text);
			if (inputDialog.ShowDialog() != DialogResult.OK)
			{
				return;
			}
			string editCategoryName = inputDialog.inputText;

			try
			{
				string sql = @"UPDATE Category
							   SET CategoryName = @CategoryName
							   WHERE CategoryID = @CategoryID";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("CategoryName", editCategoryName),
					new ParameterOBJ("CategoryID", categorySelector.SelectedValue)
				};
				DBHelper.queryNoneDT(sql, parameters);

				RefreshCatgorySelector();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
		}

		private void deleteCategoryButton_Click(object sender, EventArgs e)
		{
			string categoryID = Convert.ToString(categorySelector.SelectedValue);

			if (string.IsNullOrEmpty(categoryID))
			{
				return;
			}

			DialogResult askDelete = MessageBox.Show(string.Format("確定要刪除單字類別 {0} 與分類底下的所有單字?", categorySelector.Text), "詢問",
													 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (askDelete != DialogResult.Yes)
			{
				return;
			}

			try
			{
				string sql = @"DELETE
							   FROM Category
							   WHERE CategoryID = @CategoryID;
							   
							   DELETE
							   FROM Vocabulary 
							   WHERE CategoryID = @CategoryID;";
				List<ParameterOBJ> parameters = new List<ParameterOBJ>()
				{
					new ParameterOBJ("CategoryID", categoryID)
				};
				DBHelper.queryNoneDT(sql, parameters);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			LoadCategoryToSelector();
			LoadVocabularyToGridView();
		}

		#endregion

		#endregion

		#region 單字內容

		#region 讀取單字

		private void categorySelector_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadVocabularyToGridView();
		}

		public void LoadVocabularyToGridView()
		{
			if (categorySelector.SelectedValue == null)
			{
				return;
			}

			try
			{
				vocabularyGrid.DataSource = VocabularyHelper.getAllVocabulary(categorySelector.SelectedValue.ToString());

				vocabularyGrid.ClearSelection();
				vocabularyInput.Text = chineseInput.Text = partOfSpeechInput.Text = "";

                vocabularyInput.Focus();

            }
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}


			string[] dataColumn = new string[] { "English", "Chinese", "PartOfSpeech" };
			string[] columnText = new string[] { "單字", "中文", "詞性" };

			for (int i = 0; i < vocabularyGrid.Columns.Count; i++)
			{
				if (i < dataColumn.GetLength(0))
				{
					vocabularyGrid.Columns[i].HeaderText = columnText[i];
					vocabularyGrid.Columns[i].DataPropertyName = dataColumn[i];
				}
				else
				{
					vocabularyGrid.Columns[i].Visible = false;
				}
			}

			vocabularyGrid.ClearSelection();
			vocabularyInput.Text = chineseInput.Text = partOfSpeechInput.Text = "";
		}

		private void showVocabularyView_SelectionChanged(object sender, EventArgs e)
		{
			if (vocabularyGrid.CurrentRow == null)
			{
				return;
			}

			Vocabulary selectVocabulary = getVocabularyFromGridView(vocabularyGrid.CurrentRow.Index);
			putVocabularyToField(selectVocabulary);
		}

		public Vocabulary getVocabularyFromGridView(int index)
		{
			Vocabulary vocabulary = new Vocabulary();

			vocabulary.vocabularyID = vocabularyGrid.Rows[index].Cells["VocabularyID"].Value.ToString();
			vocabulary.categoryID = categorySelector.SelectedValue.ToString();
			vocabulary.english = Convert.ToString(vocabularyGrid.Rows[index].Cells["English"].Value);
			vocabulary.chinese = Convert.ToString(vocabularyGrid.Rows[index].Cells["Chinese"].Value);
			vocabulary.partOfSpeech = Convert.ToString(vocabularyGrid.Rows[index].Cells["PartOfSpeech"].Value);

			return vocabulary;
		}

		public Vocabulary getVocabularyFromField()
		{
			Vocabulary vocabulary = new Vocabulary();

			vocabulary.vocabularyID = Convert.ToString(vocabularyGrid.CurrentRow?.Cells["VocabularyID"].Value ?? "");
			vocabulary.categoryID = categorySelector.SelectedValue.ToString();
			vocabulary.english = vocabularyInput.Text;
			vocabulary.chinese = chineseInput.Text;
			vocabulary.partOfSpeech = partOfSpeechInput.Text;

			return vocabulary;
		}

		public void putVocabularyToField(Vocabulary vocabulary)
		{
			vocabularyInput.Text = vocabulary.english;
			chineseInput.Text = vocabulary.chinese;
			partOfSpeechInput.Text = vocabulary.partOfSpeech;
		}

		#endregion

		#region 單字操作

		private void insertVocabularyBtn_Click(object sender, EventArgs e)
		{
			Vocabulary insertVocabulary = getVocabularyFromField();
			insertVocabulary.vocabularyID = Guid.NewGuid().ToString();

			try
			{
				VocabularyHelper.insertVocabulary(insertVocabulary);
				LoadVocabularyToGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void editVocabularyBtn_Click(object sender, EventArgs e)
		{
			if (vocabularyGrid.CurrentRow == null)
			{
				return;
			}

			Vocabulary editVocabulary = getVocabularyFromField();

			try
			{
				VocabularyHelper.editVocabulary(editVocabulary);
				LoadVocabularyToGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void deleteVocabularyBtn_Click(object sender, EventArgs e)
		{
			if (vocabularyGrid.CurrentRow == null)
			{
				return;
			}

			Vocabulary deleteVocabulary = getVocabularyFromField();

			try
			{
				VocabularyHelper.deleteVocabulary(deleteVocabulary);
				LoadVocabularyToGridView();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void deleteStripItem_Click(object sender, EventArgs e)
		{
			DataGridViewSelectedRowCollection allSelectedRow = vocabularyGrid.SelectedRows;
			for (int i = vocabularyGrid.SelectedRows.Count - 1; i >= 0; i--)
			{
				Vocabulary vocabulary = getVocabularyFromGridView(vocabularyGrid.SelectedRows[i].Index);

				try
				{
					VocabularyHelper.deleteVocabulary(vocabulary);
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			LoadVocabularyToGridView();
		}

		#endregion

		#endregion
	}
}
