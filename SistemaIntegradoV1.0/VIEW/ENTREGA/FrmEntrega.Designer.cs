namespace SistemaIntegradoV1._0
{
    partial class FrmEntrega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntrega));
            this.EntregasDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tbsCadastroProdruto = new System.Windows.Forms.ToolStripButton();
            this.tbsProdutoDespachado = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.EntregasDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // EntregasDataGridView
            // 
            this.EntregasDataGridView.AccessibleName = "Table";
            this.EntregasDataGridView.AllowFiltering = true;
            this.EntregasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EntregasDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.EntregasDataGridView.Location = new System.Drawing.Point(0, 61);
            this.EntregasDataGridView.Name = "EntregasDataGridView";
            this.EntregasDataGridView.Size = new System.Drawing.Size(872, 446);
            this.EntregasDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.EntregasDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.EntregasDataGridView.TabIndex = 9;
            this.EntregasDataGridView.Text = "sfDataGrid1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 485);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 20;
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
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.toolStrip3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsCadastroProdruto,
            this.tbsProdutoDespachado,
            this.tdbRefresh});
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(872, 69);
            this.toolStrip3.TabIndex = 26;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // tbsCadastroProdruto
            // 
            this.tbsCadastroProdruto.ForeColor = System.Drawing.Color.White;
            this.tbsCadastroProdruto.Image = ((System.Drawing.Image)(resources.GetObject("tbsCadastroProdruto.Image")));
            this.tbsCadastroProdruto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsCadastroProdruto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsCadastroProdruto.Name = "tbsCadastroProdruto";
            this.tbsCadastroProdruto.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsCadastroProdruto.Size = new System.Drawing.Size(130, 66);
            this.tbsCadastroProdruto.Text = "Mandar P/ Entrega";
            this.tbsCadastroProdruto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsCadastroProdruto.Click += new System.EventHandler(this.tbsEntregasAfazer_Click);
            // 
            // tbsProdutoDespachado
            // 
            this.tbsProdutoDespachado.ForeColor = System.Drawing.Color.White;
            this.tbsProdutoDespachado.Image = ((System.Drawing.Image)(resources.GetObject("tbsProdutoDespachado.Image")));
            this.tbsProdutoDespachado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsProdutoDespachado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsProdutoDespachado.Name = "tbsProdutoDespachado";
            this.tbsProdutoDespachado.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsProdutoDespachado.Size = new System.Drawing.Size(152, 66);
            this.tbsProdutoDespachado.Text = "Produtos Despachados";
            this.tbsProdutoDespachado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsProdutoDespachado.Click += new System.EventHandler(this.tbsProdutoDespachado_Click);
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
            // entrega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 507);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.EntregasDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "entrega";
            this.Text = "Entregas";
            this.Load += new System.EventHandler(this.entrega_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EntregasDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid EntregasDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tbsCadastroProdruto;
        private System.Windows.Forms.ToolStripButton tbsProdutoDespachado;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
    }
}