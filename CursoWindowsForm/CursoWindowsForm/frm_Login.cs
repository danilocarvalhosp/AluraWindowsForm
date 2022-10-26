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
    public partial class frm_Login : Form
    {
        public string senha;
        public string login;

        public frm_Login()
        {
            InitializeComponent();

            lbl_login.Text = "Usuário";
            lbl_password.Text = "Senha";
            btn_ok.Text = "OK";
            btn_cancel.Text = "Cancelar";
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            senha = txt_password.Text;
            login = txt_login.Text;

            this.Close();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
