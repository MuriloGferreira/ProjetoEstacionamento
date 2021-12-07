using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Control;
using DAO;
using Model;

namespace View
{
    public partial class FormListaClientes : Form
    {   
        public FormListaClientes()
        {
            InitializeComponent();
        }
        private void FormListaClientes_Load(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            try
            {
                var controller = new ClienteCtrl();
                Dictionary<Int64, Cliente> mapa = (Dictionary<Int64, Cliente>)controller.BD("todos", null);

                foreach(var cli in mapa.Values)
                {
                    GridViewClientes.Rows.Add(cli.Nome, cli.Cpf);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO LISTAR CLIENTE" + ex.Message);
            }

        }

    }
}
