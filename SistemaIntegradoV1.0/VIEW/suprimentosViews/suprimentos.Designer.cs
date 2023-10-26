namespace SistemaIntegradoV1._0
{
    partial class suprimentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(suprimentos));
            this.PedidosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.tbsCadastroProdruto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.AccessibleName = "Table";
            this.PedidosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PedidosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.PedidosDataGridView.Location = new System.Drawing.Point(0, 64);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.Size = new System.Drawing.Size(826, 443);
            this.PedidosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.PedidosDataGridView.TabIndex = 10;
            this.PedidosDataGridView.Text = "sfDataGrid1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 507);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(826, 22);
            this.statusStrip1.TabIndex = 21;
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
            this.toolStripButton2});
            this.toolStrip3.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip3.Location = new System.Drawing.Point(0, 0);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(826, 69);
            this.toolStrip3.TabIndex = 27;
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
            this.tbsCadastroProdruto.Size = new System.Drawing.Size(163, 66);
            this.tbsCadastroProdruto.Text = "Enviar P/ Um Fornecedor";
            this.tbsCadastroProdruto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsCadastroProdruto.Click += new System.EventHandler(this.tbsEntregasAfazer_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.toolStripButton2.Size = new System.Drawing.Size(107, 66);
            this.toolStripButton2.Text = "Setar Entregue";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // suprimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(826, 529);
            this.Controls.Add(this.toolStrip3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.PedidosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "suprimentos";
            this.Text = "Suprimentos";
            this.Load += new System.EventHandler(this.suprimentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid PedidosDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton tbsCadastroProdruto;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
    }
}