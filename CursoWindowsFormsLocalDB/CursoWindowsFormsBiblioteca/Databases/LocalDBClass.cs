using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class LocalDBClass
    {
        public string stringConn;
        public SqlConnection connDB;

        public LocalDBClass()
        {
            stringConn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Projetos\\Curso C#\\Alura\\Windows Form\\AluraWindowsForm\\CursoWindowsFormsLocalDB\\CursoWindowsFormsBiblioteca\\Databases\\Fichario.mdf\";Integrated Security=True";
            connDB = new SqlConnection(stringConn);
            connDB.Open();
        }
    }
}
