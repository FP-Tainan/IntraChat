using Npgsql;
using System;

namespace IntraChat.DataAccess
{
    internal class ConexaoSQL
    {

        public string _connectionString { get;  private set; }

        public ConexaoSQL(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void TestConnection()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString))
                {
                    conn.Open();
                    Console.WriteLine("Conexão bem-sucedida com o banco de dados.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }


    }
}
