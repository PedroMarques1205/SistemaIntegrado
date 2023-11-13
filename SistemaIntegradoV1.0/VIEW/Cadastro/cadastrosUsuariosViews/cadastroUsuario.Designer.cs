namespace SistemaIntegradoV1._0.VIEW.Cadastro
{
    partial class cadastroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroUsuario));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbsCadastroUsuario = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbsInativarUsuario = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.UsuariosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsCadastroUsuario,
            this.tdbRefresh,
            this.tbsInativarUsuario});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(904, 69);
            this.toolStrip2.TabIndex = 28;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbsCadastroUsuario
            // 
            this.tbsCadastroUsuario.ForeColor = System.Drawing.Color.White;
            this.tbsCadastroUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tbsCadastroUsuario.Image")));
            this.tbsCadastroUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsCadastroUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsCadastroUsuario.Name = "tbsCadastroUsuario";
            this.tbsCadastroUsuario.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsCadastroUsuario.Size = new System.Drawing.Size(124, 66);
            this.tbsCadastroUsuario.Text = "Cadastrar Usuário";
            this.tbsCadastroUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsCadastroUsuario.Click += new System.EventHandler(this.tbsCadastroUsuario_Click);
            // 
            // tdbRefresh
            // 
            this.tdbRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tdbRefresh.ForeColor = System.Drawing.Color.White;
            this.tdbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tdbRefresh.Image")));
            this.tdbRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tdbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tdbRefresh.Name = "tdbRefresh";
            this.tdbRefresh.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tdbRefresh.Size = new System.Drawing.Size(77, 66);
            this.tdbRefresh.Text = "Atualizar";
            this.tdbRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tdbRefresh.Click += new System.EventHandler(this.tdbRefresh_Click);
            // 
            // tbsInativarUsuario
            // 
            this.tbsInativarUsuario.ForeColor = System.Drawing.Color.White;
            this.tbsInativarUsuario.Image = ((System.Drawing.Image)(resources.GetObject("tbsInativarUsuario.Image")));
            this.tbsInativarUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsInativarUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsInativarUsuario.Name = "tbsInativarUsuario";
            this.tbsInativarUsuario.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsInativarUsuario.Size = new System.Drawing.Size(113, 66);
            this.tbsInativarUsuario.Text = "Inativar Usuário";
            this.tbsInativarUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsInativarUsuario.Click += new System.EventHandler(this.tbsInativarUsuario_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 27;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // registrosLabel
            // 
            this.registrosLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrosLabel.ForeColor = System.Drawing.Color.White;
            this.registrosLabel.Name = "registrosLabel";
            this.registrosLabel.Size = new System.Drawing.Size(146, 17);
            this.registrosLabel.Text = "Registros Encontrados: 0";
            // 
            // UsuariosDataGridView
            // 
            this.UsuariosDataGridView.AccessibleName = "Table";
            this.UsuariosDataGridView.AllowFiltering = true;
            this.UsuariosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UsuariosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.UsuariosDataGridView.Location = new System.Drawing.Point(0, 63);
            this.UsuariosDataGridView.Name = "UsuariosDataGridView";
            this.UsuariosDataGridView.Size = new System.Drawing.Size(904, 469);
            this.UsuariosDataGridView.Style.CellStyle.Font.Size = 10F;
            this.UsuariosDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.UsuariosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.UsuariosDataGridView.TabIndex = 26;
            this.UsuariosDataGridView.Text = "sfDataGrid1";
            // 
            // cadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 530);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.UsuariosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroUsuario";
            this.Text = "Usuários";
            this.Load += new System.EventHandler(this.cadastroUsuario_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbsCadastroUsuario;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
        private System.Windows.Forms.ToolStripButton tbsInativarUsuario;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid UsuariosDataGridView;
    }
}