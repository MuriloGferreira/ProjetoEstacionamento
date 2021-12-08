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


        private Task ProcessData(List<string> list, IProgress<ProgressReport> progress)
        {
            int index = 1;
            int totalProcess = list.Count;
            var progressReport = new ProgressReport();

            return Task.Run(() => {
                for (int i=0; i < totalProcess; i++){
                    progressReport.PercentComplete = index++ * 100 / totalProcess;
                    progress.Report(progressReport);
                    Thread.Sleep(10);//used to simulate length of operation 
                }
            });
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


            //ProgressBar
            List<string> list = new List<string>();
            for (int i = 0; i < 1000; i++)
                list.Add(i.ToString());

            labelProgressLogin.Text = "Working...";
            var progress = new Progress<ProgressReport>();
            progress.ProgressChanged += (o, report) => {
                labelProgressLogin.Text = string.Format("Processing...{0}%", report.PercentComplete)
                progressBar.Value = report.PercentComplete;
                progressBar.Update();
            };
            await ProcessData(list, progress);
            labelProgressLogin.Text = "Done!";


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
