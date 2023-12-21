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

namespace SistemaIntegradoV1._0.VIEW.CADASTROS.USUARIOS
{
    public partial class FrmEditarUsuario : Form
    {
        public Usuario user { get; set; }
        public List<Acessos> acessosUser { get; set; }
        public FrmEditarUsuario(Usuario usuario, List<Acessos> acessos)
        {
            InitializeComponent();
            user = usuario;
            acessosUser = acessos;
            txtUsuario.Text = usuario.Login;
            foreach (Acessos item in acessos)
            {
                if (item.CodAcesso.Equals("FAB"))
                {
                    FabricaCheckBox.Checked = true;
                }
                if (item.CodAcesso.Equals("VEN"))
                {
                    vendasCheckBox.Checked = true;
                }
                if (item.CodAcesso.Equals("FIN"))
                {
                    FinanceiroCheckBox.Checked = true;
                }
                if (item.CodAcesso.Equals("SUP"))
                {
                    SuprimentosCheckBox.Checked = true;
                }
                if (item.CodAcesso.Equals("ADM"))
                {
                    FinanceiroCheckBox.Checked = true;
                    SuprimentosCheckBox.Checked = true;
                    vendasCheckBox.Checked = true;
                    FabricaCheckBox.Checked = true;
                }
            }
        }

        private void FrmEditarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsuario.Text))
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
                    List<Acessos> acessos = acessosUser;
                    Usuario usuario = context.Usuario.FirstOrDefault(x => x.Login.Equals(user.Login));

                    foreach (Acessos item in acessos) 
                    {
                        bool encontrou = false;
                        foreach (String codigo in acessosUsuario) 
                        {
                            if (item.CodAcesso.Equals(codigo))
                            {
                                encontrou = true;
                                break;
                            }
                        }
                        if (!encontrou) 
                        {
                            Acessos acessoRemovido = context.Acessos.FirstOrDefault(x => x.Login.Equals(item.Login));
                            context.Acessos.Remove(acessoRemovido);
                            context.SaveChanges();
                        }
                    }

                    //vião sistema para banco de dados
                    //nesse caso, caso não haja no banco o sistema
                    //adiciona um novo acesso
                    foreach (string codigo in acessosUsuario) 
                    {
                        bool NaoEncontrou = false;
                        foreach (Acessos item in acessos)
                        {
                            if (item.CodAcesso.Equals(codigo))
                            {
                                NaoEncontrou = true;
                                break;
                            }
                        }
                        if (!NaoEncontrou)
                        {
                            Acessos novoAcesso = new Acessos();
                            novoAcesso.Login = usuario.Login;
                            novoAcesso.CodAcesso = codigo;
                            context.Acessos.Add(novoAcesso);
                            context.SaveChanges();
                        }
                    }

                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Usuário Editado", "Sucesso", buttons, MessageBoxIcon.Information);

                    this.Close();
                }
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

    }
}
