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
    public class ClienteDAO
    {
        //SELECT CLIENTE
        public Dictionary<Int64, Cliente> ListarClientes()
        {
            Dictionary<Int64, Cliente> mapaClientes = new Dictionary<Int64, Cliente>();

            try
            {
                String SQL = "SELECT * FROM cliente ORDER BY nome;";

                DataTableReader data = BD.ExecutSelect(SQL);

                while (data.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Cpf = data.GetInt64(0);
                    cliente.Nome = data.GetString(1);

                    mapaClientes.Add(cliente.Cpf, cliente);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS OS CLIENTES " + ex.Message);
            }

            return mapaClientes;
        }

        public bool Inserir(Cliente _obj)
        {
            int linhasAfetadas = 0;

            try
            {
                String SQL = String.Format("INSERT INTO cliente (" +
                    "cpf," +
                    "nome" +
                    ") " +
                    "VALUES ({0}, '{1}');",
                    _obj.Cpf,
                    _obj.Nome
                    );

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT CLIENTE" + ex.Message);
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

        public bool Deletar(Int64 _cpf)
        {
            int linhasAfetadas = 0;

            try
            {
                String SQL = "DELETE FROM cliente WHERE cpf = " + _cpf;

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("DELETE CLIENTE" + ex.Message);
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

        public bool Alterar(Cliente _obj)
        {
            int linhasAfetadas = 0;

            try
            {
                String SQL = String.Format("UPDATE cliente SET " + "nome = {0}," + " WHERE cpf = {1}", _obj.Nome, _obj.Cpf);

                linhasAfetadas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("UPDATE CLIENTE" + ex.Message);
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
