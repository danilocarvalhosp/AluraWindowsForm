using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class FicharioSQLServer
    {
        public string mensagem;
        public bool status;
        public string tabela;
        public SQLServerClass db;

        public FicharioSQLServer(string Tabela)
        {
            status = true;

            try
            {
                db = new SQLServerClass();
                tabela = Tabela;
                mensagem = "Conexão com a tabela realizada com sucesso";
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro de conexão com a tabela: " + ex.Message;
            }
        }

        public void Incluir(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                var SQL = $"INSERT INTO {tabela} (ID, JSON) VALUES ('{Id}', '{jsonUnit}')";
                db.SqlCommand(SQL);
                status = true;
                mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
            finally
            {
                db.Close();
            }
        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                var SQL = $"SELECT * FROM {tabela} WHERE id = '{Id}'";
                var dt = db.SqlQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    string conteudo = dt.Rows [0] ["JSON"].ToString();
                    status = true;
                    mensagem = "Inclusão efetuada com sucesso. Identificador: " + Id;
                    return conteudo;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            finally
            {
                db.Close();
            }

            return "";
        }

        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();
            try
            {
                var SQL = $"SELECT * FROM {tabela}";
                var dt = db.SqlQuery(SQL);
                if (dt.Rows.Count > 0)
                {
                    for (int i = 0; i <= dt.Rows.Count - 1; i++)
                    {
                        string conteudo = dt.Rows [i] ["JSON"].ToString();
                        List.Add(conteudo);
                    }

                    return List;
                }
                else
                {
                    status = false;
                    mensagem = "Não existem clientes na base de dados";
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            finally
            {
                db.Close();
            }

            return List;
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {
                var SQL = $"SELECT * FROM {tabela} WHERE id = '{Id}'";
                var dt = db.SqlQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    SQL = $"DELETE FROM {tabela} WHERE id = '{Id}'";
                    db.SqlCommand(SQL);

                    status = true;
                    mensagem = "Exclusão efetuada com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Identificador não existente: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Erro ao buscar o conteúdo do identificador: " + ex.Message;
            }
            finally
            {
                db.Close();
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {
            status = true;
            try
            {
                var SQL = $"SELECT * FROM {tabela} WHERE id = '{Id}'";
                var dt = db.SqlQuery(SQL);

                if (dt.Rows.Count > 0)
                {
                    SQL = $"UPDATE {tabela} SET JSON = '{jsonUnit}' WHERE id = '{Id}'";
                    db.SqlCommand(SQL);

                    status = true;
                    mensagem = "Alteração efetuada com sucesso. Identificador: " + Id;
                }
                else
                {
                    status = false;
                    mensagem = "Alteração não permitida porque o identificador não existe: " + Id;
                }
            }
            catch (Exception ex)
            {
                status = false;
                mensagem = "Conexão com o Fichario com erro: " + ex.Message;
            }
            finally
            {
                db.Close();
            }
        }

    }
}
