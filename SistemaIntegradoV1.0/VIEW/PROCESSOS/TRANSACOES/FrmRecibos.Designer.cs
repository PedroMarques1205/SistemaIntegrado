namespace SistemaIntegradoV1._0
{
    partial class FrmRecibos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRecibos));
            this.RecibosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbDarBaixaRecibo = new System.Windows.Forms.ToolStrip();
            this.tbsCadastroProdruto = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.RecibosDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tsbDarBaixaRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecibosDataGridView
            // 
            this.RecibosDataGridView.AccessibleName = "Table";
            this.RecibosDataGridView.AllowFiltering = true;
            this.RecibosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecibosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.RecibosDataGridView.Location = new System.Drawing.Point(0, 63);
            this.RecibosDataGridView.Name = "RecibosDataGridView";
            this.RecibosDataGridView.Size = new System.Drawing.Size(939, 446);
            this.RecibosDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.RecibosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.RecibosDataGridView.TabIndex = 11;
            this.RecibosDataGridView.Text = "sfDataGrid1";
            this.RecibosDataGridView.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.RecibosDataGridView_QueryRowStyle);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 14;
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
            // tsbDarBaixaRecibo
            // 
            this.tsbDarBaixaRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.tsbDarBaixaRecibo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsbDarBaixaRecibo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsCadastroProdruto,
            this.tdbRefresh});
            this.tsbDarBaixaRecibo.Location = new System.Drawing.Point(0, 0);
            this.tsbDarBaixaRecibo.Name = "tsbDarBaixaRecibo";
            this.tsbDarBaixaRecibo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsbDarBaixaRecibo.Size = new System.Drawing.Size(939, 69);
            this.tsbDarBaixaRecibo.TabIndex = 28;
            this.tsbDarBaixaRecibo.Text = "toolStrip3";
            // 
            // tbsCadastroProdruto
            // 
            this.tbsCadastroProdruto.ForeColor = System.Drawing.Color.White;
            this.tbsCadastroProdruto.Image = ((System.Drawing.Image)(resources.GetObject("tbsCadastroProdruto.Image")));
            this.tbsCadastroProdruto.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsCadastroProdruto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsCadastroProdruto.Name = "tbsCadastroProdruto";
            this.tbsCadastroProdruto.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsCadastroProdruto.Size = new System.Drawing.Size(138, 66);
            this.tbsCadastroProdruto.Text = "Dar Baixa No Recibo";
            this.tbsCadastroProdruto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsCadastroProdruto.Click += new System.EventHandler(this.tsbDarBaixaRecibo_Click);
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
            // Recibos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 521);
            this.Controls.Add(this.tsbDarBaixaRecibo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.RecibosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Recibos";
            this.Text = "Administrar Recibos";
            this.Load += new System.EventHandler(this.Recibos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RecibosDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsbDarBaixaRecibo.ResumeLayout(false);
            this.tsbDarBaixaRecibo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid RecibosDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.ToolStrip tsbDarBaixaRecibo;
        private System.Windows.Forms.ToolStripButton tbsCadastroProdruto;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
    }
}