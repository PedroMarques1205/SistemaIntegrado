namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews
{
    partial class FrmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuario));
            this.btnCancela = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.FabricaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuprimentosCheckBox = new System.Windows.Forms.CheckBox();
            this.FinanceiroCheckBox = new System.Windows.Forms.CheckBox();
            this.vendasCheckBox = new System.Windows.Forms.CheckBox();
            this.olhoAberto = new System.Windows.Forms.PictureBox();
            this.olhoFechado = new System.Windows.Forms.PictureBox();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olhoAberto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.olhoFechado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancela
            // 
            this.btnCancela.BackColor = System.Drawing.SystemColors.Control;
            this.btnCancela.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancela.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancela.Location = new System.Drawing.Point(432, 171);
            this.btnCancela.Name = "btnCancela";
            this.btnCancela.Size = new System.Drawing.Size(101, 33);
            this.btnCancela.TabIndex = 33;
            this.btnCancela.Text = "&Cancelar";
            this.btnCancela.UseVisualStyleBackColor = false;
            this.btnCancela.Click += new System.EventHandler(this.btnCancela_Click);
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.BackColor = System.Drawing.SystemColors.Control;
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnCadastrarProduto.Location = new System.Drawing.Point(325, 171);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(101, 33);
            this.btnCadastrarProduto.TabIndex = 32;
            this.btnCadastrarProduto.Text = "&Cadastrar";
            this.btnCadastrarProduto.UseVisualStyleBackColor = false;
            this.btnCadastrarProduto.Click += new System.EventHandler(this.btnCadastrarProduto_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Location = new System.Drawing.Point(13, 36);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(251, 20);
            this.txtUsuario.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Usuário: *";
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.White;
            this.txtSenha.Location = new System.Drawing.Point(13, 109);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(251, 20);
            this.txtSenha.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "Senha: *";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.FabricaCheckBox);
            this.groupBox.Controls.Add(this.SuprimentosCheckBox);
            this.groupBox.Controls.Add(this.FinanceiroCheckBox);
            this.groupBox.Controls.Add(this.vendasCheckBox);
            this.groupBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox.Location = new System.Drawing.Point(325, 15);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(208, 134);
            this.groupBox.TabIndex = 44;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Setor: *";
            // 
            // FabricaCheckBox
            // 
            this.FabricaCheckBox.AutoSize = true;
            this.FabricaCheckBox.Location = new System.Drawing.Point(6, 105);
            this.FabricaCheckBox.Name = "FabricaCheckBox";
            this.FabricaCheckBox.Size = new System.Drawing.Size(91, 21);
            this.FabricaCheckBox.TabIndex = 3;
            this.FabricaCheckBox.Text = "Fabricação";
            this.FabricaCheckBox.UseVisualStyleBackColor = true;
            // 
            // SuprimentosCheckBox
            // 
            this.SuprimentosCheckBox.AutoSize = true;
            this.SuprimentosCheckBox.Location = new System.Drawing.Point(6, 78);
            this.SuprimentosCheckBox.Name = "SuprimentosCheckBox";
            this.SuprimentosCheckBox.Size = new System.Drawing.Size(104, 21);
            this.SuprimentosCheckBox.TabIndex = 2;
            this.SuprimentosCheckBox.Text = "Suprimentos";
            this.SuprimentosCheckBox.UseVisualStyleBackColor = true;
            // 
            // FinanceiroCheckBox
            // 
            this.FinanceiroCheckBox.AutoSize = true;
            this.FinanceiroCheckBox.Location = new System.Drawing.Point(6, 51);
            this.FinanceiroCheckBox.Name = "FinanceiroCheckBox";
            this.FinanceiroCheckBox.Size = new System.Drawing.Size(89, 21);
            this.FinanceiroCheckBox.TabIndex = 1;
            this.FinanceiroCheckBox.Text = "Financeiro";
            this.FinanceiroCheckBox.UseVisualStyleBackColor = true;
            // 
            // vendasCheckBox
            // 
            this.vendasCheckBox.AutoSize = true;
            this.vendasCheckBox.Location = new System.Drawing.Point(6, 24);
            this.vendasCheckBox.Name = "vendasCheckBox";
            this.vendasCheckBox.Size = new System.Drawing.Size(70, 21);
            this.vendasCheckBox.TabIndex = 0;
            this.vendasCheckBox.Text = "Vendas";
            this.vendasCheckBox.UseVisualStyleBackColor = true;
            // 
            // olhoAberto
            // 
            this.olhoAberto.Image = ((System.Drawing.Image)(resources.GetObject("olhoAberto.Image")));
            this.olhoAberto.Location = new System.Drawing.Point(271, 109);
            this.olhoAberto.Name = "olhoAberto";
            this.olhoAberto.Size = new System.Drawing.Size(21, 20);
            this.olhoAberto.TabIndex = 46;
            this.olhoAberto.TabStop = false;
            this.olhoAberto.Visible = false;
            this.olhoAberto.Click += new System.EventHandler(this.olhoAberto_Click);
            // 
            // olhoFechado
            // 
            this.olhoFechado.Image = ((System.Drawing.Image)(resources.GetObject("olhoFechado.Image")));
            this.olhoFechado.Location = new System.Drawing.Point(271, 109);
            this.olhoFechado.Name = "olhoFechado";
            this.olhoFechado.Size = new System.Drawing.Size(21, 20);
            this.olhoFechado.TabIndex = 45;
            this.olhoFechado.TabStop = false;
            this.olhoFechado.Click += new System.EventHandler(this.olhoFechado_Click);
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(545, 216);
            this.Controls.Add(this.olhoAberto);
            this.Controls.Add(this.olhoFechado);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancela);
            this.Controls.Add(this.btnCadastrarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Usuário";
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.olhoAberto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.olhoFechado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancela;
        private System.Windows.Forms.Button btnCadastrarProduto;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.PictureBox olhoFechado;
        private System.Windows.Forms.PictureBox olhoAberto;
        private System.Windows.Forms.CheckBox FabricaCheckBox;
        private System.Windows.Forms.CheckBox SuprimentosCheckBox;
        private System.Windows.Forms.CheckBox FinanceiroCheckBox;
        private System.Windows.Forms.CheckBox vendasCheckBox;
    }
}