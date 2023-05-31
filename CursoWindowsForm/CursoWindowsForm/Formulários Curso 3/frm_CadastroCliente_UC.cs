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
    public partial class Frm_CadastroCliente_UC : UserControl
    {
        public Frm_CadastroCliente_UC()
        {
            InitializeComponent();

            grp_codigo.Text = "Código";
            grp_dadosPessoais.Text = "Dados Pessoais";
            grp_endereco.Text = "Endereço";
            grp_outros.Text = "Outros";
            lbl_bairro.Text = "Bairro";
            lbl_Cidade.Text = "Cidade";
            lbl_CEP.Text = "CEP";
            lbl_complemento.Text = "Complemento";
            lbl_CPF.Text = "CPF";
            lbl_estado.Text = "Estado";
            lbl_logradouro.Text = "Logradouro";
            lbl_nomeCliente.Text = "Nome";
            lbl_nomeMae.Text = "Nome da Mãe";
            lbl_nomePai.Text = "Nome do Pai";
            lbl_profissao.Text = "Profissão";
            lbl_rendaFamiliar.Text = "Renda Familiar";
            lbl_telefone.Text = "Telefone";
            chk_TemPai.Text = "Pai desconhecido";
            rdb_Masculino.Text = "Masculino";
            rdb_Feminino.Text = "Feminino";
            rdb_Indefinido.Text = "Indefinido";
            grp_Genero.Text = "Gênero";

            cmb_Estados.Items.Clear();
            cmb_Estados.Items.Add("Acre (AC)");
            cmb_Estados.Items.Add("Alagoas (AL)");
            cmb_Estados.Items.Add("Amapá (AP)");

            Tls_Principal.Items [0].ToolTipText = "Incluir na base de dados um novo cliente";
            Tls_Principal.Items [1].ToolTipText = "Capturar um cliente já cadastrado na base";
            Tls_Principal.Items [2].ToolTipText = "Atualizar o cliente já existente";
            Tls_Principal.Items [4].ToolTipText = "Apagar o cliente selecionado";
            Tls_Principal.Items [5].ToolTipText = "Limpar dados na tela de entrada de dados";
        }

        private void chk_TemPai_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_TemPai.Checked)
            {
                txt_nomePai.Enabled = false;
                lbl_nomePai.Enabled = false;
            }
            else
            {
                txt_nomePai.Enabled = true;
                lbl_nomePai.Enabled = true;
            }
        }

        private void novaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão NOVO");
        }

        private void abrirToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão ABRIR");
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão SALVAR");
        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão APAGAR");
        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Efetuei um clique sobre o botão LIMPAR");
        }

    }
}
