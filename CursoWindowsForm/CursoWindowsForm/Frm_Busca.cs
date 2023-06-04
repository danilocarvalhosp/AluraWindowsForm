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
    public partial class Frm_Busca : Form
    {
        public Frm_Busca()
        {
            InitializeComponent();
            this.Text = "Busca";

            Tls_Principal.Items [0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items [1].ToolTipText = "Fechar a tela";

        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
