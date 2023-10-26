using SISTEMA.INTEGRADO.V1._0.DAO;
using Syncfusion.DataSource.Extensions;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0
{
    public partial class entrega : Form
    {
        public entrega()
        {
            InitializeComponent();
        }

        private void entrega_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConstroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void ConstroiGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    EntregasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idEntrega", HeaderText = "idEntrega", Visible = true, Width = 0 });
                    EntregasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "produto", HeaderText = "Produto", Visible = true });
                    EntregasDataGridView.Columns.Add(new GridDateTimeColumn() { MappingName = "dataEntrega", HeaderText = "Data prevista", Visible = true });
                    EntregasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "tipoEntrega", HeaderText = "Tipo de Entrega", Visible = true });
                    EntregasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "rua", HeaderText = "Rua", Visible = true });
                    EntregasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "num", HeaderText = "N° residência", Visible = true });
                    EntregasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "bairro", HeaderText = "Bairro", Visible = true });
                    EntregasDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "isEntregue", HeaderText = "Está entregue?", Visible = true });
                    var query = (from entrega in context.Entrega
                                 select new
                                 {
                                     idEntrega = entrega.IdEntrega,
                                     produto = entrega.Orcamento.Produto.Nome,
                                     dataEntrega = entrega.DataEntrega,
                                     tipoEntrega = entrega.tipoEntrega,
                                     isEntregue = entrega.IsEntregue,
                                     rua = entrega.Orcamento.Cliente.Rua,
                                     num = entrega.Orcamento.Cliente.Num,
                                     bairro = entrega.Orcamento.Cliente.Bairro,
                                 }).ToList();
                    EntregasDataGridView.DataSource  = query;
                }
                catch
                {

                }
            }
        }
        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from entrega in context.Entrega
                             select new
                             {
                                 idEntrega = entrega.IdEntrega,
                                 produto = entrega.Orcamento.Produto.Nome,
                                 dataEntrega = entrega.DataEntrega,
                                 tipoEntrega = entrega.tipoEntrega,
                                 isEntregue = entrega.IsEntregue,
                                 rua = entrega.Orcamento.Cliente.Rua,
                                 num = entrega.Orcamento.Cliente.Num,
                                 bairro = entrega.Orcamento.Cliente.Bairro,
                             }).ToList();

                EntregasDataGridView.DataSource  = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
            }
        }
        private void tbsEntregasAfazer_Click(object sender, EventArgs e)
        {
            entregasAfazer tela = new entregasAfazer();
            tela.ShowDialog();
            carregaGrid();
        }

        private void tsbMudarEntrega_Click_1(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (EntregasDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = EntregasDataGridView.SelectedItem;

                        int idEntrega = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idEntrega").GetValue(linhaSelecionada));

                        Entrega entrega = context.Entrega.
                        FirstOrDefault(
                            v =>
                                v.IdEntrega.Equals(idEntrega)
                        );
                        entrega.IsEntregue = true;

                        context.Entry<Entrega>(entrega).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Pedido entregue!", ":)", buttons, MessageBoxIcon.Information);
                        
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Selecione a entrega que quer dar baixa porfavor", "Nenhuma entrega selecionada", buttons, MessageBoxIcon.Information);
                    }
                    carregaGrid();
                }
                catch
                {

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (EntregasDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = EntregasDataGridView.SelectedItem;

                        int idEntrega = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idEntrega").GetValue(linhaSelecionada));

                        Entrega entrega = context.Entrega.
                        FirstOrDefault(
                            v =>
                                v.IdEntrega.Equals(idEntrega)
                        );
                        entrega.IsEntregue = true;

                        context.Entry<Entrega>(entrega).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Pedido entregue!", ":)", buttons, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Selecione a entrega que quer dar baixa porfavor", "Nenhuma entrega selecionada", buttons, MessageBoxIcon.Information);
                    }
                    carregaGrid();
                }
                catch
                {

                }
            }
        }
    }
}
