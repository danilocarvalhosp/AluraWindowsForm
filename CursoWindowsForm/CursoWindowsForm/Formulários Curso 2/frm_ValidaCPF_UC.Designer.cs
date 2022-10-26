namespace CursoWindowsForm
{
    partial class frm_ValidaCPF_UC
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
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_valida
            // 
            this.btn_valida.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_valida.Location = new System.Drawing.Point(249, 40);
            this.btn_valida.Name = "btn_valida";
            this.btn_valida.Size = new System.Drawing.Size(111, 23);
            this.btn_valida.TabIndex = 7;
            this.btn_valida.Text = "Valida";
            this.btn_valida.UseVisualStyleBackColor = true;
            this.btn_valida.Click += new System.EventHandler(this.btn_valida_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_reset.Location = new System.Drawing.Point(249, 11);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 23);
            this.btn_reset.TabIndex = 6;
            this.btn_reset.Text = "Limpa";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_resultado.Location = new System.Drawing.Point(13, -87);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(0, 22);
            this.lbl_resultado.TabIndex = 5;
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(13, 14);
            this.msk_CPF.Mask = "000,000,000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(218, 23);
            this.msk_CPF.TabIndex = 4;
            // 
            // frm_ValidaCPF_UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_valida);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.msk_CPF);
            this.Name = "frm_ValidaCPF_UC";
            this.Size = new System.Drawing.Size(382, 115);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_valida;
        private Button btn_reset;
        private Label lbl_resultado;
        private MaskedTextBox msk_CPF;
    }
}
