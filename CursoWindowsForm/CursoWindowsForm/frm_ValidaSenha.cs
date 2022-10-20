﻿using System.Text.RegularExpressions;

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

    public class ChecaForcaSenha
    {

        public enum ForcaDaSenha
        {
            Inaceitavel,
            Fraca,
            Aceitavel,
            Forte,
            Segura
        }

        public int geraPontosSenha(string senha)
        {
            if (senha == null) return 0;
            int pontosPorTamanho = GetPontoPorTamanho(senha);
            int pontosPorMinusculas = GetPontoPorMinusculas(senha);
            int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
            int pontosPorDigitos = GetPontoPorDigitos(senha);
            int pontosPorSimbolos = GetPontoPorSimbolos(senha);
            int pontosPorRepeticao = GetPontoPorRepeticao(senha);
            return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
        }

        private int GetPontoPorTamanho(string senha)
        {
            return Math.Min(10, senha.Length) * 7;
        }

        private int GetPontoPorMinusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorMaiusculas(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorDigitos(string senha)
        {
            int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
            return Math.Min(2, rawplacar) * 6;
        }

        private int GetPontoPorSimbolos(string senha)
        {
            int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
            return Math.Min(2, rawplacar) * 5;
        }

        private int GetPontoPorRepeticao(string senha)
        {
            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
            bool repete = regex.IsMatch(senha);
            if (repete)
            {
                return 30;
            }
            else
            {
                return 0;
            }
        }


        public ForcaDaSenha GetForcaDaSenha(string senha)
        {
            int placar = geraPontosSenha(senha);

            if (placar < 50)
                return ForcaDaSenha.Inaceitavel;
            else if (placar < 60)
                return ForcaDaSenha.Fraca;
            else if (placar < 80)
                return ForcaDaSenha.Aceitavel;
            else if (placar < 100)
                return ForcaDaSenha.Forte;
            else
                return ForcaDaSenha.Segura;
        }
    }
}