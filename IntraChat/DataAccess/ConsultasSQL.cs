using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntraChat.DataAccess
{
    internal class ConsultasSQL : ConexaoSQL
    {

        public ConsultasSQL() { }

        public bool VerificaUsuario(string login, string senha)
        {
            bool Validacao = false;

            DataTable dt = new DataTable();

            try
            {
                NpgsqlConnection conn = Conexao();
                
                    conn.Open();

                    string query = $"SELECT * FROM tbl_usuario WHERE login = {login} AND senha = {senha}";

                    NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    dt.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao executar consulta: {ex.Message}");
            }

            if (dt.Rows.Count > 0) { Validacao = true; }

            return Validacao;

        }





    }
}
