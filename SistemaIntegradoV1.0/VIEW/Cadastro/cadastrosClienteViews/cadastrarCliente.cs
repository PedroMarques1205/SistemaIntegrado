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

        public bool verificaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
                else if (c is MaskedTextBox)
                {
                    MaskedTextBox textBox = c as MaskedTextBox;
                    if (!textBox.MaskCompleted)
                        return true;
                }
                else if (c is ComboBox)
                {
                    ComboBox textBox = c as ComboBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            }
            return false;
        }

        public bool verificaCpf()
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Cliente item in context.Cliente)
                {
                    if (item.CpfCliente.Equals(txtCpf.Text))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
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
                        if (verificaCpf())
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Esse cliente já existe", "Error", buttons, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Cliente cliente = new Cliente();

                            cliente.isAtivo = true;
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
                            DialogResult result = MessageBox.Show("Cadastrado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);

                            MessageBoxButtons button = MessageBoxButtons.YesNo;
                            DialogResult resul = MessageBox.Show("Deseja cadastrar outro cliente?", "Pergunta", button, MessageBoxIcon.Question);
                            if (resul == DialogResult.Yes)
                            {
                                txtCpf.Text = "";
                                txtNomeCliente.Text = "";
                                txtRua.Text = "";
                                txtBairro.Text = "";
                                txtNum.Text = "";
                                cbEstado.Text = "";
                                txtMunicipio.Text = "";
                                txtComplemento.Text = "";
                            }
                            else
                            {
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
