using Npgsql;
using System;
using System.Windows;

namespace IntraChat.DataAccess
{
    internal class ConexaoSQL
    {

        

        private string _connectionString()
        {
            ArquivoConfiguracao ArquivoConfiguracaoBanco = new ArquivoConfiguracao();
            string StringConexao = $"Host={ArquivoConfiguracaoBanco.Servidor};Username={ArquivoConfiguracaoBanco.Usuario};Password={ArquivoConfiguracaoBanco.Senha};Database={ArquivoConfiguracaoBanco.Banco}";
            return StringConexao;
        }

        public ConexaoSQL() { }


        public NpgsqlConnection Conexao()
        {
            NpgsqlConnection conexao = new NpgsqlConnection(_connectionString());

            return conexao;
        }

        public void TestConnection()
        {
            try
            {
                using (var conn = new NpgsqlConnection(_connectionString()))
                {
                    conn.Open();
                   MessageBox.Show("Conexão bem-sucedida com o banco de dados.","Configuração Banco de Dados",MessageBoxButton.OK,MessageBoxImage.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {ex.Message}");
            }
        }


    }
}
