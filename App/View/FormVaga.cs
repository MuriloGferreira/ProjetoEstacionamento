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
    public partial class FormVaga : Form
    {
        public FormVaga()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormVaga_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrarVaga_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtBoxVagaStatus.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVagaPatio.Text))
                {
                    return;
                }
                if (string.IsNullOrEmpty(txtBoxVagaNum.Text))
                {
                    return;
                }

                Vaga vaga = CarregarObjetoVagaDoForm();

                VagaCtrl vagacontrole = new VagaCtrl();

                if ((Boolean)vagacontrole.BD("inserir", vaga))
                {
                    MessageBox.Show("VAGA OCUPADA COM SUCESSO !");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO CADASTRAR/INSERIR VEICULO" + ex.Message);
            }
        }

        private Vaga CarregarObjetoVagaDoForm()
        {
            Vaga vaga = new Vaga();
            try
            {
                vaga.Nome = txtBoxVagaCliente.Text;
                vaga.Numero = txtBoxVagaNum.Text;
                vaga.Patio = txtBoxVagaPatio.Text;
                vaga.Status = txtBoxVagaStatus.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR VAGA! " + ex.Message);
            }
            return vaga;
        }

        private void txtBoxVagaStatus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
