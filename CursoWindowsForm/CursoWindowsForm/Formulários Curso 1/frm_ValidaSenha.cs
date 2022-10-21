using static CursoWindowsFormsBiblioteca.Cls_Uteis;

namespace CursoWindowsForm
{
    public partial class frm_ValidaSenha : Form
    {
        bool VerSenhaTxt = false;

        public frm_ValidaSenha()
        {
            InitializeComponent();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_Senha.Text = "";
            lbl_resultado.Text = "";
        }

        private void txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha verifica = new();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = verifica.GetForcaDaSenha(txt_Senha.Text);
            lbl_resultado.Text = forca.ToString();

            if (lbl_resultado.Text == "Inaceitavel" || lbl_resultado.Text == "Fraca")
            {
                lbl_resultado.ForeColor = Color.Red;
            }
            else if (lbl_resultado.Text == "Aceitavel")
            {
                lbl_resultado.ForeColor = Color.Blue;
            }
            else
            {
                lbl_resultado.ForeColor = Color.Green;
            }
        }

        private void btn_verSenha_Click(object sender, EventArgs e)
        {
            if (VerSenhaTxt == false)
            {
                txt_Senha.PasswordChar = '\0'; // REPRESENTA UM CARACTERE VAZIO
                VerSenhaTxt = true;
                btn_verSenha.Text = "Esconder Senha";
            }
            else
            {
                txt_Senha.PasswordChar = '*'; // REPRESENTA UM CARACTERE VAZIO
                VerSenhaTxt = false;
                btn_verSenha.Text = "Mostrar Senha";
            }
        }
    }
}
