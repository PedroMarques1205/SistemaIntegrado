namespace SistemaIntegradoV1._0
{
    partial class FrmPedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPedido));
            this.txtQuantidade = new System.Windows.Forms.NumericUpDown();
            this.materiasDropDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).BeginInit();
            this.SuspendLayout();
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(181, 51);
            this.txtQuantidade.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.txtQuantidade.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(152, 20);
            this.txtQuantidade.TabIndex = 46;
            this.txtQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // materiasDropDown
            // 
            this.materiasDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materiasDropDown.FormattingEnabled = true;
            this.materiasDropDown.Location = new System.Drawing.Point(14, 50);
            this.materiasDropDown.Name = "materiasDropDown";
            this.materiasDropDown.Size = new System.Drawing.Size(161, 21);
            this.materiasDropDown.TabIndex = 45;
            this.materiasDropDown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materiasDropDown_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(178, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "Quantidade desejada:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "Matéria a comprar:";
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancela.Location = new System.Drawing.Point(232, 120);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(101, 33);
            this.btnCancela.TabIndex = 48;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(125, 120);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(101, 33);
            this.btnCadastrarProduto.TabIndex = 47;
            this.btnCadastrarProduto.Text = "&Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // realizarPedidoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(354, 170);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.materiasDropDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "realizarPedidoCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Pedido";
            this.Load += new System.EventHandler(this.realizarPedidoCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtQuantidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown txtQuantidade;
        private System.Windows.Forms.ComboBox materiasDropDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}