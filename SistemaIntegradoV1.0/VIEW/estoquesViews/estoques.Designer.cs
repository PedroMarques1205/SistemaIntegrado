namespace SistemaIntegradoV1._0
{
    partial class estoques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estoques));
            this.produtosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.materiaDataGridViewe = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridViewe)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // produtosDataGridView
            // 
            this.produtosDataGridView.AccessibleName = "Table";
            this.produtosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.produtosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.produtosDataGridView.Location = new System.Drawing.Point(12, 61);
            this.produtosDataGridView.Name = "produtosDataGridView";
            this.produtosDataGridView.Size = new System.Drawing.Size(540, 411);
            this.produtosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.produtosDataGridView.TabIndex = 13;
            this.produtosDataGridView.Text = "sfDataGrid1";
            this.produtosDataGridView.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.produtosDataGridView_QueryRowStyle);
            // 
            // materiaDataGridViewe
            // 
            this.materiaDataGridViewe.AccessibleName = "Table";
            this.materiaDataGridViewe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materiaDataGridViewe.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.materiaDataGridViewe.Location = new System.Drawing.Point(558, 61);
            this.materiaDataGridViewe.Name = "materiaDataGridViewe";
            this.materiaDataGridViewe.Size = new System.Drawing.Size(541, 411);
            this.materiaDataGridViewe.Style.HeaderStyle.Font.Size = 11F;
            this.materiaDataGridViewe.TabIndex = 14;
            this.materiaDataGridViewe.Text = "sfDataGrid1";
            this.materiaDataGridViewe.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.materiaDataGridViewe_QueryRowStyle);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(550, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 47);
            this.label2.TabIndex = 17;
            this.label2.Text = "Estoque Matérias Primas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(465, 47);
            this.label1.TabIndex = 16;
            this.label1.Text = "Estoque Produtos Acabados";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 475);
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
            // estoques
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1111, 497);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.materiaDataGridViewe);
            this.Controls.Add(this.produtosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "estoques";
            this.Text = "Verficiar Estoques";
            this.Load += new System.EventHandler(this.estoques_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridViewe)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid produtosDataGridView;
        private Syncfusion.WinForms.DataGrid.SfDataGrid materiaDataGridViewe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
    }
}