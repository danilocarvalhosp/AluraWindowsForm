namespace CursoWindowsForm
{
    partial class frm_ArquivoImagem_UC
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
            this.lbl_arquivoImagem = new System.Windows.Forms.Label();
            this.pic_arquivoImagem = new System.Windows.Forms.PictureBox();
            this.btn_cor = new System.Windows.Forms.Button();
            this.btn_fonte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pic_arquivoImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_arquivoImagem
            // 
            this.lbl_arquivoImagem.AutoSize = true;
            this.lbl_arquivoImagem.Location = new System.Drawing.Point(17, 36);
            this.lbl_arquivoImagem.Name = "lbl_arquivoImagem";
            this.lbl_arquivoImagem.Size = new System.Drawing.Size(38, 15);
            this.lbl_arquivoImagem.TabIndex = 0;
            this.lbl_arquivoImagem.Text = "label1";
            // 
            // pic_arquivoImagem
            // 
            this.pic_arquivoImagem.Location = new System.Drawing.Point(20, 76);
            this.pic_arquivoImagem.Name = "pic_arquivoImagem";
            this.pic_arquivoImagem.Size = new System.Drawing.Size(209, 156);
            this.pic_arquivoImagem.TabIndex = 1;
            this.pic_arquivoImagem.TabStop = false;
            // 
            // btn_cor
            // 
            this.btn_cor.Location = new System.Drawing.Point(20, 4);
            this.btn_cor.Name = "btn_cor";
            this.btn_cor.Size = new System.Drawing.Size(75, 23);
            this.btn_cor.TabIndex = 2;
            this.btn_cor.Text = "Cor";
            this.btn_cor.UseVisualStyleBackColor = true;
            this.btn_cor.Click += new System.EventHandler(this.btn_cor_Click);
            // 
            // btn_fonte
            // 
            this.btn_fonte.Location = new System.Drawing.Point(154, 4);
            this.btn_fonte.Name = "btn_fonte";
            this.btn_fonte.Size = new System.Drawing.Size(75, 23);
            this.btn_fonte.TabIndex = 3;
            this.btn_fonte.Text = "Fonte";
            this.btn_fonte.UseVisualStyleBackColor = true;
            this.btn_fonte.Click += new System.EventHandler(this.btn_fonte_Click);
            // 
            // frm_ArquivoImagem_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_fonte);
            this.Controls.Add(this.btn_cor);
            this.Controls.Add(this.pic_arquivoImagem);
            this.Controls.Add(this.lbl_arquivoImagem);
            this.Name = "frm_ArquivoImagem_UC";
            this.Size = new System.Drawing.Size(503, 279);
            ((System.ComponentModel.ISupportInitialize)(this.pic_arquivoImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_arquivoImagem;
        private PictureBox pic_arquivoImagem;
        private Button btn_cor;
        private Button btn_fonte;
    }
}
