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
    public partial class entregasDespachadas : Form
    {
        public entregasDespachadas()
        {
            InitializeComponent();
        }

        private void entregasAfazer_Load(object sender, EventArgs e)
        {
            constroiGrid();
        }

        private void constroiGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idEntrega", HeaderText = "idEntrega", Visible = true, Width = 0 });
                    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "produto", HeaderText = "Produto", Visible = true,Width = 300 });
                    EnviosDataGridView.Columns.Add(new GridDateTimeColumn() { MappingName = "dataEntrega", HeaderText = "Data prevista", Visible = true });
                    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "tipoEntrega", HeaderText = "Tipo de Entrega", Visible = true });
                    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "rua", HeaderText = "Rua", Visible = true });
                    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "num", HeaderText = "N° residência", Visible = true });
                    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "bairro", HeaderText = "Bairro", Visible = true });
                    EnviosDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "isEntregue", HeaderText = "Está entregue?", Visible = true });
                    var query = (from entrega in context.Entrega
                                 select new
                                 {
                                     idEntrega = entrega.IdEntrega,
                                     produto = entrega.Orcamento.Produto.Nome,
                                     dataEntrega = entrega.DataEntrega,
                                     tipoEntrega = entrega.tipoEntrega,
                                     isEntregue = entrega.IsEntregue,
                                     rua = entrega.Orcamento.Cliente.Rua,
                                     num = entrega.Orcamento.Cliente.Num,
                                     bairro = entrega.Orcamento.Cliente.Bairro,
                                 }).ToList();
                    EnviosDataGridView.DataSource  = query;
                }
                catch
                {

                }
            }
        }
        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from entrega in context.Entrega
                             select new
                             {
                                 idEntrega = entrega.IdEntrega,
                                 produto = entrega.Orcamento.Produto.Nome,
                                 dataEntrega = entrega.DataEntrega,
                                 tipoEntrega = entrega.tipoEntrega,
                                 isEntregue = entrega.IsEntregue,
                                 rua = entrega.Orcamento.Cliente.Rua,
                                 num = entrega.Orcamento.Cliente.Num,
                                 bairro = entrega.Orcamento.Cliente.Bairro,
                             }).ToList();

            }
        }
        //public void carregaGrid() 
        //{
        //    using (ConnectionString context = new ConnectionString())
        //    {
        //        var query = (from orcamento in context.Orcamento
        //                     join cliente in context.Cliente
        //                     on orcamento.CpfCliente equals cliente.CpfCliente
        //                     join produto in context.Produto
        //                     on orcamento.idProduto equals produto.IdProduto
        //                     where orcamento.statusCliente == "Aceito" &&
        //                     orcamento.statusEntrega !="Aceito"
        //                     select new
        //                     {
        //                         idOrc = orcamento.idOrcamento,
        //                         CpfCliente = cliente.CpfCliente,
        //                         NomeDoCliente = cliente.Nome,
        //                         Produto = produto.Nome,
        //                         quantidade = orcamento.QuantProduto,
        //                         bairro = cliente.Bairro,
        //                         rua = cliente.Rua,
        //                         num = cliente.Num,
        //                     }).ToList();
        //        EnviosDataGridView.DataSource = query;
        //    }
        //}
        //public void constroiGrid() 
        //{
            
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idOrc", HeaderText = "IdOrcamento", Visible = true, Width = 0 });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "CpfCliente", HeaderText = "CPF do cliente", Visible = true });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "NomeDoCliente", HeaderText = "Cliente", Visible = true, Width = 300 });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Produto", HeaderText = "Produto", Visible = true });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "quantidade", Visible = true });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "rua", HeaderText = "Rua", Visible = true });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "bairro", HeaderText = "Bairro", Visible = true });
        //    EnviosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "num", HeaderText = "N° residência", Visible = true });
        //    using (ConnectionString context = new ConnectionString())
        //    {
        //        var query = (from orcamento in context.Orcamento
        //                     join cliente in context.Cliente
        //                     on orcamento.CpfCliente equals cliente.CpfCliente
        //                     join produto in context.Produto
        //                     on orcamento.idProduto equals produto.IdProduto
        //                     where orcamento.statusCliente == "Aceito" &&
        //                     orcamento.statusEntrega !="Aceito"
        //                     select new
        //                     {
        //                         idOrc = orcamento.idOrcamento,
        //                         CpfCliente = cliente.CpfCliente,
        //                         NomeDoCliente = cliente.Nome,
        //                         Produto = produto.Nome,
        //                         quantidade = orcamento.QuantProduto,
        //                         bairro = cliente.Bairro,
        //                         rua = cliente.Rua,
        //                         num = cliente.Num,
        //                     }).ToList();
        //        EnviosDataGridView.DataSource = query;
        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (EnviosDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = EnviosDataGridView.SelectedItem;

                        int idEntrega = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idEntrega").GetValue(linhaSelecionada));

                        Entrega entrega = context.Entrega.
                        FirstOrDefault(
                            v =>
                                v.IdEntrega.Equals(idEntrega)
                        );
                        entrega.IsEntregue = true;

                        context.Entry<Entrega>(entrega).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Pedido entregue!", "Sucesso", buttons, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Selecione a entrega que quer dar baixa porfavor", "Nenhuma entrega selecionada", buttons, MessageBoxIcon.Information);
                    }
                    carregaGrid();
                }
                catch
                {

                }
            }
        }
    }
}
