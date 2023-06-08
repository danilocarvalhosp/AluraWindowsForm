﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_agencia : Form
    {
        public Frm_agencia()
        {
            InitializeComponent();
            this.Text = "Cadastro de Agência";
            Tls_Principal.Items [0].ToolTipText = "Fechar a caixa de diálogo";
        }

        private void ApagatoolStripButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_agenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tb_agenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.byteBankDataSet);

        }

        private void Frm_agencia_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'byteBankDataSet.tb_agencia'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_agenciaTableAdapter.Fill(this.byteBankDataSet.tb_agencia);

        }
    }
}