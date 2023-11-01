using SISTEMA.INTEGRADO.V1._0.DAO;
using Syncfusion.Data.Extensions;
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
    public partial class Faturas : Form
    {
        public Faturas()
        {
            InitializeComponent();
        }

        private void Faturas_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            controiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from recibo in context.Transacao
                             where recibo.idPedidoPagar != null
                             select new
                             {
                                 idTransacao = recibo.IdTransacao,
                                 fornecedor = recibo.PedidoCompraSuprimento.Fornecedor,
                                 valorPagar = recibo.ValorPago,
                                 situacao = recibo.Situacao,
                             }).ToList();

                FaturasDataGridView.DataSource = query;
                registrosLabelfooter.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
            }
        }
        public void controiGrid()
        {
            FaturasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idTransacao", HeaderText = "idTransacao", Visible = true, Width = 0 });
            FaturasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "fornecedor", HeaderText = "Fornecedor", Visible = true, Width = 300 });
            FaturasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "valorPagar", HeaderText = "Valor a ser pago", Visible = true });
            FaturasDataGridView.Columns.Add(new GridTextColumn() { MappingName = "situacao", HeaderText = "Situação do Recibo", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from recibo in context.Transacao
                             where recibo.idPedidoPagar != null
                             select new
                             {
                                 idTransacao = recibo.IdTransacao,
                                 fornecedor = recibo.PedidoCompraSuprimento.Fornecedor,
                                 valorPagar = recibo.ValorPago,
                                 situacao = recibo.Situacao,
                             }).ToList();

                FaturasDataGridView.DataSource = query;
            }
        }

        private void tsbPagarFatura_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (FaturasDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = FaturasDataGridView.SelectedItem;

                        int idOrcamento = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idTransacao").GetValue(linhaSelecionada, null));

                        Transacao recibo = context.Transacao.
                        FirstOrDefault(
                            r =>
                                r.IdTransacao.Equals(idOrcamento)
                        );
                        recibo.Situacao = "Pago";

                        context.Entry<Transacao>(recibo).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Fatura paga!", "Sucesso", buttons, MessageBoxIcon.Information);
                        carregaGrid();
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Selecione a fatura que quer pagar porfavor", "Nenhuma fatura selecionada", buttons, MessageBoxIcon.Information);
                    }


                }
                catch { }
            }
        }

        private void FaturasDataGridView_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData != null)
            {
                string status = Convert.ToString(e.RowData.GetType().GetProperty("situacao").GetValue(e.RowData, null));

                switch (status)
                {
                    case "Pago":
                        e.Style.BackColor = Color.LightCoral;
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
    }
}
