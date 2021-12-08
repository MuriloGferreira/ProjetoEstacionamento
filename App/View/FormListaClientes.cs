using System;
using System.Collections.Generic;
using System.Windows.Forms;
using control;
using DAO;
using Model;

namespace View
{
    public partial class FormListaClientes : Form
    {
        private Dictionary<Int64, Cliente> mapa;
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
                CarregarGrid();
            }
            catch (Exception ex)
            {
                throw new Exception("ERRO AO LISTAR CLIENTE" + ex.Message);
            }

        }

        private void GridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDeleteCliente_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow primeiraLinhaSelecionada = GridViewClientes.SelectedRows[0];
                DataGridViewCell primeiraColuna = primeiraLinhaSelecionada.Cells[0];
                Object valorDentroDaCelula = primeiraColuna.Value;

                String cpfSelecionadoString = valorDentroDaCelula.ToString();

                Int64 cpfSelecionado = Convert.ToInt64(cpfSelecionadoString);

                //Int64 cpfSelecionado = Convert.ToInt64(GridViewClientes.SelectedRows[0].Cells[0].Value.ToString());

                //Acionar o meu controller

                ClienteCtrl clientecontrole = new ClienteCtrl();

                if ((Boolean)clientecontrole.BD("deletar", cpfSelecionado))
                {
                    CarregarGrid();
                    MessageBox.Show("Pessoa deletada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR PESSOA! " + ex.Message);
            }
        }


        private void CarregarGrid()
        {
            GridViewClientes.Rows.Clear();

            var controller = new ClienteCtrl();
            mapa = (Dictionary<Int64, Cliente>)controller.BD("todos", null);

            foreach (var cliente in mapa.Values)
            {
                GridViewClientes.Rows.Add(cliente.Cpf, cliente.Nome);
            }
        }

        private void GridViewClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount = GridViewClientes.Rows.GetRowCount(DataGridViewElementStates.Selected);

            Int64 cpfSelecionado = Convert.ToInt64(GridViewClientes.SelectedRows[0].Cells[0].Value.ToString());

            Cliente cliente = mapa[cpfSelecionado];

            FormCliente formCliente = new FormCliente(cliente.Cpf.ToString(), cliente.Nome);

            formCliente.Tag = cliente;

            //formCliente.p

            formCliente.ShowDialog();
            
        }

        //private void btnUpdateCliente_Click(object sender, EventArgs e)
        //{
            //try
            //{
            //    Cliente cliente = CarregarGrid
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("ERRO AO ALTERAR PESSOA! " + ex.Message);
            //}
        //}
    }
}
