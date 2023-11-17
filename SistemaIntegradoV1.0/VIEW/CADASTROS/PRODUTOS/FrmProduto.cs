using SISTEMA.INTEGRADO.V1._0.DAO;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaIntegradoV1._0
{
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void cadastrarProduto_Load(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                List<MateriaPrima> listaMP = context.MateriaPrima.Where(x => x.isAtivo == true).ToList();
                List<materiasQuantidade> ListaMateriaQuantidade = new List<materiasQuantidade>();

                materiasDataGrid.Columns.Add(new GridComboBoxColumn() { MappingName = "materia", HeaderText = "MP", Visible = true, AllowEditing = true, DataSource = listaMP, ValueMember = "Nome", DisplayMember = "Nome", Width = 250 });
                materiasDataGrid.Columns.Add(new GridTextColumn() { MappingName = "quantidade", HeaderText = "QTDE", Visible = true, AllowEditing = true });

                MateriasUsadasBindingSource = new BindingSource();
                MateriasUsadasBindingSource.DataSource = ListaMateriaQuantidade;
                materiasDataGrid.DataSource = MateriasUsadasBindingSource;

            }
        }

        private void btnCancela_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txtPreco.Text) || string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                return true;
            }
            return false;
        }

        public bool verificaProduto()
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (Produto item in context.Produto)
                {
                    if (item.Nome.ToUpper().Equals(txtNomeProduto.Text.ToUpper()))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public void esvaziaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.TextBox)
                {
                    System.Windows.Forms.TextBox textBox = c as System.Windows.Forms.TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        c.Text = "";
                    }

                }
                else if (c is MaskedTextBox)
                {
                    MaskedTextBox textBox = c as MaskedTextBox;
                    if (!textBox.MaskCompleted)
                    {
                    }

                }
                else if (c is System.Windows.Forms.ComboBox)
                {
                    System.Windows.Forms.ComboBox textBox = c as System.Windows.Forms.ComboBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        c.Text = "";
                    }

                }
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    if (verificaCampos())
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Preencha todos os campos", "Error", buttons, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (verificaProduto())
                        {
                            MessageBoxButtons buttons = MessageBoxButtons.OK;
                            DialogResult result = MessageBox.Show("Produto já cadastrado", "Error", buttons, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Produto produto = new Produto();
                            MateriaPrima mp = new MateriaPrima();
                            EstoqueProdutoAcabado estoque = new EstoqueProdutoAcabado();
                            MateriasUsadasNoProduto mpUsadas = new MateriasUsadasNoProduto();

                            produto.Nome = txtNomeProduto.Text;
                            produto.PrecoUnitario = Convert.ToDouble(txtPreco.Text);
                            produto.isAtivo = true;
                            if (materiasDataGrid.View.Records.Count == 0)
                            {
                                MessageBoxButtons buttons = MessageBoxButtons.OK;
                                DialogResult result = MessageBox.Show("Preencha as matérias primas", "Error", buttons, MessageBoxIcon.Error);
                            }
                            else
                            {
                                context.Produto.Add(produto);
                                context.SaveChanges();

                                produto = context.Produto.Where(p => p.Nome.Equals(produto.Nome)).FirstOrDefault();
                                estoque.NomeProduto = produto.Nome;
                                estoque.IdProduto = produto.IdProduto;
                                estoque.Quantidade = 0;
                                mpUsadas.idProduto = produto.IdProduto;
                                mpUsadas.NomeProduto = produto.Nome;
                                context.EstoqueProdutoAcabado.Add(estoque);
                                context.SaveChanges();

                                List<materiasQuantidade> lista = new List<materiasQuantidade>();

                                for (int i = 0; i < materiasDataGrid.View.Records.Count; i++)
                                {
                                    if (materiasDataGrid.View.Records[i].Data is materiasQuantidade item && item != null)
                                    {
                                        lista.Add(item);
                                    }

                                }
                                if (lista != null)
                                {
                                    foreach (materiasQuantidade item in lista)
                                    {
                                        MateriaPrima newMp = context.MateriaPrima.FirstOrDefault(m => m.Nome.Equals(item.materia));
                                        MateriasUsadasNoProduto newMpUsadas = new MateriasUsadasNoProduto();
                                        materiasQuantidade newMpQuantidade = new materiasQuantidade();
                                        newMpQuantidade.materia = item.materia;
                                        newMpQuantidade.quantidade = item.quantidade;
                                        newMpUsadas.idProduto = produto.IdProduto;
                                        newMpUsadas.NomeProduto = produto.Nome;
                                        newMpUsadas.idMateriaPrima = newMp.idMateriaPrima;
                                        newMpUsadas.NomeMp = newMp.Nome;
                                        newMpUsadas.Quantidade = newMpQuantidade.quantidade;
                                        context.MateriasUsadasNoProduto.Add(newMpUsadas);
                                        context.SaveChanges();
                                    }
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                                    DialogResult result = MessageBox.Show("Cadastrado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                                    lista.Clear();
                                    MessageBoxButtons button = MessageBoxButtons.YesNo;
                                    DialogResult resul = MessageBox.Show("Deseja cadastrar outro produto?", "Pergunta", button, MessageBoxIcon.Question);
                                    if (resul == DialogResult.Yes)
                                    {
                                        txtNomeProduto.Text = "";
                                        txtPreco.Text = "";
                                        materiasDataGrid.DataSource = lista;
                                        materiasDataGrid.AddNewRowText = "Click aqui para adicionar uma nova informação";
                                    }
                                    else
                                    {
                                        this.Close();
                                    }
                                }

                            }
                        }
                    }
                }
            }
            catch (Exception r)
            {
                var x = r;
            }
        }

        private void mpDropDown_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtPreco_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            List<materiasQuantidade> lista = new List<materiasQuantidade>();
            lista.Clear();
            materiasDataGrid.DataSource = lista;
            materiasDataGrid.AddNewRowText = "Click aqui para adicionar uma nova informação";
        }
    }
}
