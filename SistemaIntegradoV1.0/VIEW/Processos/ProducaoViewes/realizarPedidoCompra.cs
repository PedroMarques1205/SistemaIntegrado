using SISTEMA.INTEGRADO.V1._0.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0
{
    public partial class realizarPedidoCompra : Form
    {
        public realizarPedidoCompra()
        {
            InitializeComponent();
        }

        private void realizarPedidoCompra_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (MateriaPrima item in context.MateriaPrima)
                {
                    materiasDropDown.Items.Add(item.Nome);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                PedidoCompraSuprimento pedido = new PedidoCompraSuprimento();
                MateriaPrima mp = context.MateriaPrima.FirstOrDefault(m => m.Nome.Equals(materiasDropDown.Text));

                pedido.IdMateriaPrima = mp.idMateriaPrima;
                pedido.Quantidade = Convert.ToInt32(txtQuantidade.Value);
                pedido.IsPedidoAceito = false;
                context.PedidoCompraSuprimento.Add(pedido);
                context.SaveChanges();
                txtQuantidade.Value = 1;
                materiasDropDown.Text = " ";
            }
        }

        private void materiasDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }
    }
}
