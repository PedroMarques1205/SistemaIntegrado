namespace SistemaIntegradoV1._0
{
    partial class FrmProducao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProducao));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnRealizarPedido = new System.Windows.Forms.ToolStripButton();
            this.tsbMandarParaProducao = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizarProducao = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            this.ProducaoDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProducaoDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnRealizarPedido,
            this.tsbMandarParaProducao,
            this.btnFinalizarProducao,
            this.tdbRefresh});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(928, 69);
            this.toolStrip2.TabIndex = 22;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnRealizarPedido
            // 
            this.btnRealizarPedido.ForeColor = System.Drawing.Color.White;
            this.btnRealizarPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnRealizarPedido.Image")));
            this.btnRealizarPedido.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRealizarPedido.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRealizarPedido.Name = "btnRealizarPedido";
            this.btnRealizarPedido.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.btnRealizarPedido.Size = new System.Drawing.Size(111, 66);
            this.btnRealizarPedido.Text = "Realizar Pedido";
            this.btnRealizarPedido.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRealizarPedido.Click += new System.EventHandler(this.btnRealizarPedido_Click);
            // 
            // tsbMandarParaProducao
            // 
            this.tsbMandarParaProducao.ForeColor = System.Drawing.Color.White;
            this.tsbMandarParaProducao.Image = ((System.Drawing.Image)(resources.GetObject("tsbMandarParaProducao.Image")));
            this.tsbMandarParaProducao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbMandarParaProducao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbMandarParaProducao.Name = "tsbMandarParaProducao";
            this.tsbMandarParaProducao.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tsbMandarParaProducao.Size = new System.Drawing.Size(132, 66);
            this.tsbMandarParaProducao.Text = "Enviar P/ Produção";
            this.tsbMandarParaProducao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbMandarParaProducao.Click += new System.EventHandler(this.tsbMandarParaProducao_Click);
            // 
            // btnFinalizarProducao
            // 
            this.btnFinalizarProducao.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarProducao.Image = ((System.Drawing.Image)(resources.GetObject("btnFinalizarProducao.Image")));
            this.btnFinalizarProducao.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFinalizarProducao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizarProducao.Name = "btnFinalizarProducao";
            this.btnFinalizarProducao.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.btnFinalizarProducao.Size = new System.Drawing.Size(128, 66);
            this.btnFinalizarProducao.Text = "Finalizar Produção";
            this.btnFinalizarProducao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFinalizarProducao.Click += new System.EventHandler(this.btnFinalizarProducao_Click);
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
            // ProducaoDataGridView
            // 
            this.ProducaoDataGridView.AccessibleName = "Table";
            this.ProducaoDataGridView.AllowFiltering = true;
            this.ProducaoDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.ProducaoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProducaoDataGridView.EnableDataVirtualization = true;
            this.ProducaoDataGridView.Location = new System.Drawing.Point(0, 69);
            this.ProducaoDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.ProducaoDataGridView.Name = "ProducaoDataGridView";
            this.ProducaoDataGridView.Size = new System.Drawing.Size(928, 439);
            this.ProducaoDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.ProducaoDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.ProducaoDataGridView.TabIndex = 23;
            this.ProducaoDataGridView.Text = "sfDataGrid1";
            this.ProducaoDataGridView.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.ProducaoDataGridView_QueryRowStyle);
            // 
            // registrosLabel
            // 
            this.registrosLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrosLabel.ForeColor = System.Drawing.Color.White;
            this.registrosLabel.Name = "registrosLabel";
            this.registrosLabel.Size = new System.Drawing.Size(146, 17);
            this.registrosLabel.Text = "Registros Encontrados: 0";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(928, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // producao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 530);
            this.Controls.Add(this.ProducaoDataGridView);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "producao";
            this.Text = "Produção";
            this.Load += new System.EventHandler(this.producao_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProducaoDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnFinalizarProducao;
        private System.Windows.Forms.ToolStripButton btnRealizarPedido;
        private System.Windows.Forms.ToolStripButton tsbMandarParaProducao;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
        private Syncfusion.WinForms.DataGrid.SfDataGrid ProducaoDataGridView;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}