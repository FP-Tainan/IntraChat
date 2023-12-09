using System;
using System.Xml;
using System.IO;

namespace IntraChat.DataAccess
{
    public class ArquivoConfiguracao
    {
        public string Servidor { get; set; }
        public string Banco { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        private string arquivoDeConfiguracao;

        public ArquivoConfiguracao()
        {
            this.arquivoDeConfiguracao = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Programa.xml"); 
            CarregarConfiguracao();
        }

        private void CarregarConfiguracao()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(arquivoDeConfiguracao);

            Servidor = doc.SelectSingleNode("//servidor").InnerText;
            Banco = doc.SelectSingleNode("//banco").InnerText;
            Usuario = doc.SelectSingleNode("//usuario").InnerText;
            Senha = doc.SelectSingleNode("//senha").InnerText;
        }

        public void SalvarConfiguracao(string servidor, string banco, string usuario, string senha)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(arquivoDeConfiguracao);

            doc.SelectSingleNode("//servidor").InnerText = servidor;
            doc.SelectSingleNode("//banco").InnerText = banco;
            doc.SelectSingleNode("//usuario").InnerText = usuario;
            doc.SelectSingleNode("//senha").InnerText = senha;

            doc.Save(arquivoDeConfiguracao);
        }







    }
}
