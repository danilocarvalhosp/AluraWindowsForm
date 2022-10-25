﻿using System;
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
    public partial class frm_Principal_Menu_UC : Form
    {
        int ControleHelloWorld = 0;
        int ControleDemonstracaoKey = 0;
        int ControleMarcara = 0;
        int ControleValidaCPF = 0;
        int ControleValidaCPF2 = 0;
        int ControleValidaSenha = 0;
        int ControleArquivoImagem = 0;

        public frm_Principal_Menu_UC()
        {
            InitializeComponent();
        }

        private void demonstraçãoKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleDemonstracaoKey += 1;
            frm_DemonstraçãoKey_UC U = new();
            U.Dock = DockStyle.Fill;
            TabPage TB = new();
            TB.Name = "Demonstração Key " + ControleDemonstracaoKey;
            TB.Text = TB.Name;
            TB.ImageIndex = 0;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
        }

        private void helloWorldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleHelloWorld += 1;
            frm_HelloWorld_UC U = new();
            U.Dock = DockStyle.Fill;
            TabPage TB = new();
            TB.Name = "Hello World " + ControleHelloWorld;
            TB.Text = TB.Name;
            TB.ImageIndex = 1;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
        }

        private void máscaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleMarcara += 1;
            frm_Mascara_UC U = new();
            U.Dock = DockStyle.Fill;
            TabPage TB = new();
            TB.Name = "Máscara " + ControleMarcara;
            TB.Text = TB.Name;
            TB.ImageIndex = 2;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
        }

        private void validaCPFToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF += 1;
            frm_ValidaCPF_UC U = new();
            U.Dock = DockStyle.Fill;
            TabPage TB = new();
            TB.Name = "Valida CPF " + ControleValidaCPF;
            TB.Text = TB.Name;
            TB.ImageIndex = 3;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
        }

        private void validaCPF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaCPF2 += 1;
            frm_ValidaCPF2_UC U = new();
            U.Dock = DockStyle.Fill;
            TabPage TB = new();
            TB.Name = "Valida CPF2 " + ControleValidaCPF2;
            TB.Text = TB.Name;
            TB.ImageIndex = 4;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
        }

        private void validaSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleValidaSenha += 1;
            frm_ValidaSenha_UC U = new();
            U.Dock = DockStyle.Fill;
            TabPage TB = new();
            TB.Name = "Valida Senha " + ControleValidaSenha;
            TB.Text = TB.Name;
            TB.ImageIndex = 5;
            TB.Controls.Add(U);
            tbc_aplicacoes.TabPages.Add(TB);
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void apagarAbaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(tbc_aplicacoes.SelectedTab == null))
            {
                tbc_aplicacoes.TabPages.Remove(tbc_aplicacoes.SelectedTab);
            }            
        }

        private void abrirImagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog Db = new();
            Db.InitialDirectory = "C:\\Users\\cpd4\\Videos\\Windows Form\\AluraWindowsForm\\CursoWindowsForm\\CursoWindowsForm\\Imagens";
            Db.Filter = "PNG | *.PNG";
            Db.Title = "Escolha a Imagem";

            if (Db.ShowDialog() == DialogResult.OK)
            {
                string nomeArquivoImagem = Db.FileName;
                

                ControleArquivoImagem += 1;
                frm_ArquivoImagem_UC U = new(nomeArquivoImagem);
                U.Dock = DockStyle.Fill;
                TabPage TB = new();
                TB.Name = "Arquivo Imagem " + ControleArquivoImagem;
                TB.Text = TB.Name;
                TB.ImageIndex = 6;
                TB.Controls.Add(U);
                tbc_aplicacoes.TabPages.Add(TB);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Login F = new();
            F.ShowDialog();
        }
    }
}
