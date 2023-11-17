using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews
{
    public partial class FrmMudarSenha : Form
    {
        public Usuario thisUser { get; set; }
        public FrmMudarSenha(Usuario currentUser)
        {
            thisUser = currentUser;
            InitializeComponent();
        }
        private void btnEditarUsuário_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("A nova senha não pode ser nula", "Atenção", buttons, MessageBoxIcon.Error);
            }
            else if (!txtSenha.Text.Equals(txtConfirmacao.Text)) 
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show("A nova senha e a confirmação não correspondem", "Atenção", buttons, MessageBoxIcon.Error);
            }
            else
            {
                using (ConnectionString context = new ConnectionString())
                {
                    Usuario editar = context.Usuario.FirstOrDefault(u => u.Login.Equals(thisUser.Login));
                    editar.Senha = Criptografia.Encrypt(txtSenha.Text);

                    context.Entry<Usuario>(editar).State = EntityState.Modified;
                    context.SaveChanges();

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Senha editada", "Sucesso", buttons, MessageBoxIcon.Information);

                    this.Close();
                }
            }
        }
    }
}
