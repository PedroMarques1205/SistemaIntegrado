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
    public partial class enviarProducao : Form
    {
        public enviarProducao()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    OrdemProducao producao = new OrdemProducao();

                    Produto produto = context.Produto.FirstOrDefault(
                        p => p.Nome.Equals(produtosDropDown.Text));

                    producao.IdProduto = produto.IdProduto;
                    producao.QtdAproduzir =  Convert.ToInt32(txtQuantidade.Text);
                    producao.FaseAtual = "Em aprovação";

                    context.OrdemProducao.Add(producao);
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Pedido realizado com sucesso!", ":)", buttons, MessageBoxIcon.Information);
                }
            }
            catch { }
        }

        private void enviarProducao_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Produto item in context.Produto)
                {
                    produtosDropDown.Items.Add(item.Nome);
                }
            }
        }

        private void produtosDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void produtosDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }
    }
}
