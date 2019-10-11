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
            try
            {
                string sql = @"SELECT StudentID,
                                      RealName,
								      Username,
								      CAST(Birthdate AS DATE) AS Birthdate
						       FROM Student";

                queryResultGrid.DataSource = queryDT(sql, new Dictionary<string, object>());

                insertStudentBtn.Enabled = editStudentBtn.Enabled = deleteStudentBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                if (queryScalar(sql, parameters) != 0)
                {
                    MessageBox.Show("學生帳號已經存在！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            sql = @"INSERT
                    INTO Student(StudentID, RealName, Birthdate, Username, Password)
                    VALUES (@StudentID, @RealName, @Birthdate, @Username, SHA2(@Password, 256))";
            parameters = new Dictionary<string, object>()
            {
                {"StudentID", Guid.NewGuid().ToString() },
                {"RealName", studentNameTextBox.Text },
                {"Birthdate", studentBirthdatePicker.Value },
                {"Username", studentUsernameTextBox.Text },
                {"Password", studentPasswordTextBox.Text }
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
