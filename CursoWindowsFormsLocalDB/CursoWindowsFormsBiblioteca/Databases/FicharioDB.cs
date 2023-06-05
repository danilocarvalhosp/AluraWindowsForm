﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioDB
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public LocalDBClass db;

        public FicharioDB(string Tabela)
        {
            status = true;

            try
            {
                db = new LocalDBClass();
                tabela = Tabela;
                mensagem = "Conexão com a tabela realizada com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro de conexão com a tabela: " + ex.Message;
            }
        }
    }
}
