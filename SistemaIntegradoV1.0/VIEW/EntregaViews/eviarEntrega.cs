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

namespace SistemaIntegradoV1._0
{
    public partial class eviarEntrega : Form
    {
        public eviarEntrega(int idOrcamento)
        {
            InitializeComponent();
            txtIdorcamento.Text = idOrcamento.ToString();
            dpTipoEntrega.Items.Add("Produto");
            dpTipoEntrega.Items.Add("Matéria Prima");
        }

        private void eviarEntrega_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarEntrega_Click(object sender, EventArgs e)
        {
            try 
            {
                using (ConnectionString context = new ConnectionString())
                {
                    Entrega entrega = new Entrega();
                    
                    entrega.DataEntrega = DateTime.Parse(txtDataEntrega.Text);
                    entrega.tipoEntrega = dpTipoEntrega.Text;
                    entrega.IsEntregue = false;
                    entrega.IdOrcamento = Convert.ToInt32(txtIdorcamento.Text);

                    Orcamento orcamento = new Orcamento();

                    orcamento = context.Orcamento.FirstOrDefault(o => o.idOrcamento == entrega.IdOrcamento);

                    orcamento.statusEntrega = "Aceito";

                    context.Entrega.Add(entrega);
                    context.SaveChanges();
                    context.Entry<Orcamento>(orcamento).State = EntityState.Modified;
                    context.SaveChanges();
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    DialogResult result = MessageBox.Show("Produto enviado para entrega", ":)", buttons, MessageBoxIcon.Exclamation);
                    this.Close();
                }
            }
            catch { }
        }

        private void dpTipoEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            e.Handled = true;
            
        }
    }
}
