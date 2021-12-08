using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlServerCe;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class VagaDAO
    {
        //SELECT VAGA
        public Dictionary<String, Vaga> ListarVagas()
        {
            Dictionary<String, Vaga> mapaVaga = new Dictionary<String, Vaga>();
            try
            {
                String SQL = "SELECT * FROM vaga ORDER BY numero;";

                DataTableReader data = BD.ExecutSelect(SQL);

                while (data.Read())
                {
                    Vaga vaga = new Vaga();

                    vaga.Nome = data.GetString(0);
                    vaga.Numero = data.GetString(1);
                    vaga.Patio = data.GetString(2);
                    vaga.Status = data.GetString(3);

                    mapaVaga.Add(vaga.Numero, vaga);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS OS VEICULO " + ex.Message);
            }

            return mapaVaga;
        }

        public bool Inserir(Vaga _obj)
        {
            int linhasAfetadas = 0;

            try
            {
                String SQL = String.Format("INSERT INTO vaga (" +
                    "nome," +
                    "numero," +
                    "patio," +
                    "status" +
                    ") " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}');",
                    _obj.Nome,
                    _obj.Numero,
                    _obj.Patio,
                    _obj.Status
                    );

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ENTRAR NA VAGA" + ex.Message);
            }

            if (linhasAfetadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Deletar(String _numero)
        {
            int linhasAfetadas = 0;

            try
            {
                String SQL = $"DELETE FROM vaga WHERE numero =  '{_numero}'";

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO DELETAR VAGA" + ex.Message);
            }

            if (linhasAfetadas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
