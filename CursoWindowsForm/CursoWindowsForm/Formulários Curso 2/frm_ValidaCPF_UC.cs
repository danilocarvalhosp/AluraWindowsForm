using CursoWindowsFormsBiblioteca;
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
    public partial class frm_ValidaCPF_UC : UserControl
    {
        public frm_ValidaCPF_UC()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            lbl_resultado.Text = "";
            msk_CPF.Text = "";
        }

        private void btn_valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(msk_CPF.Text);
            if (validaCPF)
            {
                lbl_resultado.Text = "CPF VÁLIDO";
                lbl_resultado.ForeColor = Color.Green;
            }
            else
            {
                lbl_resultado.Text = "CPF INVÁLIDO";
                lbl_resultado.ForeColor = Color.Red;
            }
        }
    }
}
