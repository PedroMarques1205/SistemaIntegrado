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

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from usuario in context.Usuario
                             select new
                             {
                                 login = usuario.Login,
                                 area = usuario.TipoAcesso.TipoAcesso1
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
                                 area = usuario.TipoAcesso.TipoAcesso1
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

        }
    }
}
