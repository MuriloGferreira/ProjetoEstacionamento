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
    public static class ClienteDAO
    {
        public static Dictionary<int, Cliente> ListarClientes()
        {
            Dictionary<int, Cliente> mapaClientes = new Dictionary<int, Cliente>();

            try
            {
                String SQL = "SELECT * FROM cliente ORDER BY cpf;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Cliente cliente = new Cliente();

                    cliente.Cpf = data.GetInt32(0);
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


        //public Endereco BuscarPorCPF(Int64 _cpf)
        //{
        //    Endereco p = null;
        //    try
        //    {
        //        String SQL = String.Format("SELECT * FROM cliente WHERE participante_cpf = {0};", _cpf);

        //        DataTableReader data = BD.ExecutarSelect(SQL);

        //        if (data.Read())
        //        {
        //            p = new Endereco();

        //            p.ID = data.GetInt32(0);
        //            p.TipoEndereco = data.GetInt32(1);
        //            p.Logradouro = data.GetString(2);
        //            p.Cidade = data.GetInt32(3);
        //            p.Estado = data.GetInt32(4);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("BUSCAR POR CPF / " + ex.Message);
        //    }

        //    return p;
        //}

        //public int Inserir(Endereco _obj)
        //{
        //    int idEnd = 0;

        //    try
        //    {
        //        String SQL = String.Format("INSERT INTO enderecos (" +
        //            "tipo_end," +
        //            "logradouro," +
        //            "cidade_id," +
        //            "estado_id," +
        //            "participante_cpf" +
        //            ") " +
        //            "VALUES ({0}, '{1}', {2}, {3}, {4});",
        //            _obj.TipoEndereco,
        //            _obj.Logradouro,
        //            _obj.Cidade,
        //            _obj.Estado,
        //            _obj.ParticipanteCPF
        //            );


        //        Object teste = BD.ExecutarInsertComRetornoDeValor(SQL, new List<SqlCeParameter>());
        //        idEnd = Convert.ToInt32(teste);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("INSERT / " + ex.Message);
        //    }

        //    return idEnd;
        //}

        //public Boolean Alterar(Endereco _obj)
        //{
        //    int linhasAfetasdas = 0;

        //    try
        //    {
        //        String SQL = String.Format("UPDATE enderecos SET " +
        //            "tipo_end = {0}," +
        //            "logradouro = '{1}'," +
        //            "cidade_id = {2}," +
        //            "estado_id = {3}" +
        //            " WHERE id = {4}",
        //            _obj.TipoEndereco,
        //            _obj.Logradouro,
        //            _obj.Cidade,
        //            _obj.Estado,
        //            _obj.ID
        //            );

        //        linhasAfetasdas = BD.ExecutarIDU(SQL);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("UPDATE / " + ex.Message);
        //    }

        //    if (linhasAfetasdas > 0)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
    }
}
