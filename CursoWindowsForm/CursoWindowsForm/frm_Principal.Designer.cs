namespace CursoWindowsForm
{
    partial class frm_Principal
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
            this.btn_demonstracaoKey = new System.Windows.Forms.Button();
            this.btn_helloWorld = new System.Windows.Forms.Button();
            this.btn_mascara = new System.Windows.Forms.Button();
            this.btn_validaCPF = new System.Windows.Forms.Button();
            this.btn_ValidaCPF2 = new System.Windows.Forms.Button();
            this.btn_ValidaSenha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_demonstracaoKey
            // 
            this.btn_demonstracaoKey.Location = new System.Drawing.Point(12, 12);
            this.btn_demonstracaoKey.Name = "btn_demonstracaoKey";
            this.btn_demonstracaoKey.Size = new System.Drawing.Size(114, 48);
            this.btn_demonstracaoKey.TabIndex = 0;
            this.btn_demonstracaoKey.Text = "Demonstração Key";
            this.btn_demonstracaoKey.UseVisualStyleBackColor = true;
            this.btn_demonstracaoKey.Click += new System.EventHandler(this.btn_demonstracaoKey_Click);
            // 
            // btn_helloWorld
            // 
            this.btn_helloWorld.Location = new System.Drawing.Point(132, 12);
            this.btn_helloWorld.Name = "btn_helloWorld";
            this.btn_helloWorld.Size = new System.Drawing.Size(114, 48);
            this.btn_helloWorld.TabIndex = 1;
            this.btn_helloWorld.Text = "Hello World";
            this.btn_helloWorld.UseVisualStyleBackColor = true;
            this.btn_helloWorld.Click += new System.EventHandler(this.btn_helloWorld_Click);
            // 
            // btn_mascara
            // 
            this.btn_mascara.Location = new System.Drawing.Point(252, 12);
            this.btn_mascara.Name = "btn_mascara";
            this.btn_mascara.Size = new System.Drawing.Size(114, 48);
            this.btn_mascara.TabIndex = 2;
            this.btn_mascara.Text = "Máscara";
            this.btn_mascara.UseVisualStyleBackColor = true;
            this.btn_mascara.Click += new System.EventHandler(this.btn_mascara_Click);
            // 
            // btn_validaCPF
            // 
            this.btn_validaCPF.Location = new System.Drawing.Point(12, 66);
            this.btn_validaCPF.Name = "btn_validaCPF";
            this.btn_validaCPF.Size = new System.Drawing.Size(114, 48);
            this.btn_validaCPF.TabIndex = 3;
            this.btn_validaCPF.Text = "Valida CPF";
            this.btn_validaCPF.UseVisualStyleBackColor = true;
            this.btn_validaCPF.Click += new System.EventHandler(this.btn_validaCPF_Click);
            // 
            // btn_ValidaCPF2
            // 
            this.btn_ValidaCPF2.Location = new System.Drawing.Point(132, 66);
            this.btn_ValidaCPF2.Name = "btn_ValidaCPF2";
            this.btn_ValidaCPF2.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaCPF2.TabIndex = 4;
            this.btn_ValidaCPF2.Text = "Valida CPF 2";
            this.btn_ValidaCPF2.UseVisualStyleBackColor = true;
            this.btn_ValidaCPF2.Click += new System.EventHandler(this.btn_ValidaCPF2_Click);
            // 
            // btn_ValidaSenha
            // 
            this.btn_ValidaSenha.Location = new System.Drawing.Point(252, 66);
            this.btn_ValidaSenha.Name = "btn_ValidaSenha";
            this.btn_ValidaSenha.Size = new System.Drawing.Size(114, 48);
            this.btn_ValidaSenha.TabIndex = 5;
            this.btn_ValidaSenha.Text = "Valida Senha";
            this.btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.btn_ValidaSenha.Click += new System.EventHandler(this.btn_ValidaSenha_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 126);
            this.Controls.Add(this.btn_ValidaSenha);
            this.Controls.Add(this.btn_ValidaCPF2);
            this.Controls.Add(this.btn_validaCPF);
            this.Controls.Add(this.btn_mascara);
            this.Controls.Add(this.btn_helloWorld);
            this.Controls.Add(this.btn_demonstracaoKey);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_demonstracaoKey;
        private Button btn_helloWorld;
        private Button btn_mascara;
        private Button btn_validaCPF;
        private Button btn_ValidaCPF2;
        private Button btn_ValidaSenha;
    }
}