using DocumentFormat.OpenXml.Office2010.ExcelAc;
using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.MODEL;
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

namespace SistemaIntegradoV1._0.VIEW.RELATORIO
{
    public partial class FrmRelatorioPedidos : Form
    {
        private DadosUsuarioRelatorio dadosUsuario { get; set; }
        public FrmRelatorioPedidos(Usuario user)
        {
            InitializeComponent();
            DadosUsuarioRelatorio obj = new DadosUsuarioRelatorio();
            obj.usuario = user.Login;
            obj.dataEmissao = DateTime.Now;
            obj.area = user.Acessos.FirstOrDefault().ToString();
            dadosUsuario = obj;
        }

        private void FrmRelatorioPedidos_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DateTime primeiroDiaDoMes = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            txtInicio.Text = primeiroDiaDoMes.ToString("dd/MM/yyyy");
            int ultimoDiaDoMes = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
            DateTime ultimoDiaDoMesDt = new DateTime(DateTime.Now.Year, DateTime.Now.Month, ultimoDiaDoMes);
            txtFim.Text = ultimoDiaDoMesDt.ToString("dd/MM/yyyy");
            this.reportViewer1.RefreshReport();
            Cursor.Current = Cursors.Default;
        }

        private void tdbGerarRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                this.Update();
                this.reportViewer1.LocalReport.Refresh();
                this.reportViewer1.RefreshReport();
                reportViewer1.Visible = true;
                if (!txtInicio.MaskCompleted || !txtFim.MaskCompleted)
                {
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Preencha as datas de início e fim", "Error", buttons, MessageBoxIcon.Error);
                }
                else
                {
                    DateTime inicio = DateTime.Parse(txtInicio.Text);
                    DateTime fim = DateTime.Parse(txtFim.Text);
                    using (ConnectionString context = new ConnectionString())
                    {
                        List<RelatorioOrcamentos> orcamentos = context.RelatorioOrcamentos.Where(x => x.DataOrcamento >= inicio && x.DataOrcamento <= fim).ToList();
                        List<Transacao> transacoes = context.Transacao.Where(x => x.Orcamento.DataOrcamento >= inicio && x.Orcamento.DataOrcamento <= fim).ToList();
                        List<Transacao> transacoesp = new List<Transacao>();
                        List<DadosUsuarioRelatorio> dadosEmissor = new List<DadosUsuarioRelatorio>();
                        dadosEmissor.Add(dadosUsuario);
                        foreach (RelatorioOrcamentos item in orcamentos)
                        {
                            int id = Convert.ToInt32(item.IdOrdem);
                            if (id != 0)
                            {
                                var transacao = context.Transacao.FirstOrDefault(x => x.idPedidoPagar == id);
                                if (transacao != null)
                                {
                                    transacoesp.Add(transacao);
                                }
                            }
                        }
                        this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                        this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.Percent;
                        this.reportViewer1.ZoomPercent = 200;
                        this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", orcamentos));
                        this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", transacoes));
                        this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", transacoesp));
                        this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet4", dadosEmissor));
                        this.reportViewer1.LocalReport.Refresh();
                        this.reportViewer1.RefreshReport();
                    }
                }
            }
            catch
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Insira datas válidas", "Error", buttons, MessageBoxIcon.Error);
            }
        }
    }
}
