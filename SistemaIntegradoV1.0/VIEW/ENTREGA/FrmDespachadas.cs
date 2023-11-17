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
    public partial class FrmDespachadas : Form
    {
        public FrmDespachadas()
        {
            InitializeComponent();
        }

        private void entregasAfazer_Load(object sender, EventArgs e)
        {
            constroiGrid();
            carregaGrid();
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
                                 join endereco in context.Endereco
                                 on entrega.Orcamento.idOrcamento equals endereco.idOrcamento
                                 select new
                                 {
                                     idEntrega = entrega.IdEntrega,
                                     produto = entrega.Orcamento.Produto.Nome,
                                     dataEntrega = entrega.DataEntrega,
                                     tipoEntrega = entrega.tipoEntrega,
                                     isEntregue = entrega.IsEntregue,
                                     rua = endereco.Rua,
                                     num = endereco.Num,
                                     bairro = endereco.Bairro,
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
                             join endereco in context.Endereco
                             on entrega.Orcamento.idOrcamento equals endereco.idOrcamento
                             select new
                             {
                                 idEntrega = entrega.IdEntrega,
                                 produto = entrega.Orcamento.Produto.Nome,
                                 dataEntrega = entrega.DataEntrega,
                                 tipoEntrega = entrega.tipoEntrega,
                                 isEntregue = entrega.IsEntregue,
                                 rua = endereco.Rua,
                                 num = endereco.Num,
                                 bairro = endereco.Bairro,
                             }).ToList();
                EnviosDataGridView.DataSource  = query;

            }
        }
        
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
                        carregaGrid();
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
