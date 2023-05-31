namespace CursoWindowsForm
{
    partial class frm_MouseEventos
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
            this.btn_mouse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mouse
            // 
            this.btn_mouse.Location = new System.Drawing.Point(121, 49);
            this.btn_mouse.Name = "btn_mouse";
            this.btn_mouse.Size = new System.Drawing.Size(323, 125);
            this.btn_mouse.TabIndex = 0;
            this.btn_mouse.UseVisualStyleBackColor = true;
            this.btn_mouse.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_mouse_MouseDown);
            this.btn_mouse.MouseEnter += new System.EventHandler(this.btn_mouse_MouseEnter);
            this.btn_mouse.MouseLeave += new System.EventHandler(this.btn_mouse_MouseLeave);
            this.btn_mouse.MouseHover += new System.EventHandler(this.btn_mouse_MouseHover);
            this.btn_mouse.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_mouse_MouseUp);
            // 
            // frm_MouseEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 245);
            this.Controls.Add(this.btn_mouse);
            this.Name = "frm_MouseEventos";
            this.Text = "frm_MouseEventos";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_mouse;
    }
}