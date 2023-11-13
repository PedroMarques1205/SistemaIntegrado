﻿using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosProdutoViews;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0
{
    public partial class cadastroProduto : Form
    {
        public bool doubleClick { get; set; }

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
                if (comboBoxFiltros.Text == "Todos")
                {
                    var query = (from produto in context.Produto
                                 select new
                                 {
                                     idProduto = produto.IdProduto,
                                     Nome = produto.Nome,
                                     preco = produto.PrecoUnitario,
                                     isAtivo = produto.isAtivo
                                 }).ToList();

                    ProdutosDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.Produto.Count());
                }
                else if (comboBoxFiltros.Text == "Ativos")
                {
                    var query = (from produto in context.Produto
                                 where produto.isAtivo == true
                                 select new
                                 {
                                     idProduto = produto.IdProduto,
                                     Nome = produto.Nome,
                                     preco = produto.PrecoUnitario,
                                     isAtivo = produto.isAtivo
                                 }).ToList();

                    ProdutosDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.Produto.Count());
                }
                else if (comboBoxFiltros.Text == "Desativos")
                {
                    var query = (from produto in context.Produto
                                 where produto.isAtivo == false
                                 select new
                                 {
                                     idProduto = produto.IdProduto,
                                     Nome = produto.Nome,
                                     preco = produto.PrecoUnitario,
                                     isAtivo = produto.isAtivo
                                 }).ToList();

                    ProdutosDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.Produto.Count());
                }
            }
        }
        public void constroiGrid()
        {
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idProduto", HeaderText = "ID Produto", Visible = true, Width = 0 });
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Produto", Visible = true });
            ProdutosDataGridView.Columns.Add(new GridNumericColumn() { MappingName = "preco", HeaderText = "Preço", Visible = true, Width = 200 });
            ProdutosDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "isAtivo", HeaderText = "Ativo", Visible = true,Width = 200 });

            ProdutosDataGridView.Columns["preco"].Format = "{0:C}";

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from produto in context.Produto
                             where produto.isAtivo == true
                             select new
                             {
                                 idProduto = produto.IdProduto,
                                 Nome = produto.Nome,
                                 preco = produto.PrecoUnitario,
                                 isAtivo = produto.isAtivo
                             }).ToList();
                ProdutosDataGridView.DataSource = query;
            }
        }

        private void cadastroProduto_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            comboBoxFiltros.Text = "Ativos";
            comboBoxFiltros.Items.Add("Ativos");
            comboBoxFiltros.Items.Add("Desativos");
            comboBoxFiltros.Items.Add("Todos");
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

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void ProdutosDataGridView_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                var linhaSelecionada = ProdutosDataGridView.SelectedItem;

                int idProduto = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idProduto").GetValue(linhaSelecionada, null));

                Produto produtoSeleciondo = context.Produto.FirstOrDefault(x => x.IdProduto.Equals(idProduto));
                List<MateriasUsadasNoProduto> mpUsadas = context.MateriasUsadasNoProduto.Where(x => x.idProduto.Equals(produtoSeleciondo.IdProduto)).ToList();

                informacoesProdutosView tela = new informacoesProdutosView(mpUsadas, produtoSeleciondo);
                tela.ShowDialog();
            }
        }
    }
}
