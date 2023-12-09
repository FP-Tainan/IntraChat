using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Timers;
using IntraChat.Services;

namespace IntraChat
{
    public partial class Frm_Login : KryptonForm
    {
        public Frm_Login()
        {
            InitializeComponent();
            this.Load += new EventHandler(Frm_Login_Load);

        }
    
        private void Frm_Login_Load(object sender, EventArgs e)
        {
           
            this.BeginInvoke(new Action(AtivarTextBox));
        }

        private void Txt_Usuario_MouseEnter(object sender, EventArgs e)
        {
           if(Txt_Usuario.Text == "Entre com seu usuário") { Txt_Usuario.Clear(); Txt_Usuario.Focus(); }
        }

        private void Txt_SenhaUsuario_MouseEnter(object sender, EventArgs e)
        {
            if(Txt_SenhaUsuario.Text == "Entre com sua senha") { Txt_SenhaUsuario.Clear(); Txt_SenhaUsuario.UseSystemPasswordChar = true; Txt_SenhaUsuario.Focus(); }
        }
        private void Btn_Acessar_Click(object sender, EventArgs e)
        {

        }
        #region Metodos

        private void AtivarTextBox()
        {
            Txt_SenhaUsuario.Enabled = true;
            Txt_Usuario.Enabled = true;
        }


        #endregion

        private void btn_verSenha_Click(object sender, EventArgs e)
        {
            if (Txt_SenhaUsuario.UseSystemPasswordChar) { Txt_SenhaUsuario.UseSystemPasswordChar = false; btn_verSenha.IconChar = FontAwesome.Sharp.IconChar.Eye; }
            else { Txt_SenhaUsuario.UseSystemPasswordChar = true; btn_verSenha.IconChar = FontAwesome.Sharp.IconChar.EyeSlash; }
            Txt_SenhaUsuario.Focus();

        }

        private void Txt_SenhaUsuario_TextChanged(object sender, EventArgs e)
        {
            if(Txt_SenhaUsuario.Text.Length > 10) { Txt_SenhaUsuario.Clear(); MessageBox.Show("A senha tem no maximo 10 digitos!"); }
        }
    }
}
