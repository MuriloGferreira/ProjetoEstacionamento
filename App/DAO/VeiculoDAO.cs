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
    public class VeiculoDAO
    {
        //SELECT CLIENTE
        public Dictionary<String, Veiculo> ListarVeiculos()
        {
            Dictionary<String, Veiculo> mapaVeiculo = new Dictionary<String, Veiculo>();

            try
            {
                String SQL = "SELECT * FROM veiculo ORDER BY placa;";

                DataTableReader data = BD.ExecutSelect(SQL);

                while (data.Read())
                {
                    Veiculo veiculo = new Veiculo();

                    veiculo.Nome = data.GetString(0);
                    veiculo.Placa = data.GetString(1);
                    veiculo.Modelo = data.GetString(2);
                    veiculo.Cor = data.GetString(3);
                    veiculo.Cliente = data.GetString(4);

                    mapaVeiculo.Add(veiculo.Placa, veiculo);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS OS VEICULO " + ex.Message);
            }

            return mapaVeiculo;
        }

        public bool Inserir(Veiculo _obj)
        {
            int linhasAfetadas = 0;

            try
            {
                String SQL = String.Format("INSERT INTO veiculo (" +
                    "nome," +
                    "placa," +
                    "modelo," +
                    "cor," +
                    "cliente" +
                    ") " +
                    "VALUES ('{0}', '{1}', '{2}', '{3}', '{4}');",
                    _obj.Nome,
                    _obj.Placa,
                    _obj.Modelo,
                    _obj.Cor,
                    _obj.Cliente
                    );

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO INSERT VEICULO" + ex.Message);
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

        public bool Deletar(String _placa)
        {
            int linhasAfetadas = 0;

            try
            {
                //String SQL = "DELETE FROM veiculo WHERE placa = '"+_placa +"' ";

                String SQL = $"DELETE FROM veiculo WHERE placa =  '{_placa}'";


                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("DELETE VEICULO" + ex.Message);
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

        public bool Alterar(Veiculo _obj)
        {
            int linhasAfetadas = 0;
            try
            {
                String SQL = String.Format("UPDATE veiculo SET"
                    + "nome = {0},"
                    + "modelo = {1},"
                    + "cor = {2},"
                    + "cliente = {3},"
                    + " WHERE placa = {4}",
                    _obj.Nome,
                    _obj.Modelo,
                    _obj.Cor,
                    _obj.Cliente,
                    _obj.Placa
                    );

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("UPDATE VEICULO !" + ex.Message);
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
