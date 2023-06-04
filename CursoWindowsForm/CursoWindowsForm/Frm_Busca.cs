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
            lista_Busca.Sorted = true;
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
                ItemBox x = new ItemBox();
                x.id = _ListaBusca [i] [0];
                x.nome = _ListaBusca [i] [1];

                lista_Busca.Items.Add(x);
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            ItemBox itemSelecionado = (ItemBox) lista_Busca.Items [lista_Busca.SelectedIndex];
            idSelected = itemSelecionado.id;

            this.Close();
        }

        class ItemBox
        {
            public string? id { get; set; }
            public string? nome { get; set; }

            public override string ToString()
            {
                return nome;
            }
        }
    }
}
