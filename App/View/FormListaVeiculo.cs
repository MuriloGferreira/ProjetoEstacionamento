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
    public partial class FormListaVeiculo : Form
    {
        public FormListaVeiculo()
        {
            InitializeComponent();
        }


        private void GridVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormListaVeiculo_Load_1(object sender, EventArgs e)
        {
            try
            {
                foreach (Veiculo v in Repositorio.RepositorioGeral.RepositorioGeralVeiculo)
                {
                    GridVeiculos.Rows.Add(v.Placa, v.Modelo, v.Cor);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM: " + ex.Message);
            }
        }

        private void btnDeletarVeículo_Click_1(object sender, EventArgs e)
        {

            //try
            //{
            //    DataGridViewRow primeiraLinhaSelecionada = GridViewClientes.SelectedRows[0];
            //    DataGridViewCell primeiraColuna = primeiraLinhaSelecionada.Cells[0];
            //    Object valorDentroDaCelula = primeiraColuna.Value;

            //    String cpfSelecionadoString = valorDentroDaCelula.ToString();
            //    Int64 cpfSelecionado = Convert.ToInt64(cpfSelecionadoString);



            //    ClienteCtrl clientecontrole = new ClienteCtrl();

            //    if ((Boolean)clientecontrole.BD("deletar", null))
            //    {
            //        MessageBox.Show("PESSOA DELETADA COM SUCESSO !");
            //    }

            //    this.Close();
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("ERRO AO DELETADAR CLIENTE" + ex.Message);
            //}

            //            DataGridViewRow row = this.GridVeiculos.SelectedRows[0];
            //            for (var i = 0; i < Repositorio.RepositorioGeral.RepositorioGeralVeiculo.Count; i++)
            //            {
            //// Comparação de referência não intencional possível; para obter uma comparação de valor, converta o lado esquerdo para o tipo "string"
            //                if (row.Cells["Placa"].Value == Repositorio.RepositorioGeral.RepositorioGeralVeiculo[i].Placa) {
            //// Comparação de referência não intencional possível; para obter uma comparação de valor, converta o lado esquerdo para o tipo "string"
            //                    Repositorio.RepositorioGeral.RepositorioGeralVeiculo.Remove(Repositorio.RepositorioGeral.RepositorioGeralVeiculo[i]);
            //                    GridVeiculos.Rows.Remove(row);
            //                }
            //            }
            //            GridVeiculos.Update();
        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.DialogResult = DialogResult.OK;
        }
    }
}
