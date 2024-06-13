using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ControleDeTarefas.Classes
{
    public class Database
    {
        private string connectionString;
        public Database(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public void ExecuteQuery(Action<MySqlCommand> query)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    query(command);
                }
            }
        }

        public DataTable ExecuteQueryToDataTable(string query, Action<MySqlCommand> parameterize = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    parameterize?.Invoke(command);

                    DataTable dataTable = new DataTable();
                    using (var adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                    return dataTable;
                }
            }

        }

        public T ExecuteScalar<T>(string query, Action<MySqlCommand> parameterize = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    parameterize?.Invoke(command);

                    object result = command.ExecuteScalar();
                    return (T)Convert.ChangeType(result, typeof(T));
                }
            }
        }

        public void ExecuteNonQuery(string query, Action<MySqlCommand> parameterize = null)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = query;
                    parameterize?.Invoke(command);
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
