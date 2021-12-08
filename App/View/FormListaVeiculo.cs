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
        private Dictionary<String, Veiculo> mapa;

        public FormListaVeiculo()
        {
            InitializeComponent();
        }


        //private void GridVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //}

        private void FormListaVeiculo_Load_1(object sender, EventArgs e)
        {
            try
            {
                ListarVeiculos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM: " + ex.Message);
            }
        }

        private void ListarVeiculos()
        {
            try
            {
                CarregarGridVeiculos();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO LISTAR VEICULO" + ex.Message);
            }

        }


        private void btnDeletarVeículo_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow primeiraLinhaVeiculoSelecionada = GridVeiculos.SelectedRows[0];
                DataGridViewCell primeiraColuna = primeiraLinhaVeiculoSelecionada.Cells[0];
                Object valorDentroDaCelula = primeiraColuna.Value;

                String placaSelecionadoString = valorDentroDaCelula.ToString();

                //Int64 cpfSelecionado = Convert.ToInt64(numeroSelecionadoString);

                //Int64 cpfSelecionado = Convert.ToInt64(GridViewClientes.SelectedRows[0].Cells[0].Value.ToString());

                //Acionar o meu controller

                VeiculoCtrl veiculocontrole = new VeiculoCtrl();

                if ((Boolean)veiculocontrole.BD("deletar", placaSelecionadoString))
                {
                    CarregarGridVeiculos();
                    MessageBox.Show("Veiculo deletado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR VEICULO! " + ex.Message);
            }
        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.DialogResult = DialogResult.OK;
        }

        private void CarregarGridVeiculos()
        {
            GridVeiculos.Rows.Clear();

            var controllerVeiculo = new VeiculoCtrl();
            mapa = (Dictionary<String, Veiculo>)controllerVeiculo.BD("todos", null);

            foreach (var veiculo in mapa.Values)
            {
                GridVeiculos.Rows.Add(veiculo.Placa, veiculo.Nome, veiculo.Modelo, veiculo.Cor, veiculo.Cliente);
            }
        }

       
        private void GridVeiculos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //String selectedRowCount = GridVeiculos.Rows.GetRowCount(DataGridViewElementStates.Selected);

            String placaSelecionada = GridVeiculos.SelectedRows[0].Cells[0].Value.ToString();

            Veiculo veiculo = mapa[placaSelecionada];

            FormVeiculo formveiculo = new FormVeiculo(veiculo.Placa, veiculo.Nome, veiculo.Modelo, veiculo.Cor, veiculo.Cliente);

            formveiculo.Tag = veiculo;

            formveiculo.ShowDialog();
        }
    }
}
