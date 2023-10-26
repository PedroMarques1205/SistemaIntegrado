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
    public partial class ordemsEmAprovacao : Form
    {
        public ordemsEmAprovacao()
        {
            InitializeComponent();
        }

        private void ordemsEmAprovacao_Load(object sender, EventArgs e)
        {
            constroiGrid();
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from ordem in context.OrdemProducao
                             where ordem.FaseAtual == "Em aprovação"
                             select new
                             {
                                 idOrdem = ordem.IdOrdem,
                                 produto = ordem.Produto.Nome,
                                 quantidade = ordem.QtdAproduzir,
                                 estadoAtual = ordem.FaseAtual
                             }).ToList();

                ordemDataGridView.DataSource = query;
            }
        }

        public void constroiGrid()
        {
            ordemDataGridView.Columns.Add(new GridTextColumn() { MappingName = "produto", HeaderText = "Produto", Visible = true, Width = 200 });
            ordemDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade a produzir", Visible = true });
            ordemDataGridView.Columns.Add(new GridTextColumn() { MappingName = "estadoAtual", HeaderText = "Estado atual", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from ordem in context.OrdemProducao
                             where ordem.FaseAtual == "Em aprovação"
                             select new
                             {
                                 idOrdem = ordem.IdOrdem,
                                 produto = ordem.Produto.Nome,
                                 quantidade = ordem.QtdAproduzir,
                                 estadoAtual = ordem.FaseAtual
                             }).ToList();

                ordemDataGridView.DataSource = query;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (ordemDataGridView.SelectedItems.Count > 0)
                    {
                        bool temMp = true;
                        var linhaSelecionada = ordemDataGridView.SelectedItem;
                        int contador = 0;
                        int idOrdem = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idOrdem").GetValue(linhaSelecionada, null));
                        int quantProduzir = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("quantidade").GetValue(linhaSelecionada, null));

                        OrdemProducao ordem = context.OrdemProducao.
                        FirstOrDefault(
                            o =>
                                o.IdOrdem.Equals(idOrdem)
                        );
                        

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
                            string mensagem = "";
                            for (int i = 0; i<newMpUsadas.Count; i++)
                            {
                                MateriasUsadasNoProduto newMp = newMpUsadas[i];
                                EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(newMp.idMateriaPrima));
                                if (newMpUsadas[i].Quantidade * ordem.QtdAproduzir > estoqueMateriaPrima.Quantidade)
                                {
                                    mensagem += newMpUsadas[i].NomeMp + "\t" + ((quantProduzir*newMpUsadas[i].Quantidade) - estoqueMateriaPrima.Quantidade)+ "\n";
                                }
                            }
                            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                            DialogResult result = MessageBox.Show("Não temos matéria prima suficiente\ndeseja realizar um pedido?\nMatérias faltantes:\n"+mensagem, ":(", buttons, MessageBoxIcon.Exclamation);
                            if (result == DialogResult.Yes)
                            {
                                for (int i = 0; i<newMpUsadas.Count; i++)
                                {
                                    PedidoCompraSuprimento pedido = new PedidoCompraSuprimento();
                                    MateriasUsadasNoProduto newMp = newMpUsadas[i];
                                    EstoqueMateriaPrima estoqueMateriaPrima = new EstoqueMateriaPrima();
                                    estoqueMateriaPrima = context.EstoqueMateriaPrima.FirstOrDefault(x => x.MateriaPrima.idMateriaPrima.Equals(newMp.idMateriaPrima));

                                    pedido.IdMateriaPrima = newMpUsadas[i].idMateriaPrima;
                                    pedido.Quantidade = (quantProduzir*(newMpUsadas[i].Quantidade) - estoqueMateriaPrima.Quantidade);
                                    pedido.IsPedidoAceito= false;
                                    context.PedidoCompraSuprimento.Add(pedido);
                                    context.SaveChanges();
                                }
                            }
                            temMp = false;
                        }
                        if(temMp)
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
                            MessageBox.Show("Mandado para produção!", ":)", buttons, MessageBoxIcon.Information);
                            carregaGrid();
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

        public bool verificarQtdMateria(List<MateriasUsadasNoProduto> mpUsadas)
        {

            using (ConnectionString context = new ConnectionString())
            {

                return false;
            }
        }
    }
}
