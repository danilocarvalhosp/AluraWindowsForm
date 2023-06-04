using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForm
{
    public partial class Frm_Busca : Form
    {
        List<List<string>> _ListaBusca = new List<List<string>>();

        public string idSelected { get; set; }

        public Frm_Busca(List<List<string>> ListaBusca)
        {
            _ListaBusca = ListaBusca;
            InitializeComponent();
            this.Text = "Busca";

            Tls_Principal.Items [0].ToolTipText = "Salvar a seleção";
            Tls_Principal.Items [1].ToolTipText = "Fechar a tela";
            PreencherLista();
        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void PreencherLista()
        {
            lista_Busca.Items.Clear();

            for (int i = 0; i <= _ListaBusca.Count - 1; i++)
            {
                lista_Busca.Items.Add(_ListaBusca [i] [1]);
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            idSelected = _ListaBusca [lista_Busca.SelectedIndex] [0];
            this.Close ();
        }
    }
}
