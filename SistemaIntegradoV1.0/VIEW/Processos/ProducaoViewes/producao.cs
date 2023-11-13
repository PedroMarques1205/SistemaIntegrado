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
    public partial class producao : Form
    {
        public producao()
        {
            InitializeComponent();
        }

        private void producao_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            constroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }


        public void constroiGrid()
        {
            ProducaoDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idOrdem", HeaderText = "idOrdem", Visible = true, Width = 0 });
            ProducaoDataGridView.Columns.Add(new GridTextColumn() { MappingName = "produto", HeaderText = "Produto", Visible = true });
            ProducaoDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade a produzir", Visible = true });
            ProducaoDataGridView.Columns.Add(new GridTextColumn() { MappingName = "estadoAtual", HeaderText = "Estado atual", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from ordem in context.OrdemProducao
                             select new
                             {
                                 idOrdem = ordem.IdOrdem,
                                 produto = ordem.Produto.Nome,
                                 quantidade = ordem.QtdAproduzir,
                                 estadoAtual = ordem.FaseAtual
                             }).ToList();
                ProducaoDataGridView.DataSource = query;
            }
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from ordem in context.OrdemProducao
                             select new
                             {
                                 idOrdem = ordem.IdOrdem,
                                 produto = ordem.Produto.Nome,
                                 quantidade = ordem.QtdAproduzir,
                                 estadoAtual = ordem.FaseAtual
                             }).ToList();

                ProducaoDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
            }
        }

        private void ProducaoDataGridView_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData != null)
            {
                string status = Convert.ToString(e.RowData.GetType().GetProperty("estadoAtual").GetValue(e.RowData, null));

                switch (status)
                {
                    case "Finalizado":
                        e.Style.BackColor = Color.LightGreen;
                        break;

                    case "Em produção":
                        e.Style.BackColor = Color.LightCoral;
                        break;
                }
            }
        }

        private void btnFinalizarProducao_Click(object sender, EventArgs e)
        {
            bool temLinhaSelecionada = ProducaoDataGridView.SelectedItems.Count > 0;
            if (!temLinhaSelecionada)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Porfavor selecione uma ordem para finalizar", "nenhuma ordem selecionada", buttons, MessageBoxIcon.Exclamation);
            }
            else
            {
                using (ConnectionString context = new ConnectionString())
                {
                    try
                    {
                        if (ProducaoDataGridView.SelectedItems.Count > 0)
                        {
                            var linhaSelecionada = ProducaoDataGridView.SelectedItem;

                            if (linhaSelecionada.GetType().GetProperty("estadoAtual").GetValue(linhaSelecionada, null).Equals("Finalizado"))
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Essa ordem já foi finalizada", "Atenção", buttons, MessageBoxIcon.Information);
                            }
                            else if (linhaSelecionada.GetType().GetProperty("estadoAtual").GetValue(linhaSelecionada, null).Equals("Em aprovação"))
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Essa ordem ainda está em aprovação", "Atenção", buttons, MessageBoxIcon.Information);
                            }
                            else
                            {
                                int idOrdem = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idOrdem").GetValue(linhaSelecionada, null));

                                OrdemProducao ordem = context.OrdemProducao.
                                FirstOrDefault(
                                    o =>
                                        o.IdOrdem.Equals(idOrdem)
                                );
                                ordem.FaseAtual = "Finalizado";

                                context.Entry<OrdemProducao>(ordem).State = EntityState.Modified;
                                context.SaveChanges();

                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Produção finalizada!", "Sucesso", buttons, MessageBoxIcon.Information);
                                carregaGrid();


                                string produto = Convert.ToString(linhaSelecionada.GetType().GetProperty("produto").GetValue(linhaSelecionada, null));

                                Produto produtoAadicionar = context.Produto.FirstOrDefault(
                                    p => p.Nome.Equals(produto));

                                EstoqueProdutoAcabado estoque = context.EstoqueProdutoAcabado.FirstOrDefault(
                                    x => x.Produto.IdProduto.Equals(produtoAadicionar.IdProduto));

                                estoque.Quantidade += Convert.ToInt32(ordem.QtdAproduzir);

                                context.Entry<EstoqueProdutoAcabado>(estoque).State = EntityState.Modified;
                                context.SaveChanges();
                            }


                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Porfavor selecione uma ordem", "nenhuma ordem selecionada", buttons, MessageBoxIcon.Exclamation);
                        }

                    }
                    catch { }
                }
            }
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            realizarPedidoCompra tela = new realizarPedidoCompra();
            tela.ShowDialog();
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void tsbMandarParaProducao_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (ProducaoDataGridView.SelectedItems.Count > 0)
                    {
                        bool temMp = true;
                        var linhaSelecionada = ProducaoDataGridView.SelectedItem;
                        int contador = 0;
                        int idOrdem = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idOrdem").GetValue(linhaSelecionada, null));
                        int quantProduzir = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("quantidade").GetValue(linhaSelecionada, null));

                        OrdemProducao ordem = context.OrdemProducao.
                        FirstOrDefault(
                            o =>
                                o.IdOrdem.Equals(idOrdem)
                        );

                        if (ordem.FaseAtual.Equals("Em aprovação"))
                        {
                            List<MateriasUsadasNoProduto> mpUsadas = context.MateriasUsadasNoProduto.Where(c => c.idProduto.Equals(ordem.Produto.IdProduto)).ToList();


                            List<MateriasUsadasNoProduto> newMpUsadas = new List<MateriasUsadasNoProduto>();
                            foreach (MateriasUsadasNoProduto item in mpUsadas)
                            {
                                EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(item.idMateriaPrima));
                                if (item.Quantidade * ordem.QtdAproduzir > estoqueMateriaPrima.Quantidade)
                                {
                                    contador++;
                                    newMpUsadas.Add(item);
                                }
                            }
                            if (contador >= 1)
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Não possuimos matéria prima suficiente em estoque!", "Error", buttons, MessageBoxIcon.Exclamation);

                                temMp = false;
                                //string mensagem = "";
                                //for (int i = 0; i<newMpUsadas.Count; i++)
                                //{
                                //    MateriasUsadasNoProduto newMp = newMpUsadas[i];
                                //    EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                //    estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(newMp.idMateriaPrima));
                                //    if (newMpUsadas[i].Quantidade * ordem.QtdAproduzir > estoqueMateriaPrima.Quantidade)
                                //    {
                                //        mensagem += newMpUsadas[i].NomeMp + "\t" + ((quantProduzir*newMpUsadas[i].Quantidade) - estoqueMateriaPrima.Quantidade)+ "\n";
                                //    }
                                //}
                                //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                                //DialogResult result = MessageBox.Show("Não temos matéria prima suficiente\ndeseja realizar um pedido?\nMatérias faltantes:\n"+mensagem, ":(", buttons, MessageBoxIcon.Exclamation);
                                //if (result == DialogResult.Yes)
                                //{
                                //    for (int i = 0; i<newMpUsadas.Count; i++)
                                //    {
                                //        PedidoCompraSuprimento pedido = new PedidoCompraSuprimento();
                                //        MateriasUsadasNoProduto newMp = newMpUsadas[i];
                                //        EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                //        estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(newMp.idMateriaPrima));

                                //        pedido.IdMateriaPrima = newMpUsadas[i].idMateriaPrima;
                                //        pedido.Quantidade = (quantProduzir*(newMpUsadas[i].Quantidade) - estoqueMateriaPrima.Quantidade);
                                //        pedido.IsPedidoAceito= false;
                                //        context.PedidoCompraSuprimento.Add(pedido);
                                //        context.SaveChanges();
                                //    }
                                //}
                            }
                            if (temMp)
                            {
                                foreach (MateriasUsadasNoProduto item in mpUsadas)
                                {
                                    EstoqueMateriaPrima estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.IdMateriaPrima.Equals(item.idMateriaPrima));
                                    estoqueMateriaPrima.Quantidade -= Convert.ToInt32((quantProduzir*item.Quantidade));
                                    context.Entry<EstoqueMateriaPrima>(estoqueMateriaPrima).State = EntityState.Modified;
                                }
                                ordem.FaseAtual = "Em produção";
                                context.Entry<OrdemProducao>(ordem).State = EntityState.Modified;
                                context.SaveChanges();

                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                MessageBox.Show("Mandado para produção!", "Sucesso", buttons, MessageBoxIcon.Information);
                                carregaGrid();
                            }
                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Essa ordem já passou pela aprovação", "Error", buttons, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Porfavor selecione uma ordem", "nenhuma ordem selecionada", buttons, MessageBoxIcon.Exclamation);
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
    }
}
