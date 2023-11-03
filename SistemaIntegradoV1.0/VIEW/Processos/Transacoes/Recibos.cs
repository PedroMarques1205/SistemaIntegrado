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
    public partial class Recibos : Form
    {
        public Recibos()
        {
            InitializeComponent();
        }

        private void Recibos_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            comboBoxFiltros.Text = "Todos";
            comboBoxFiltros.Items.Add("Todos");
            comboBoxFiltros.Items.Add("Recebidos");
            comboBoxFiltros.Items.Add("A receber");
            controiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                if (comboBoxFiltros.Text=="Todos")
                {
                    var query = (from recibo in context.Transacao
                                 where recibo.IdPedidoReceber != null
                                 select new
                                 {
                                     idTransacao = recibo.IdTransacao,
                                     cliente = recibo.Orcamento.Cliente.Nome,
                                     valorReceber = recibo.ValorReceber,
                                     situacao = recibo.Situacao,
                                 }).ToList();

                    RecibosDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
                }
                else if (comboBoxFiltros.Text=="Recebidos")
                {
                    var query = (from recibo in context.Transacao
                                 where recibo.IdPedidoReceber != null && recibo.Situacao == "Recebido"
                                 select new
                                 {
                                     idTransacao = recibo.IdTransacao,
                                     cliente = recibo.Orcamento.Cliente.Nome,
                                     valorReceber = recibo.ValorReceber,
                                     situacao = recibo.Situacao,
                                 }).ToList();

                    RecibosDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
                }
                else if (comboBoxFiltros.Text=="A receber")
                {
                    var query = (from recibo in context.Transacao
                                 where recibo.IdPedidoReceber != null && recibo.Situacao != "Recebido"
                                 select new
                                 {
                                     idTransacao = recibo.IdTransacao,
                                     cliente = recibo.Orcamento.Cliente.Nome,
                                     valorReceber = recibo.ValorReceber,
                                     situacao = recibo.Situacao,
                                 }).ToList();

                    RecibosDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.ToList().Count);
                }
            }
        }
        public void controiGrid()
        {
            RecibosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idTransacao", HeaderText = "idTransacao", Visible = true, Width = 0 });
            RecibosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "cliente", HeaderText = "Cliente", Visible = true, Width = 300 });
            RecibosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "valorReceber", HeaderText = "Valor a Receber", Visible = true });
            RecibosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "situacao", HeaderText = "Situação do Recibo", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from recibo in context.Transacao
                             where recibo.IdPedidoReceber != null
                             select new
                             {
                                 idTransacao = recibo.IdTransacao,
                                 cliente = recibo.Orcamento.Cliente.Nome,
                                 valorReceber = recibo.ValorReceber,
                                 situacao = recibo.Situacao,
                             }).ToList();

                RecibosDataGridView.DataSource = query;
            }
        }

        private void RecibosDataGridView_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowData != null)
            {
                string status = Convert.ToString(e.RowData.GetType().GetProperty("situacao").GetValue(e.RowData, null));

                switch (status.ToLower())
                {
                    case "recebido":
                        e.Style.BackColor = Color.LightGreen;
                        break;
                }
            }
        }

        private void tsbDarBaixaRecibo_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {
                    if (RecibosDataGridView.SelectedItems.Count > 0)
                    {
                        var linhaSelecionada = RecibosDataGridView.SelectedItem;

                        int idOrcamento = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idTransacao").GetValue(linhaSelecionada, null));

                        Transacao recibo = context.Transacao.
                        FirstOrDefault(
                            r =>
                                r.IdTransacao.Equals(idOrcamento)
                        );
                        recibo.Situacao = "Recebido";

                        context.Entry<Transacao>(recibo).State = EntityState.Modified;
                        context.SaveChanges();

                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Recibo recebido!", "Sucesso", buttons, MessageBoxIcon.Information);
                        carregaGrid();
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Selecione o recibo que quer dar baixa porfavor", "Nenhum recibo selecionado", buttons, MessageBoxIcon.Information);
                    }


                }
                catch { }
            }
        }

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }
    }
}
