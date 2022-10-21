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
    public partial class frm_Principal_Menu : Form
    {
        public frm_Principal_Menu()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_DemonstracaoKey f = new();
            f.ShowDialog();
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_HelloWorld f = new();
            f.ShowDialog();
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Mascara f = new();
            f.ShowDialog();
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF f = new();
            f.ShowDialog();
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 f = new();
            f.ShowDialog();
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha f = new();
            f.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
