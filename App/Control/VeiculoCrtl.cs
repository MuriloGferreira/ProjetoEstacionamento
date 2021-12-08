using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Model;

namespace control
{
    public class VeiculoCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            var veiculo = new VeiculoDAO();

            switch (_comando)
            {
                case "inserir":
                    return veiculo.Inserir((Veiculo)_parametro);
                case "deletar":
                    return veiculo.Deletar((String)_parametro);
                case "alterar":
                    return veiculo.Alterar((Veiculo)_parametro);
                case "todos":
                    return veiculo.ListarVeiculos();
                default:
                    return "Comando inválido!";
            }
        }

    }
}
