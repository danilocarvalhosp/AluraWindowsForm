using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Classes.Databases
{
    public class Fichario
    {
        public string? diretorio;
        public string mensagem;
        public bool status;

        public Fichario(string Diretorio)
        {
            status = true;
            try
            {
                if (!Directory.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                }

                diretorio = Diretorio;
                mensagem = "Conexão com o fichário criada com sucesso!!!";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o fichário criada com erro: " + ex.Message;
            }
        }
    }
}
