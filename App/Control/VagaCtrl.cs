using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace control
{
    public class VagaCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            var vaga = new VagaDAO();

            switch (_comando)
            {
                //case "inserir":
                //    return vaga.Inserir((Vaga)_parametro);
                //case "deletar":
                //    return vaga.Deletar((Int64)_parametro);
                //case "alterar":
                //    return vaga.Alterar((Vaga)_parametro);
                //case "todos":
                //    return vaga.ListarVagas();
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
