using SISTEMA.INTEGRADO.V1._0.DAO;
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

namespace SistemaIntegradoV1._0.VIEW.cadastrosClienteViews
{
    public partial class clientesDesativados : Form
    {
        public clientesDesativados()
        {
            InitializeComponent();
        }
        public void constroiGrid()
        {
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "CPF", HeaderText = "CPF", Visible = true });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Nome", Visible = true, Width = 300 });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Rua", HeaderText = "Rua", Visible = true });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Complemento", HeaderText = "Complemento", Visible = true });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Bairro", HeaderText = "Bairro", Visible = true });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "NumeroResidencia", HeaderText = "N° residência", Visible = true });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "estado", HeaderText = "Estado", Visible = true });
            DesativadosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "municipio", HeaderText = "Municipio", Visible = true });
            using (ConnectionString context = new ConnectionString())
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
                                 municipio = cliente.Municipio
                             }).ToList();

                DesativadosDataGridView.DataSource = query;
            }
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
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
                                 municipio = cliente.Municipio
                             }).ToList();

                DesativadosDataGridView.DataSource = query;
            }
        }
        private void clientesDesativados_Load(object sender, EventArgs e)
        {
            constroiGrid();
            carregaGrid();
        }

        private void btnReativarCliente_Click(object sender, EventArgs e)
        {
            if (DesativadosDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = DesativadosDataGridView.SelectedItem;

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
                    if (DesativadosDataGridView.SelectedItems.Count > 0)
                    {
                        linhaSelecionada = DesativadosDataGridView.SelectedItem;

                        cpf = Convert.ToString(linhaSelecionada.GetType().GetProperty("CPF").GetValue(linhaSelecionada, null));

                        using (ConnectionString context = new ConnectionString())
                        {
                            var ClienteParaExcluir = context.Cliente.FirstOrDefault(v => v.CpfCliente.Equals(cpf));
                            if (ClienteParaExcluir != null)
                            {
                                ClienteParaExcluir.isAtivo = true;
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
    }
}
