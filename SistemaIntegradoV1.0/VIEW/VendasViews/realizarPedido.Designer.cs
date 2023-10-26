namespace SistemaIntegradoV1._0
{
    partial class realizarPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(realizarPedido));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dpdPagamento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCpfCliente = new System.Windows.Forms.MaskedTextBox();
            this.produtosDropDown = new System.Windows.Forms.ComboBox();
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(9, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "CPF do Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(137, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Produto pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(193, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantidade desejada:";
            // 
            // dpdPagamento
            // 
            this.dpdPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpdPagamento.FormattingEnabled = true;
            this.dpdPagamento.Location = new System.Drawing.Point(12, 118);
            this.dpdPagamento.Name = "dpdPagamento";
            this.dpdPagamento.Size = new System.Drawing.Size(178, 21);
            this.dpdPagamento.TabIndex = 23;
            this.dpdPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpdPagamento_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(9, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 17);
            this.label11.TabIndex = 24;
            this.label11.Text = "Forma de pagamento:";
            // 
            // txtCpfCliente
            // 
            this.txtCpfCliente.Location = new System.Drawing.Point(12, 52);
            this.txtCpfCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txtCpfCliente.Mask = "000.000.000-00";
            this.txtCpfCliente.Name = "txtCpfCliente";
            this.txtCpfCliente.Size = new System.Drawing.Size(121, 20);
            this.txtCpfCliente.TabIndex = 27;
            this.txtCpfCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // produtosDropDown
            // 
            this.produtosDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produtosDropDown.FormattingEnabled = true;
            this.produtosDropDown.Location = new System.Drawing.Point(140, 51);
            this.produtosDropDown.Name = "produtosDropDown";
            this.produtosDropDown.Size = new System.Drawing.Size(234, 21);
            this.produtosDropDown.TabIndex = 28;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(196, 119);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(178, 20);
            this.txtQuantidade.TabIndex = 29;
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancela.Location = new System.Drawing.Point(273, 184);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(101, 33);
            this.btnCancela.TabIndex = 31;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(166, 184);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(101, 33);
            this.btnCadastrarProduto.TabIndex = 30;
            this.btnCadastrarProduto.Text = "&Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // realizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 229);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.produtosDropDown);
            this.Controls.Add(this.txtCpfCliente);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dpdPagamento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "realizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Orçamento";
            this.Load += new System.EventHandler(this.realizarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox dpdPagamento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox txtCpfCliente;
        private System.Windows.Forms.ComboBox produtosDropDown;
        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}