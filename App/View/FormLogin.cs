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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
              
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxLoginUsuario.Text))
            {
                return;
            }
            if (string.IsNullOrEmpty(txtBoxLoginSenha.Text))
            {
                return;
            }

            Login logins = new Login();

            logins.Usuario = txtBoxLoginUsuario.Text;
            logins.Senha = txtBoxLoginSenha.Text;

            if (ValidarLogin(logins))
            {
                this.DialogResult = DialogResult.OK;

                this.Tag = logins;

                this.Close();
            }
            else
            {
                lblMsg.Visible = true;
            }
        }

        private bool ValidarLogin(Login user)
        {
            bool resultado = false;

            try
            {
                if (user.Usuario.Equals("Murilo") && user.Senha.Equals("murilo123"))
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EFETUAR LOGIN: " + ex.Message);
            }

            return resultado;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnLogin_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
