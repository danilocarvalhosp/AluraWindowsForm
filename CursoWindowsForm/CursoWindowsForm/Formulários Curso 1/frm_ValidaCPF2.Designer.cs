namespace CursoWindowsForm
{
    partial class frm_ValidaCPF2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_ValidaCPF2));
            this.msk_CPF = new System.Windows.Forms.MaskedTextBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_valida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // msk_CPF
            // 
            this.msk_CPF.Location = new System.Drawing.Point(12, 45);
            this.msk_CPF.Mask = "000,000,000-00";
            this.msk_CPF.Name = "msk_CPF";
            this.msk_CPF.Size = new System.Drawing.Size(218, 23);
            this.msk_CPF.TabIndex = 0;
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(245, 42);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(111, 23);
            this.btn_reset.TabIndex = 2;
            this.btn_reset.Text = "Limpa";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_valida
            // 
            this.btn_valida.Location = new System.Drawing.Point(245, 71);
            this.btn_valida.Name = "btn_valida";
            this.btn_valida.Size = new System.Drawing.Size(111, 23);
            this.btn_valida.TabIndex = 3;
            this.btn_valida.Text = "Valida";
            this.btn_valida.UseVisualStyleBackColor = true;
            this.btn_valida.Click += new System.EventHandler(this.btn_valida_Click);
            // 
            // frm_ValidaCPF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 154);
            this.Controls.Add(this.btn_valida);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.msk_CPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_ValidaCPF2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validação CPF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox msk_CPF;
        private Button btn_reset;
        private Button btn_valida;
    }
}