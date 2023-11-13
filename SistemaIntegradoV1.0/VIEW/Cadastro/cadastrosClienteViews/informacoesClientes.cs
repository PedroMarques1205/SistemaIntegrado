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

namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosClienteViews
{
    public partial class informacoesClientes : Form
    {
        public informacoesClientes(Cliente cliente)
        {
            InitializeComponent();
            txtBairro.Text = cliente.Bairro;
            txtComplemento.Text = cliente.Complemento;
            txtCpf.Text = cliente.CpfCliente;
            txtEstado.Text = cliente.Estado;
            txtMunicipio.Text = cliente.Municipio;
            txtNomeCliente.Text = cliente.Nome;
            txtRua.Text = cliente.Rua;
            txtNum.Text = Convert.ToString(cliente.Num);
        }

        private void informacoesClientes_Load(object sender, EventArgs e)
        {

        }
    }
}
