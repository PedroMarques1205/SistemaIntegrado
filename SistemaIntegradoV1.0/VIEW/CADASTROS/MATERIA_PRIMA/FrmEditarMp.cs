using SISTEMA.INTEGRADO.V1._0.DAO;
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

namespace SistemaIntegradoV1._0.VIEW.CADASTROS.MATERIA_PRIMA
{
    public partial class FrmEditarMp : Form
    {
        public MateriaPrima materia { get; set; }
        public FrmEditarMp(MateriaPrima mp)
        {
            InitializeComponent();
            txtNomeMP.Text = mp.Nome;
            materia = mp;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomeMP.Text))
            {

            }
            else 
            {
                using (ConnectionString context = new ConnectionString()) 
                {
                    MateriaPrima MateriaEditar = materia;
                    MateriaEditar.Nome = txtNomeMP.Text;
                    EstoqueMateriaPrima estoque = context.EstoqueMateriaPrima.FirstOrDefault(x => x.IdMateriaPrima.Equals(MateriaEditar.idMateriaPrima));
                    estoque.NomeMp = MateriaEditar.Nome;
                    context.Entry<MateriaPrima>(MateriaEditar).State = EntityState.Modified;
                    context.SaveChanges();
                    context.Entry<EstoqueMateriaPrima>(estoque).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Editado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                    this.Close();
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
