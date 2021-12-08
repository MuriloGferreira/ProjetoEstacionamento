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
                case "inserir":
                    return vaga.Inserir((Vaga)_parametro);
                case "deletar":
                    return vaga.Deletar((String)_parametro);
                case "todos":
                    return vaga.ListarVagas();
                default:
                    return "Comando inválido!";
            }
        }

    }
}
