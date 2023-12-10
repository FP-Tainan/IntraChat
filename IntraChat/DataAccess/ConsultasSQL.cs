using IntraChat.Services;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IntraChat.Utilities;

namespace IntraChat.DataAccess
{
    internal class ConsultasSQL : ConexaoSQL
    {

        public ConsultasSQL() { }

        public bool VerificaUsuario(string login, string senha)
        {
            Criptografia cripto = new Criptografia();
            DataTable dt = new DataTable();

            bool Validacao = false;
            string SenhaCriptografada = cripto.Senha(senha);

            try
            {
                NpgsqlConnection conn = Conexao();

                conn.Open();

                string query = $"SELECT id,usuario,nome FROM tbl_usuario WHERE usuario = '{login}' AND senha = '{SenhaCriptografada}'";

                NpgsqlCommand cmd = new NpgsqlCommand(query, conn);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                dt.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro ao executar consulta: {ex.Message}");
            }

            if (dt.Rows.Count > 0)
            {
                DataRow dr = dt.Rows[0];

                Global.DefinirUsuario_id(Convert.ToInt32(dr["id"]));

                Global.DefinirUsuario(dr["usuario"].ToString());

                Global.DefinirNome(dr["nome"].ToString());


                Validacao = true;
            }

            return Validacao;

        }





    }
}
