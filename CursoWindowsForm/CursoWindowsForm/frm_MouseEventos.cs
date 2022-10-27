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
    public partial class frm_MouseEventos : Form
    {
        public frm_MouseEventos()
        {
            InitializeComponent();
        }

        private void btn_mouse_MouseEnter(object sender, EventArgs e)
        {
            btn_mouse.Text = "Mouse Enter";
        }

        private void btn_mouse_MouseLeave(object sender, EventArgs e)
        {
            btn_mouse.Text = "Mouse Leave";
        }

        private void btn_mouse_MouseHover(object sender, EventArgs e)
        {
            btn_mouse.Text = "Mouse Hover";
        }

        private void btn_mouse_MouseDown(object sender, MouseEventArgs e)
        {
            btn_mouse.Text = "Mouse Down";
        }

        private void btn_mouse_MouseUp(object sender, MouseEventArgs e)
        {
            btn_mouse.Text = "Mouse Up";
        }
    }
}
