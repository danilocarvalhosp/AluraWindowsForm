using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm
{
    public partial class frm_MenuFlutuante : Form
    {
        public frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = DesenhaItemMenu("Item do menu 1", "key");
                var vToolTip002 = DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha");

                ContextMenu.Items.Add(vToolTip001);
                ContextMenu.Items.Add(vToolTip002);
                ContextMenu.Show(this, new Point(e.X, e.Y));

                vToolTip001.Click += new EventHandler(VToolTip001_Click);
                vToolTip002.Click += new EventHandler(VToolTip002_Click);
            }

            void VToolTip001_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Selecionei a opção do menu 001");
            }

            void VToolTip002_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Selecionei a opção do menu 002");
            }

            ToolStripMenuItem DesenhaItemMenu(string text, string nomeImagem)
            {
                var vToolTip = new ToolStripMenuItem();
                vToolTip.Text = text;

                Image? MyImage = (Image?) Properties.Resources.ResourceManager.GetObject(nomeImagem);
                vToolTip.Image = MyImage;
                return vToolTip;
            }
        }
    }
}
