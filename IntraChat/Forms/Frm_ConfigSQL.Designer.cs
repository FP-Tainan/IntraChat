namespace IntraChat.Forms
{
    partial class Frm_ConfigSQL
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ConfigSQL));
            this.txt_Servidor = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.kryptonPalette_Login = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.txt_banco = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Usuario = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Senha = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_TestarConexao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_SalvarConfiguracao = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // txt_Servidor
            // 
            this.txt_Servidor.Location = new System.Drawing.Point(13, 12);
            this.txt_Servidor.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Servidor.Name = "txt_Servidor";
            this.txt_Servidor.Size = new System.Drawing.Size(279, 57);
            this.txt_Servidor.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_Servidor.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_Servidor.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_Servidor.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Servidor.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_Servidor.StateCommon.Border.Rounding = 20;
            this.txt_Servidor.StateCommon.Border.Width = 1;
            this.txt_Servidor.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_Servidor.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Servidor.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.txt_Servidor.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Servidor";
            // 
            // kryptonPalette_Login
            // 
            this.kryptonPalette_Login.ButtonSpecs.FormClose.Image = global::IntraChat.Properties.Resources.Fechar_22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormClose.ImageStates.ImagePressed = global::IntraChat.Properties.Resources.FecharHouver22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormClose.ImageStates.ImageTracking = global::IntraChat.Properties.Resources.FecharHouver22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormMax.Image = global::IntraChat.Properties.Resources.MaxMin22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormMax.ImageStates.ImagePressed = global::IntraChat.Properties.Resources.MaxMin22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormMax.ImageStates.ImageTracking = global::IntraChat.Properties.Resources.MaxMin22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormMin.Image = global::IntraChat.Properties.Resources.Min22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormMin.ImageStates.ImagePressed = global::IntraChat.Properties.Resources.Min22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormMin.ImageStates.ImageTracking = global::IntraChat.Properties.Resources.Min22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormRestore.Image = global::IntraChat.Properties.Resources.MaxMin22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormRestore.ImageStates.ImagePressed = global::IntraChat.Properties.Resources.MaxMin22PX;
            this.kryptonPalette_Login.ButtonSpecs.FormRestore.ImageStates.ImageTracking = global::IntraChat.Properties.Resources.MaxMin22PX;
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.OverrideFocus.Border.Color1 = System.Drawing.Color.Transparent;
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.OverrideFocus.Border.Color2 = System.Drawing.Color.Transparent;
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.OverrideFocus.Border.Width = 0;
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_Login.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            this.kryptonPalette_Login.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonPalette_Login.FormStyles.FormMain.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.None;
            this.kryptonPalette_Login.FormStyles.FormMain.StateCommon.Border.Rounding = 12;
            this.kryptonPalette_Login.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.kryptonPalette_Login.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            this.kryptonPalette_Login.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10, -1, -1, -1);
            // 
            // txt_banco
            // 
            this.txt_banco.Location = new System.Drawing.Point(13, 104);
            this.txt_banco.Margin = new System.Windows.Forms.Padding(4);
            this.txt_banco.Name = "txt_banco";
            this.txt_banco.Size = new System.Drawing.Size(279, 57);
            this.txt_banco.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_banco.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_banco.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_banco.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_banco.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_banco.StateCommon.Border.Rounding = 20;
            this.txt_banco.StateCommon.Border.Width = 1;
            this.txt_banco.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_banco.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_banco.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.txt_banco.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Banco de Dados";
            // 
            // txt_Usuario
            // 
            this.txt_Usuario.Location = new System.Drawing.Point(13, 194);
            this.txt_Usuario.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Usuario.Name = "txt_Usuario";
            this.txt_Usuario.Size = new System.Drawing.Size(279, 57);
            this.txt_Usuario.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_Usuario.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_Usuario.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_Usuario.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Usuario.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_Usuario.StateCommon.Border.Rounding = 20;
            this.txt_Usuario.StateCommon.Border.Width = 1;
            this.txt_Usuario.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_Usuario.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Usuario.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.txt_Usuario.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(13, 279);
            this.txt_Senha.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.Size = new System.Drawing.Size(279, 57);
            this.txt_Senha.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.txt_Senha.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_Senha.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.txt_Senha.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txt_Senha.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.txt_Senha.StateCommon.Border.Rounding = 20;
            this.txt_Senha.StateCommon.Border.Width = 1;
            this.txt_Senha.StateCommon.Content.Color1 = System.Drawing.Color.Gray;
            this.txt_Senha.StateCommon.Content.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Senha.StateCommon.Content.Padding = new System.Windows.Forms.Padding(10);
            this.txt_Senha.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Senha";
            // 
            // Btn_TestarConexao
            // 
            this.Btn_TestarConexao.Location = new System.Drawing.Point(31, 368);
            this.Btn_TestarConexao.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_TestarConexao.Name = "Btn_TestarConexao";
            this.Btn_TestarConexao.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Btn_TestarConexao.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Btn_TestarConexao.OverrideDefault.Back.ColorAngle = 45F;
            this.Btn_TestarConexao.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.Btn_TestarConexao.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Btn_TestarConexao.OverrideDefault.Border.ColorAngle = 45F;
            this.Btn_TestarConexao.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_TestarConexao.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_TestarConexao.OverrideDefault.Border.Rounding = 20;
            this.Btn_TestarConexao.OverrideDefault.Border.Width = 1;
            this.Btn_TestarConexao.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Btn_TestarConexao.Size = new System.Drawing.Size(239, 53);
            this.Btn_TestarConexao.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Btn_TestarConexao.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Btn_TestarConexao.StateCommon.Back.ColorAngle = 45F;
            this.Btn_TestarConexao.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Btn_TestarConexao.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Btn_TestarConexao.StateCommon.Border.ColorAngle = 45F;
            this.Btn_TestarConexao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_TestarConexao.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_TestarConexao.StateCommon.Border.Rounding = 20;
            this.Btn_TestarConexao.StateCommon.Border.Width = 1;
            this.Btn_TestarConexao.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.Btn_TestarConexao.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.Btn_TestarConexao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_TestarConexao.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.Btn_TestarConexao.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.Btn_TestarConexao.StatePressed.Back.ColorAngle = 135F;
            this.Btn_TestarConexao.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.Btn_TestarConexao.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.Btn_TestarConexao.StatePressed.Border.ColorAngle = 135F;
            this.Btn_TestarConexao.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_TestarConexao.StatePressed.Border.Rounding = 20;
            this.Btn_TestarConexao.StatePressed.Border.Width = 1;
            this.Btn_TestarConexao.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Btn_TestarConexao.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.Btn_TestarConexao.StateTracking.Back.ColorAngle = 45F;
            this.Btn_TestarConexao.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.Btn_TestarConexao.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.Btn_TestarConexao.StateTracking.Border.ColorAngle = 45F;
            this.Btn_TestarConexao.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Btn_TestarConexao.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.Btn_TestarConexao.StateTracking.Border.Rounding = 20;
            this.Btn_TestarConexao.StateTracking.Border.Width = 1;
            this.Btn_TestarConexao.TabIndex = 8;
            this.Btn_TestarConexao.Values.Text = "Testar conexão";
            this.Btn_TestarConexao.Click += new System.EventHandler(this.Btn_TestarConexao_Click);
            // 
            // btn_SalvarConfiguracao
            // 
            this.btn_SalvarConfiguracao.Location = new System.Drawing.Point(71, 429);
            this.btn_SalvarConfiguracao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SalvarConfiguracao.Name = "btn_SalvarConfiguracao";
            this.btn_SalvarConfiguracao.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_SalvarConfiguracao.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_SalvarConfiguracao.OverrideDefault.Back.ColorAngle = 45F;
            this.btn_SalvarConfiguracao.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.btn_SalvarConfiguracao.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_SalvarConfiguracao.OverrideDefault.Border.ColorAngle = 45F;
            this.btn_SalvarConfiguracao.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SalvarConfiguracao.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_SalvarConfiguracao.OverrideDefault.Border.Rounding = 20;
            this.btn_SalvarConfiguracao.OverrideDefault.Border.Width = 1;
            this.btn_SalvarConfiguracao.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.btn_SalvarConfiguracao.Size = new System.Drawing.Size(153, 53);
            this.btn_SalvarConfiguracao.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_SalvarConfiguracao.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_SalvarConfiguracao.StateCommon.Back.ColorAngle = 45F;
            this.btn_SalvarConfiguracao.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_SalvarConfiguracao.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_SalvarConfiguracao.StateCommon.Border.ColorAngle = 45F;
            this.btn_SalvarConfiguracao.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SalvarConfiguracao.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_SalvarConfiguracao.StateCommon.Border.Rounding = 20;
            this.btn_SalvarConfiguracao.StateCommon.Border.Width = 1;
            this.btn_SalvarConfiguracao.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_SalvarConfiguracao.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_SalvarConfiguracao.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SalvarConfiguracao.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btn_SalvarConfiguracao.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btn_SalvarConfiguracao.StatePressed.Back.ColorAngle = 135F;
            this.btn_SalvarConfiguracao.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(145)))), ((int)(((byte)(198)))));
            this.btn_SalvarConfiguracao.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(121)))), ((int)(((byte)(206)))));
            this.btn_SalvarConfiguracao.StatePressed.Border.ColorAngle = 135F;
            this.btn_SalvarConfiguracao.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SalvarConfiguracao.StatePressed.Border.Rounding = 20;
            this.btn_SalvarConfiguracao.StatePressed.Border.Width = 1;
            this.btn_SalvarConfiguracao.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_SalvarConfiguracao.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(174)))), ((int)(((byte)(244)))));
            this.btn_SalvarConfiguracao.StateTracking.Back.ColorAngle = 45F;
            this.btn_SalvarConfiguracao.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(147)))), ((int)(((byte)(244)))));
            this.btn_SalvarConfiguracao.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(142)))), ((int)(((byte)(254)))));
            this.btn_SalvarConfiguracao.StateTracking.Border.ColorAngle = 45F;
            this.btn_SalvarConfiguracao.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_SalvarConfiguracao.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btn_SalvarConfiguracao.StateTracking.Border.Rounding = 20;
            this.btn_SalvarConfiguracao.StateTracking.Border.Width = 1;
            this.btn_SalvarConfiguracao.TabIndex = 8;
            this.btn_SalvarConfiguracao.Values.Text = "Salvar";
            this.btn_SalvarConfiguracao.Click += new System.EventHandler(this.btn_SalvarConfiguracao_Click);
            // 
            // Frm_ConfigSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.ClientSize = new System.Drawing.Size(305, 491);
            this.Controls.Add(this.btn_SalvarConfiguracao);
            this.Controls.Add(this.Btn_TestarConexao);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.txt_Usuario);
            this.Controls.Add(this.txt_banco);
            this.Controls.Add(this.txt_Servidor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(321, 530);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(321, 530);
            this.Name = "Frm_ConfigSQL";
            this.Palette = this.kryptonPalette_Login;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Banco Dados";
            this.Load += new System.EventHandler(this.Frm_ConfigSQL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Servidor;
        private System.Windows.Forms.Label label2;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette_Login;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_banco;
        private System.Windows.Forms.Label label1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Usuario;
        private System.Windows.Forms.Label label3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txt_Senha;
        private System.Windows.Forms.Label label4;
        private ComponentFactory.Krypton.Toolkit.KryptonButton Btn_TestarConexao;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btn_SalvarConfiguracao;
    }
}