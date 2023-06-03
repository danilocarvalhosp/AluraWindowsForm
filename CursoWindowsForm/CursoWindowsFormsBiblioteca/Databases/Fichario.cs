using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace CursoWindowsFormsBiblioteca.Databases
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

        public void IncluirCliente(string id, string jsonUnit)
        {
            status = true;

            try
            {
                if (File.Exists(diretorio + "\\" + id + ".json"))
                {
                    status = false;
                    mensagem = "Inclusão não permitida porque o identificador já existe: " + id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + id + ".json", jsonUnit);
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Inclusão efetuada com erro: " + ex.Message;
            }
        }
    }
}
