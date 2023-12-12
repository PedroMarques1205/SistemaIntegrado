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
        public FrmDetalhes(Usuario currentUser, List<string> acessos, bool eEdicao)
        {
            InitializeComponent();
            usuario = currentUser;
            if (eEdicao == false)
            {
                txtUsuario.Enabled = false;
                txtUsuario.ReadOnly = true;
                FinanceiroCheckBox.Enabled = false;
                FabricaCheckBox.Enabled = false;
                SuprimentosCheckBox.Enabled = false;
                vendasCheckBox.Enabled = false;
            }
            txtUsuario.Text = currentUser.Login;
            foreach (string item in acessos)
            {
                if (item.Equals("FAB"))
                {
                    FabricaCheckBox.Checked = true;
                }
                if (item.Equals("VEN"))
                {
                    vendasCheckBox.Checked = true;
                }
                if (item.Equals("FIN"))
                {
                    FinanceiroCheckBox.Checked = true;
                }
                if (item.Equals("SUP"))
                {
                    SuprimentosCheckBox.Checked = true;
                }
                if (item.Equals("ADM"))
                {
                    FinanceiroCheckBox.Checked = true;
                    SuprimentosCheckBox.Checked = true;
                    vendasCheckBox.Checked = true;
                    FabricaCheckBox.Checked = true;
                }
            }
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

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {

        }
    }
}
