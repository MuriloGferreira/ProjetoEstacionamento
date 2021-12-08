using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using control;
using Model;

namespace View
{
    public partial class FormListaVagas : Form
    {
        private Dictionary<String, Vaga> mapa;
        public FormListaVagas()
        {
            InitializeComponent();
        }

        private void FormListaVagas_Load(object sender, EventArgs e)
        {
            ListarVagas();
        }

        private void ListarVagas()
        {
            try
            {
                CarregarGridVagas();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO LISTAR VAGAS!" + ex.Message);
            }
        }

        private void GridVeiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CarregarGridVagas()
        {
            GridVagas.Rows.Clear();

            var vagacontroller = new VagaCtrl();
            mapa = (Dictionary<String, Vaga>)vagacontroller.BD("todos", null);

            foreach (var vaga in mapa.Values)
            {
                GridVagas.Rows.Add(vaga.Numero, vaga.Nome, vaga.Patio, vaga.Status);
            }
        }

        private void GridVagas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeletarVaga_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow primeiraLinhaVeiculoSelecionada = GridVagas.SelectedRows[0];
                DataGridViewCell primeiraColuna = primeiraLinhaVeiculoSelecionada.Cells[0];
                Object valorDentroDaCelula = primeiraColuna.Value;

                String numeroSelecionadoString = valorDentroDaCelula.ToString();

                //Int64 cpfSelecionado = Convert.ToInt64(numeroSelecionadoString);

                //Int64 cpfSelecionado = Convert.ToInt64(GridViewClientes.SelectedRows[0].Cells[0].Value.ToString());

                //Acionar o meu controller

                VagaCtrl vagacontrole = new VagaCtrl();

                if ((Boolean)vagacontrole.BD("deletar", numeroSelecionadoString))
                {
                    CarregarGridVagas();
                    MessageBox.Show("Vaga liberada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO LIBERAR VEICULO! " + ex.Message);
            }
        }
    }
    
}
