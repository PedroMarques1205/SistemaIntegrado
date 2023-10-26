using SISTEMA.INTEGRADO.V1._0.DAO;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0
{
    public partial class cadastroCliente : Form
    {

        public cadastroCliente()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        public void constroiGrid()
        {
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "CPF", HeaderText = "CPF", Visible = true });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Nome", Visible = true, Width = 300 });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Rua", HeaderText = "Rua", Visible = true });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Complemento", HeaderText = "Complemento", Visible = true });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Bairro", HeaderText = "Bairro", Visible = true });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "NumeroResidencia", HeaderText = "N° residência", Visible = true });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "estado", HeaderText = "Estado", Visible = true });
            ClientesDataGridView.Columns.Add(new GridTextColumn() { MappingName = "municipio", HeaderText = "Municipio", Visible = true });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from cliente in context.Cliente
                             select new
                             {
                                 CPF = cliente.CpfCliente,
                                 Nome = cliente.Nome,
                                 Bairro = cliente.Bairro,
                                 Rua = cliente.Rua,
                                 Complemento = cliente.Complemento,
                                 NumeroResidencia = cliente.Num,
                                 estado = cliente.Estado,
                                 municipio = cliente.Municipio
                             }).ToList();

                ClientesDataGridView.DataSource = query;
            }
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from cliente in context.Cliente
                             select new
                             {
                                 CPF = cliente.CpfCliente,
                                 Nome = cliente.Nome,
                                 Bairro = cliente.Bairro,
                                 Rua = cliente.Rua,
                                 Complemento = cliente.Complemento,
                                 NumeroResidencia = cliente.Num,
                                 estado = cliente.Estado,
                                 municipio = cliente.Municipio
                             }).ToList();

                ClientesDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.Cliente.Count());
            }
        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            constroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void ClientesDataGridView_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            cadastrarCliente tela = new cadastrarCliente();
            tela.ShowDialog();
            carregaGrid();
        }

        // a implementar, cancelamento de cadastro
        /* private void button1_Click(object sender, EventArgs e)
         {
             if (ClientesDataGridView.SelectedItems.Count > 0)
             {
                 var linhaSelecionada = ClientesDataGridView.SelectedItem;

                 var poggers = new Cliente();

                 string cpf = Convert.ToString(linhaSelecionada.GetType().GetProperty("CPF").GetValue(linhaSelecionada, null));

                 using (ConnectionString context = new ConnectionString())
                 {
                     var ClienteParaExcluir = context.Cliente.FirstOrDefault(v => v.CpfCliente.Equals(cpf));
                     if (ClienteParaExcluir != null)
                     {
                         poggers = ClienteParaExcluir;
                     }
                 }

                 MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                 DialogResult result = MessageBox.Show("Tem Certeza que deseja canelar o cadastro de " + poggers.Nome + "?", "Alerta", buttons, MessageBoxIcon.Exclamation);
                 if (result == DialogResult.Yes)
                 {
                     if (ClientesDataGridView.SelectedItems.Count > 0)
                     {
                         linhaSelecionada = ClientesDataGridView.SelectedItem;

                         cpf = Convert.ToString(linhaSelecionada.GetType().GetProperty("CPF").GetValue(linhaSelecionada, null));

                         using (ConnectionString context = new ConnectionString())
                         {
                             var ClienteParaExcluir = context.Cliente.FirstOrDefault(v => v.CpfCliente.Equals(cpf));
                             if (ClienteParaExcluir != null)
                             {
                                 context.Cliente.Remove(ClienteParaExcluir);
                                 context.SaveChanges();

                                 carregaGrid();
                             }
                         }
                     }
                 }
             }
             else 
             {
                 MessageBoxButtons buttons = MessageBoxButtons.OK;
                 DialogResult result = MessageBox.Show("Selecione o cliente que deseja cancelar", "Nenhum cliente selecionado", buttons, MessageBoxIcon.Asterisk);
             }
         }*/
    }
}
