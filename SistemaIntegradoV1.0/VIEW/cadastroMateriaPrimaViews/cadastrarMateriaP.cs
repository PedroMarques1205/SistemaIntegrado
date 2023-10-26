using SISTEMA.INTEGRADO.V1._0.DAO;
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
    public partial class cadastrarMateriaP : Form
    {
        public cadastrarMateriaP()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrarMP_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    MateriaPrima mp = new MateriaPrima();
                    EstoqueMateriaPrima Estoque = new EstoqueMateriaPrima();

                    mp.Nome = txtNomeMP.Text;
                    mp.CodigoMp = txtCodigoMP.Text;

                    context.MateriaPrima.Add(mp);
                    context.SaveChanges();

                    mp = context.MateriaPrima.Where(m => m.CodigoMp.Equals(mp.CodigoMp)).FirstOrDefault();

                    Estoque.NomeMp = mp.Nome;
                    Estoque.IdMateriaPrima = mp.idMateriaPrima;
                    Estoque.Quantidade = 0;

                    context.EstoqueMateriaPrima.Add(Estoque);
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Cadastrado com sucesso!", ":)", buttons, MessageBoxIcon.Information);

                }
            }
            catch 
            {
                
            }
        }
    }
}
