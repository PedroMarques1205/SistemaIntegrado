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
                             where produto.isAtivo == true
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
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Produto", Visible = true });
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "preco", HeaderText = "Preço", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from produto in context.Produto
                             where produto.isAtivo == true
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

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (ProdutosDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = ProdutosDataGridView.SelectedItem;

                int idProduto = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idProduto").GetValue(linhaSelecionada, null));

                using (ConnectionString context = new ConnectionString())
                {
                    Produto produtoParaInativar = context.Produto.FirstOrDefault(v => v.IdProduto.Equals(idProduto));
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Tem Certeza que deseja inativar " + produtoParaInativar.Nome + "?", "Atenção", buttons, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        if (ProdutosDataGridView.SelectedItems.Count > 0)
                        {
                            linhaSelecionada = ProdutosDataGridView.SelectedItem;

                            idProduto = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idProduto").GetValue(linhaSelecionada, null));

                            Produto produtoaParaInativar = context.Produto.FirstOrDefault(v => v.IdProduto.Equals(idProduto));
                            if (produtoParaInativar != null)
                            {
                                produtoaParaInativar.isAtivo = false;
                                context.Entry<Produto>(produtoaParaInativar).State = EntityState.Modified;
                                context.SaveChanges();
                                carregaGrid();
                            }
                        }
                    }
                    else
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        DialogResult resul = MessageBox.Show("Selecione o produto que deseja inativar", "Nenhuma linha selecionada", button, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }
    }
}
