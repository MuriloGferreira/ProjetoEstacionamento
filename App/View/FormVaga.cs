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

            Vaga vagas = new Vaga();

        }
    }
}
