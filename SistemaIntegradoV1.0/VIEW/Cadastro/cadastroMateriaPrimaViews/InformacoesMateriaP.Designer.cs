namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastroMateriaPrimaViews
{
    partial class InformacoesMateriaP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformacoesMateriaP));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeMP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodMp = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(8, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome Matéria :";
            // 
            // txtNomeMP
            // 
            this.txtNomeMP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNomeMP.Enabled = false;
            this.txtNomeMP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeMP.Location = new System.Drawing.Point(12, 61);
            this.txtNomeMP.Name = "txtNomeMP";
            this.txtNomeMP.Size = new System.Drawing.Size(236, 25);
            this.txtNomeMP.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(250, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código Matéria :";
            // 
            // txtCodMp
            // 
            this.txtCodMp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodMp.Enabled = false;
            this.txtCodMp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodMp.Location = new System.Drawing.Point(254, 61);
            this.txtCodMp.Name = "txtCodMp";
            this.txtCodMp.Size = new System.Drawing.Size(140, 25);
            this.txtCodMp.TabIndex = 4;
            // 
            // InformacoesMateriaP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(406, 152);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodMp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeMP);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InformacoesMateriaP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações Matéria";
            this.Load += new System.EventHandler(this.InformacoesMateriaP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeMP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodMp;
    }
}