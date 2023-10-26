using SISTEMA.INTEGRADO.V1._0.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.EntityClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0
{
    public partial class realizarPedido : Form
    {
        public bool AbrirProducao { get; set; }

        public realizarPedido()
        {
            InitializeComponent();
            AbrirProducao = false;
        }

        bool imageTransiction = false;
       
        private void realizarPedido_Load(object sender, EventArgs e)
        {
            dpdPagamento.Items.Add("PIX");
            dpdPagamento.Items.Add("Crédito");
            dpdPagamento.Items.Add("Débito");
            dpdPagamento.Items.Add("Dinheiro");
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Produto item in context.Produto)
                {
                    produtosDropDown.Items.Add(item.Nome);
                }
            }
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
                    Orcamento orcamento = new Orcamento();
                    Produto produto = context.Produto.FirstOrDefault(p => p.Nome.Equals(produtosDropDown.Text));
                    EstoqueProdutoAcabado estoque = context.EstoqueProdutoAcabado.FirstOrDefault(q => q.IdProduto.Equals(produto.IdProduto));

                    if (verificarEstoque(produto, estoque))
                    {
                        if (produto != null)
                        {
                            Cliente cliente = context.Cliente.FirstOrDefault(c => c.CpfCliente.Equals(txtCpfCliente.Text));

                            if (cliente != null)
                            {
                                orcamento.CpfCliente = cliente.CpfCliente;
                                orcamento.idProduto = produto.IdProduto;
                                orcamento.QuantProduto = Convert.ToInt32(txtQuantidade.Text);
                                orcamento.ValorTotal = orcamento.QuantProduto * produto.PrecoUnitario;
                                orcamento.statusCliente = "Em aprovação";
                                orcamento.formaPagamento = dpdPagamento.Text;

                                context.Orcamento.Add(orcamento);
                                context.SaveChanges();
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show("Cadastrado com sucesso!", ":)", buttons, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show("Esse cliente não existe", ":(", buttons, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Esse produto não existe", ":(", buttons, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Não possuimos esse produto em estoque,\ndeseja solicitar produção?", ":(", buttons, MessageBoxIcon.Error);
                        if (result == DialogResult.Yes)
                        {
                            this.Close();
                            enviarProducao tela = new enviarProducao();
                            tela.ShowDialog();
                        }
                    }
                }
            }
            catch
            {

            }

        }

        public bool verificarEstoque(Produto produto, EstoqueProdutoAcabado estoqueProduto)
        {
            using (ConnectionString context = new ConnectionString())
            {
                if (estoqueProduto.Quantidade < Convert.ToInt32(txtQuantidade.Text))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        private void dpdPagamento_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = true;

        }
    }
}
