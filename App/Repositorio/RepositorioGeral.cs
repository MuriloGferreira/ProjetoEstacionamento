using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioGeral
    {
        public static RepositorioGeral _instancia;
        public static RepositorioGeral Instancia
        {
            get { return _instancia ?? (_instancia = new RepositorioGeral()); }
        }
        private RepositorioGeral() { }
        public string Mensagem { get; set; }

        public static List<Veiculo> RepositorioGeralVeiculo = new List<Veiculo>();
        public static List<Veiculo> RegistrarVeiculo(Veiculo veiculo)
        {
            RepositorioGeralVeiculo.Add(veiculo);
            return RepositorioGeralVeiculo;
        }


        public static List<Vaga> RepositorioGeralVaga = new List<Vaga>();
       
        public static List<Vaga> RegistrarVaga(Vaga vaga)
        {
            RepositorioGeralVaga.Add(vaga);
            return RepositorioGeralVaga;
        }


        public static List<Patio> RepositorioGeralPatio = new List<Patio>();
        public static List<Patio> RegistrarPatio(Patio patio)
        {
            RepositorioGeralPatio.Add(patio);
            return RepositorioGeralPatio;
        }


        public static List<Login> RepositorioGeralLogin = new List<Login>();
        public static List<Login> RegistrarLogin(Login login)
        {
            RepositorioGeralLogin.Add(login);
            return RepositorioGeralLogin;
        }

        public static List<Cliente> RepositorioGeralCliente = new List<Cliente>();
        public static List<Cliente> RegistrarCliente(Cliente cliente)
        {
            RepositorioGeralCliente.Add(cliente);
            return RepositorioGeralCliente;
        }
    }
}
