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
                MessageBox.Show("Cliquei com o botão da direita do mouse");
            }
        }
    }
}