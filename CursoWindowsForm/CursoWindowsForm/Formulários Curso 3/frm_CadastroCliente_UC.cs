using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CursoWindowsFormsBiblioteca.Classes;
using System.ComponentModel.DataAnnotations;
using Microsoft.VisualBasic;
using CursoWindowsFormsBiblioteca;

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
            try
            {
                var vJson = Cls_Uteis.GeraJSONCEP("13348263");

                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.Id = txt_codigoCliente.Text;
                C.ValidaClasse();
                C.ValidaComplemento();

                MessageBox.Show("Classe foi inicializada sem erros", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        Cliente.Unit LeituraFormulario()
        {
            Cliente.Unit C = new Cliente.Unit();

            C.Id = txt_codigoCliente.Text;
            C.Nome = txt_nomeCliente.Text;
            C.NomeMae = txt_nomeMae.Text;
            C.NomePai = txt_nomePai.Text;

            if (chk_TemPai.Checked)
            {
                C.NaoTemPai = true;
            }
            else
            {
                C.NaoTemPai = false;
            }

            if (rdb_Masculino.Checked)
            {
                C.Genero = 0;
            }
            else if (rdb_Feminino.Checked)
            {
                C.Genero = 1;
            }
            else
            {
                C.Genero = 2;
            }

            C.Cpf = txt_CPF.Text;
            C.Cep = txt_CEP.Text;
            C.Logradouro = txt_logradouro.Text;
            C.Complemento = txt_complemento.Text;
            C.Bairro = txt_bairro.Text;
            C.Cidade = txt_Cidade.Text;

            if(cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = cmb_Estados.Items [cmb_Estados.SelectedIndex].ToString ();
            }

            C.Telefone = txt_telefone.Text;
            C.Profissao = txt_profissao.Text;

            if (Information.IsNumeric(txt_rendaFamiliar.Text))
            {
                Double vRenda = Convert.ToDouble(txt_rendaFamiliar.Text);
                if (vRenda < 0)
                {
                    C.RendaFamiliar = 0;
                }
                else
                {
                    C.RendaFamiliar = vRenda;
                }
            }
                
            return C;
        }
    }
}
