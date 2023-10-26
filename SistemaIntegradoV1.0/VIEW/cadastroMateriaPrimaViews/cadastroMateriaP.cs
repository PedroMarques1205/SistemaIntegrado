using SISTEMA.INTEGRADO.V1._0.DAO;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                             select new
                             {
                                 idMateria = mp.idMateriaPrima,
                                 Nome = mp.Nome,
                                 codigo = mp.CodigoMp,
                             }).ToList();

                MpDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.MateriaPrima.Count());
            }
        }
        public void constroiGrid()
        {
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idMateria", HeaderText = "ID Matéria", Visible = true, Width = 100 });
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Matéria Prima", Visible = true });
            MpDataGridView.Columns.Add(new GridTextColumn() { MappingName = "codigo", HeaderText = "Código", Visible = true });

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from mp in context.MateriaPrima
                             select new
                             {
                                 idMateria = mp.idMateriaPrima,
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
    }
}
