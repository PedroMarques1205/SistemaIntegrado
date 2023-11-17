namespace SistemaIntegradoV1._0
{
    partial class FrmListagemProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemProduto));
            this.ProdutosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.tbsCadastroProdruto = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbsDesativaProduto = new System.Windows.Forms.ToolStripButton();
            this.tbsExportExcel = new System.Windows.Forms.ToolStripButton();
            this.tbsImportarExcel = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProdutosDataGridView
            // 
            this.ProdutosDataGridView.AccessibleName = "Table";
            this.ProdutosDataGridView.AllowFiltering = true;
            this.ProdutosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProdutosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.ProdutosDataGridView.Location = new System.Drawing.Point(0, 64);
            this.ProdutosDataGridView.Name = "ProdutosDataGridView";
            this.ProdutosDataGridView.Size = new System.Drawing.Size(904, 469);
            this.ProdutosDataGridView.Style.CellStyle.Font.Size = 10F;
            this.ProdutosDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.ProdutosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.ProdutosDataGridView.TabIndex = 12;
            this.ProdutosDataGridView.Text = "sfDataGrid1";
            this.ProdutosDataGridView.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.ProdutosDataGridView_CellDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(904, 22);
            this.statusStrip1.TabIndex = 13;
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
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsCadastroProdruto,
            this.tdbRefresh,
            this.tbsDesativaProduto,
            this.tbsExportExcel,
            this.tbsImportarExcel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(904, 69);
            this.toolStrip2.TabIndex = 25;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // tbsCadastroProdruto
            // 
            this.tbsCadastroProdruto.ForeColor = System.Drawing.Color.White;
            this.tbsCadastroProdruto.Image = ((System.Drawing.Image)(resources.GetObject("tbsCadastroProdruto.Image")));
            this.tbsCadastroProdruto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsCadastroProdruto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsCadastroProdruto.Name = "tbsCadastroProdruto";
            this.tbsCadastroProdruto.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsCadastroProdruto.Size = new System.Drawing.Size(127, 66);
            this.tbsCadastroProdruto.Text = "Cadastrar Produto";
            this.tbsCadastroProdruto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsCadastroProdruto.Click += new System.EventHandler(this.tbsCadastroProdruto_Click);
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
            // tbsDesativaProduto
            // 
            this.tbsDesativaProduto.ForeColor = System.Drawing.Color.White;
            this.tbsDesativaProduto.Image = ((System.Drawing.Image)(resources.GetObject("tbsDesativaProduto.Image")));
            this.tbsDesativaProduto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsDesativaProduto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsDesativaProduto.Name = "tbsDesativaProduto";
            this.tbsDesativaProduto.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsDesativaProduto.Size = new System.Drawing.Size(125, 66);
            this.tbsDesativaProduto.Text = "Desativar Produto";
            this.tbsDesativaProduto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsDesativaProduto.Click += new System.EventHandler(this.tbsDesativaProduto_Click);
            // 
            // tbsExportExcel
            // 
            this.tbsExportExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbsExportExcel.ForeColor = System.Drawing.Color.White;
            this.tbsExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbsExportExcel.Image")));
            this.tbsExportExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsExportExcel.Margin = new System.Windows.Forms.Padding(0, 1, 30, 2);
            this.tbsExportExcel.Name = "tbsExportExcel";
            this.tbsExportExcel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsExportExcel.Size = new System.Drawing.Size(120, 66);
            this.tbsExportExcel.Text = "Exportar P/ Excel";
            this.tbsExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsExportExcel.Click += new System.EventHandler(this.tbsExportExcel_Click);
            // 
            // tbsImportarExcel
            // 
            this.tbsImportarExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbsImportarExcel.ForeColor = System.Drawing.Color.White;
            this.tbsImportarExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbsImportarExcel.Image")));
            this.tbsImportarExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsImportarExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsImportarExcel.Name = "tbsImportarExcel";
            this.tbsImportarExcel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsImportarExcel.Size = new System.Drawing.Size(107, 66);
            this.tbsImportarExcel.Text = "Importar Excel";
            this.tbsImportarExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsImportarExcel.Click += new System.EventHandler(this.tbsImportarExcel_Click);
            // 
            // cadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(904, 530);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ProdutosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroProduto";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Cadastro de Produto";
            this.Load += new System.EventHandler(this.cadastroProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid ProdutosDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton tbsCadastroProdruto;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
        private System.Windows.Forms.ToolStripButton tbsDesativaProduto;
        private System.Windows.Forms.ToolStripButton tbsExportExcel;
        private System.Windows.Forms.ToolStripButton tbsImportarExcel;
    }
}