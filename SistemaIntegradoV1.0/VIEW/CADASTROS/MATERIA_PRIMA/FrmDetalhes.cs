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
    public partial class FrmDetalhes : Form
    {
        public FrmDetalhes(MateriaPrima mp)
        {
            InitializeComponent();
            txtNomeMP.Text = mp.Nome;
            txtCodMp.Text = mp.CodigoMp;
        }
    }
}
