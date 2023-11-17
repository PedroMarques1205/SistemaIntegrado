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
    public partial class FrmEstoquesProduto : Form
    {
        public FrmEstoquesProduto()
        {
            InitializeComponent();
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var queryProduto = (from estoque in context.EstoqueProdutoAcabado
                                    where estoque.Produto.isAtivo == true
                                    select new
                                    {
                                        Produto = estoque.NomeProduto,
                                        quantidade = estoque.Quantidade,
                                    }).ToList();

                produtosDataGridView.DataSource = queryProduto;

                registrosLabel.Text = "Registros Encontrados " + Convert.ToString(queryProduto.ToList().Count);
            }
        }
 
        public void ConstroiGrid()
        {
            produtosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Produto", HeaderText = "Produto", Visible = true});
            produtosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true, Width = 300 });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from estoque in context.EstoqueProdutoAcabado
                             where estoque.Produto.isAtivo == true
                             select new
                             {
                                 Produto = estoque.NomeProduto,
                                 quantidade = estoque.Quantidade,
                             }).ToList();

                produtosDataGridView.DataSource = query;
            }
        }
        private void estoques_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConstroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void produtosDataGridView_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData != null)
            {
                int status = Convert.ToInt32(e.RowData.GetType().GetProperty("quantidade").GetValue(e.RowData, null));

                if (status<=0)
                {
                    e.Style.BackColor = Color.LightCoral;

                }
            }
        }

        private void materiaDataGridViewe_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData != null)
            {
                int status = Convert.ToInt32(e.RowData.GetType().GetProperty("quantidade").GetValue(e.RowData, null));

                if (status<=0)
                {
                    e.Style.BackColor = Color.LightCoral;

                }
            }
        }
    }
}
