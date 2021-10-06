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
            if (string.IsNullOrEmpty(txtBoxVeiculoPlaca.Text)) {
               
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

            Veiculo veiculos = new Veiculo();

        }
    }
}
