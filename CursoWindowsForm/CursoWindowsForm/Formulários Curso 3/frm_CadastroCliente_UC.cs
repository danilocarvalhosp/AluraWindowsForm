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
using CursoWindowsFormsBiblioteca.Databases;

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

            btn_busca.Text = "Buscar";

            LimparFormulario();
        }

        private void LimparFormulario()
        {
            txt_codigoCliente.Text = "";
            txt_bairro.Text = "";
            txt_Cidade.Text = "";
            txt_CEP.Text = "";
            txt_complemento.Text = "";
            txt_CPF.Text = "";
            cmb_Estados.SelectedIndex = -1;
            txt_logradouro.Text = "";
            txt_nomeCliente.Text = "";
            txt_nomeMae.Text = "";
            txt_nomePai.Text = "";
            txt_profissao.Text = "";
            txt_rendaFamiliar.Text = "";
            txt_telefone.Text = "";
            chk_TemPai.Checked = false;
            rdb_Masculino.Checked = true;
            txt_codigoCliente.Focus();
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
                Cliente.Unit C = new Cliente.Unit();
                C = LeituraFormulario();
                C.Id = txt_codigoCliente.Text;
                C.ValidaClasse();
                C.ValidaComplemento();
                C.IncluirFichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                MessageBox.Show("Ok: Identificador incluído com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //string clienteJson = Cliente.SerializedClassUnit(C);

                //Fichario f = new Fichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                //if (f.status)
                //{
                //    f.IncluirCliente(C.Id, clienteJson);
                //    if (f.status)
                //    {
                //        MessageBox.Show("Ok: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
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
            if (txt_codigoCliente.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFichario(txt_codigoCliente.Text, "E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                    }

                    //Fichario f = new Fichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                    //if (f.status)
                    //{
                    //    string clienteJson = f.BuscarCliente(txt_codigoCliente.Text);
                    //    Cliente.Unit C = new Cliente.Unit();
                    //    C = Cliente.DesSerializedClassUnit(clienteJson);

                    //    EscreveFormulario(C);
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            if (txt_codigoCliente.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = LeituraFormulario();
                    C.Id = txt_codigoCliente.Text;
                    C.ValidaClasse();
                    C.ValidaComplemento();
                    C.AlterarFichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                    MessageBox.Show("Ok: Identificador alterado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //string clienteJson = Cliente.SerializedClassUnit(C);

                    //Fichario f = new Fichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                    //if (f.status)
                    //{
                    //    f.AlterarCliente(C.Id, clienteJson);
                    //    if (f.status)
                    //    {
                    //        MessageBox.Show("Ok: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //    }
                    //    else
                    //    {
                    //        MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
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
        }

        private void ApagaToolStripButton_Click(object sender, EventArgs e)
        {
            if (txt_codigoCliente.Text == "")
            {
                MessageBox.Show("Código do cliente vazio", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Cliente.Unit C = new Cliente.Unit();
                    C = C.BuscarFichario(txt_codigoCliente.Text, "E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");

                    if (C == null)
                    {
                        MessageBox.Show("Identificador não encontrado", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        EscreveFormulario(C);
                        frm_Questao Db = new frm_Questao("icons8-question-mark-961", "Deseja excluir o cliente???");
                        Db.ShowDialog();
                        if (Db.DialogResult == DialogResult.Yes)
                        {
                            C.ApagarFichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                            MessageBox.Show("Ok: Identificador apagado com sucesso", "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimparFormulario();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


                //Fichario f = new Fichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
                //if (f.status)
                //{
                //    string clienteJson = f.BuscarCliente(txt_codigoCliente.Text);
                //    Cliente.Unit C = new Cliente.Unit();
                //    C = Cliente.DesSerializedClassUnit(clienteJson);

                //    EscreveFormulario(C);

                //    frm_Questao Db = new frm_Questao("icons8-question-mark-961", "Deseja excluir o cliente???");
                //    Db.ShowDialog();
                //    if (Db.DialogResult == DialogResult.Yes)
                //    {
                //        f.ExcluirCliente(txt_codigoCliente.Text);
                //        if (f.status)
                //        {
                //            MessageBox.Show("Ok: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //            LimparFormulario();
                //        }
                //        else
                //        {
                //            MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //        }
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void LimparToolStripButton_Click(object sender, EventArgs e)
        {
            LimparFormulario();
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

            if (cmb_Estados.SelectedIndex < 0)
            {
                C.Estado = "";
            }
            else
            {
                C.Estado = cmb_Estados.Items [cmb_Estados.SelectedIndex].ToString();
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

        void EscreveFormulario(Cliente.Unit C)
        {
            txt_codigoCliente.Text = C.Id;
            txt_nomeCliente.Text = C.Nome;
            txt_nomeMae.Text = C.NomeMae;

            if (C.NaoTemPai == true)
            {
                chk_TemPai.Checked = true;
                txt_nomePai.Text = "";

            }
            else
            {
                chk_TemPai.Checked = false;
                txt_nomePai.Text = C.NomePai;
            }

            if (C.Genero == 0)
            {
                rdb_Masculino.Checked = true;
            }
            else if (C.Genero == 1)
            {
                rdb_Feminino.Checked = true;
            }
            else
            {
                rdb_Indefinido.Checked = true;
            }

            txt_CPF.Text = C.Cpf;
            txt_CEP.Text = C.Cep;
            txt_logradouro.Text = C.Logradouro;
            txt_complemento.Text = C.Complemento;
            txt_bairro.Text = C.Bairro;
            txt_Cidade.Text = C.Cidade;

            if (C.Estado == "")
            {
                cmb_Estados.SelectedIndex = -1;
            }
            else
            {
                for (int i = 0; i < cmb_Estados.Items.Count - 1; i++)
                {
                    if (C.Estado == cmb_Estados.Items [i].ToString())
                    {
                        cmb_Estados.SelectedIndex = i;
                    }
                }
            }

            txt_telefone.Text = C.Telefone;
            txt_profissao.Text = C.Profissao;
            txt_rendaFamiliar.Text = C.RendaFamiliar.ToString();
        }


        private void txt_CEP_Leave(object sender, EventArgs e)
        {
            string vCep = txt_CEP.Text;

            if (vCep != "")
            {
                if (vCep.Length == 8)
                {
                    if (Information.IsNumeric(vCep))
                    {
                        var vJson = Cls_Uteis.GeraJSONCEP(vCep);
                        CEP.Unit Cep = new CEP.Unit();
                        Cep = CEP.DesSerializedClassUnit(vJson);

                        txt_logradouro.Text = Cep.logradouro;
                        txt_bairro.Text = Cep.bairro;
                        txt_Cidade.Text = Cep.localidade;

                        cmb_Estados.SelectedIndex = -1;
                        for (int i = 0; i < cmb_Estados.Items.Count - 1; i++)
                        {
                            var vPos = Strings.InStr(cmb_Estados.Items [i].ToString(), "(" + Cep.uf + ")");
                            if (vPos > 0)
                            {
                                cmb_Estados.SelectedIndex = i;
                            }
                        }
                    }
                }
            }
        }

        private void btn_busca_Click(object sender, EventArgs e)
        {
            Fichario f = new Fichario("E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\Fichario");
            if (f.status)
            {
                List<string> list = new List<string>();
                list = f.BuscarTodos();

                if (f.status)
                {
                    List<List<string>> ListaBusca = new List<List<string>>();

                    for (int i = 0; i <= list.Count - 1; i++)
                    {
                        Cliente.Unit C = Cliente.DesSerializedClassUnit(list [i]);
                        ListaBusca.Add(new List<string> { C.Id, C.Nome });
                    }

                    Frm_Busca frm = new Frm_Busca(ListaBusca);
                    frm.ShowDialog();

                    if (frm.DialogResult == DialogResult.OK)
                    {
                        var idSelect = frm.idSelected;

                        string clienteJson = f.BuscarCliente(idSelect);
                        Cliente.Unit C = new Cliente.Unit();
                        C = Cliente.DesSerializedClassUnit(clienteJson);
                        EscreveFormulario(C);
                    }
                }
                else
                {
                    MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Erro: " + f.mensagem, "ByteBank", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
