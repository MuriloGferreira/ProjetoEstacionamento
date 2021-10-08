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
    public partial class FormPatio : Form
    {
        public FormPatio()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FormPatio_Load(object sender, EventArgs e)
        {

        }

        private void btnPatioValorTotal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxPatioDesc.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtBoxPatioTaxaHora.Text))
            {
                return;
            }

            Patio Patios = new Patio();
        }
    }
}
