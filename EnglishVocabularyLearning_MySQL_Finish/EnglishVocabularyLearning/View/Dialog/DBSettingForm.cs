using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnglishVocabularyLearning
{
	public partial class DBSettingForm : Form
	{
		public DBSettingForm()
		{
			InitializeComponent();
		}

		private void DBSettingForm_Load(object sender, EventArgs e)
		{
			dbSourceTextBox.Text = ConfigurationHelper.readConfiguration("DataSource");
			dbNameTextBox.Text = ConfigurationHelper.readConfiguration("DBName");
			usernameTextBox.Text = ConfigurationHelper.readConfiguration("Username");
			passwordTextBox.Text = ConfigurationHelper.readConfiguration("Password");
		}

		private void saveBtn_Click(object sender, EventArgs e)
		{
			ConfigurationHelper.writeConfiguration("DataSource", dbSourceTextBox.Text);
			ConfigurationHelper.writeConfiguration("DBName", dbNameTextBox.Text);
			ConfigurationHelper.writeConfiguration("Username", usernameTextBox.Text);
			ConfigurationHelper.writeConfiguration("Password", passwordTextBox.Text);

            this.Dispose();
		}

		private void cancleBtn_Click(object sender, EventArgs e)
		{
			this.Dispose();
		}

        private void testConnectBtn_Click(object sender, EventArgs e)
        {
            string dbSource = dbSourceTextBox.Text;
            string dbName = dbNameTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;

            testConnectBtn.Enabled = false;

            try
            {
                DBHelper.testConnect(dbSource, dbName, username, password);
                MessageBox.Show("連線成功", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            testConnectBtn.Enabled = true;
        }

        private void testInsert()
        {
            List<ParameterOBJ> parameters = new List<ParameterOBJ>()
            {
                new ParameterOBJ("GUID", Guid.NewGuid()),
                new ParameterOBJ("Username", "test"),
                new ParameterOBJ("Password", "1234"),
                new ParameterOBJ("Name", "安安"),
                new ParameterOBJ("BirthDate", "2001-01-01"),
            };

            DBHelper.queryNoneDT(@"INSERT
								   INTO Student (StudentID, Username, Password, RealName, Birthdate)
								   VALUES(@GUID, @Username, @Password, @Name, @Birthdate);
														", parameters);
        }
    }
}
