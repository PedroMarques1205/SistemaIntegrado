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

namespace SistemaIntegradoV1._0.VIEW.estoquesViews
{
    public partial class estoqueMaterias : Form
    {
        public estoqueMaterias()
        {
            InitializeComponent();
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {
                var queryMP = (from estoque in context.EstoqueMateriaPrima
                               where estoque.MateriaPrima.isAtivo == true
                               select new
                               {
                                   materia = estoque.NomeMp,
                                   quantidade = estoque.Quantidade,
                               }).ToList();

                materiaDataGridViewe.DataSource = queryMP;
            }
        }

        public void ConstroiGrid()
        {
            materiaDataGridViewe.Columns.Add(new GridTextColumn() { MappingName = "materia", HeaderText = "Matéria Prima", Visible = true});
            materiaDataGridViewe.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "Quantidade", Visible = true, Width = 300 });
            using (ConnectionString context = new ConnectionString())
            {
                var query = (from estoque in context.EstoqueMateriaPrima
                             where estoque.MateriaPrima.isAtivo == true
                             select new
                             {
                                 materia = estoque.NomeMp,
                                 quantidade = estoque.Quantidade,
                             }).ToList();

                materiaDataGridViewe.DataSource = query;
            }
        }

        private void estoqueMaterias_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            ConstroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }
    }
}
