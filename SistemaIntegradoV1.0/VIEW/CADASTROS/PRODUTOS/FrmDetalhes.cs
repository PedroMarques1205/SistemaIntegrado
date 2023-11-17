using SISTEMA.INTEGRADO.V1._0.DAO;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosProdutoViews
{
    public partial class FrmDetalhes : Form
    {
        public FrmDetalhes(List<MateriasUsadasNoProduto> mpUsadas, Produto produto)
        {
            using (ConnectionString context = new ConnectionString())
            {
                InitializeComponent();
                txtNomeProduto.Text = produto.Nome;
                txtPreco.Text = Convert.ToString(produto.PrecoUnitario);

                materiasDataGrid.Columns.Add(new GridTextColumn() { MappingName = "nome", HeaderText = "Matérias", Visible = true, Width = 400});
                materiasDataGrid.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true });

                var query = (from mp in context.MateriasUsadasNoProduto
                             where mp.idProduto == produto.IdProduto
                             select new
                             {
                                 nome = mp.MateriaPrima.Nome,
                                 quantidade = mp.Quantidade,     
                             }).ToList();
                materiasDataGrid.DataSource = query;
            }
        }

        private void informacoesProdutosView_Load(object sender, EventArgs e)
        {

        }
    }
}
