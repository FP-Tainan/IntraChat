using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using IntraChat.DataAccess;

namespace IntraChat.Forms
{
    public partial class Frm_ConfigSQL : KryptonForm
    {
        public Frm_ConfigSQL()
        {
            InitializeComponent();
        }
        ArquivoConfiguracao configuracao = new ArquivoConfiguracao();
        ConexaoSQL conexaoSQL = new ConexaoSQL();
        private void Frm_ConfigSQL_Load(object sender, System.EventArgs e)
        {
            
            txt_Servidor.Text = configuracao.Servidor;
            txt_banco.Text = configuracao.Banco;
            txt_Usuario.Text = configuracao.Usuario;
            txt_Senha.Text = configuracao.Senha;
        }

        private void Btn_TestarConexao_Click(object sender, System.EventArgs e)
        {
            conexaoSQL.TestConnection();
        }

        private void btn_SalvarConfiguracao_Click(object sender, System.EventArgs e)
        {
            configuracao.SalvarConfiguracao(txt_Servidor.Text,txt_banco.Text,txt_Usuario.Text,txt_Senha.Text);
        }
    }
}
