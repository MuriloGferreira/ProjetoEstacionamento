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

        private Task ProcessData(List<string> list, IProgress<Vaga> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var vagaProgress = new Vaga();

            return Task.Run(() => {
                for (int i = 0; i < totalProcess; i++)
                {
                    vagaProgress.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(vagaProgress);
                    Thread.Sleep(10);//used to simulate length of operation 
                }
            });
        }

        private async void btnCadastrarVaga_Click(object sender, EventArgs e)
        {
            labelProgressVaga.Visible = true;
            progressBarVaga.Visible = true;
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

                ////ProgressBar
                List<string> list = new List<string>();
                for (int i = 0; i < 100; i++)
                    list.Add(i.ToString());
                labelProgressVaga.Text = "Working...";
                var progressVaga = new Progress<Vaga>();
                progressVaga.ProgressChanged += (o, report) => {
                    labelProgressVaga.Text = string.Format("Processando...{0}%", report.PercentComplete);
                    progressBarVaga.Value = report.PercentComplete;
                    progressBarVaga.Update();
                };
                await ProcessData(list, progressVaga);
                labelProgressVaga.Text = "Vaga foi ocupada!";
                ////ProgressBar

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
