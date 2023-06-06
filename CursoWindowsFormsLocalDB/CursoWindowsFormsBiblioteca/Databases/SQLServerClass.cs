using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class SQLServerClass
    {
        public string stringConn;
        public SqlConnection connDB;

        public SQLServerClass()
        {
            try
            {
                // stringConn = "Data Source=DCSQL\\DANILO;Initial Catalog=ByteBank;Persist Security Info=True;User ID=sa;Password=Dan@8257";

                stringConn = ConfigurationManager.ConnectionStrings ["Fichario"].ConnectionString;

                connDB = new SqlConnection(stringConn);
                connDB.Open();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable SqlQuery(string sql)
        {
            DataTable dt = new DataTable();

            try
            {
                var myCommand = new SqlCommand(sql, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return dt;
        }

        public string SqlCommand(string sql)
        {
            try
            {
                var myCommand = new SqlCommand(sql, connDB);
                myCommand.CommandTimeout = 0;
                var myReader = myCommand.ExecuteReader();
                return "";
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void Close()
        {
            connDB.Close();
        }

    }
}
