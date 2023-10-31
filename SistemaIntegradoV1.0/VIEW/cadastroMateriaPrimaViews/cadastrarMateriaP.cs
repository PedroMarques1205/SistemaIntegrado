﻿using SISTEMA.INTEGRADO.V1._0.DAO;
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

        public bool materiaJaCadastrada()
        {
            using (ConnectionString context = new ConnectionString())
            {
                foreach (MateriaPrima item in context.MateriaPrima)
                {
                    if (txtNomeMP.Text.ToUpper().Equals(item.Nome.ToUpper()))
                    {
                        return true;
                    }
                }
                return false;
            }
        }
        public bool verificaCampos()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox textBox = c as TextBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
                else if (c is MaskedTextBox)
                {
                    MaskedTextBox textBox = c as MaskedTextBox;
                    if (!textBox.MaskCompleted)
                        return true;
                }
                else if (c is ComboBox)
                {
                    ComboBox textBox = c as ComboBox;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                        return true;
                }
            }
            return false;
        }
        private void btnCadastrarMP_Click(object sender, EventArgs e)
        {
            try
            {
                using (ConnectionString context = new ConnectionString())
                {
                    if (materiaJaCadastrada())
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        DialogResult resul = MessageBox.Show("Essa matéria já foi cadastrada!", "Error", button, MessageBoxIcon.Error);
                    }
                    else if (verificaCampos()) 
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        DialogResult resul = MessageBox.Show("Preencha todos os campos", "Error", button, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MateriaPrima mp = new MateriaPrima();
                        EstoqueMateriaPrima Estoque = new EstoqueMateriaPrima();
                        string letra = txtNomeMP.Text.ToUpper();

                        int numCodigo = 1;
                        string codeMP = letra[0] + "-";

                        foreach (MateriaPrima item in context.MateriaPrima)
                        {
                            if (item.CodigoMp[0].Equals(codeMP[0]))
                            {
                                numCodigo++;
                            }
                        }

                        string formato = codeMP + numCodigo.ToString("D4");
                        mp.Nome = txtNomeMP.Text;
                        mp.CodigoMp = formato;
                        mp.isAtivo = true;

                        context.MateriaPrima.Add(mp);
                        context.SaveChanges();

                        mp = context.MateriaPrima.Where(m => m.CodigoMp.Equals(mp.CodigoMp)).FirstOrDefault();

                        Estoque.NomeMp = mp.Nome;
                        Estoque.IdMateriaPrima = mp.idMateriaPrima;
                        Estoque.Quantidade = 0;

                        context.EstoqueMateriaPrima.Add(Estoque);
                        context.SaveChanges();
                        MessageBoxButtons buttons = MessageBoxButtons.OK;
                        DialogResult result = MessageBox.Show("Cadastrado com sucesso!", "Sucesso", buttons, MessageBoxIcon.Information);
                        this.Close();
                    }
                }
            }
            catch
            {
            }
        }

        private void cadastrarMateriaP_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomeMP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
