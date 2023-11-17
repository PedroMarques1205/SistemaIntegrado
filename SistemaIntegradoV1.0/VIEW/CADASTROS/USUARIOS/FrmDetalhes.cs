using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.MODEL;
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

namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews
{

    public partial class FrmDetalhes : Form
    {
        public Usuario usuario { get; set; }
        public FrmDetalhes(Usuario currentUser)
        {
            InitializeComponent();
            usuario = currentUser;
            txtUsuario.ReadOnly = true;
            txtUsuario.Text = currentUser.Login;
            if (currentUser.CodTipoAcesso.Equals("FAB"))
            {
                FabricaCheckBox.Checked = true;
            }
            else if (currentUser.CodTipoAcesso.Equals("VEN"))
            {
                vendasCheckBox.Checked = true;
            }
            else if (currentUser.CodTipoAcesso.Equals("FIN"))
            {
                FinanceiroCheckBox.Checked = true;
            }
            else if (currentUser.CodTipoAcesso.Equals("SUP"))
            {
                SuprimentosCheckBox.Checked = true;
            }
            else if (currentUser.CodTipoAcesso.Equals("ADM"))
            {
                FinanceiroCheckBox.Checked = true;
                SuprimentosCheckBox.Checked = true;
                vendasCheckBox.Checked = true;
                FabricaCheckBox.Checked = true;
            }
        }

        private void informacoesUsuario_Load(object sender, EventArgs e)
        {
        }

        private void labelMudarSenha_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmMudarSenha tela = new FrmMudarSenha(usuario);
            tela.ShowDialog();
        }

        private void labelMudarSenha_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
