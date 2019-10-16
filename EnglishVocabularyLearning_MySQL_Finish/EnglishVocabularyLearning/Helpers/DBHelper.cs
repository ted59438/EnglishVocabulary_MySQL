using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;

namespace EnglishVocabularyLearning
{
	public class DBHelper
	{
		public static MySqlConnection getConnection()
		{
			MySqlConnection connection = new MySqlConnection();
			connection.ConnectionString = string.Format(@"Server = {0};
														  Database = {1};
														  User ID = {2};
														  Password = {3};
                                                          Connection Timeout = 5",
														  ConfigurationHelper.readConfiguration("DataSource"),
														  ConfigurationHelper.readConfiguration("DBName"),
														  ConfigurationHelper.readConfiguration("Username"),
														  ConfigurationHelper.readConfiguration("Password"));

			return connection;
		}

		public static void testConnect()
		{
			MySqlConnection connection = getConnection();

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

		public static void testConnect(string dataSource, string dbName, string username, string password)
		{
			MySqlConnection connection = new MySqlConnection();
			connection.ConnectionString = string.Format(@"Server = {0};
														  Database = {1};
														  User ID = {2};
														  Password = {3};
                                                          Connection Timeout = 2", dataSource,
																		   dbName,
																		   username,
																		   password
													   );

			try
			{
				connection.Open();
				connection.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static DataTable queryDT(string sql, List<ParameterOBJ> parameters = null)
		{
			parameters = parameters == null ? new List<ParameterOBJ>() : parameters;

			try
			{
				MySqlCommand command = bindCommandParameter(sql, parameters);

				MySqlDataAdapter adapt = new MySqlDataAdapter();
				DataTable queryResultDT = new DataTable();

				command.Connection.Open();

				adapt.SelectCommand = command;
				adapt.Fill(queryResultDT);

				command.Connection.Close();

				return queryResultDT;
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		public static int queryNoneDT(string sql, List<ParameterOBJ> parameters)
		{
			parameters = parameters == null ? new List<ParameterOBJ>() : parameters;

			MySqlCommand command = bindCommandParameter(sql, parameters);

			try
			{
				command.Connection.Open();
				command.Transaction = command.Connection.BeginTransaction();

				int affectDataNum = command.ExecuteNonQuery();
				command.Transaction.Commit();

				return affectDataNum;
			}
			catch (Exception ex)
			{
				command.Transaction.Rollback();
				throw ex;
			}

		}

        public static int queryScalar(string sql, List<ParameterOBJ> parameters)
        {
            parameters = parameters == null ? new List<ParameterOBJ>() : parameters;

            MySqlCommand command = bindCommandParameter(sql, parameters);

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

		private static MySqlCommand bindCommandParameter(string sql, List<ParameterOBJ> parameters)
		{
			MySqlCommand command = new MySqlCommand();

			command.Connection = getConnection();

			command.CommandText = sql;

			command.Parameters.Clear();
			foreach (ParameterOBJ item in parameters)
			{
				command.Parameters.AddWithValue(item.name, item.value);
			}

			return command;
		}
	}
}
