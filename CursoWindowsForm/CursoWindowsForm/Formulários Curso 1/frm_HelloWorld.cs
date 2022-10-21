namespace CursoWindowsForm
{
    public partial class frm_HelloWorld : Form
    {
        public frm_HelloWorld()
        {
            InitializeComponent();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ModificaLabel_Click(object sender, EventArgs e)
        {
            // lbl_Titulo.Text = "Label modificado";
            lbl_Titulo.Text = txt_ConteudoLabel.Text;
        }
    }
}