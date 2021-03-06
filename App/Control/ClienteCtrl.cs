using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace control
{
    public class ClienteCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            var cliente = new ClienteDAO();

            switch (_comando)
            {
                case "inserir":
                    return cliente.Inserir((Cliente)_parametro);
                case "deletar":
                    return cliente.Deletar((Int64)_parametro);
                case "alterar":
                    return cliente.Alterar((Cliente)_parametro);
                case "todos":
                    return cliente.ListarClientes();
                //case "Evento":
                //    return ClienteDAO.BuscarTodasPornome((int)_parametro);
                //case "filtro":
                //    return ClienteDAO.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }

    }
}
