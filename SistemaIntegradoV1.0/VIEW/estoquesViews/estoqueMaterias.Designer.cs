namespace SistemaIntegradoV1._0.VIEW.estoquesViews
{
    partial class estoqueMaterias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(estoqueMaterias));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.materiaDataGridViewe = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridViewe)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 500);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1111, 22);
            this.statusStrip1.TabIndex = 23;
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
            // materiaDataGridViewe
            // 
            this.materiaDataGridViewe.AccessibleName = "Table";
            this.materiaDataGridViewe.AllowFiltering = true;
            this.materiaDataGridViewe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materiaDataGridViewe.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.materiaDataGridViewe.Location = new System.Drawing.Point(0, 0);
            this.materiaDataGridViewe.Name = "materiaDataGridViewe";
            this.materiaDataGridViewe.Size = new System.Drawing.Size(1111, 501);
            this.materiaDataGridViewe.Style.HeaderStyle.Font.Bold = true;
            this.materiaDataGridViewe.Style.HeaderStyle.Font.Size = 11F;
            this.materiaDataGridViewe.TabIndex = 22;
            this.materiaDataGridViewe.Text = "sfDataGrid1";
            // 
            // estoqueMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 522);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.materiaDataGridViewe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "estoqueMaterias";
            this.Text = "Estoque Matérias Primas";
            this.Load += new System.EventHandler(this.estoqueMaterias_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materiaDataGridViewe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private Syncfusion.WinForms.DataGrid.SfDataGrid materiaDataGridViewe;
    }
}