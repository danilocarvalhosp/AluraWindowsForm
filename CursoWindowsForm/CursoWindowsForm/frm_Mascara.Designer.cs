namespace CursoWindowsForm
{
    partial class frm_Mascara
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
            this.msk_textBox = new System.Windows.Forms.MaskedTextBox();
            this.lbl_conteudo = new System.Windows.Forms.Label();
            this.lbl_mascaraAtiva = new System.Windows.Forms.Label();
            this.btn_hora = new System.Windows.Forms.Button();
            this.btn_CEP = new System.Windows.Forms.Button();
            this.btn_moeda = new System.Windows.Forms.Button();
            this.btn_telefone = new System.Windows.Forms.Button();
            this.btn_senha = new System.Windows.Forms.Button();
            this.btn_data = new System.Windows.Forms.Button();
            this.btn_verConteudo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_textBox
            // 
            this.msk_textBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.msk_textBox.Location = new System.Drawing.Point(23, 31);
            this.msk_textBox.Name = "msk_textBox";
            this.msk_textBox.Size = new System.Drawing.Size(258, 26);
            this.msk_textBox.TabIndex = 0;
            this.msk_textBox.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_conteudo
            // 
            this.lbl_conteudo.AutoSize = true;
            this.lbl_conteudo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_conteudo.Location = new System.Drawing.Point(23, 246);
            this.lbl_conteudo.Name = "lbl_conteudo";
            this.lbl_conteudo.Size = new System.Drawing.Size(0, 19);
            this.lbl_conteudo.TabIndex = 1;
            // 
            // lbl_mascaraAtiva
            // 
            this.lbl_mascaraAtiva.AutoSize = true;
            this.lbl_mascaraAtiva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_mascaraAtiva.Location = new System.Drawing.Point(23, 75);
            this.lbl_mascaraAtiva.Name = "lbl_mascaraAtiva";
            this.lbl_mascaraAtiva.Size = new System.Drawing.Size(0, 19);
            this.lbl_mascaraAtiva.TabIndex = 2;
            // 
            // btn_hora
            // 
            this.btn_hora.Location = new System.Drawing.Point(23, 110);
            this.btn_hora.Name = "btn_hora";
            this.btn_hora.Size = new System.Drawing.Size(82, 37);
            this.btn_hora.TabIndex = 3;
            this.btn_hora.Text = "Hora";
            this.btn_hora.UseVisualStyleBackColor = true;
            this.btn_hora.Click += new System.EventHandler(this.btn_hora_Click);
            // 
            // btn_CEP
            // 
            this.btn_CEP.Location = new System.Drawing.Point(111, 110);
            this.btn_CEP.Name = "btn_CEP";
            this.btn_CEP.Size = new System.Drawing.Size(82, 37);
            this.btn_CEP.TabIndex = 4;
            this.btn_CEP.Text = "CEP";
            this.btn_CEP.UseVisualStyleBackColor = true;
            this.btn_CEP.Click += new System.EventHandler(this.btn_CEP_Click);
            // 
            // btn_moeda
            // 
            this.btn_moeda.Location = new System.Drawing.Point(199, 110);
            this.btn_moeda.Name = "btn_moeda";
            this.btn_moeda.Size = new System.Drawing.Size(82, 37);
            this.btn_moeda.TabIndex = 5;
            this.btn_moeda.Text = "Moeda";
            this.btn_moeda.UseVisualStyleBackColor = true;
            this.btn_moeda.Click += new System.EventHandler(this.btn_moeda_Click);
            // 
            // btn_telefone
            // 
            this.btn_telefone.Location = new System.Drawing.Point(199, 153);
            this.btn_telefone.Name = "btn_telefone";
            this.btn_telefone.Size = new System.Drawing.Size(82, 37);
            this.btn_telefone.TabIndex = 8;
            this.btn_telefone.Text = "Telefone";
            this.btn_telefone.UseVisualStyleBackColor = true;
            this.btn_telefone.Click += new System.EventHandler(this.btn_telefone_Click);
            // 
            // btn_senha
            // 
            this.btn_senha.Location = new System.Drawing.Point(111, 153);
            this.btn_senha.Name = "btn_senha";
            this.btn_senha.Size = new System.Drawing.Size(82, 37);
            this.btn_senha.TabIndex = 7;
            this.btn_senha.Text = "Senha";
            this.btn_senha.UseVisualStyleBackColor = true;
            this.btn_senha.Click += new System.EventHandler(this.btn_senha_Click);
            // 
            // btn_data
            // 
            this.btn_data.Location = new System.Drawing.Point(23, 153);
            this.btn_data.Name = "btn_data";
            this.btn_data.Size = new System.Drawing.Size(82, 37);
            this.btn_data.TabIndex = 6;
            this.btn_data.Text = "Data";
            this.btn_data.UseVisualStyleBackColor = true;
            this.btn_data.Click += new System.EventHandler(this.btn_data_Click);
            // 
            // btn_verConteudo
            // 
            this.btn_verConteudo.Location = new System.Drawing.Point(23, 196);
            this.btn_verConteudo.Name = "btn_verConteudo";
            this.btn_verConteudo.Size = new System.Drawing.Size(258, 37);
            this.btn_verConteudo.TabIndex = 9;
            this.btn_verConteudo.Text = "Ver Conteúdo";
            this.btn_verConteudo.UseVisualStyleBackColor = true;
            this.btn_verConteudo.Click += new System.EventHandler(this.btn_verConteudo_Click);
            // 
            // frm_Mascara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 283);
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
            this.Name = "frm_Mascara";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplos de Máscaras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox msk_textBox;
        private Label lbl_conteudo;
        private Label lbl_mascaraAtiva;
        private Button btn_hora;
        private Button btn_CEP;
        private Button btn_moeda;
        private Button btn_telefone;
        private Button btn_senha;
        private Button btn_data;
        private Button btn_verConteudo;
    }
}