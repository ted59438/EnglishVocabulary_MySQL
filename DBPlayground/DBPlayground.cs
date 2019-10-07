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
            catch (Exception  ex)
            {

                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 測試連線資料庫：設定連線字串→開啟連線→關閉連線
        /// 如果無法正常連線，丟出例外錯誤
        /// </summary>
        private void testConnectDB()
        {
            MySqlConnection connection = new MySqlConnection();

            string connectionString = string.Format(@"Server =   {0};
                                                      Database = {1};
                                                      User ID =  {2};
                                                      Password = {3};
                                                      Connection Timeout = 5",
                                                      serverNameInput.Text,
                                                      dbNameInput.Text,
                                                      dbUsernameInput.Text,
                                                      dbPasswordInput.Text);
            connection.ConnectionString = connectionString;

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
    }
}
