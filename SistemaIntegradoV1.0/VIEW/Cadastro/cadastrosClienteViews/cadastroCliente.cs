using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.cadastrosClienteViews;
using Syncfusion.Windows.Forms;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0
{
    public partial class cadastroCliente : Form
    {
        public bool mostrarDesativados { get; set; }

        public cadastroCliente()
        {
            Cursor.Current = Cursors.WaitCursor;
            mostrarDesativados = false;
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
            ClientesDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "isAtivo", HeaderText = "Ativo?", Visible = true });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from cliente in context.Cliente
                             where cliente.isAtivo == true
                             select new
                             {
                                 CPF = cliente.CpfCliente,
                                 Nome = cliente.Nome,
                                 Bairro = cliente.Bairro,
                                 Rua = cliente.Rua,
                                 Complemento = cliente.Complemento,
                                 NumeroResidencia = cliente.Num,
                                 estado = cliente.Estado,
                                 municipio = cliente.Municipio,
                                 isAtivo = cliente.isAtivo
                             }).ToList();

                ClientesDataGridView.DataSource = query;
            }
        }

        public void carregaGrid(bool situacao = true)
        {
            using (ConnectionString context = new ConnectionString())
            {
                if (comboBoxFiltros.Text == "Todos")
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
                                     municipio = cliente.Municipio,
                                     isAtivo = cliente.isAtivo
                                 }).ToList();

                    ClientesDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.Count);
                }
                else if (comboBoxFiltros.Text == "Ativos") 
                {
                    var query = (from cliente in context.Cliente
                                 where cliente.isAtivo == true
                                 select new
                                 {
                                     CPF = cliente.CpfCliente,
                                     Nome = cliente.Nome,
                                     Bairro = cliente.Bairro,
                                     Rua = cliente.Rua,
                                     Complemento = cliente.Complemento,
                                     NumeroResidencia = cliente.Num,
                                     estado = cliente.Estado,
                                     municipio = cliente.Municipio,
                                     isAtivo = cliente.isAtivo
                                 }).ToList();

                    ClientesDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.Count);
                }
                else if (comboBoxFiltros.Text == "Desativos")
                {
                    var query = (from cliente in context.Cliente
                                 where cliente.isAtivo == false
                                 select new
                                 {
                                     CPF = cliente.CpfCliente,
                                     Nome = cliente.Nome,
                                     Bairro = cliente.Bairro,
                                     Rua = cliente.Rua,
                                     Complemento = cliente.Complemento,
                                     NumeroResidencia = cliente.Num,
                                     estado = cliente.Estado,
                                     municipio = cliente.Municipio,
                                     isAtivo = cliente.isAtivo
                                 }).ToList();
                    ClientesDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.Count);
                }
            }
        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            comboBoxFiltros.Text = "Todos";
            comboBoxFiltros.Items.Add("Ativos");
            comboBoxFiltros.Items.Add("Desativos");
            comboBoxFiltros.Items.Add("Todos");
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

        private void tsbCancelaCadastro_Click(object sender, EventArgs e)
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
                DialogResult result = MessageBox.Show("Tem Certeza que deseja canelar o cadastro de " + poggers.Nome + "?", "Atenção", buttons, MessageBoxIcon.Exclamation);
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
                                ClienteParaExcluir.isAtivo = false;
                                context.Entry<Cliente>(ClienteParaExcluir).State = EntityState.Modified;
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
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (ClientesDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = ClientesDataGridView.SelectedItem;

                var poggers = new Cliente();

                string cpf = Convert.ToString(linhaSelecionada.GetType().GetProperty("CPF").GetValue(linhaSelecionada, null));

                using (ConnectionString context = new ConnectionString())
                {
                    Cliente ClienteParaEditar = context.Cliente.FirstOrDefault(v => v.CpfCliente.Equals(cpf));
                    if (ClienteParaEditar != null)
                    {
                        poggers = ClienteParaEditar;
                    }
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Tem Certeza que deseja editar o cadastro de " + poggers.Nome + "?", "Atenção", buttons, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        editarCliente tela = new editarCliente(ClienteParaEditar.CpfCliente, ClienteParaEditar.Nome, ClienteParaEditar.Rua, ClienteParaEditar.Bairro, ClienteParaEditar.Complemento, ClienteParaEditar.Municipio, ClienteParaEditar.Estado, ClienteParaEditar.Num);
                        tela.ShowDialog();
                        carregaGrid();
                    }
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Selecione o cliente que deseja Editar", "Nenhum cliente selecionado", buttons, MessageBoxIcon.Asterisk);
            }
        }

        private void tbsReativarCliente_Click(object sender, EventArgs e)
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
                DialogResult result = MessageBox.Show("Tem Certeza que deseja reativar o cadastro de " + poggers.Nome + "?", "Atenção", buttons, MessageBoxIcon.Exclamation);
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
                                ClienteParaExcluir.isAtivo = true;
                                context.Entry<Cliente>(ClienteParaExcluir).State = EntityState.Modified;
                                context.SaveChanges();

                                carregaGrid(false);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Selecione o cliente que deseja reativar", "Nenhum cliente selecionado", buttons, MessageBoxIcon.Asterisk);
            }
        }

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }
    }
}
