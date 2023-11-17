using SISTEMA.INTEGRADO.V1._0.DAO;
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
    public partial class FrmRealizaPedido : Form
    {
        private static PedidoCompraSuprimento pedidoM { get; set; }
        public FrmRealizaPedido(PedidoCompraSuprimento pedido)
        {
            InitializeComponent();
            txtMateria.Text = pedido.MateriaPrima.Nome;
            txtQuantidade.Text = Convert.ToString(pedido.Quantidade);
            pedidoM = pedido;
        }

        private void cadastrarPedido_Load(object sender, EventArgs e)
        {
            dpdPagamento.Items.Add("PIX");
            dpdPagamento.Items.Add("Crédito");
            dpdPagamento.Items.Add("Débito");
            dpdPagamento.Items.Add("Dinheiro");
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                Transacao recibo = new Transacao();
                PedidoCompraSuprimento pedidoAserfeito = new PedidoCompraSuprimento();
                MateriaPrima mp = context.MateriaPrima.FirstOrDefault(x => x.Nome.Equals(txtMateria.Text));

                pedidoAserfeito.IdPedidoCompra = pedidoM.IdPedidoCompra;
                int idMp = mp.idMateriaPrima;
                pedidoAserfeito.IdMateriaPrima = idMp;
                pedidoAserfeito.Fornecedor = txtFornecedor.Text;
                pedidoAserfeito.Quantidade = Convert.ToInt32(txtQuantidade.Text);
                pedidoAserfeito.PrecoUnit = Convert.ToDouble(txtPrecoUnitario.Text);
                pedidoAserfeito.PrecoTotal = pedidoAserfeito.PrecoUnit*pedidoAserfeito.Quantidade;
                pedidoAserfeito.PrazoEntrega = DateTime.Parse(txtPrazoEntrega.Text);
                pedidoAserfeito.CondicaoPagamento = dpdPagamento.Text;
                pedidoAserfeito.IsPedidoAceito = true;
                pedidoAserfeito.IsEntregue = false;

                recibo.idPedidoPagar = pedidoAserfeito.IdPedidoCompra;
                recibo.ValorPago = pedidoAserfeito.PrecoTotal;
                recibo.Situacao = "Aberto";

                context.Transacao.Add(recibo);
                context.Entry<PedidoCompraSuprimento>(pedidoAserfeito).State = EntityState.Modified;
                context.SaveChanges();

                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Pedido realizado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dpdPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
