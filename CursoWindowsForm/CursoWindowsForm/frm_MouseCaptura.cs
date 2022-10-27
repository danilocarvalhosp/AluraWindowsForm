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
    public partial class frm_MouseCaptura : Form
    {
        public frm_MouseCaptura()
        {
            InitializeComponent();
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            string str1 = e.Button.ToString();
            MessageBox.Show("Foi pressionada o botão: " + str1);
        }
    }
}
