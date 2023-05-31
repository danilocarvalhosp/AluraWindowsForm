namespace CursoWindowsForm
{
    partial class Frm_CadastroCliente_UC
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CadastroCliente_UC));
            lbl_CPF = new Label();
            txt_CPF = new TextBox();
            txt_nomeCliente = new TextBox();
            lbl_nomeCliente = new Label();
            txt_nomePai = new TextBox();
            lbl_nomePai = new Label();
            txt_nomeMae = new TextBox();
            lbl_nomeMae = new Label();
            txt_CEP = new TextBox();
            lbl_CEP = new Label();
            txt_logradouro = new TextBox();
            lbl_logradouro = new Label();
            txt_telefone = new TextBox();
            lbl_telefone = new Label();
            txt_profissao = new TextBox();
            lbl_profissao = new Label();
            txt_rendaFamiliar = new TextBox();
            lbl_rendaFamiliar = new Label();
            txt_codigoCliente = new TextBox();
            grp_codigo = new GroupBox();
            grp_dadosPessoais = new GroupBox();
            grp_Genero = new GroupBox();
            rdb_Indefinido = new RadioButton();
            rdb_Masculino = new RadioButton();
            rdb_Feminino = new RadioButton();
            grp_TemPai = new GroupBox();
            chk_TemPai = new CheckBox();
            grp_endereco = new GroupBox();
            cmb_Estados = new ComboBox();
            txt_Cidade = new TextBox();
            lbl_Cidade = new Label();
            lbl_estado = new Label();
            txt_bairro = new TextBox();
            lbl_bairro = new Label();
            txt_complemento = new TextBox();
            lbl_complemento = new Label();
            grp_outros = new GroupBox();
            Tls_Principal = new ToolStrip();
            novaToolStripButton = new ToolStripButton();
            abrirToolStripButton = new ToolStripButton();
            salvarToolStripButton = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ApagaToolStripButton = new ToolStripButton();
            LimparToolStripButton = new ToolStripButton();
            grp_codigo.SuspendLayout();
            grp_dadosPessoais.SuspendLayout();
            grp_Genero.SuspendLayout();
            grp_TemPai.SuspendLayout();
            grp_endereco.SuspendLayout();
            grp_outros.SuspendLayout();
            Tls_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_CPF
            // 
            lbl_CPF.AutoSize = true;
            lbl_CPF.Location = new Point(484, 68);
            lbl_CPF.Name = "lbl_CPF";
            lbl_CPF.Size = new Size(38, 15);
            lbl_CPF.TabIndex = 0;
            lbl_CPF.Text = "label1";
            // 
            // txt_CPF
            // 
            txt_CPF.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_CPF.Location = new Point(482, 84);
            txt_CPF.Name = "txt_CPF";
            txt_CPF.Size = new Size(292, 23);
            txt_CPF.TabIndex = 6;
            // 
            // txt_nomeCliente
            // 
            txt_nomeCliente.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nomeCliente.Location = new Point(6, 42);
            txt_nomeCliente.Name = "txt_nomeCliente";
            txt_nomeCliente.Size = new Size(768, 23);
            txt_nomeCliente.TabIndex = 2;
            // 
            // lbl_nomeCliente
            // 
            lbl_nomeCliente.AutoSize = true;
            lbl_nomeCliente.Location = new Point(6, 26);
            lbl_nomeCliente.Name = "lbl_nomeCliente";
            lbl_nomeCliente.Size = new Size(38, 15);
            lbl_nomeCliente.TabIndex = 2;
            lbl_nomeCliente.Text = "label1";
            // 
            // txt_nomePai
            // 
            txt_nomePai.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nomePai.Location = new Point(6, 122);
            txt_nomePai.Name = "txt_nomePai";
            txt_nomePai.Size = new Size(470, 23);
            txt_nomePai.TabIndex = 3;
            // 
            // lbl_nomePai
            // 
            lbl_nomePai.AutoSize = true;
            lbl_nomePai.Location = new Point(6, 106);
            lbl_nomePai.Name = "lbl_nomePai";
            lbl_nomePai.Size = new Size(38, 15);
            lbl_nomePai.TabIndex = 4;
            lbl_nomePai.Text = "label1";
            // 
            // txt_nomeMae
            // 
            txt_nomeMae.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_nomeMae.Location = new Point(6, 84);
            txt_nomeMae.Name = "txt_nomeMae";
            txt_nomeMae.Size = new Size(470, 23);
            txt_nomeMae.TabIndex = 4;
            // 
            // lbl_nomeMae
            // 
            lbl_nomeMae.AutoSize = true;
            lbl_nomeMae.Location = new Point(6, 68);
            lbl_nomeMae.Name = "lbl_nomeMae";
            lbl_nomeMae.Size = new Size(38, 15);
            lbl_nomeMae.TabIndex = 6;
            lbl_nomeMae.Text = "label1";
            // 
            // txt_CEP
            // 
            txt_CEP.Location = new Point(6, 35);
            txt_CEP.Name = "txt_CEP";
            txt_CEP.Size = new Size(132, 23);
            txt_CEP.TabIndex = 7;
            // 
            // lbl_CEP
            // 
            lbl_CEP.AutoSize = true;
            lbl_CEP.Location = new Point(6, 19);
            lbl_CEP.Name = "lbl_CEP";
            lbl_CEP.Size = new Size(38, 15);
            lbl_CEP.TabIndex = 10;
            lbl_CEP.Text = "label1";
            // 
            // txt_logradouro
            // 
            txt_logradouro.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_logradouro.Location = new Point(156, 35);
            txt_logradouro.Name = "txt_logradouro";
            txt_logradouro.Size = new Size(618, 23);
            txt_logradouro.TabIndex = 8;
            // 
            // lbl_logradouro
            // 
            lbl_logradouro.AutoSize = true;
            lbl_logradouro.Location = new Point(156, 19);
            lbl_logradouro.Name = "lbl_logradouro";
            lbl_logradouro.Size = new Size(38, 15);
            lbl_logradouro.TabIndex = 12;
            lbl_logradouro.Text = "label1";
            // 
            // txt_telefone
            // 
            txt_telefone.Location = new Point(6, 35);
            txt_telefone.Name = "txt_telefone";
            txt_telefone.Size = new Size(328, 23);
            txt_telefone.TabIndex = 13;
            // 
            // lbl_telefone
            // 
            lbl_telefone.AutoSize = true;
            lbl_telefone.Location = new Point(6, 19);
            lbl_telefone.Name = "lbl_telefone";
            lbl_telefone.Size = new Size(38, 15);
            lbl_telefone.TabIndex = 20;
            lbl_telefone.Text = "label1";
            // 
            // txt_profissao
            // 
            txt_profissao.Anchor =  AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_profissao.Location = new Point(341, 35);
            txt_profissao.Name = "txt_profissao";
            txt_profissao.Size = new Size(433, 23);
            txt_profissao.TabIndex = 14;
            // 
            // lbl_profissao
            // 
            lbl_profissao.AutoSize = true;
            lbl_profissao.Location = new Point(339, 19);
            lbl_profissao.Name = "lbl_profissao";
            lbl_profissao.Size = new Size(38, 15);
            lbl_profissao.TabIndex = 22;
            lbl_profissao.Text = "label1";
            // 
            // txt_rendaFamiliar
            // 
            txt_rendaFamiliar.Location = new Point(6, 77);
            txt_rendaFamiliar.Name = "txt_rendaFamiliar";
            txt_rendaFamiliar.Size = new Size(328, 23);
            txt_rendaFamiliar.TabIndex = 15;
            // 
            // lbl_rendaFamiliar
            // 
            lbl_rendaFamiliar.AutoSize = true;
            lbl_rendaFamiliar.Location = new Point(6, 61);
            lbl_rendaFamiliar.Name = "lbl_rendaFamiliar";
            lbl_rendaFamiliar.Size = new Size(38, 15);
            lbl_rendaFamiliar.TabIndex = 24;
            lbl_rendaFamiliar.Text = "label1";
            // 
            // txt_codigoCliente
            // 
            txt_codigoCliente.Location = new Point(6, 22);
            txt_codigoCliente.Name = "txt_codigoCliente";
            txt_codigoCliente.Size = new Size(178, 23);
            txt_codigoCliente.TabIndex = 1;
            // 
            // grp_codigo
            // 
            grp_codigo.Controls.Add(txt_codigoCliente);
            grp_codigo.Location = new Point(12, 56);
            grp_codigo.Name = "grp_codigo";
            grp_codigo.Size = new Size(194, 52);
            grp_codigo.TabIndex = 28;
            grp_codigo.TabStop = false;
            grp_codigo.Text = "groupBox1";
            // 
            // grp_dadosPessoais
            // 
            grp_dadosPessoais.Controls.Add(grp_Genero);
            grp_dadosPessoais.Controls.Add(grp_TemPai);
            grp_dadosPessoais.Controls.Add(txt_nomeCliente);
            grp_dadosPessoais.Controls.Add(lbl_nomeCliente);
            grp_dadosPessoais.Controls.Add(txt_nomePai);
            grp_dadosPessoais.Controls.Add(lbl_nomePai);
            grp_dadosPessoais.Controls.Add(txt_nomeMae);
            grp_dadosPessoais.Controls.Add(lbl_nomeMae);
            grp_dadosPessoais.Controls.Add(txt_CPF);
            grp_dadosPessoais.Controls.Add(lbl_CPF);
            grp_dadosPessoais.Location = new Point(12, 107);
            grp_dadosPessoais.Name = "grp_dadosPessoais";
            grp_dadosPessoais.Size = new Size(780, 195);
            grp_dadosPessoais.TabIndex = 29;
            grp_dadosPessoais.TabStop = false;
            grp_dadosPessoais.Text = "groupBox1";
            // 
            // grp_Genero
            // 
            grp_Genero.Controls.Add(rdb_Indefinido);
            grp_Genero.Controls.Add(rdb_Masculino);
            grp_Genero.Controls.Add(rdb_Feminino);
            grp_Genero.Location = new Point(482, 107);
            grp_Genero.Name = "grp_Genero";
            grp_Genero.Size = new Size(142, 79);
            grp_Genero.TabIndex = 36;
            grp_Genero.TabStop = false;
            // 
            // rdb_Indefinido
            // 
            rdb_Indefinido.AutoSize = true;
            rdb_Indefinido.Location = new Point(6, 54);
            rdb_Indefinido.Name = "rdb_Indefinido";
            rdb_Indefinido.Size = new Size(94, 19);
            rdb_Indefinido.TabIndex = 34;
            rdb_Indefinido.TabStop = true;
            rdb_Indefinido.Text = "radioButton3";
            rdb_Indefinido.UseVisualStyleBackColor = true;
            // 
            // rdb_Masculino
            // 
            rdb_Masculino.AutoSize = true;
            rdb_Masculino.Location = new Point(6, 16);
            rdb_Masculino.Name = "rdb_Masculino";
            rdb_Masculino.Size = new Size(94, 19);
            rdb_Masculino.TabIndex = 32;
            rdb_Masculino.TabStop = true;
            rdb_Masculino.Text = "radioButton1";
            rdb_Masculino.UseVisualStyleBackColor = true;
            // 
            // rdb_Feminino
            // 
            rdb_Feminino.AutoSize = true;
            rdb_Feminino.Location = new Point(6, 35);
            rdb_Feminino.Name = "rdb_Feminino";
            rdb_Feminino.Size = new Size(94, 19);
            rdb_Feminino.TabIndex = 33;
            rdb_Feminino.TabStop = true;
            rdb_Feminino.Text = "radioButton2";
            rdb_Feminino.UseVisualStyleBackColor = true;
            // 
            // grp_TemPai
            // 
            grp_TemPai.Controls.Add(chk_TemPai);
            grp_TemPai.Location = new Point(6, 145);
            grp_TemPai.Name = "grp_TemPai";
            grp_TemPai.Size = new Size(211, 41);
            grp_TemPai.TabIndex = 9;
            grp_TemPai.TabStop = false;
            // 
            // chk_TemPai
            // 
            chk_TemPai.AutoSize = true;
            chk_TemPai.Location = new Point(12, 14);
            chk_TemPai.Name = "chk_TemPai";
            chk_TemPai.Size = new Size(83, 19);
            chk_TemPai.TabIndex = 0;
            chk_TemPai.Text = "checkBox1";
            chk_TemPai.UseVisualStyleBackColor = true;
            chk_TemPai.CheckedChanged += chk_TemPai_CheckedChanged;
            // 
            // grp_endereco
            // 
            grp_endereco.Controls.Add(cmb_Estados);
            grp_endereco.Controls.Add(txt_Cidade);
            grp_endereco.Controls.Add(lbl_Cidade);
            grp_endereco.Controls.Add(lbl_estado);
            grp_endereco.Controls.Add(txt_bairro);
            grp_endereco.Controls.Add(lbl_bairro);
            grp_endereco.Controls.Add(txt_complemento);
            grp_endereco.Controls.Add(lbl_complemento);
            grp_endereco.Controls.Add(txt_CEP);
            grp_endereco.Controls.Add(lbl_CEP);
            grp_endereco.Controls.Add(txt_logradouro);
            grp_endereco.Controls.Add(lbl_logradouro);
            grp_endereco.Location = new Point(12, 302);
            grp_endereco.Name = "grp_endereco";
            grp_endereco.Size = new Size(780, 150);
            grp_endereco.TabIndex = 30;
            grp_endereco.TabStop = false;
            grp_endereco.Text = "groupBox1";
            // 
            // cmb_Estados
            // 
            cmb_Estados.FormattingEnabled = true;
            cmb_Estados.Location = new Point(283, 121);
            cmb_Estados.Name = "cmb_Estados";
            cmb_Estados.Size = new Size(491, 23);
            cmb_Estados.TabIndex = 27;
            // 
            // txt_Cidade
            // 
            txt_Cidade.Location = new Point(6, 121);
            txt_Cidade.Name = "txt_Cidade";
            txt_Cidade.Size = new Size(271, 23);
            txt_Cidade.TabIndex = 11;
            // 
            // lbl_Cidade
            // 
            lbl_Cidade.AutoSize = true;
            lbl_Cidade.Location = new Point(4, 105);
            lbl_Cidade.Name = "lbl_Cidade";
            lbl_Cidade.Size = new Size(38, 15);
            lbl_Cidade.TabIndex = 26;
            lbl_Cidade.Text = "label1";
            // 
            // lbl_estado
            // 
            lbl_estado.AutoSize = true;
            lbl_estado.Location = new Point(283, 105);
            lbl_estado.Name = "lbl_estado";
            lbl_estado.Size = new Size(38, 15);
            lbl_estado.TabIndex = 24;
            lbl_estado.Text = "label1";
            // 
            // txt_bairro
            // 
            txt_bairro.Location = new Point(283, 78);
            txt_bairro.Name = "txt_bairro";
            txt_bairro.Size = new Size(491, 23);
            txt_bairro.TabIndex = 10;
            // 
            // lbl_bairro
            // 
            lbl_bairro.AutoSize = true;
            lbl_bairro.Location = new Point(281, 62);
            lbl_bairro.Name = "lbl_bairro";
            lbl_bairro.Size = new Size(38, 15);
            lbl_bairro.TabIndex = 22;
            lbl_bairro.Text = "label1";
            // 
            // txt_complemento
            // 
            txt_complemento.Location = new Point(6, 78);
            txt_complemento.Name = "txt_complemento";
            txt_complemento.Size = new Size(271, 23);
            txt_complemento.TabIndex = 9;
            // 
            // lbl_complemento
            // 
            lbl_complemento.AutoSize = true;
            lbl_complemento.Location = new Point(6, 62);
            lbl_complemento.Name = "lbl_complemento";
            lbl_complemento.Size = new Size(38, 15);
            lbl_complemento.TabIndex = 20;
            lbl_complemento.Text = "label1";
            // 
            // grp_outros
            // 
            grp_outros.Controls.Add(txt_telefone);
            grp_outros.Controls.Add(txt_rendaFamiliar);
            grp_outros.Controls.Add(lbl_telefone);
            grp_outros.Controls.Add(lbl_rendaFamiliar);
            grp_outros.Controls.Add(lbl_profissao);
            grp_outros.Controls.Add(txt_profissao);
            grp_outros.Location = new Point(12, 452);
            grp_outros.Name = "grp_outros";
            grp_outros.Size = new Size(780, 107);
            grp_outros.TabIndex = 31;
            grp_outros.TabStop = false;
            grp_outros.Text = "groupBox1";
            // 
            // Tls_Principal
            // 
            Tls_Principal.Items.AddRange(new ToolStripItem [] { novaToolStripButton, abrirToolStripButton, salvarToolStripButton, toolStripSeparator1, ApagaToolStripButton, LimparToolStripButton });
            Tls_Principal.Location = new Point(0, 0);
            Tls_Principal.Name = "Tls_Principal";
            Tls_Principal.Size = new Size(802, 25);
            Tls_Principal.TabIndex = 32;
            Tls_Principal.Text = "toolStrip1";
            // 
            // novaToolStripButton
            // 
            novaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            novaToolStripButton.Image = (Image) resources.GetObject("novaToolStripButton.Image");
            novaToolStripButton.ImageTransparentColor = Color.Magenta;
            novaToolStripButton.Name = "novaToolStripButton";
            novaToolStripButton.Size = new Size(23, 22);
            novaToolStripButton.Text = "&Novo";
            novaToolStripButton.Click += novaToolStripButton_Click;
            // 
            // abrirToolStripButton
            // 
            abrirToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            abrirToolStripButton.Image = (Image) resources.GetObject("abrirToolStripButton.Image");
            abrirToolStripButton.ImageTransparentColor = Color.Magenta;
            abrirToolStripButton.Name = "abrirToolStripButton";
            abrirToolStripButton.Size = new Size(23, 22);
            abrirToolStripButton.Text = "&Abrir";
            abrirToolStripButton.Click += abrirToolStripButton_Click;
            // 
            // salvarToolStripButton
            // 
            salvarToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            salvarToolStripButton.Image = (Image) resources.GetObject("salvarToolStripButton.Image");
            salvarToolStripButton.ImageTransparentColor = Color.Magenta;
            salvarToolStripButton.Name = "salvarToolStripButton";
            salvarToolStripButton.Size = new Size(23, 22);
            salvarToolStripButton.Text = "&Salvar";
            salvarToolStripButton.Click += salvarToolStripButton_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // ApagaToolStripButton
            // 
            ApagaToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            ApagaToolStripButton.Image = Properties.Resources.ExcluirBarra;
            ApagaToolStripButton.ImageTransparentColor = Color.Magenta;
            ApagaToolStripButton.Name = "ApagaToolStripButton";
            ApagaToolStripButton.Size = new Size(23, 22);
            ApagaToolStripButton.Text = "toolStripButton1";
            ApagaToolStripButton.Click += ApagaToolStripButton_Click;
            // 
            // LimparToolStripButton
            // 
            LimparToolStripButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            LimparToolStripButton.Image = Properties.Resources.LimparBarra;
            LimparToolStripButton.ImageTransparentColor = Color.Magenta;
            LimparToolStripButton.Name = "LimparToolStripButton";
            LimparToolStripButton.Size = new Size(23, 22);
            LimparToolStripButton.Text = "toolStripButton1";
            LimparToolStripButton.Click += LimparToolStripButton_Click;
            // 
            // Frm_CadastroCliente_UC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(Tls_Principal);
            Controls.Add(grp_outros);
            Controls.Add(grp_endereco);
            Controls.Add(grp_dadosPessoais);
            Controls.Add(grp_codigo);
            Name = "Frm_CadastroCliente_UC";
            Size = new Size(802, 571);
            grp_codigo.ResumeLayout(false);
            grp_codigo.PerformLayout();
            grp_dadosPessoais.ResumeLayout(false);
            grp_dadosPessoais.PerformLayout();
            grp_Genero.ResumeLayout(false);
            grp_Genero.PerformLayout();
            grp_TemPai.ResumeLayout(false);
            grp_TemPai.PerformLayout();
            grp_endereco.ResumeLayout(false);
            grp_endereco.PerformLayout();
            grp_outros.ResumeLayout(false);
            grp_outros.PerformLayout();
            Tls_Principal.ResumeLayout(false);
            Tls_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_CPF;
        private TextBox txt_CPF;
        private TextBox txt_nomeCliente;
        private Label lbl_nomeCliente;
        private TextBox txt_nomePai;
        private Label lbl_nomePai;
        private TextBox txt_nomeMae;
        private Label lbl_nomeMae;
        private TextBox txt_genero;
        private Label lbl_genero;
        private TextBox txt_CEP;
        private Label lbl_CEP;
        private TextBox txt_logradouro;
        private Label lbl_logradouro;
        private TextBox txt_telefone;
        private Label lbl_telefone;
        private TextBox txt_profissao;
        private Label lbl_profissao;
        private TextBox txt_rendaFamiliar;
        private Label lbl_rendaFamiliar;
        private TextBox txt_codigoCliente;
        private GroupBox grp_codigo;
        private GroupBox grp_dadosPessoais;
        private GroupBox grp_endereco;
        private TextBox txt_bairro;
        private Label lbl_bairro;
        private TextBox txt_complemento;
        private Label lbl_complemento;
        private GroupBox grp_outros;
        private TextBox txt_Cidade;
        private Label lbl_Cidade;
        private GroupBox grp_TemPai;
        private CheckBox chk_TemPai;
        private RadioButton rdb_Masculino;
        private RadioButton rdb_Feminino;
        private RadioButton radioButton4;
        private GroupBox grp_Genero;
        private RadioButton rdb_Indefinido;
        private GroupBox groupBox2;
        private ComboBox cmb_Estados;
        private Label lbl_estado;
        private ToolStrip Tls_Principal;
        private ToolStripButton novaToolStripButton;
        private ToolStripButton abrirToolStripButton;
        private ToolStripButton salvarToolStripButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton ApagaToolStripButton;
        private ToolStripButton LimparToolStripButton;
    }
}
