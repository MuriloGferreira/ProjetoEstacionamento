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

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();

                FormCliente formCliente = new FormCliente();

                //var repo = Repositorio.RepositorioGeral.Instancia;

                if (formCliente.ShowDialog() == DialogResult.OK)
                {
                    
                }
                this.Show();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO INSERIR DADOS DO CLIENTE" + ex.Message);
            }

        }

        private void btnListarClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listaCliente = new FormListaClientes();
            if (listaCliente.ShowDialog() == DialogResult.OK)
            {
                
            }
            this.Show();
        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            this.Hide();
            var veiculo = new FormVeiculo();
            if (veiculo.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }

        private void btnListarVeiculosN_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listaVeiculo = new FormListaVeiculo();
            if (listaVeiculo.ShowDialog() == DialogResult.OK)
            {
                
            }
            this.Show();
        }

        private void btnLoadVaga_Click(object sender, EventArgs e)
        {
            this.Hide();
            var Vaga = new FormVaga();
            if (Vaga.ShowDialog() == DialogResult.OK)
            {
                
            }

            this.Show();
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

        private void btnListarVaga_Click(object sender, EventArgs e)
        {
            this.Hide();
            var listavaga = new FormListaVagas();
            if (listavaga.ShowDialog() == DialogResult.OK)
            {

            }
            this.Show();
        }
    }
}
