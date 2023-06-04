namespace CursoWindowsForm
{
    partial class Frm_Busca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Busca));
            Tls_Principal = new ToolStrip();
            salvarToolStripButton = new ToolStripButton();
            ApagaToolStripButton = new ToolStripButton();
            lista_Busca = new ListBox();
            Tls_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // Tls_Principal
            // 
            Tls_Principal.Items.AddRange(new ToolStripItem [] { salvarToolStripButton, ApagaToolStripButton });
            Tls_Principal.Location = new Point(0, 0);
            Tls_Principal.Name = "Tls_Principal";
            Tls_Principal.Size = new Size(345, 25);
            Tls_Principal.TabIndex = 33;
            Tls_Principal.Text = "toolStrip1";
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
            // lista_Busca
            // 
            lista_Busca.FormattingEnabled = true;
            lista_Busca.ItemHeight = 15;
            lista_Busca.Location = new Point(12, 37);
            lista_Busca.Name = "lista_Busca";
            lista_Busca.Size = new Size(321, 259);
            lista_Busca.TabIndex = 34;
            // 
            // Frm_Busca
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 320);
            Controls.Add(lista_Busca);
            Controls.Add(Tls_Principal);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon) resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Busca";
            Text = "Frm_Busca";
            Tls_Principal.ResumeLayout(false);
            Tls_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip Tls_Principal;
        private ToolStripButton salvarToolStripButton;
        private ToolStripButton ApagaToolStripButton;
        private ListBox lista_Busca;
    }
}