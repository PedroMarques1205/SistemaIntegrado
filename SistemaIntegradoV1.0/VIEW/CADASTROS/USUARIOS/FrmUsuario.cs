using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void olhoFechado_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '\0';
            olhoFechado.Visible = false;
            olhoAberto.Visible = true;
        }

        private void olhoAberto_Click(object sender, EventArgs e)
        {
            txtSenha.PasswordChar = '*';
            olhoFechado.Visible = true;
            olhoAberto.Visible = false;
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text) || string.IsNullOrEmpty(txtUsuario.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Preencha todos os campos", "Error", buttons, MessageBoxIcon.Error);
            }
            else if (!FinanceiroCheckBox.Checked && !FabricaCheckBox.Checked && !SuprimentosCheckBox.Checked && !vendasCheckBox.Checked)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Preencha todos os campos", "Error", buttons, MessageBoxIcon.Error);
            }
            else
            {
                using (ConnectionString context = new ConnectionString())
                {
                    List<string> acessosUsuario = new List<string>();
                    tipoAcesso(acessosUsuario);
                    //TipoAcesso acesso = context.TipoAcesso.FirstOrDefault(x => x.CodTipoAcesso.Equals(codigoAceso));
                    Usuario usuario = new Usuario();
                    usuario.Login = txtUsuario.Text;
                    usuario.Senha = Criptografia.Encrypt(txtSenha.Text);
                    //usuario.CodTipoAcesso = acesso.CodTipoAcesso;
                    usuario.EstaAtivo = true;
                    context.Usuario.Add(usuario);
                    context.SaveChanges();

                    foreach (string item in acessosUsuario) 
                    {
                        Acessos acessos = new Acessos();
                        acessos.Login = usuario.Login;
                        acessos.CodAcesso = item;
                        context.Acessos.Add(acessos);
                        context.SaveChanges();
                    }
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Novo usuário cadastrado", "Sucesso", buttons, MessageBoxIcon.Information);

                    txtSenha.Text = "";
                    txtUsuario.Text = "";
                    vendasCheckBox.Checked = false;
                    FinanceiroCheckBox.Checked  = false;
                    FabricaCheckBox.Checked = false;
                    SuprimentosCheckBox.Checked = false;
               }
            }
        }

        private void vendasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (vendasCheckBox.Checked)
            {
                FinanceiroCheckBox.Checked = false;
                SuprimentosCheckBox.Checked = false;
                FabricaCheckBox.Checked = false;
            }
        }

        private void FinanceiroCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FinanceiroCheckBox.Checked)
            {
                vendasCheckBox.Checked = false;
                SuprimentosCheckBox.Checked = false;
                FabricaCheckBox.Checked = false;
            }
        }

        private void SuprimentosCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SuprimentosCheckBox.Checked)
            {
                vendasCheckBox.Checked = false;
                FinanceiroCheckBox.Checked  = false;
                FabricaCheckBox.Checked = false;
            }
        }

        private void FabricaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (FabricaCheckBox.Checked)
            {
                vendasCheckBox.Checked = false;
                FinanceiroCheckBox.Checked  = false;
                SuprimentosCheckBox.Checked  = false;
            }
        }

        public void tipoAcesso(List<string> acessosUsuario) 
        {
            if (vendasCheckBox.Checked)
            {
                acessosUsuario.Add("VEN");
            }
            if (SuprimentosCheckBox.Checked)
            {
                acessosUsuario.Add("SUP");
            }
            if (FinanceiroCheckBox.Checked)
            {
                acessosUsuario.Add("FIN");
            }
            if (FabricaCheckBox.Checked)
            {
                acessosUsuario.Add("FAB");
            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
