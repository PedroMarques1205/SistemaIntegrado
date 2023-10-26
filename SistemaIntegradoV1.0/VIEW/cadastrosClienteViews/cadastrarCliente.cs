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
    public partial class cadastrarCliente : Form
    {
        public cadastrarCliente()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    Cliente cliente = new Cliente();

                    cliente.CpfCliente = txtCpf.Text;
                    cliente.Nome = txtNomeCliente.Text;
                    cliente.Rua = txtRua.Text;
                    cliente.Bairro = txtBairro.Text;
                    cliente.Num = Convert.ToInt32(txtNum.Text);
                    cliente.Estado = cbEstado.Text;
                    cliente.Municipio = txtMunicipio.Text;
                    cliente.Complemento = txtComplemento.Text;
                    context.Cliente.Add(cliente);
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Cadastrado com sucesso!", ":)", buttons, MessageBoxIcon.Information);
                }
            }
            catch
            {

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }
    }
}
