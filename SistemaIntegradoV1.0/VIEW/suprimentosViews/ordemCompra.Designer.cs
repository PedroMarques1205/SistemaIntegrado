namespace SistemaIntegradoV1._0
{
    partial class ordemCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordemCompra));
            this.PedidosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PedidosDataGridView
            // 
            this.PedidosDataGridView.AccessibleName = "Table";
            this.PedidosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PedidosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.PedidosDataGridView.Location = new System.Drawing.Point(12, 69);
            this.PedidosDataGridView.Name = "PedidosDataGridView";
            this.PedidosDataGridView.Size = new System.Drawing.Size(832, 445);
            this.PedidosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.PedidosDataGridView.TabIndex = 11;
            this.PedidosDataGridView.Text = "sfDataGrid1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(589, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(255, 51);
            this.button1.TabIndex = 12;
            this.button1.Text = "Realizar pedido para um fornecedor";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordemCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(856, 524);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PedidosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ordemCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos a serem realizados";
            this.Load += new System.EventHandler(this.ordemCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PedidosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid PedidosDataGridView;
        private System.Windows.Forms.Button button1;
    }
}