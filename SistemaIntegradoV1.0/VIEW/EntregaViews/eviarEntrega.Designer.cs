namespace SistemaIntegradoV1._0
{
    partial class eviarEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(eviarEntrega));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dpTipoEntrega = new System.Windows.Forms.ComboBox();
            this.txtDataEntrega = new System.Windows.Forms.MaskedTextBox();
            this.txtIdorcamento = new System.Windows.Forms.TextBox();
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(168, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data da Entrega:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "tipo de entrega";
            // 
            // dpTipoEntrega
            // 
            this.dpTipoEntrega.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dpTipoEntrega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dpTipoEntrega.FormattingEnabled = true;
            this.dpTipoEntrega.Location = new System.Drawing.Point(8, 31);
            this.dpTipoEntrega.Name = "dpTipoEntrega";
            this.dpTipoEntrega.Size = new System.Drawing.Size(157, 23);
            this.dpTipoEntrega.TabIndex = 3;
            this.dpTipoEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dpTipoEntrega_KeyPress);
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDataEntrega.Location = new System.Drawing.Point(171, 31);
            this.txtDataEntrega.Mask = "00/00/0000";
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Size = new System.Drawing.Size(135, 23);
            this.txtDataEntrega.TabIndex = 4;
            this.txtDataEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDataEntrega.ValidatingType = typeof(System.DateTime);
            // 
            // txtIdorcamento
            // 
            this.txtIdorcamento.Location = new System.Drawing.Point(12, 119);
            this.txtIdorcamento.Name = "txtIdorcamento";
            this.txtIdorcamento.Size = new System.Drawing.Size(49, 20);
            this.txtIdorcamento.TabIndex = 21;
            this.txtIdorcamento.Visible = false;
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancela.Location = new System.Drawing.Point(205, 106);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(101, 33);
            this.btnCancela.TabIndex = 23;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(98, 106);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(101, 33);
            this.btnCadastrarProduto.TabIndex = 22;
            this.btnCadastrarProduto.Text = "&Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnEnviarEntrega_Click);
            // 
            // eviarEntrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(318, 156);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.txtIdorcamento);
            this.Controls.Add(this.txtDataEntrega);
            this.Controls.Add(this.dpTipoEntrega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "eviarEntrega";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enviar Entrega";
            this.Load += new System.EventHandler(this.eviarEntrega_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox dpTipoEntrega;
        private System.Windows.Forms.MaskedTextBox txtDataEntrega;
        private System.Windows.Forms.TextBox txtIdorcamento;
        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}