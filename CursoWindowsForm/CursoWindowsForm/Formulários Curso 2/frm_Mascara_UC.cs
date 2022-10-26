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
    public partial class frm_Mascara_UC : UserControl
    {
        public frm_Mascara_UC()
        {
            InitializeComponent();
        }

        private void btn_verConteudo_Click(object sender, EventArgs e)
        {
            lbl_conteudo.Text = msk_textBox.Text;
        }

        private void btn_hora_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            msk_textBox.Mask = "90:00";
            lbl_mascaraAtiva.Text = msk_textBox.Mask;
            msk_textBox.Text = "";
            msk_textBox.Focus();
        }

        private void btn_CEP_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            msk_textBox.Mask = "00000-000";
            lbl_mascaraAtiva.Text = msk_textBox.Mask;
            msk_textBox.Text = "";
            msk_textBox.Focus();
        }

        private void btn_moeda_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            msk_textBox.Mask = "$ 000,000,000.00";
            lbl_mascaraAtiva.Text = msk_textBox.Mask;
            msk_textBox.Text = "";
            msk_textBox.Focus();
        }

        private void btn_data_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            msk_textBox.Mask = "00/00/0000";
            lbl_mascaraAtiva.Text = msk_textBox.Mask;
            msk_textBox.Text = "";
            msk_textBox.Focus();
        }

        private void btn_senha_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = true;
            lbl_conteudo.Text = "";
            msk_textBox.Mask = "000000";
            lbl_mascaraAtiva.Text = msk_textBox.Mask;
            msk_textBox.Text = "";
            msk_textBox.Focus();
        }

        private void btn_telefone_Click(object sender, EventArgs e)
        {
            msk_textBox.UseSystemPasswordChar = false;
            lbl_conteudo.Text = "";
            msk_textBox.Mask = "(00) 0000-0000";
            lbl_mascaraAtiva.Text = msk_textBox.Mask;
            msk_textBox.Text = "";
            msk_textBox.Focus();
        }
    }
}
