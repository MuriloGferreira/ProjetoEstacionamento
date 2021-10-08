using Model;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();

            if (formLogin.ShowDialog() == DialogResult.OK)
            {
                Login u = (Login)formLogin.Tag;
                UsuarioLogado.Text = u.Usuario;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btnLoadCliente_Click(object sender, EventArgs e)
        {

            FormCliente formCliente = new FormCliente();
            this.Hide();
            var repo = Repositorio.RepositorioGeral.Instancia;
            if (formCliente.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            FormVeiculo formVeiculo = new FormVeiculo();
            this.Hide();
            var repo = Repositorio.RepositorioGeral.Instancia;

            if (formVeiculo.ShowDialog() == DialogResult.OK)
            {
                Veiculo u = (Veiculo)formVeiculo.Tag;
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btnLoadVaga_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoadPatio_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void btnVeiculo_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var veiculo = new FormVeiculo();
            if (veiculo.ShowDialog() == DialogResult.OK)
            {
                Veiculo veiculoCadastrado = (Veiculo)veiculo.Tag;
                Repositorio.RepositorioGeral.RegistrarVeiculo(veiculoCadastrado);
                Console.WriteLine(Repositorio.RepositorioGeral.RepositorioGeralVeiculo.Count());
            }
            this.Show();
        }

        private void btnListarVeiculosN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listaVeiculo = new FormListaVeiculo();
            if (listaVeiculo.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
        }
    }
}
