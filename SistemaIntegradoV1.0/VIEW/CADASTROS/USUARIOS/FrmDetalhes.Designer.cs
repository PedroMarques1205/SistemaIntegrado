namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosUsuariosViews
{
    partial class FrmDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalhes));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.FabricaCheckBox = new System.Windows.Forms.CheckBox();
            this.SuprimentosCheckBox = new System.Windows.Forms.CheckBox();
            this.FinanceiroCheckBox = new System.Windows.Forms.CheckBox();
            this.vendasCheckBox = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelMudarSenha = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FabricaCheckBox);
            this.groupBox1.Controls.Add(this.SuprimentosCheckBox);
            this.groupBox1.Controls.Add(this.FinanceiroCheckBox);
            this.groupBox1.Controls.Add(this.vendasCheckBox);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(306, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(208, 134);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setor :";
            // 
            // FabricaCheckBox
            // 
            this.FabricaCheckBox.AutoSize = true;
            this.FabricaCheckBox.Enabled = false;
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
            this.SuprimentosCheckBox.Enabled = false;
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
            this.FinanceiroCheckBox.Enabled = false;
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
            this.vendasCheckBox.Enabled = false;
            this.vendasCheckBox.Location = new System.Drawing.Point(6, 24);
            this.vendasCheckBox.Name = "vendasCheckBox";
            this.vendasCheckBox.Size = new System.Drawing.Size(70, 21);
            this.vendasCheckBox.TabIndex = 0;
            this.vendasCheckBox.Text = "Vendas";
            this.vendasCheckBox.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.txtUsuario.BackColor = System.Drawing.Color.White;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(13, 29);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(251, 25);
            this.txtUsuario.TabIndex = 46;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 8);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 45;
            this.label5.Text = "Usuário :";
            // 
            // labelMudarSenha
            // 
            this.labelMudarSenha.AutoSize = true;
            this.labelMudarSenha.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMudarSenha.ForeColor = System.Drawing.Color.Navy;
            this.labelMudarSenha.Location = new System.Drawing.Point(10, 131);
            this.labelMudarSenha.Name = "labelMudarSenha";
            this.labelMudarSenha.Size = new System.Drawing.Size(120, 15);
            this.labelMudarSenha.TabIndex = 54;
            this.labelMudarSenha.Text = "Esqueci Minha Senha";
            this.labelMudarSenha.Click += new System.EventHandler(this.labelMudarSenha_Click);
            this.labelMudarSenha.MouseHover += new System.EventHandler(this.labelMudarSenha_MouseHover);
            // 
            // informacoesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 158);
            this.Controls.Add(this.labelMudarSenha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informacoesUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Usuário";
            this.Load += new System.EventHandler(this.informacoesUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox FabricaCheckBox;
        private System.Windows.Forms.CheckBox SuprimentosCheckBox;
        private System.Windows.Forms.CheckBox FinanceiroCheckBox;
        private System.Windows.Forms.CheckBox vendasCheckBox;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelMudarSenha;
    }
}