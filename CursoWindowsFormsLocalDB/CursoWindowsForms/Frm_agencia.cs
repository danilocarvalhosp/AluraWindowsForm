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
    }
}
