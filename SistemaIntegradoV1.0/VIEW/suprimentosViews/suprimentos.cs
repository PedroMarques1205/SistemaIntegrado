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

namespace SistemaIntegradoV1._0
{
    public partial class suprimentos : Form
    {
        public suprimentos()
        {
            InitializeComponent();
        }

        private void suprimentos_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            constroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        public void carregaGrid() 
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from pedido in context.PedidoCompraSuprimento
                             where pedido.IsPedidoAceito == true
                             select new
                             {
                                 idPedido = pedido.IdPedidoCompra,
                                 materia = pedido.MateriaPrima.Nome,
                                 quantidade = pedido.Quantidade,
                                 fornecedor = pedido.Fornecedor,
                                 precoUnit = pedido.PrecoUnit,
                                 precoTotal = pedido.PrecoTotal,
                                 prazo = pedido.PrazoEntrega,
                                 condicao = pedido.CondicaoPagamento,
                                 entregue = pedido.IsEntregue
                             }).ToList();
                PedidosDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
            }
        }
        public void constroiGrid() 
        {
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idPedido", HeaderText = "idOrdem", Visible = true, Width = 0 });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "materia", HeaderText = "Matéria pedida", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "fornecedor", HeaderText = "Fornecedor", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "precoUnit", HeaderText = "Preço Unitário", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "precoTotal", HeaderText = "Preço Total", Visible = true });
            PedidosDataGridView.Columns.Add(new GridDateTimeColumn() { MappingName = "prazo", HeaderText = "Prazo", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "condicao", HeaderText = "Forma de pagamento", Visible = true });
            PedidosDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "entregue", HeaderText = "Foi Entregue?", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from pedido in context.PedidoCompraSuprimento
                             where pedido.IsPedidoAceito == true
                             select new
                             {
                                idPedido = pedido.IdPedidoCompra,
                                materia = pedido.MateriaPrima.Nome,
                                quantidade = pedido.Quantidade,
                                fornecedor = pedido.Fornecedor,
                                precoUnit = pedido.PrecoUnit,
                                precoTotal = pedido.PrecoTotal,
                                prazo = pedido.PrazoEntrega,
                                condicao = pedido.CondicaoPagamento,
                                entregue = pedido.IsEntregue
                             }).ToList();
                PedidosDataGridView.DataSource = query;
            }
        }

        private void tbsEntregasAfazer_Click(object sender, EventArgs e)
        {
            ordemCompra tela = new ordemCompra();
            tela.ShowDialog();
            carregaGrid();
        }

        private void tsbMudarEntrega_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (PedidosDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = PedidosDataGridView.SelectedItem;

                        int idPedido = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idPedido").GetValue(linhaSelecionada, null));

                        PedidoCompraSuprimento pedido = context.PedidoCompraSuprimento.
                        FirstOrDefault(
                            p =>
                                p.IdPedidoCompra.Equals(idPedido)
                        );

                        EstoqueMateriaPrima estoque = context.EstoqueMateriaPrima.FirstOrDefault(
                            x => x.IdMateriaPrima.Equals(pedido.MateriaPrima.idMateriaPrima));

                        estoque.Quantidade += Convert.ToInt32(pedido.Quantidade);
                        pedido.IsEntregue = true;

                        context.Entry<EstoqueMateriaPrima>(estoque).State = EntityState.Modified;
                        context.Entry<PedidoCompraSuprimento>(pedido).State = EntityState.Modified;
                        context.SaveChanges();
                        carregaGrid();
                    }
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
                    if (PedidosDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = PedidosDataGridView.SelectedItem;

                        int idPedido = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idPedido").GetValue(linhaSelecionada, null));

                        PedidoCompraSuprimento pedido = context.PedidoCompraSuprimento.
                        FirstOrDefault(
                            p =>
                                p.IdPedidoCompra.Equals(idPedido)
                        );

                        EstoqueMateriaPrima estoque = context.EstoqueMateriaPrima.FirstOrDefault(
                            x => x.IdMateriaPrima.Equals(pedido.MateriaPrima.idMateriaPrima));

                        estoque.Quantidade += Convert.ToInt32(pedido.Quantidade);
                        pedido.IsEntregue = true;

                        context.Entry<EstoqueMateriaPrima>(estoque).State = EntityState.Modified;
                        context.Entry<PedidoCompraSuprimento>(pedido).State = EntityState.Modified;
                        context.SaveChanges();
                        carregaGrid();
                    }
                }
                catch
                {

                }
            }
        }

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
