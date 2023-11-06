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
                foreach (Produto item in context.Produto.Where(x => x.isAtivo == true))
                {
                    produtosDropDown.Items.Add(item.Nome);
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        public bool verificaCampos()
        {
            if (!localEntregaCheckBox.Checked)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox textBox = c as TextBox;
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            return true;
                        }
                    }
                    else if (c is MaskedTextBox)
                    {
                        MaskedTextBox textBox = c as MaskedTextBox;
                        if (!textBox.MaskCompleted)
                        {
                            return true;
                        }
                    }
                    else if (c is ComboBox)
                    {
                        ComboBox textBox = c as ComboBox;
                        if (string.IsNullOrWhiteSpace(textBox.Text))
                        {
                            return true;
                        }
                    }
                    else if (c is NumericUpDown)
                    {
                        NumericUpDown textBox = c as NumericUpDown;
                        if (textBox.Value == 0)
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
            else
            {
                return false;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    if (verificaCampos())
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Preencha todos os campos", "Error", buttons, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (localEntregaCheckBox.Checked)
                        {
                            Orcamento orcamento = new Orcamento();
                            Produto produto = context.Produto.FirstOrDefault(p => p.Nome.Equals(produtosDropDown.Text));
                            EstoqueProdutoAcabado estoque = context.EstoqueProdutoAcabado.FirstOrDefault(q => q.IdProduto.Equals(produto.IdProduto));
                            Endereco endereco = new Endereco();
                            if (produto != null)
                            {
                                Cliente cliente = context.Cliente.FirstOrDefault(c => c.CpfCliente.Equals(txtCpfCliente.Text));

                                if (cliente != null && cliente.isAtivo == true)
                                {
                                    orcamento.CpfCliente = cliente.CpfCliente;
                                    orcamento.idProduto = produto.IdProduto;
                                    orcamento.QuantProduto = Convert.ToInt32(txtQuantidade.Text);
                                    orcamento.ValorTotal = orcamento.QuantProduto * produto.PrecoUnitario;
                                    orcamento.statusCliente = "Em aprovação";
                                    orcamento.formaPagamento = dpdPagamento.Text;

                                    context.Orcamento.Add(orcamento);
                                    context.SaveChanges();

                                    endereco.Rua = cliente.Rua;
                                    endereco.Num = cliente.Num;
                                    endereco.Bairro = cliente.Bairro;
                                    endereco.Estado = cliente.Estado;
                                    endereco.idOrcamento = orcamento.idOrcamento;
                                    endereco.Complemento = cliente.Complemento;

                                    context.Endereco.Add(endereco);
                                    context.SaveChanges();
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show("Cadastrado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show("Esse cliente não existe", "Error", buttons, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show("Esse produto não existe", "Error", buttons, MessageBoxIcon.Error);
                                this.Close();
                            }
                        }
                        else
                        {
                            Orcamento orcamento = new Orcamento();
                            Produto produto = context.Produto.FirstOrDefault(p => p.Nome.Equals(produtosDropDown.Text));
                            EstoqueProdutoAcabado estoque = context.EstoqueProdutoAcabado.FirstOrDefault(q => q.IdProduto.Equals(produto.IdProduto));
                            Endereco endereco = new Endereco();
                            if (produto != null)
                            {
                                endereco.Rua = txtRua.Text;
                                endereco.Num = Convert.ToInt32(txtNum.Text);
                                endereco.Bairro = txtBairro.Text;
                                endereco.Estado = cbEstado.Text;

                                Cliente cliente = context.Cliente.FirstOrDefault(c => c.CpfCliente.Equals(txtCpfCliente.Text));


                                endereco.Complemento = txtComplemento.Text;


                                if (cliente != null && cliente.isAtivo == true)
                                {
                                    orcamento.CpfCliente = cliente.CpfCliente;
                                    orcamento.idProduto = produto.IdProduto;
                                    orcamento.QuantProduto = Convert.ToInt32(txtQuantidade.Text);
                                    orcamento.ValorTotal = orcamento.QuantProduto * produto.PrecoUnitario;
                                    orcamento.statusCliente = "Em aprovação";
                                    orcamento.formaPagamento = dpdPagamento.Text;

                                    context.Orcamento.Add(orcamento);
                                    context.SaveChanges();
                                    endereco.idOrcamento = orcamento.idOrcamento;
                                    context.Endereco.Add(endereco);
                                    context.SaveChanges();
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show("Cadastrado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show("Esse cliente não existe", "Error", buttons, MessageBoxIcon.Error);
                                    this.Close();
                                }
                            }
                            else
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show("Esse produto não existe", "Error", buttons, MessageBoxIcon.Error);
                                this.Close();
                            }
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

        private void txtQuantidade_ValueChanged(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                Produto produto = context.Produto.FirstOrDefault(x => x.Nome.Equals(produtosDropDown.Text));
                if (produto != null)
                {
                    double preco = Convert.ToDouble(produto.PrecoUnitario);
                    int quant = (int)txtQuantidade.Value;

                    double precoTotal = quant * preco;
                    string texto = string.Format("{0:N}", precoTotal);

                    valorTotal.Text = "Valor Total: $" + texto;
                }
            }
        }

        private void produtosDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                Produto produto = context.Produto.FirstOrDefault(x => x.Nome.Equals(produtosDropDown.Text));
                if (produto != null)
                {
                    double preco = Convert.ToDouble(produto.PrecoUnitario);
                    int quant = (int)txtQuantidade.Value;

                    double precoTotal = quant * preco;
                    string texto = string.Format("{0:N}", precoTotal);

                    valorTotal.Text = "Valor Total: $" + texto;
                }
            }
        }

        private void localEntregaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (localEntregaCheckBox.Checked)
            {
                txtRua.Enabled = false;
                txtBairro.Enabled = false;
                txtNum.Enabled = false;
                cbEstado.Enabled = false;
                txtMunicipio.Enabled = false;
                txtComplemento.Enabled = false;
            }
            else
            {
                txtRua.Enabled = true;
                txtBairro.Enabled = true;
                txtNum.Enabled = true;
                cbEstado.Enabled = true;
                txtMunicipio.Enabled = true;
                txtComplemento.Enabled = true;
            }
        }
    }
}
