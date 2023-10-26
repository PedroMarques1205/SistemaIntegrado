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
    public partial class estoques : Form
    {
        public estoques()
        {
            InitializeComponent();
        }

        public void carregaGrids() 
        {
            using (ConnectionString context = new ConnectionString())
            {
                var queryMP = (from estoque in context.EstoqueMateriaPrima
                             select new
                             {
                                 materia = estoque.NomeMp,
                                 quantidade = estoque.Quantidade,
                             }).ToList();

                materiaDataGridViewe.DataSource = queryMP;

                var queryProduto = (from estoque in context.EstoqueProdutoAcabado
                             select new
                             {
                                 Produto = estoque.NomeProduto,
                                 quantidade = estoque.Quantidade,
                             }).ToList();

                produtosDataGridView.DataSource = queryProduto;

                registrosLabel.Text = "Registros Encontrados Produto: " + Convert.ToString(queryProduto.ToList().Count) + " | Registros Encontrados Matéria: " + Convert.ToString(queryMP.ToList().Count);
            }
        }
        public void ConstroiGridMateria()
        {
            materiaDataGridViewe.Columns.Add(new GridTextColumn() { MappingName = "materia", HeaderText = "Matéria Prima", Visible = true, Width = 300 });
            materiaDataGridViewe.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from estoque in context.EstoqueMateriaPrima
                             select new
                             {
                                 materia = estoque.NomeMp,
                                 quantidade = estoque.Quantidade,
                             }).ToList();

                materiaDataGridViewe.DataSource = query;
            }
        }
        public void ConstroiGripProduto()
        {
            produtosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Produto", HeaderText = "Produto", Visible = true, Width = 300 });
            produtosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from estoque in context.EstoqueProdutoAcabado
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
            ConstroiGridMateria();
            ConstroiGripProduto();
            carregaGrids();
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
