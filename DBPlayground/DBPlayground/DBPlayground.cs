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

		private void connectBtn_Click(object sender, EventArgs e)
		{
			try
			{
				testConnectDB();
				MessageBox.Show("測試連線成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{

				MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

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

		private void queryStudentBtn_Click(object sender, EventArgs e)
		{
			string sql = @"SELECT StudentID,
                                  RealName AS 真實姓名,
								  Username AS 測驗帳號,
								  CAST(Birthdate AS DATE) AS 出生日期
						  FROM Student";

			queryResultGrid.DataSource = queryDT(sql, new Dictionary<string, object>());

            selectStudentCombo.DataSource = queryDT(sql, new Dictionary<string, object>());

            // 設定下拉選單哪個欄位用於顯示，那個欄位代表選擇的對應值
            selectStudentCombo.DisplayMember = "真實姓名";
            selectStudentCombo.ValueMember = "StudentID";
        }

		/// <summary>
		///  基本查詢
		/// </summary>
		/// <param name="sql"></param>
		/// <returns></returns>
		private DataTable queryDT(string sql, Dictionary<string, object> parameters)
		{
			// Step 1. 建立連線物件 (SqlConnection)
			MySqlConnection connection = new MySqlConnection();
			connection.ConnectionString = getConnectString();

			// Step 2. 建立指令物件，設定SQL語法 (SqlCommand)
			MySqlCommand command = new MySqlCommand();
			command.Connection = connection;
			command.CommandText = sql;

            // 將參數綁定到語法上
            foreach (KeyValuePair<string, object> parameter in parameters)
            {
                command.Parameters.AddWithValue(parameter.Key, parameter.Value);
            }


			// Step 3. 建立撈取資料的物件 (Adapter)
			MySqlDataAdapter adapter = new MySqlDataAdapter();
			adapter.SelectCommand = command;

			// Step 4. 開啟連線 
			connection.Open();

			// Step 5. 執行SELECT查詢，取得資料後存放到DataTable
			DataTable queryResultDT = new DataTable();
			adapter.Fill(queryResultDT);

			// Step 6. 關閉連線
			connection.Close();

			return queryResultDT;
		}
        /// <summary>
        /// 取得特定學生的資料
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void queryOneStudentBtn_Click(object sender, EventArgs e)
        {
            string sql = @"SELECT *
                           FROM Student
                           WHERE StudentID = @StudentID";

            Dictionary<string, object> parameters = new Dictionary<string, object>()
            {
                {"StudentID", selectStudentCombo.SelectedValue }
            };

            queryResultGrid.DataSource = queryDT(sql, parameters);
        }
    }
}
