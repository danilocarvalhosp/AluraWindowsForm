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
    public partial class frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;

        public frm_Principal_Menu_UC()
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
            ControleHelloWorld += 1;
            frm_HelloWorld_UC U = new();
            TabPage TB = new();
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = TB.Name;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
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

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(tbc_aplicacoes.SelectedTab == null))
            {
                tbc_aplicacoes.TabPages.Remove(tbc_aplicacoes.SelectedTab);
            }            
        }
    }
}
