namespace SistemaIntegradoV1._0.VIEW.Processos.VendasViews
{
    partial class FrmDetalhesOrcamento
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalhesOrcamento));
            this.clientesDropdown = new System.Windows.Forms.ComboBox();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.txtMunicipio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.valorTotal = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.produtosDropDown = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dpdPagamento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // clientesDropdown
            // 
            this.clientesDropdown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clientesDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientesDropdown.Enabled = false;
            this.clientesDropdown.FormattingEnabled = true;
            this.clientesDropdown.Location = new System.Drawing.Point(10, 56);
            this.clientesDropdown.Name = "clientesDropdown";
            this.clientesDropdown.Size = new System.Drawing.Size(318, 21);
            this.clientesDropdown.TabIndex = 70;
            // 
            // cbEstado
            // 
            this.cbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstado.Enabled = false;
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.cbEstado.Location = new System.Drawing.Point(488, 312);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(169, 21);
            this.cbEstado.TabIndex = 68;
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.BackColor = System.Drawing.Color.White;
            this.txtMunicipio.Enabled = false;
            this.txtMunicipio.Location = new System.Drawing.Point(211, 312);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.MaxLength = 40;
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(270, 20);
            this.txtMunicipio.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(7, 291);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 17);
            this.label9.TabIndex = 65;
            this.label9.Text = "Complemento: *";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(208, 291);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 66;
            this.label8.Text = "Municipio: *";
            // 
            // txtComplemento
            // 
            this.txtComplemento.BackColor = System.Drawing.Color.White;
            this.txtComplemento.Enabled = false;
            this.txtComplemento.Location = new System.Drawing.Point(10, 312);
            this.txtComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.txtComplemento.MaxLength = 40;
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(190, 20);
            this.txtComplemento.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(483, 291);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 17);
            this.label7.TabIndex = 63;
            this.label7.Text = "Estado: *";
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.White;
            this.txtNum.Enabled = false;
            this.txtNum.Location = new System.Drawing.Point(353, 264);
            this.txtNum.Margin = new System.Windows.Forms.Padding(4);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(75, 20);
            this.txtNum.TabIndex = 62;
            // 
            // txtRua
            // 
            this.txtRua.BackColor = System.Drawing.Color.White;
            this.txtRua.Enabled = false;
            this.txtRua.Location = new System.Drawing.Point(10, 264);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(332, 20);
            this.txtRua.TabIndex = 61;
            // 
            // txtBairro
            // 
            this.txtBairro.BackColor = System.Drawing.Color.White;
            this.txtBairro.Enabled = false;
            this.txtBairro.Location = new System.Drawing.Point(436, 264);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(221, 20);
            this.txtBairro.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(353, 243);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 59;
            this.label6.Text = "Num: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 264);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Rua: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(433, 243);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 57;
            this.label3.Text = "Bairro: *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(8, 204);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 25);
            this.label10.TabIndex = 56;
            this.label10.Text = "Local de Entrega";
            // 
            // valorTotal
            // 
            this.valorTotal.AutoSize = true;
            this.valorTotal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.valorTotal.ForeColor = System.Drawing.Color.Green;
            this.valorTotal.Location = new System.Drawing.Point(548, 9);
            this.valorTotal.Name = "valorTotal";
            this.valorTotal.Size = new System.Drawing.Size(109, 17);
            this.valorTotal.TabIndex = 55;
            this.valorTotal.Text = "Valor Total: $0,00";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Enabled = false;
            this.txtQuantidade.Location = new System.Drawing.Point(391, 124);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(269, 20);
            this.txtQuantidade.TabIndex = 54;
            // 
            // produtosDropDown
            // 
            this.produtosDropDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.produtosDropDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.produtosDropDown.Enabled = false;
            this.produtosDropDown.FormattingEnabled = true;
            this.produtosDropDown.Location = new System.Drawing.Point(334, 56);
            this.produtosDropDown.Name = "produtosDropDown";
            this.produtosDropDown.Size = new System.Drawing.Size(326, 21);
            this.produtosDropDown.TabIndex = 53;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(7, 104);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "Forma de pagamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(388, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Quantidade desejada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(331, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 49;
            this.label2.Text = "Produto pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Cliente:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(7, 243);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 71;
            this.label12.Text = "Rua: *";
            // 
            // dpdPagamento
            // 
            this.dpdPagamento.BackColor = System.Drawing.Color.White;
            this.dpdPagamento.Enabled = false;
            this.dpdPagamento.Location = new System.Drawing.Point(10, 125);
            this.dpdPagamento.Margin = new System.Windows.Forms.Padding(4);
            this.dpdPagamento.Name = "dpdPagamento";
            this.dpdPagamento.Size = new System.Drawing.Size(374, 20);
            this.dpdPagamento.TabIndex = 73;
            // 
            // informacoesOrcamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(673, 360);
            this.Controls.Add(this.dpdPagamento);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clientesDropdown);
            this.Controls.Add(this.cbEstado);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtComplemento);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.valorTotal);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.produtosDropDown);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informacoesOrcamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Orçamento";
            this.Load += new System.EventHandler(this.informacoesOrcamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clientesDropdown;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.TextBox txtMunicipio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label valorTotal;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.ComboBox produtosDropDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox dpdPagamento;
    }
}