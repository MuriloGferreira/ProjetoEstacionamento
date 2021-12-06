using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public static class BD
    {
        private static String StrConn = @"Data Source=C:\Users\muril\Desktop\Projetos\ProjetoEstacionamento\App\banco.sdf;Password=admin";

        private static SqlCeConnection conection;

        public static void OpenConection()
        {
            try
            {
                if(conection != null)
                {
                    if(conection.State == ConnectionState.Closed)
                    {
                        conection.ConnectionString = StrConn;
                        conection.Open();
                    }
                }
                else
                {
                    conection = new SqlCeConnection(StrConn);
                    conection.Open();
                }
            }
            catch(Exception ex)
            {
                throw new Exception("ERRO AO ABRIR CONEXÃO" + ex.Message);
            }
        }

        public static void CloseConection()
        {
            try
            {
                if (conection != null)
                {
                    if (conection.State == ConnectionState.Open)
                    {
                        conection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO FECHAR CONEXÃO" + ex.Message);
            }
        }

        public static DataTableReader ExecutSelect(String SQL)
        {

        }


        //IDU = Insert, delet, update
        public static int ExecutarIDU(String SQL)
        {

        }

        public static int ExecutarIDU(String SQL, List<SqlCeParameter> parameters)
        {

        }

        public static Object ExecutarInsertComRetornoDeValor(String SQL, List<SqlCeParameter> parameters))
        {

        }
    }
}
