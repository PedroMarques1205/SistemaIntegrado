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
    public partial class ordemCompra : Form
    {
        public ordemCompra()
        {
            InitializeComponent();
        }

        public void carregaGrid() 
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from pedido in context.PedidoCompraSuprimento
                             where pedido.IsPedidoAceito == false
                             select new
                             {
                                 idPedido = pedido.IdPedidoCompra,
                                 materia = pedido.MateriaPrima.Nome,
                                 quantidade = pedido.Quantidade,
                             }).ToList();
                PedidosDataGridView.DataSource = query;
            }
        }
        private void ordemCompra_Load(object sender, EventArgs e)
        {
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idPedido", HeaderText = "idPedido", Visible = true, Width = 0 });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "materia", HeaderText = "Matéria pedida", Visible = true, Width = 250 });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from pedido in context.PedidoCompraSuprimento
                             where pedido.IsPedidoAceito == false
                             select new
                             {
                                 idPedido = pedido.IdPedidoCompra,
                                 materia = pedido.MateriaPrima.Nome,
                                 quantidade = pedido.Quantidade,
                             }).ToList();
                PedidosDataGridView.DataSource = query;
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

                        cadastrarPedido tela = new cadastrarPedido(pedido);
                        tela.ShowDialog();

                        carregaGrid();
                    }
                }
                catch
                {
                
                }
            }
        }
    }
}
