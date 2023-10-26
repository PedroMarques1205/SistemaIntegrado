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
    public partial class pedidoVendas : Form
    {
        public pedidoVendas()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            realizarPedido tela = new realizarPedido();
            tela.ShowDialog();

            if (tela.AbrirProducao)
            {
                producao formProducao = new producao();
                formProducao.MdiParent = this.MdiParent;
                formProducao.Show();
            }
            carregaGrid();
            tela.Dispose();
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from orcamento in context.Orcamento
                             join cliente in context.Cliente
                             on orcamento.CpfCliente equals cliente.CpfCliente
                             join produto in context.Produto
                             on orcamento.idProduto equals produto.IdProduto
                             select new
                             {
                                 idOrcamento = orcamento.idOrcamento,
                                 CpfCliente = cliente.CpfCliente,
                                 NomeDoCliente = cliente.Nome,
                                 Produto = produto.Nome,
                                 quantidade = orcamento.QuantProduto,
                                 ValorTotal = orcamento.ValorTotal,
                                 FormaDePagamento = orcamento.formaPagamento,
                                 EstaAceito = orcamento.statusCliente
                             }).ToList();

                PedidosDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
            }
        }

        public void constroiGrid()
        {
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idOrcamento", HeaderText = "ID do orçamento", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "CpfCliente", HeaderText = "CPF do cliente", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "NomeDoCliente", HeaderText = "Cliente", Visible = true, Width = 300 });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Produto", HeaderText = "Produto", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "quantidade", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "ValorTotal", HeaderText = "Valor total", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "FormaDePagamento", HeaderText = "Forma de pagamento", Visible = true });
            PedidosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "EstaAceito", HeaderText = "Está aceito?", Visible = true });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from orcamento in context.Orcamento
                             join cliente in context.Cliente
                             on orcamento.CpfCliente equals cliente.CpfCliente
                             join produto in context.Produto
                             on orcamento.idProduto equals produto.IdProduto
                             select new
                             {
                                 idOrcamento = orcamento.idOrcamento,
                                 CpfCliente = cliente.CpfCliente,
                                 NomeDoCliente = cliente.Nome,
                                 Produto = produto.Nome,
                                 quantidade = orcamento.QuantProduto,
                                 ValorTotal = orcamento.ValorTotal,
                                 FormaDePagamento = orcamento.formaPagamento,
                                 EstaAceito = orcamento.statusCliente
                             }).ToList();

                PedidosDataGridView.DataSource = query;
            }
        }
        private void pedidoVendas_Load(object sender, EventArgs e)
        {
            constroiGrid();
            carregaGrid();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (PedidosDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = PedidosDataGridView.SelectedItem;

                        int idOrcamento = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idOrcamento").GetValue(linhaSelecionada, null));

                        Orcamento orcamento = context.Orcamento.
                        FirstOrDefault(
                            o =>
                                o.idOrcamento.Equals(idOrcamento)
                        );
                        orcamento.statusCliente = "Aceito";

                        EstoqueProdutoAcabado estoque = context.EstoqueProdutoAcabado.FirstOrDefault(x => x.IdProduto.Equals(orcamento.idProduto));
                        estoque.Quantidade -= Convert.ToInt32(orcamento.QuantProduto);

                        context.Entry<Orcamento>(orcamento).State = EntityState.Modified;
                        context.Entry<EstoqueProdutoAcabado>(estoque).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Aceito pelo cliente!", ":)", buttons, MessageBoxIcon.Information);
                        carregaGrid();
                        Transacao recibo = new Transacao();

                        recibo.IdPedidoReceber = orcamento.idOrcamento;
                        recibo.ValorReceber = orcamento.ValorTotal;
                        recibo.Situacao = "Aberto";

                        context.Transacao.Add(recibo);
                        context.SaveChanges();
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Porfavor selecione um pedido", "nenhum pedido selecionado", buttons, MessageBoxIcon.Exclamation);
                    }
                }
                catch { }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (PedidosDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = PedidosDataGridView.SelectedItem;

                        int idOrcamento = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idOrcamento").GetValue(linhaSelecionada, null));

                        Orcamento orcamento = context.Orcamento.
                        FirstOrDefault(
                            o =>
                                o.idOrcamento.Equals(idOrcamento)
                        );
                        orcamento.statusCliente = "Reprovado";

                        context.Entry<Orcamento>(orcamento).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Reprovado pelo cliente!", ":(", buttons, MessageBoxIcon.Information);
                        carregaGrid();
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Porfavor selecione um pedido", "nenhum pedido selecionado", buttons, MessageBoxIcon.Exclamation);
                    }

                }
                catch { }
            }
        }

        private void PedidosDataGridView_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData != null)
            {
                string status = Convert.ToString(e.RowData.GetType().GetProperty("EstaAceito").GetValue(e.RowData, null));

                switch (status.ToLower())
                {
                    case "reprovado":
                        e.Style.BackColor = Color.LightCoral;
                        break;

                    case "aceito":
                        e.Style.BackColor = Color.LightGreen;
                        break;
                }
            }
        }
    }
}
