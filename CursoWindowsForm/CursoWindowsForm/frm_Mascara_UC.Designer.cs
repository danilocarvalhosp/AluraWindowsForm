namespace CursoWindowsForm
{
    partial class frm_Mascara_UC
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
            this.btn_verConteudo = new System.Windows.Forms.Button();
            this.btn_telefone = new System.Windows.Forms.Button();
            this.btn_senha = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_moeda = new System.Windows.Forms.Button();
            this.btn_CEP = new System.Windows.Forms.Button();
            this.btn_hora = new System.Windows.Forms.Button();
            this.lbl_mascaraAtiva = new System.Windows.Forms.Label();
            this.lbl_conteudo = new System.Windows.Forms.Label();
            this.msk_textBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_verConteudo
            // 
            this.btn_verConteudo.Location = new System.Drawing.Point(20, 181);
            this.btn_verConteudo.Name = "btn_verConteudo";
            this.btn_verConteudo.Size = new System.Drawing.Size(258, 37);
            this.btn_verConteudo.TabIndex = 19;
            this.btn_verConteudo.Text = "Ver Conteúdo";
            this.btn_verConteudo.UseVisualStyleBackColor = true;
            this.btn_verConteudo.Click += new System.EventHandler(this.btn_verConteudo_Click);
            // 
            // btn_telefone
            // 
            this.btn_telefone.Location = new System.Drawing.Point(196, 138);
            this.btn_telefone.Name = "btn_telefone";
            this.btn_telefone.Size = new System.Drawing.Size(82, 37);
            this.btn_telefone.TabIndex = 18;
            this.btn_telefone.Text = "Telefone";
            this.btn_telefone.UseVisualStyleBackColor = true;
            this.btn_telefone.Click += new System.EventHandler(this.btn_telefone_Click);
            // 
            // btn_senha
            // 
            this.btn_senha.Location = new System.Drawing.Point(108, 138);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(82, 37);
            this.btn_senha.TabIndex = 17;
            this.btn_senha.Text = "Senha";
            this.btn_senha.UseVisualStyleBackColor = true;
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click);
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(20, 138);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(82, 37);
            this.btn_data.TabIndex = 16;
            this.btn_data.Text = "Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_moeda
            // 
            this.btn_moeda.Location = new System.Drawing.Point(196, 95);
            this.btn_moeda.Name = "btn_moeda";
            this.btn_moeda.Size = new System.Drawing.Size(82, 37);
            this.btn_moeda.TabIndex = 15;
            this.btn_moeda.Text = "Moeda";
            this.btn_moeda.UseVisualStyleBackColor = true;
            this.btn_moeda.Click += new System.EventHandler(this.btn_moeda_Click);
            // 
            // btn_CEP
            // 
            this.btn_CEP.Location = new System.Drawing.Point(108, 95);
            this.btn_CEP.Name = "btn_CEP";
            this.btn_CEP.Size = new System.Drawing.Size(82, 37);
            this.btn_CEP.TabIndex = 14;
            this.btn_CEP.Text = "CEP";
            this.btn_CEP.UseVisualStyleBackColor = true;
            this.btn_CEP.Click += new System.EventHandler(this.btn_CEP_Click);
            // 
            // btn_hora
            // 
            this.btn_hora.Location = new System.Drawing.Point(20, 95);
            this.btn_hora.Name = "btn_hora";
            this.btn_hora.Size = new System.Drawing.Size(82, 37);
            this.btn_hora.TabIndex = 13;
            this.btn_hora.Text = "Hora";
            this.btn_hora.UseVisualStyleBackColor = true;
            this.btn_hora.Click += new System.EventHandler(this.btn_hora_Click);
            // 
            // lbl_mascaraAtiva
            // 
            this.lbl_mascaraAtiva.AutoSize = true;
            this.lbl_mascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mascaraAtiva.Location = new System.Drawing.Point(20, 60);
            this.lbl_mascaraAtiva.Name = "lbl_mascaraAtiva";
            this.lbl_mascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.lbl_mascaraAtiva.TabIndex = 12;
            // 
            // lbl_conteudo
            // 
            this.lbl_conteudo.AutoSize = true;
            this.lbl_conteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_conteudo.Location = new System.Drawing.Point(20, 231);
            this.lbl_conteudo.Name = "lbl_conteudo";
            this.lbl_conteudo.Size = new System.Drawing.Size(0, 19);
            this.lbl_conteudo.TabIndex = 11;
            // 
            // msk_textBox
            // 
            this.msk_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msk_textBox.Location = new System.Drawing.Point(20, 16);
            this.msk_textBox.Name = "msk_textBox";
            this.msk_textBox.Size = new System.Drawing.Size(258, 26);
            this.msk_textBox.TabIndex = 10;
            this.msk_textBox.ValidatingType = typeof(System.DateTime);
            // 
            // frm_Mascara_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_verConteudo);
            this.Controls.Add(this.btn_telefone);
            this.Controls.Add(this.btn_senha);
            this.Controls.Add(this.btn_data);
            this.Controls.Add(this.btn_moeda);
            this.Controls.Add(this.btn_CEP);
            this.Controls.Add(this.btn_hora);
            this.Controls.Add(this.lbl_mascaraAtiva);
            this.Controls.Add(this.lbl_conteudo);
            this.Controls.Add(this.msk_textBox);
            this.Name = "frm_Mascara_UC";
            this.Size = new System.Drawing.Size(301, 275);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_verConteudo;
        private Button btn_telefone;
        private Button btn_senha;
        private Button btn_data;
        private Button btn_moeda;
        private Button btn_CEP;
        private Button btn_hora;
        private Label lbl_mascaraAtiva;
        private Label lbl_conteudo;
        private MaskedTextBox msk_textBox;
    }
}
