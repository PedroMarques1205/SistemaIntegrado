using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.cadastrosClienteViews;
using Syncfusion.WinForms.DataGrid;
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

namespace SistemaIntegradoV1._0
{
    public partial class cadastroMateriaP : Form
    {
        public cadastroMateriaP()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        private void tbsCadastroMateria_Click(object sender, EventArgs e)
        {
            cadastrarMateriaP tela = new cadastrarMateriaP();
            tela.ShowDialog();
            carregaGrid();
        }
        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                if (comboBoxFiltros.Text == "Ativos")
                {
                    var query = (from mp in context.MateriaPrima
                                 where mp.isAtivo == true
                                 select new
                                 {
                                     Nome = mp.Nome,
                                     codigo = mp.CodigoMp,
                                     isAtivo = mp.isAtivo
                                 }).ToList();

                    MpDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.MateriaPrima.Count());
                }
                else if (comboBoxFiltros.Text == "Desativos")
                {
                    var query = (from mp in context.MateriaPrima
                                 where mp.isAtivo == false
                                 select new
                                 {
                                     Nome = mp.Nome,
                                     codigo = mp.CodigoMp,
                                     isAtivo = mp.isAtivo
                                 }).ToList();

                    MpDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.MateriaPrima.Count());
                }
                else if (comboBoxFiltros.Text == "Todos")
                {
                    var query = (from mp in context.MateriaPrima
                                 select new
                                 {
                                     Nome = mp.Nome,
                                     codigo = mp.CodigoMp,
                                     isAtivo = mp.isAtivo
                                 }).ToList();

                    MpDataGridView.DataSource = query;
                    registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.MateriaPrima.Count());
                }
            }
        }
        public void constroiGrid()
        {
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "codigo", HeaderText = "Código", Visible = true, Width = 100 });
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Matéria Prima", Visible = true });
            MpDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "isAtivo", HeaderText = "Ativo", Visible = true, Width = 200 });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from mp in context.MateriaPrima
                             where mp.isAtivo == true
                             select new
                             {
                                 Nome = mp.Nome,
                                 codigo = mp.CodigoMp,
                                 isAtivo = mp.isAtivo
                             }).ToList();

                MpDataGridView.DataSource = query;
            }
        }
        private void cadastroMateriaP_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            comboBoxFiltros.Text = "Ativos";
            comboBoxFiltros.Items.Add("Ativos");
            comboBoxFiltros.Items.Add("Desativos");
            comboBoxFiltros.Items.Add("Todos");
            constroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void tsbDesativarMp_Click(object sender, EventArgs e)
        {
            if (MpDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = MpDataGridView.SelectedItem;

                var poggers = new MateriaPrima();

                string codigo = Convert.ToString(linhaSelecionada.GetType().GetProperty("codigo").GetValue(linhaSelecionada, null));

                using (ConnectionString context = new ConnectionString())
                {
                    MateriaPrima MateriaParaExcluir = context.MateriaPrima.FirstOrDefault(v => v.CodigoMp.Equals(codigo));
                    if (MateriaParaExcluir != null)
                    {
                        poggers = MateriaParaExcluir;
                    }
                }
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Tem Certeza que deseja inativar " + poggers.Nome + "?", "Atenção", buttons, MessageBoxIcon.Exclamation);
                if (result == DialogResult.Yes)
                {
                    if (MpDataGridView.SelectedItems.Count > 0)
                    {
                        linhaSelecionada = MpDataGridView.SelectedItem;

                        codigo = Convert.ToString(linhaSelecionada.GetType().GetProperty("codigo").GetValue(linhaSelecionada, null));

                        using (ConnectionString context = new ConnectionString())
                        {
                            MateriaPrima MateriaParaExcluir = context.MateriaPrima.FirstOrDefault(v => v.CodigoMp.Equals(codigo));
                            if (MateriaParaExcluir != null)
                            {
                                MateriaParaExcluir.isAtivo = false;
                                context.Entry<MateriaPrima>(MateriaParaExcluir).State = EntityState.Modified;
                                context.SaveChanges();

                                List<MateriasUsadasNoProduto> lista = context.MateriasUsadasNoProduto.ToList();
                                List<Produto> produtos = context.Produto.ToList();
                                foreach (MateriasUsadasNoProduto item in lista)
                                {
                                    if (item.idMateriaPrima.Equals(MateriaParaExcluir.idMateriaPrima))
                                    {
                                        context.MateriasUsadasNoProduto.Remove(item);
                                        context.SaveChanges();
                                    }
                                }
                                carregaGrid();
                            }
                        }
                        using (ConnectionString context = new ConnectionString())
                        {
                            List<MateriasUsadasNoProduto> lista = context.MateriasUsadasNoProduto.ToList();
                            List<Produto> produtos = context.Produto.ToList();
                            foreach (Produto produto in produtos)
                            {
                                int contador = 0;
                                foreach (MateriasUsadasNoProduto item in lista)
                                {
                                    if (item.idProduto.Equals(produto.IdProduto))
                                    {
                                        contador++;
                                    }
                                }
                                if (contador == 0)
                                {
                                    produto.isAtivo = false;
                                    context.Entry<Produto>(produto).State = EntityState.Modified;
                                    context.SaveChanges();
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show("Selecione a matéria que deseja inativar", "Nenhum cliente selecionado", buttons, MessageBoxIcon.Asterisk);
            }
        }

        private void comboBoxFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregaGrid();
        }
    }
}
