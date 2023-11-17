namespace SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosProdutoViews
{
    partial class FrmDetalhes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetalhes));
            this.materiasDataGrid = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // materiasDataGrid
            // 
            this.materiasDataGrid.AccessibleName = "Table";
            this.materiasDataGrid.AllowEditing = false;
            this.materiasDataGrid.AllowGrouping = false;
            this.materiasDataGrid.AllowSorting = false;
            this.materiasDataGrid.AutoGenerateColumns = false;
            this.materiasDataGrid.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.materiasDataGrid.EditMode = Syncfusion.WinForms.DataGrid.Enums.EditMode.SingleClick;
            this.materiasDataGrid.Enabled = false;
            this.materiasDataGrid.Location = new System.Drawing.Point(15, 127);
            this.materiasDataGrid.Name = "materiasDataGrid";
            this.materiasDataGrid.Size = new System.Drawing.Size(565, 326);
            this.materiasDataGrid.TabIndex = 17;
            this.materiasDataGrid.Text = "sfDataGrid1";
            this.materiasDataGrid.ValidationMode = Syncfusion.WinForms.DataGrid.Enums.GridValidationMode.InView;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(448, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Preço Unitário: *";
            // 
            // txtPreco
            // 
            this.txtPreco.BackColor = System.Drawing.Color.White;
            this.txtPreco.Enabled = false;
            this.txtPreco.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPreco.Location = new System.Drawing.Point(451, 50);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(129, 23);
            this.txtPreco.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Produto: *";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.BackColor = System.Drawing.Color.White;
            this.txtNomeProduto.Enabled = false;
            this.txtNomeProduto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeProduto.Location = new System.Drawing.Point(15, 50);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(430, 23);
            this.txtNomeProduto.TabIndex = 13;
            // 
            // informacoesProdutosView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(593, 482);
            this.Controls.Add(this.materiasDataGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNomeProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "informacoesProdutosView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informações do Produto";
            this.Load += new System.EventHandler(this.informacoesProdutosView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.materiasDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid materiasDataGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeProduto;
    }
}