using SISTEMA.INTEGRADO.V1._0.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0.VIEW.cadastrosClienteViews
{
    public partial class FrmEditar : Form
    {
        public FrmEditar(string cpf,string nome,string rua, string bairro, string complemento,string municipio,string estado,int num)
        {
            InitializeComponent();
            txtCpf.Text = cpf;
            txtNomeCliente.Text = nome;
            txtRua.Text = rua;
            txtBairro.Text = bairro;
            txtComplemento.Text = complemento;
            txtMunicipio.Text = municipio;
            cbEstado.Text = estado;
            txtNum.Text = num.ToString();
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editarCliente_Load(object sender, EventArgs e)
        {
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

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
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
                        
                            Cliente cliente = context.Cliente.FirstOrDefault(c => c.CpfCliente.Equals(txtCpf.Text));

                            cliente.isAtivo = true;
                            cliente.Nome = txtNomeCliente.Text;
                            cliente.Rua = txtRua.Text;
                            cliente.Bairro = txtBairro.Text;
                            cliente.Num = Convert.ToInt32(txtNum.Text);
                            cliente.Estado = cbEstado.Text;
                            cliente.Municipio = txtMunicipio.Text;
                            cliente.Complemento = txtComplemento.Text;
                            context.Entry<Cliente>(cliente).State = EntityState.Modified;
                            context.SaveChanges();
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Editado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                            this.Close();
                        
                    }
                }
            }
            catch
            {

            }
            
        }
    }
}
