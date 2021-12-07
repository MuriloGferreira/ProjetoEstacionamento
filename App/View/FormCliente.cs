using control;
using Model;
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
    public partial class FormCliente : Form
    {
        public FormCliente()
        {
            InitializeComponent();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrEmpty(txtBoxClienteCpf.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxClienteNome.Text))
                {
                    return;
                }

                Cliente cliente = CarregarObjetoClienteDoForm();

                ClienteCtrl clientecontrole = new ClienteCtrl();

                if((Boolean)clientecontrole.BD("inserir", cliente))
                {
                    MessageBox.Show("PESSOA CADASTRADA COM SUCESSO !");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO CADASTRAR/INSERIR CLIENTE" + ex.Message);
            }
        }


        private Cliente CarregarObjetoClienteDoForm()
        {
            Cliente cliente = new Cliente();
            try
            {
                //String cpf_sem_tracos = mtbCPF.Text.Replace("-", "");
                //String cpf_sem_pontos = cpf_sem_tracos.Replace(".", "");
                //p.CPF = Int64.Parse(cpf_sem_pontos);

                cliente.Cpf = Convert.ToInt64(txtBoxClienteCpf.Text.Replace(".", "").Replace("-", ""));
                cliente.Nome = txtBoxClienteNome.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS PARA PESSOA: " + ex.Message);
            }
            return cliente;
        }

        //private void btnDeletarCliente_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (string.IsNullOrEmpty(txtBoxClienteCpf.Text))
        //        {
        //            return;
        //        }
        //        if (string.IsNullOrEmpty(txtBoxClienteNome.Text))
        //        {
        //            return;
        //        }

        //        ClienteCtrl clientecontrole = new ClienteCtrl();

        //        if ((Boolean)clientecontrole.BD("deletar", null))
        //        {
        //            MessageBox.Show("PESSOA DELETADA COM SUCESSO !");
        //        }

        //        this.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("ERRO AO DELETADAR CLIENTE" + ex.Message);
        //    }
        //}
    }
}
