namespace CursoWindowsForm
{
    partial class frm_ValidaCPF2_UC
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
            this.btn_valida = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_valida
            // 
            this.btn_valida.Location = new System.Drawing.Point(245, 44);
            this.btn_valida.Name = "btn_valida";
            this.btn_valida.Size = new System.Drawing.Size(111, 23);
            this.btn_valida.TabIndex = 6;
            this.btn_valida.Text = "Valida";
            this.btn_valida.UseVisualStyleBackColor = true;
            this.btn_valida.Click += new System.EventHandler(this.btn_valida_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(245, 15);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 23);
            this.btn_reset.TabIndex = 5;
            this.btn_reset.Text = "Limpa";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(12, 18);
            this.msk_CPF.Mask = "000,000,000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(218, 23);
            this.msk_CPF.TabIndex = 4;
            // 
            // frm_ValidaCPF2_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_valida);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.msk_CPF);
            this.Name = "frm_ValidaCPF2_UC";
            this.Size = new System.Drawing.Size(377, 114);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_valida;
        private Button btn_reset;
        private MaskedTextBox msk_CPF;
    }
}
