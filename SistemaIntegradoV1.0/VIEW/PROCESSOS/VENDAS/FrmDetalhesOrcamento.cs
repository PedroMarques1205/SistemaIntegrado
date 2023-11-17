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

namespace SistemaIntegradoV1._0.VIEW.Processos.VendasViews
{
    public partial class FrmDetalhesOrcamento : Form
    {

        public FrmDetalhesOrcamento(Orcamento orcamento, Cliente cliente, Endereco entrega)
        {
            InitializeComponent();
            txtRua.Text = entrega.Rua;
            txtBairro.Text = entrega.Bairro;
            txtNum.Text = Convert.ToString(entrega.Num);
            txtMunicipio.Text = entrega.Municipio;
            cbEstado.Text = entrega.Estado;
            txtComplemento.Text = entrega.Complemento;
            clientesDropdown.Text = cliente.Nome;
            dpdPagamento.Text = orcamento.formaPagamento;
            txtQuantidade.Value = Convert.ToInt32(orcamento.QuantProduto);
            produtosDropDown.Text = orcamento.Produto.Nome;
            string texto = string.Format("{0:N}", orcamento.ValorTotal);

            valorTotal.Text = "Valor Total: $" + texto;
        }

        private void informacoesOrcamento_Load(object sender, EventArgs e)
        {

        }
    }
}
