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
                var query = (from mp in context.MateriaPrima
                             where mp.isAtivo == true
                             select new
                             {
                                 Nome = mp.Nome,
                                 codigo = mp.CodigoMp,
                             }).ToList();

                MpDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.MateriaPrima.Count());
            }
        }
        public void constroiGrid()
        {
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "codigo", HeaderText = "Código", Visible = true, Width = 100 });
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Matéria Prima", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from mp in context.MateriaPrima
                             where mp.isAtivo == true
                             select new
                             {
                                 Nome = mp.Nome,
                                 codigo = mp.CodigoMp,
                             }).ToList();

                MpDataGridView.DataSource = query;
            }
        }
        private void cadastroMateriaP_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
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

                                carregaGrid();
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
    }
}
