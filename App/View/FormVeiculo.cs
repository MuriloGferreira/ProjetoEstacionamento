using control;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace View
{
    public partial class FormVeiculo : Form
    {

        public FormVeiculo()
        {
            InitializeComponent();
        }

        public FormVeiculo(string placa, string nome, string modelo, string cor, string cliente)
        {
            InitializeComponent();
            txtBoxVeiculoPlaca.Text = placa;
            txtBoxVeiculoNome.Text = nome;
            txtBoxVeiculoModelo.Text = modelo;
            txtBoxVeiculoCor.Text = cor;
            txtBoxVeiculoCliente.Text = cliente;
        }

        //private void FormVeiculo_Load(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (this.Tag != null)
        //        {
        //            btnAlterarVeiculo.Visible = true;
        //            btnCadastrarVeiculo.Visible = false;
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

        private Task ProcessData(List<string> list, IProgress<Veiculo> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var veiculoProgress = new Veiculo();

            return Task.Run(() => {
                for (int i = 0; i < totalProcess; i++)
                {
                    veiculoProgress.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(veiculoProgress);
                    Thread.Sleep(10);//used to simulate length of operation 
                }
            });
        }

        private async void btnCadastrarVeiculo_Click(object sender, EventArgs e)
        {
            labelProgressLogin.Visible = true;
            progressBarVeiculo.Visible = true;
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

                ////ProgressBar
                List<string> list = new List<string>();
                for (int i = 0; i < 100; i++)
                    list.Add(i.ToString());
                labelProgressLogin.Text = "Working...";
                var progress = new Progress<Veiculo>();
                progress.ProgressChanged += (o, report) => {
                    labelProgressLogin.Text = string.Format("Processando...{0}%", report.PercentComplete);
                    progressBarVeiculo.Value = report.PercentComplete;
                    progressBarVeiculo.Update();
                };
                await ProcessData(list, progress);
                labelProgressLogin.Text = "Cadastro completo!";
                ////ProgressBar

                Veiculo veiculo = CarregarObjetoVeiculoDoForm();

                VeiculoCtrl clientecontrole = new VeiculoCtrl();

                if ((Boolean)clientecontrole.BD("inserir", veiculo))
                {
                    MessageBox.Show("VEICULO CADASTRADO COM SUCESSO !");
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

        private void btnInserirImagemVeiculo_Click(object sender, EventArgs e)
        {

        }
    }
}
