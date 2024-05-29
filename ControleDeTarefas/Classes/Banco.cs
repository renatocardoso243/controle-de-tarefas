using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ControleDeTarefas.Classes
{
    public class Banco
    {
        //String de conexão com MySql
        private static string connectionString = "server=localhost;database=pcomercial;user=root;password=1234";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }

        public static void OpenConnection(MySqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao abrir conexão com banco de dados.", ex);
            }
        }

        public static void CloseConnection(MySqlConnection connection)
        {
            try
            {
                if (connection.State == System.Data.ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao fechar a conexão com banco de dados.", ex);
            }
        }
    }
 }

