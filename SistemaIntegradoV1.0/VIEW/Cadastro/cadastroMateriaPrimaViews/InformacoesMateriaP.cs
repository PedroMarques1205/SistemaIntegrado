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

namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastroMateriaPrimaViews
{
    public partial class InformacoesMateriaP : Form
    {
        public InformacoesMateriaP(MateriaPrima mp)
        {
            InitializeComponent();
            txtNomeMP.Text = mp.Nome;
            txtCodMp.Text = mp.CodigoMp;
        }

        private void InformacoesMateriaP_Load(object sender, EventArgs e)
        {

        }
    }
}
