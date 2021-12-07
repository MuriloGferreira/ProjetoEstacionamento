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
            DataGridViewRow row = this.GridVeiculos.SelectedRows[0];
            for (var i = 0; i < Repositorio.RepositorioGeral.RepositorioGeralVeiculo.Count; i++)
            {
#pragma warning disable CS0252 // Comparação de referência não intencional possível; para obter uma comparação de valor, converta o lado esquerdo para o tipo "string"
                if (row.Cells["Placa"].Value == Repositorio.RepositorioGeral.RepositorioGeralVeiculo[i].Placa) {
#pragma warning restore CS0252 // Comparação de referência não intencional possível; para obter uma comparação de valor, converta o lado esquerdo para o tipo "string"
                    Repositorio.RepositorioGeral.RepositorioGeralVeiculo.Remove(Repositorio.RepositorioGeral.RepositorioGeralVeiculo[i]);
                    GridVeiculos.Rows.Remove(row);
                }
            }
            GridVeiculos.Update();
        }

        private void btnVoltarPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();

            this.DialogResult = DialogResult.OK;
        }
    }
}
