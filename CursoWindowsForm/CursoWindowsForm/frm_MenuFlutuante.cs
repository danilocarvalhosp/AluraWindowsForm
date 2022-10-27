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
    public partial class frm_MenuFlutuante : Form
    {
        public frm_MenuFlutuante()
        {
            InitializeComponent();
        }

        private void frm_MenuFlutuante_MouseDown(object sender, MouseEventArgs e)
        {
            //string str1 = e.Button.ToString();
            //if (str1 == "Right")
            //{
            //    MessageBox.Show(str1);
            //}

            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                var PosicaoX = e.X;
                var PosicaoY = e.Y;
                // MessageBox.Show($"Cliquei com o botão da direita do mouse. A posição relativa foi ({PosicaoX.ToString()},{PosicaoY.ToString()})");

                var ContextMenu = new ContextMenuStrip();
                var vToolTip001 = new ToolStripMenuItem();
                vToolTip001.Text = "Item do menu 1";
                ContextMenu.Items.Add(vToolTip001.Text);
                ContextMenu.Show(this, new Point(PosicaoX, PosicaoY));
            }
        }
    }
}
