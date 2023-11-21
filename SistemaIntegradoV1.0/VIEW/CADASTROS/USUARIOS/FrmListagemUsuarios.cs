using SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews;
using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosProdutoViews;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Contexts;

namespace SistemaIntegradoV1._0.VIEW.Cadastro
{
    public partial class FrmListagemUsuarios : Form
    {
        public FrmListagemUsuarios()
        {
            InitializeComponent();
        }

        public void constroiGrid()
        {
            UsuariosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "login", HeaderText = "Login", Visible = true });
            UsuariosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "area", HeaderText = "Área", Visible = true });
            UsuariosDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "ativo", HeaderText = "Está Ativo?", Visible = true, Width = 150 });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from usuario in context.Usuario
                             select new
                             {
                                 login = usuario.Login,
                                 area = usuario.TipoAcesso.TipoAcesso1,
                                 ativo = usuario.EstaAtivo
                             }).ToList();
                UsuariosDataGridView.DataSource = query;
            }
        }
        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from usuario in context.Usuario
                             select new
                             {
                                 login = usuario.Login,
                                 area = usuario.TipoAcesso.TipoAcesso1,
                                 ativo = usuario.EstaAtivo
                             }).ToList();
                UsuariosDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(query.Count());
            }

        }

        private void tbsCadastroUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario tela = new FrmUsuario();
            tela.ShowDialog();
            carregaGrid();
        }

        private void cadastroUsuario_Load(object sender, EventArgs e)
        {
            constroiGrid();
            carregaGrid();
        }

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            carregaGrid();
        }

        private void tbsInativarUsuario_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = UsuariosDataGridView.SelectedItem;

                string login = Convert.ToString(linhaSelecionada.GetType().GetProperty("login").GetValue(linhaSelecionada, null));

                using (ConnectionString context = new ConnectionString()) 
                {
                    Usuario user = context.Usuario.FirstOrDefault(x => x.Login.Equals(login));
                    user.EstaAtivo = false;
                    context.Entry<Usuario>(user).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Usuário Inativado", "Sucesso", buttons, MessageBoxIcon.Information);
                    carregaGrid();
                }
            }
        }

        private void tbsReativarUsuario_Click(object sender, EventArgs e)
        {
            if (UsuariosDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = UsuariosDataGridView.SelectedItem;

                string login = Convert.ToString(linhaSelecionada.GetType().GetProperty("login").GetValue(linhaSelecionada, null));

                using (ConnectionString context = new ConnectionString())
                {
                    Usuario user = context.Usuario.FirstOrDefault(x => x.Login.Equals(login));
                    user.EstaAtivo = true;
                    context.Entry<Usuario>(user).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show("Usuário Reativado", "Sucesso", buttons, MessageBoxIcon.Information);
                    carregaGrid();
                }
            }
        }
    }
}
