using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.Processos.VendasViews;
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
    public partial class FrmListagemOrcamentos : Form
    {
        public FrmListagemOrcamentos()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FrmOrcamento tela = new FrmOrcamento();
            tela.ShowDialog();

            if (tela.AbrirProducao)
            {
                FrmProducao formProducao = new FrmProducao();
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
            PedidosDataGridView.Columns["ValorTotal"].Format = "{0:C}";
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

                        EstoqueProdutoAcabado estoque = context.EstoqueProdutoAcabado.FirstOrDefault(x => x.IdProduto.Equals(orcamento.idProduto));
                        if (orcamento.statusCliente == "Aceito")
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Esse pedido já foi aceito pelo cliente", "Error", buttons, MessageBoxIcon.Error);
                            carregaGrid();
                        }
                        else
                        {
                            if (orcamento.QuantProduto > estoque.Quantidade)
                            {
                                Produto produto = orcamento.Produto;
                                if (!verificarEstoque(produto, estoque))
                                {
                                    MessageBoxButtons b = MessageBoxButtons.OK;
                                    DialogResult r = MessageBox.Show("Não possuimos esse produto em estoque\nenviando para produção", "Error", b, MessageBoxIcon.Error);

                                    OrdemProducao producao = new OrdemProducao();

                                    int quantidade = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("quantidade").GetValue(linhaSelecionada, null));

                                    Produto produto1 = context.Produto.FirstOrDefault(
                                        p => p.Nome.Equals(orcamento.Produto.Nome));
                                    orcamento.PodeSerEntregue = false;
                                    producao.IdOrcamento = orcamento.idOrcamento;
                                    producao.IdProduto = produto1.IdProduto;
                                    producao.QtdAproduzir =  quantidade;
                                    producao.FaseAtual = "Em aprovação";
                                    int contador = 0;

                                    context.OrdemProducao.Add(producao);
                                    context.SaveChanges();

                                    List<MateriasUsadasNoProduto> mpUsadas = context.MateriasUsadasNoProduto.Where(c => c.idProduto.Equals(producao.Produto.IdProduto)).ToList();
                                    List<MateriasUsadasNoProduto> newMpUsadas = new List<MateriasUsadasNoProduto>();
                                    foreach (MateriasUsadasNoProduto item in mpUsadas)
                                    {
                                        EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                        estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(item.idMateriaPrima));
                                        if (item.Quantidade * producao.QtdAproduzir > estoqueMateriaPrima.Quantidade)
                                        {
                                            newMpUsadas.Add(item);
                                        }
                                    }
                                    for (int i = 0; i<newMpUsadas.Count; i++)
                                    {
                                        MateriasUsadasNoProduto newMp = newMpUsadas[i];
                                        EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                        estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(newMp.idMateriaPrima));
                                    }
                                    for (int i = 0; i<newMpUsadas.Count; i++)
                                    {
                                        PedidoCompraSuprimento pedido = new PedidoCompraSuprimento();
                                        MateriasUsadasNoProduto newMp = newMpUsadas[i];
                                        EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                        estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(newMp.idMateriaPrima));
                                        pedido.IdMateriaPrima = newMpUsadas[i].idMateriaPrima;
                                        pedido.Quantidade = (producao.QtdAproduzir*(newMpUsadas[i].Quantidade) - estoqueMateriaPrima.Quantidade);
                                        pedido.IsPedidoAceito= false;
                                        context.PedidoCompraSuprimento.Add(pedido);
                                        context.SaveChanges();
                                    }
                                    orcamento.statusCliente = "Aceito";

                                    estoque.Quantidade -= Convert.ToInt32(orcamento.QuantProduto);

                                    context.Entry<Orcamento>(orcamento).State = EntityState.Modified;
                                    context.Entry<EstoqueProdutoAcabado>(estoque).State = EntityState.Modified;
                                    context.SaveChanges();

                                    MessageBoxButtons bu = MessageBoxButtons.OK;
                                    MessageBox.Show("Aceito pelo cliente!", "Sucesso", bu, MessageBoxIcon.Information);
                                    carregaGrid();
                                    Transacao recibo = new Transacao();

                                    recibo.IdPedidoReceber = orcamento.idOrcamento;
                                    recibo.ValorReceber = orcamento.ValorTotal;
                                    recibo.Situacao = "Aberto";

                                    context.Transacao.Add(recibo);
                                    context.SaveChanges();
                                }
                            }
                            else
                            {
                                orcamento.statusCliente = "Aceito";

                                estoque.Quantidade -= Convert.ToInt32(orcamento.QuantProduto);

                                context.Entry<Orcamento>(orcamento).State = EntityState.Modified;
                                context.Entry<EstoqueProdutoAcabado>(estoque).State = EntityState.Modified;
                                context.SaveChanges();

                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Aceito pelo cliente!", "Sucesso", buttons, MessageBoxIcon.Information);
                                carregaGrid();
                                Transacao recibo = new Transacao();

                                recibo.IdPedidoReceber = orcamento.idOrcamento;
                                recibo.ValorReceber = orcamento.ValorTotal;
                                recibo.Situacao = "Aberto ";

                                context.Transacao.Add(recibo);
                                context.SaveChanges();
                            }
                        }
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

        public bool verificarEstoque(Produto produto, EstoqueProdutoAcabado estoqueProduto)
        {
            using (ConnectionString context = new ConnectionString())
            {
                var linhaSelecionada = PedidosDataGridView.SelectedItem;

                int quantidade = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("quantidade").GetValue(linhaSelecionada, null));

                if (estoqueProduto.Quantidade < quantidade)
                {
                    return false;
                }
                else
                {
                    return true;
                }
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
                        if (orcamento.statusCliente == "Aceito")
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Esse pedido já foi aceito pelo cliente", "Error", buttons, MessageBoxIcon.Error);
                            carregaGrid();
                        }
                        else
                        {
                            orcamento.statusCliente = "Reprovado";

                            context.Entry<Orcamento>(orcamento).State = EntityState.Modified;
                            context.SaveChanges();

                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Reprovado pelo cliente!", "Sucesso", buttons, MessageBoxIcon.Information);
                            carregaGrid();
                        }
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

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            FrmOrdemProducao tela = new FrmOrdemProducao();
            tela.ShowDialog();
            carregaGrid();
        }

        private void PedidosDataGridView_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            var linhaSelecionada = PedidosDataGridView.SelectedItem;

            int idOrcamento = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idOrcamento").GetValue(linhaSelecionada, null));

            string cpf = Convert.ToString(linhaSelecionada.GetType().GetProperty("CpfCliente").GetValue(linhaSelecionada, null));

            using (ConnectionString context = new ConnectionString()) 
            {
                Orcamento orcamento = context.Orcamento.FirstOrDefault(x => x.idOrcamento.Equals(idOrcamento));
                Cliente cliente = context.Cliente.FirstOrDefault(x => x.CpfCliente.Equals(cpf));
                Endereco novo = context.Endereco.FirstOrDefault(x => x.idOrcamento.Equals(idOrcamento));

                FrmDetalhesOrcamento tela = new FrmDetalhesOrcamento(orcamento,cliente,novo);
                tela.ShowDialog();
            }
        }
    }
}
