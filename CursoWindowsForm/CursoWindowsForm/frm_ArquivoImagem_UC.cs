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
    public partial class frm_ArquivoImagem_UC : UserControl
    {
        public frm_ArquivoImagem_UC(string nomeArquivoImagem)
        {
            InitializeComponent();
            lbl_arquivoImagem.Text = nomeArquivoImagem;
            pic_arquivoImagem.Image = Image.FromFile(nomeArquivoImagem);
        }

        private void btn_cor_Click(object sender, EventArgs e)
        {
            ColorDialog CDb = new();
            if (CDb.ShowDialog() == DialogResult.OK)
            {
                lbl_arquivoImagem.ForeColor = CDb.Color;
            }
        }

        private void btn_fonte_Click(object sender, EventArgs e)
        {
            FontDialog FDb = new();
            if (FDb.ShowDialog() == DialogResult.OK)
            {
                lbl_arquivoImagem.Font = FDb.Font;
            }
        }
    }
}
