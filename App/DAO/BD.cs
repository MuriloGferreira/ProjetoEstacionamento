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

        //internal static DataTableReader ExecutarSelect(string sQL)
        //{
        //    throw new NotImplementedException();
        //}

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
            try
            {
                OpenConection();

                DataTable dt = new DataTable();

                SqlCeCommand cmd = new SqlCeCommand(SQL, conection);

                SqlCeDataAdapter adapter = new SqlCeDataAdapter(cmd);

                adapter.Fill(dt);

                DataTableReader data = dt.CreateDataReader();

                CloseConection();

                return data;

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR SELECT" + ex.Message);
            }
        }


        //IDU = Insert, delet, update
        public static int ExecutarIDU(String SQL)
        {
            try
            {
                OpenConection();

                SqlCeCommand cmd = new SqlCeCommand(SQL, conection);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                CloseConection();

                return linhasAfetadas;

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR IDU" + ex.Message);
            }
        }

        public static int ExecutarIDU(String SQL, List<SqlCeParameter> _parameters)
        {
            try
            {
                OpenConection();

                SqlCeCommand cmd = new SqlCeCommand(SQL, conection);

                cmd.Parameters.AddRange(_parameters.ToArray());

                int linhasAfetadas = cmd.ExecuteNonQuery();

                CloseConection();

                return linhasAfetadas;

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR IDU" + ex.Message);
            }
        }

        public static Object ExecutarInsertComRetornoDeValor(String SQL, List<SqlCeParameter> _parameters)
        {
            try
            {
                OpenConection();

                SqlCeCommand cmd = new SqlCeCommand(SQL, conection);

                cmd.Parameters.AddRange(_parameters.ToArray());
                int linhasAfetadas = cmd.ExecuteNonQuery();


                cmd.CommandText = "SELECT @@IDENTITY";

                Object pk = cmd.ExecuteScalar();

                CloseConection();

                return pk;

            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO EXECUTAR IDU" + ex.Message);
            }

        }
    }
}
