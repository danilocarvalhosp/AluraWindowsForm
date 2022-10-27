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

                ContextMenu.Items.Add(DesenhaItemMenu("Item do menu 1", "key"));
                ContextMenu.Items.Add(DesenhaItemMenu("Item do menu 2", "Frm_ValidaSenha"));
                ContextMenu.Show(this, new Point(e.X, e.Y));
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
