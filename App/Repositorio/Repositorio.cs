using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class Repositorio
    {

        public static List<Veiculo> RepositorioVeiculo = new List<Veiculo>();
        public List<Veiculo> RegistrarVeiculo(Veiculo veiculo)
        {
            RepositorioVeiculo.Add(veiculo);
            return RepositorioVeiculo;
        }


        public static List<Vaga> RepositorioVaga = new List<Vaga>();
       
        public static List<Vaga> RegistrarVaga(Vaga vaga)
        {
            RepositorioVaga.Add(vaga);
            return RepositorioVaga;
        }


        public static List<Patio> RepositorioPatio = new List<Patio>();
        public static List<Patio> RegistrarPatio(Patio patio)
        {
            RepositorioPatio.Add(patio);
            return RepositorioPatio;
        }


        public static List<Login> RepositorioLogin = new List<Login>();
        public static List<Login> RegistrarLogin(Login login)
        {
            RepositorioLogin.Add(login);
            return RepositorioLogin;
        }

        public static List<Cliente> RepositorioCliente = new List<Cliente>();
        public static List<Cliente> RegistrarCliente(Cliente cliente)
        {
            RepositorioCliente.Add(cliente);
            return RepositorioCliente;
        }
    }
}
