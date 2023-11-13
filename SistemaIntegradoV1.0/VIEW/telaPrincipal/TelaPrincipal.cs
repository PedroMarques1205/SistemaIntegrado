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
    public partial class TelaPrincipal : Form
    {
        public bool Loggof { get; set; }


        public Usuario currentUser { get; set; }


        public TelaPrincipal(Usuario usuarioLogado)
        {
            currentUser = usuarioLogado;
            InitializeComponent();
            msgBemvindo.Text = "          " + usuarioLogado.Login;
            Loggof = false;

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


        bool menuExpand = false;
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


        private void btnVendas_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            tituloSideBarTransition.Start();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinanceiro_Click(object sender, EventArgs e)
        {
            menuFinanceiroTransition.Start();
        }

        bool financeiroExpand = false;
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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            pedidoVendas tela = new pedidoVendas();

            tela.MdiParent = this;
            tela.Show();

        }

        bool cadastroTransicted = false;
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

        private void button1_Click(object sender, EventArgs e)
        {
            menuCadastroTransition.Start();
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            entrega tela = new entrega();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            cadastroCliente tela = new cadastroCliente();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            cadastroProduto tela = new cadastroProduto();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            cadastroMateriaP tela = new cadastroMateriaP();

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
            Recibos tela = new Recibos();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnProducao_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            producao tela = new producao();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnSuplimentos_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            suprimentos tela = new suprimentos();

            tela.MdiParent = this;
            tela.Show();
        }

        private void btnFaturas_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            Faturas tela = new Faturas();

            tela.MdiParent = this;
            tela.Show();
        }

        private void tabbedMDIManager1_TabControlRemoved(object sender, Syncfusion.Windows.Forms.Tools.TabbedMDITabControlEventArgs args)
        {
            engrenagens.Visible = true;
            titulo.Visible = true;
        }

        bool tituloTransicted = false;
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

        private void btnEstoques_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            estoquesProduto tela = new estoquesProduto();
            tela.MdiParent = this;
            tela.Show();
        }

        bool tituloTransiction = false;
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

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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
            cadastroUsuario tela = new cadastroUsuario();

            tela.MdiParent = this;
            tela.Show();
        }

        private void msgBemvindo_Click(object sender, EventArgs e)
        {
            informacoesUsuario tela = new informacoesUsuario(currentUser);
            tela.ShowDialog();
        }

        bool estoqueExpand = false;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            menuEstoquesTransition.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            estoquesProduto tela = new estoquesProduto();

            tela.MdiParent = this;
            tela.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            engrenagens.Visible = false;
            titulo.Visible = false;
            estoqueMaterias tela = new estoqueMaterias();

            tela.MdiParent = this;
            tela.Show();
        }
    }
}
