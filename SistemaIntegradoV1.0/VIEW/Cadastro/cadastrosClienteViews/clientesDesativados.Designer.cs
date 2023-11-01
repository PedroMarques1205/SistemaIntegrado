namespace SistemaIntegradoV1._0.VIEW.cadastrosClienteViews
{
    partial class clientesDesativados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(clientesDesativados));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnReativarCliente = new System.Windows.Forms.ToolStripButton();
            this.DesativadosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesativadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnReativarCliente});
            this.toolStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(800, 69);
            this.toolStrip2.TabIndex = 25;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnReativarCliente
            // 
            this.btnReativarCliente.ForeColor = System.Drawing.Color.White;
            this.btnReativarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnReativarCliente.Image")));
            this.btnReativarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnReativarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReativarCliente.Name = "btnReativarCliente";
            this.btnReativarCliente.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.btnReativarCliente.Size = new System.Drawing.Size(113, 66);
            this.btnReativarCliente.Text = "Reativar Cliente";
            this.btnReativarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReativarCliente.Click += new System.EventHandler(this.btnReativarCliente_Click);
            // 
            // DesativadosDataGridView
            // 
            this.DesativadosDataGridView.AccessibleName = "Table";
            this.DesativadosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DesativadosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.DesativadosDataGridView.Location = new System.Drawing.Point(0, 63);
            this.DesativadosDataGridView.Name = "DesativadosDataGridView";
            this.DesativadosDataGridView.Size = new System.Drawing.Size(809, 388);
            this.DesativadosDataGridView.Style.CellStyle.Font.Size = 10F;
            this.DesativadosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.DesativadosDataGridView.TabIndex = 24;
            this.DesativadosDataGridView.Text = "sfDataGrid1";
            // 
            // clientesDesativados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.DesativadosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "clientesDesativados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Desativados";
            this.Load += new System.EventHandler(this.clientesDesativados_Load);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DesativadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnReativarCliente;
        private Syncfusion.WinForms.DataGrid.SfDataGrid DesativadosDataGridView;
    }
}