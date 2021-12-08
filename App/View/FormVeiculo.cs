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
    public partial class FormVeiculo : Form
    {   
        public FormVeiculo()
        {
            InitializeComponent();
        }

        //private void FormVeiculo_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.Tag != null)
        //        {
        //            btnAlterarCliente.Visible = true;
        //            btnCadastrarCliente.Visible = false;
        //            txtBoxClienteCpf.Enabled = false;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception("ERRO AO CARREGAR DADOS !" + ex.Message);
        //    }

        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
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

        private void FormVeiculo_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnCadastrarVeiculo.Visible = true;
                    btnCadastrarVeiculo.Visible = false;
                    txtBoxVeiculoPlaca.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO CARREGAR DADOS !" + ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxVeiculoPlaca.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoModelo.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoNome.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoCor.Text))
                {
                    return;
                }

                Veiculo veiculo = CarregarObjetoVeiculoDoForm();

                VeiculoCtrl clientecontrole = new VeiculoCtrl();

                if ((Boolean)clientecontrole.BD("inserir", veiculo))
                {
                    MessageBox.Show("VEICULO CADASTRADA COM SUCESSO !");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO CADASTRAR/INSERIR VEICULO" + ex.Message);
            }
        }


        private Veiculo CarregarObjetoVeiculoDoForm()
        {
            Veiculo veiculo = new Veiculo();
            try
            {
                veiculo.Nome = txtBoxVeiculoNome.Text;
                veiculo.Placa = txtBoxVeiculoPlaca.Text;
                veiculo.Modelo = txtBoxVeiculoModelo.Text;
                veiculo.Cor = txtBoxVeiculoCor.Text;
                veiculo.Cliente = txtBoxVeiculoCliente.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS PARA PESSOA: " + ex.Message);
            }
            return veiculo;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void btnAlterarVeiculo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxVeiculoNome.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoPlaca.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoModelo.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoCor.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVeiculoCliente.Text))
                {
                    return;
                }

                Veiculo veiculo = CarregarObjetoVeiculoDoForm();

                VeiculoCtrl veiculocontrole = new VeiculoCtrl();

                if ((Boolean)veiculocontrole.BD("alterar", veiculo))
                {
                    //CarregarGrid();
                    MessageBox.Show("VEÍCULO ATUALIZADA COM SUCESSO !");
                }

                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO ATUALIZAR VEÍCULO !" + ex.Message);
            }
        }

    }
}
