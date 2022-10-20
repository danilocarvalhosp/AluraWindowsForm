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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_demonstracaoKey_Click(object sender, EventArgs e)
        {
            frm_DemonstracaoKey f = new();
            f.ShowDialog();
        }

        private void btn_helloWorld_Click(object sender, EventArgs e)
        {
            frm_HelloWorld f = new();
            f.ShowDialog();
        }

        private void btn_mascara_Click(object sender, EventArgs e)
        {
            frm_Mascara f = new();
            f.ShowDialog();
        }

        private void btn_validaCPF_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF f = new();
            f.ShowDialog();
        }

        private void btn_ValidaCPF2_Click(object sender, EventArgs e)
        {
            frm_ValidaCPF2 f = new();
            f.ShowDialog();
        }

        private void btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            frm_ValidaSenha f = new();
            f.ShowDialog();
        }
    }
}
