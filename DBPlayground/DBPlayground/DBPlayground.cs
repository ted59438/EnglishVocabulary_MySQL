using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBPlayground
{
	public partial class DBPlayground : Form
	{
		public DBPlayground()
		{
			InitializeComponent();
		}
        #region 按鈕事件

        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                testConnectDB();
                queryStudentBtn.Enabled = true;

                MessageBox.Show("測試連線成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void queryStudentBtn_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT StudentID,
                                      RealName,
								      Username,
								      CAST(Birthdate AS DATE) AS Birthdate
						   FROM Student";
            try
            {
                queryResultGrid.DataSource = queryDT(sql, new Dictionary<string, object>());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            queryResultGrid.Columns["RealName"].HeaderText = "姓名";
            queryResultGrid.Columns["Username"].HeaderText = "帳號";
            queryResultGrid.Columns["Birthdate"].HeaderText = "生日";
            queryResultGrid.Columns["StudentID"].Visible = false;

            queryResultGrid.ClearSelection();
            studentNameTextBox.Text = studentUsernameTextBox.Text = studentPasswordTextBox.Text = "";

            insertStudentBtn.Enabled = editStudentBtn.Enabled = deleteStudentBtn.Enabled = true;
        }

        private void queryResultGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (queryResultGrid.CurrentRow == null)
            {
                return;
            }

            DataGridViewRow selectRow = queryResultGrid.CurrentRow;

            studentNameTextBox.Text = Convert.ToString(selectRow.Cells["RealName"].Value);
            studentBirthdatePicker.Value = Convert.ToDateTime(selectRow.Cells["Birthdate"].Value);
            studentUsernameTextBox.Text = Convert.ToString(selectRow.Cells["Username"].Value);
        }

        /// <summary>
        /// 新增學生按鈕事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertStudentBtn_Click(object sender, EventArgs e)
        {
            // 判斷所有欄位是否已經輸入
            TextBox[] fields = { studentNameTextBox, studentUsernameTextBox, studentPasswordTextBox };
            string errorMsg = fieldsIsEmpty(fields);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg.ToString(), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 判斷帳號是否已經存在
            if (usernameIsExists(studentUsernameTextBox.Text))
            {
                MessageBox.Show("帳號已經存在！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 新增學生資料到資料庫
            Student student = getStudentFromField();
            student.StudentID = Guid.NewGuid().ToString();

            string sql = @" INSERT
                            INTO Student(StudentID, RealName, Birthdate, Username, Password)
                            VALUES (@StudentID, @RealName, @Birthdate, @Username, SHA2(@Password, 256))";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"StudentID", student.StudentID },
                {"RealName", student.RealName },
                {"Birthdate", student.Birthdate },
                {"Username", student.Username },
                {"Password", student.Password }
            };

            try
            {
                queryNoneReturn(sql, parameters);
                queryStudentBtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 編輯學生按紐事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editStudentBtn_Click(object sender, EventArgs e)
        {
            if (queryResultGrid.CurrentRow == null)
            {
                return;
            }

            // 判斷所有欄位是否已經輸入
            TextBox[] fields = { studentNameTextBox, studentUsernameTextBox};
            string errorMsg = fieldsIsEmpty(fields);
            if (!string.IsNullOrEmpty(errorMsg))
            {
                MessageBox.Show(errorMsg.ToString(), "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 判斷帳號是否已經存在
            if (usernameIsExists(studentUsernameTextBox.Text))
            {
                MessageBox.Show("帳號已經存在！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 修改學生資料
            Student student = getStudentFromField();

            string sql = @"UPDATE Student
                           SET RealName = @RealName,
                               Birthdate = @Birthdate,
                               Username = @Username
                           WHERE StudentID = @StudentID";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"RealName", student.RealName },
                {"Birthdate", student.Birthdate },
                {"Username", student.Username },
                {"StudentID", student.StudentID}
            };

            try
            {
                queryNoneReturn(sql, parameters);
                queryStudentBtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 刪除學生按紐事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteStudentBtn_Click(object sender, EventArgs e)
        {
            if (queryResultGrid.CurrentRow == null)
            {
                return;
            }

            Student student = getStudentFromField();

            string sql = @"DELETE
                           FROM Student
                           WHERE StudentID = @StudentID";
            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"StudentID", student.StudentID }
            };

            try
            {
                queryNoneReturn(sql, parameters);
                queryStudentBtn.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region 其他方法

        /// <summary>
        /// 將畫面上的學生資料封裝成學生物件
        /// </summary>
        /// <returns></returns>
        private Student getStudentFromField()
        {
            Student student = new Student();

            student.StudentID = queryResultGrid.CurrentRow?.Cells["StudentID"].Value.ToString() ?? "";
            student.RealName = studentNameTextBox.Text;
            student.Birthdate = studentBirthdatePicker.Value;
            student.Username = studentUsernameTextBox.Text;
            student.Password = studentPasswordTextBox.Text;

            return student;
        }

        /// <summary>
        /// 判斷使用者帳號是否已經存在
        /// </summary>
        /// <param name="username">使用者帳號</param>
        /// <returns></returns>
        private bool usernameIsExists(string username)
        {
            string sql;
            Dictionary<string, object> parameters;

            sql = @"SELECT COUNT(StudentID)
                    FROM Student
                    WHERE Username = @Username";
            parameters = new Dictionary<string, object>()
            {
                {"Username", studentUsernameTextBox.Text }
            };

            try
            {
                return queryScalar(sql, parameters) != 0;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 判斷欄位是否已經輸入
        /// </summary>
        /// <param name="fields"></param>
        /// <returns></returns>
        private string fieldsIsEmpty(TextBox[] fields)
        {
            StringBuilder errorMsg = new StringBuilder();
            foreach (TextBox field in fields)
            {
                if (string.IsNullOrEmpty(field.Text))
                {
                    errorMsg.AppendLine(string.Format(@"請輸入 {0} ", field.Tag));
                }
            }

            return errorMsg.ToString();
        }
        #endregion

        #region SQL處理

        public string getConnectString()
        {
            return string.Format(@"Server =   {0};
                                    Database = {1};
                                    User ID =  {2};
                                    Password = {3};
                                    Connection Timeout = 5",
                                    serverNameInput.Text,
                                    dbNameInput.Text,
                                    dbUsernameInput.Text,
                                    dbPasswordInput.Text);
        }

        /// <summary>
        /// 測試連線資料庫：設定連線字串→開啟連線→關閉連線
        /// 如果無法正常連線，丟出例外錯誤
        /// </summary>
        private void testConnectDB()
        {
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = getConnectString();

            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
		///  基本查詢：傳回DataTable
		/// </summary>
		/// <param name="sql"></param>
		/// <returns></returns>
		private DataTable queryDT(string sql, Dictionary<string, object> parameters)
        {
            // 設定SQL與綁定參數到Command物件
            MySqlCommand command = getAndBindCommand(sql, parameters);

            // 建立撈取資料的物件 (Adapter)
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;

            try
            {
                // 開啟連線 
                command.Connection.Open();

                // 執行SELECT查詢，取得資料後存放到DataTable
                DataTable queryResultDT = new DataTable();
                adapter.Fill(queryResultDT);

                // 關閉連線
                command.Connection.Close();

                return queryResultDT;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 基本查詢：傳回單一值
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private int queryScalar(string sql, Dictionary<string, object> parameters)
        {
            MySqlCommand command = getAndBindCommand(sql, parameters);

            try
            {
                command.Connection.Open();
                int result = Convert.ToInt32(command.ExecuteScalar());
                command.Connection.Close();

                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        /// <summary>
        /// 交易查詢：新修刪
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        private void queryNoneReturn(string sql, Dictionary<string, object> parameters)
        {
            MySqlCommand command = getAndBindCommand(sql, parameters);

            try
            {
                // 1. 開啟連線
                command.Connection.Open();

                // 2. 開啟Transcation
                command.Transaction = command.Connection.BeginTransaction();

                // 3. 執行查詢
                command.ExecuteNonQuery();

                // 4.1 執行成功，送出Commit，確認執行查詢後結果
                command.Transaction.Commit();

                command.Connection.Close();
            }
            catch (Exception)
            {
                // 4.2 執行失敗，送出Rollback，返回執行查詢前的結果
                command.Transaction.Rollback();
                throw;
            }
        }

        /// <summary>
        /// 建立Connection→設定Command→綁定參數
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        private MySqlCommand getAndBindCommand(string sql, Dictionary<string, object> parameters)
        {
            // 建立連線物件 (SqlConnection)
            MySqlConnection connection = new MySqlConnection();
            connection.ConnectionString = getConnectString();

            // 建立指令物件，設定SQL語法 (SqlCommand)
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = sql;

            // 將參數綁定到語法上
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }

            return command;
        }

        #endregion
    }
}
