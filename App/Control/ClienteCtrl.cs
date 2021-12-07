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
            var dal = new ClienteDAO();

            switch (_comando)
            {
                case "inserir":
                    return dal.Inserir((Cliente)_parametro);
                case "deletar":
                    return dal.Deletar((Int64)_parametro);
                case "alterar":
                    return dal.Alterar((Cliente)_parametro);
                case "todos":
                    return dal.ListarClientes();
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
