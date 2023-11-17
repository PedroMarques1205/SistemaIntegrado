using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.Cadastro;
using SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews;
using SistemaIntegradoV1._0.VIEW.estoquesViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Syncfusion.Windows.Forms.Tools.MenuDropDown;

namespace SistemaIntegradoV1._0
{
    public partial class FrmTelaPrincipal : Form
    {
        public bool Loggof { get; set; }
        private bool cadastroTransicted { get; set; }
        public Usuario currentUser { get; set; }
        private bool menuExpand { get; set; }
        private bool financeiroExpand { get; set; }
        private bool tituloTransicted { get; set; }
        private bool estoqueExpand { get; set; }
        private bool tituloTransiction { get; set; }
        private bool sidebarExpand { get; set; }

        public FrmTelaPrincipal(Usuario usuarioLogado)
        {
            InitializeComponent();
            currentUser = usuarioLogado;
            Loggof = false;
            menuExpand = false;
            cadastroTransicted = false;
            financeiroExpand = false;
            tituloTransicted = false;
            estoqueExpand = false;
            tituloTransiction = false;
            sidebarExpand = true;
            msgBemvindo.Text = "          " + usuarioLogado.Login;

            if (currentUser.CodTipoAcesso.Equals("FAB"))
            {
                menuCadastro.Visible = false;
                menuContainerVendas.Visible = false;
                panel7.Visible = false;
                menuContainerFinanceiro.Visible = false;
            }
            else if (currentUser.CodTipoAcesso.Equals("VEN"))
            {
                panel16.Visible = false;
                panel12.Visible = false;
                panel13.Visible = false;
                panel6.Visible = false;
                panel7.Visible = false;
                menuContainerFinanceiro.Visible = false;
            }
            else if (currentUser.CodTipoAcesso.Equals("FIN"))
            {
                menuCadastro.Visible = false;
                menuContainerVendas.Visible = false;
                panel7.Visible = false;
                panel16.Visible = false;
                panel6.Visible = false;
            }
            else if (currentUser.CodTipoAcesso.Equals("SUP"))
            {
                menuContainerVendas.Visible = false;
                panel16.Visible = false;
                panel11.Visible = false;
                panel6.Visible = false;
                menuContainerFinanceiro.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tituloTransition.Start();
            sideBar.Width = 206;
            menuContainerVendas.Height = 39;
            menuContainerFinanceiro.Height = 39;
            menuCadastro.Height = 39;
            menuEstoques.Height = 39;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is MdiClient)
                {
                    ctrl.BackColor = Color.White;
                }
            }
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainerVendas.Height += 10;
                if (menuContainerVendas.Height >= 117)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainerVendas.Height -= 10;
                if (menuContainerVendas.Height <= 39)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sideBar.Width += 10;
                if (sideBar.Width >= 206)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
            else
            {
                sideBar.Width -= 10;
                if (sideBar.Width <= 56)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
        }
        private void menuFinanceiroTransition_Tick(object sender, EventArgs e)
        {
            if (financeiroExpand == false)
            {
                menuContainerFinanceiro.Height += 10;
                if (menuContainerFinanceiro.Height >= 117)
                {
                    menuFinanceiroTransition.Stop();
                    financeiroExpand=true;
                }
            }
            else
            {
                menuContainerFinanceiro.Height -= 10;
                if (menuContainerFinanceiro.Height <= 39)
                {
                    menuFinanceiroTransition.Stop();
                    financeiroExpand = false;
                }
            }
        }
        private void menuCadastroTransition_Tick(object sender, EventArgs e)
        {
            if (cadastroTransicted == false)
            {
                if (currentUser.CodTipoAcesso == "VEN")
                {
                    menuCadastro.Height += 10;
                    if (menuCadastro.Height >= 70)
                    {
                        menuCadastroTransition.Stop();
                        cadastroTransicted=true;
                    }
                }
                else if (currentUser.CodTipoAcesso == "SUP")
                {
                    menuCadastro.Height += 10;
                    if (menuCadastro.Height >= 110)
                    {
                        menuCadastroTransition.Stop();
                        cadastroTransicted=true;
                    }
                }
                else
                {
                    menuCadastro.Height += 10;
                    if (menuCadastro.Height >= 202)
                    {
                        menuCadastroTransition.Stop();
                        cadastroTransicted=true;
                    }
                }
            }
            else
            {
                menuCadastro.Height -= 10;
                if (menuCadastro.Height <= 39)
                {
                    menuCadastroTransition.Stop();
                    cadastroTransicted = false;
                }
            }
        }
        private void tituloSideBarTransition_Tick(object sender, EventArgs e)
        {
            if (!tituloTransicted)
            {
                titulo.Left -= 10;
                if (titulo.Location.X<=65)
                {
                    tituloSideBarTransition.Stop();
                    tituloTransicted= true;
                }
            }
            else
            {
                titulo.Left += 10;
                if (titulo.Location.X >= 222)
                {
                    tituloSideBarTransition.Stop();
                    tituloTransicted = false;
                }
            }
        }
        private void menuEstoquesTransition_Tick(object sender, EventArgs e)
        {
            if (estoqueExpand == false)
            {
                menuEstoques.Height += 10;
                if (menuEstoques.Height >= 117)
                {
                    menuEstoquesTransition.Stop();
                    estoqueExpand=true;
                }
            }
            else
            {
                menuEstoques.Height -= 10;
                if (menuEstoques.Height <= 39)
                {
                    menuEstoquesTransition.Stop();
                    estoqueExpand = false;
                }
            }
        }
        private void tituloTransition_Tick(object sender, EventArgs e)
        {
            if (!tituloTransiction)
            {
                titulo.Left -= 10;
                if (titulo.Location.X<=220)
                {
                    tituloTransition.Stop();
                    tituloTransiction= true;
                }
            }
        }
        private void btnVendas_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            tituloSideBarTransition.Start();
        }
        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            menuFinanceiroTransition.Start();
        }
        private void btnPedidos_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmListagemOrcamentos tela = new FrmListagemOrcamentos();

            tela.MdiParent = this;
            tela.Show();

        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmEntrega tela = new FrmEntrega();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmListagemCliente tela = new FrmListagemCliente();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmListagemProduto tela = new FrmListagemProduto();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmListagemMateria tela = new FrmListagemMateria();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            menuCadastroTransition.Start();
        }

        private void btnRecibos_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmRecibos tela = new FrmRecibos();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmProducao tela = new FrmProducao();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnSuplimentos_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmSuprimentos tela = new FrmSuprimentos();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmFaturas tela = new FrmFaturas();

            tela.MdiParent = this;
            tela.Show();
        }

        private void tabbedMDIManager1_TabControlRemoved(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            engrenagens.Visible = true;
            titulo.Visible = true;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Loggof = true;
            this.Close();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmListagemUsuarios tela = new FrmListagemUsuarios();

            tela.MdiParent = this;
            tela.Show();
        }

        private void msgBemvindo_Click(object sender, EventArgs e)
        {
            FrmDetalhes tela = new FrmDetalhes(currentUser);
            tela.ShowDialog();
        }


        private void btnEstoque_Click(object sender, EventArgs e)
        {
            menuEstoquesTransition.Start();
        }

        private void btnEstoqueProdutos_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmEstoquesProduto tela = new FrmEstoquesProduto();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnEstoqueMp_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            FrmEstoqueMaterias tela = new FrmEstoqueMaterias();

            tela.MdiParent = this;
            tela.Show();
        }
    }
}
