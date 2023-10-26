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
    public partial class cadastroProduto : Form
    {
        public cadastroProduto()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        private void tbsCadastroProdruto_Click(object sender, EventArgs e)
        {
            cadastrarProduto tela = new cadastrarProduto();
            tela.ShowDialog();

            carregaGrid();
        }

        public void carregaGrid() 
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from produto in context.Produto
                             select new
                             {
                                 idProduto = produto.IdProduto,
                                 Nome = produto.Nome,
                                 preco = produto.PrecoUnitario,
                             }).ToList();

                ProdutosDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.Produto.Count());
            }
        }
        public void constroiGrid() 
        {
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idProduto", HeaderText = "ID Produto", Visible = true, Width = 100 });
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Produto", Visible = true});
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "preco", HeaderText = "Preço", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from produto in context.Produto
                             select new
                             {
                                 idProduto = produto.IdProduto,
                                 Nome = produto.Nome,
                                 preco = produto.PrecoUnitario,
                             }).ToList();

                ProdutosDataGridView.DataSource = query;
            }
        }
        private void cadastroProduto_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            constroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }
    }
}
