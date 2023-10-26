namespace SistemaIntegradoV1._0
{
    partial class Faturas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Faturas));
            this.FaturasDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabelfooter = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsbDarBaixaRecibo = new System.Windows.Forms.ToolStrip();
            this.tbsCadastroProdruto = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.FaturasDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tsbDarBaixaRecibo.SuspendLayout();
            this.SuspendLayout();
            // 
            // FaturasDataGridView
            // 
            this.FaturasDataGridView.AccessibleName = "Table";
            this.FaturasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FaturasDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.FaturasDataGridView.Location = new System.Drawing.Point(0, 64);
            this.FaturasDataGridView.Name = "FaturasDataGridView";
            this.FaturasDataGridView.Size = new System.Drawing.Size(939, 445);
            this.FaturasDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.FaturasDataGridView.TabIndex = 12;
            this.FaturasDataGridView.Text = "sfDataGrid1";
            this.FaturasDataGridView.QueryRowStyle += new Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventHandler(this.FaturasDataGridView_QueryRowStyle);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabelfooter});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(939, 22);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // registrosLabelfooter
            // 
            this.registrosLabelfooter.Font = new System.Drawing.Font("Microsoft JhengHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrosLabelfooter.ForeColor = System.Drawing.Color.White;
            this.registrosLabelfooter.Name = "registrosLabelfooter";
            this.registrosLabelfooter.Size = new System.Drawing.Size(146, 17);
            this.registrosLabelfooter.Text = "Registros Encontrados: 0";
            // 
            // tsbDarBaixaRecibo
            // 
            this.tsbDarBaixaRecibo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.tsbDarBaixaRecibo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tsbDarBaixaRecibo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbsCadastroProdruto});
            this.tsbDarBaixaRecibo.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.tsbDarBaixaRecibo.Location = new System.Drawing.Point(0, 0);
            this.tsbDarBaixaRecibo.Name = "tsbDarBaixaRecibo";
            this.tsbDarBaixaRecibo.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsbDarBaixaRecibo.Size = new System.Drawing.Size(939, 69);
            this.tsbDarBaixaRecibo.TabIndex = 29;
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
            this.tbsCadastroProdruto.Size = new System.Drawing.Size(97, 66);
            this.tbsCadastroProdruto.Text = "Pagar Fatura";
            this.tbsCadastroProdruto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsCadastroProdruto.Click += new System.EventHandler(this.tsbPagarFatura_Click);
            // 
            // Faturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(939, 521);
            this.Controls.Add(this.tsbDarBaixaRecibo);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.FaturasDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Faturas";
            this.Text = "Administrar Faturas";
            this.Load += new System.EventHandler(this.Faturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FaturasDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tsbDarBaixaRecibo.ResumeLayout(false);
            this.tsbDarBaixaRecibo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid FaturasDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabelfooter;
        private System.Windows.Forms.ToolStrip tsbDarBaixaRecibo;
        private System.Windows.Forms.ToolStripButton tbsCadastroProdruto;
    }
}