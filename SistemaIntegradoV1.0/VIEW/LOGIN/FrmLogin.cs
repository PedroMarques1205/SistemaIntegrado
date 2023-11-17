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

namespace SistemaIntegradoV1._0.VIEW.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (String.IsNullOrEmpty(txtLogin.Text) || String.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("Preencha todos os campos", "Atenção", buttons, MessageBoxIcon.Warning);
                txtSenha.BackColor = Color.White;
                txtLogin.BackColor = Color.White;
            }
            else
            {
                string senhaNovaa = Criptografia.Encrypt("Saetowers2023@");
                using (ConnectionString context = new ConnectionString())
                {
                    Usuario usuario = context.Usuario.FirstOrDefault(x => x.Login.Equals(txtLogin.Text));

                    if (usuario == null)
                    {
                        Cursor.Current = Cursors.Default;
                        txtSenha.Text = "";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        MessageBox.Show("Usuário Inexistente", "Error", buttons, MessageBoxIcon.Error);
                        txtSenha.BackColor = Color.White;
                        txtLogin.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        string senha = Criptografia.Encrypt(txtSenha.Text);
                        if (usuario.Senha.Equals(senha))
                        {
                            this.Hide();
                            Cursor.Current = Cursors.Default;
                            FrmTelaPrincipal main = new FrmTelaPrincipal(usuario);
                            main.ShowDialog();

                            if (main.Loggof)
                            {
                                txtLogin.Text = "";
                                txtSenha.Text = "";
                                this.Show();
                                txtSenha.BackColor = Color.White;
                                txtLogin.BackColor = Color.White;
                            }
                            else
                            {
                                Application.Exit();
                            }
                        }
                        else
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            MessageBox.Show("Senha inválida!", "Error", buttons, MessageBoxIcon.Error);
                            txtSenha.Text = "";
                            txtSenha.BackColor = Color.LightCoral;
                            txtLogin.BackColor = Color.White;
                        }
                    }
                }
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Invoke(new MethodInvoker(() => btnLogin_Click(null, null)));
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                this.Invoke(new MethodInvoker(() => btnLogin_Click(null, null)));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginView_Load(object sender, EventArgs e)
        {

        }
    }
}
