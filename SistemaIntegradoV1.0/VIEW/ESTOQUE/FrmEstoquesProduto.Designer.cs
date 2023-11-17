namespace SistemaIntegradoV1._0
{
    partial class FrmEstoquesProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoquesProduto));
            this.produtosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AccessibleName = "Table";
            this.produtosDataGridView.AllowFiltering = true;
            this.produtosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.produtosDataGridView.Location = new System.Drawing.Point(0, -1);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.Size = new System.Drawing.Size(1111, 501);
            this.produtosDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.produtosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.produtosDataGridView.TabIndex = 13;
            this.produtosDataGridView.Text = "sfDataGrid1";
            this.produtosDataGridView.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.produtosDataGridView_QueryRowStyle);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1111, 22);
            this.statusStrip1.TabIndex = 21;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // registrosLabel
            // 
            this.registrosLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrosLabel.ForeColor = System.Drawing.Color.White;
            this.registrosLabel.Name = "registrosLabel";
            this.registrosLabel.Size = new System.Drawing.Size(393, 17);
            this.registrosLabel.Text = "Registros Encontrados Produto: 0 | Registros Encontrados Matéria: 0 ";
            // 
            // estoquesProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.produtosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "estoquesProduto";
            this.Text = "Estoque Produtos";
            this.Load += new System.EventHandler(this.estoques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid produtosDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
    }
}