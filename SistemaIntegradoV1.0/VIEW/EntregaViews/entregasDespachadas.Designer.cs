namespace SistemaIntegradoV1._0
{
    partial class entregasDespachadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(entregasDespachadas));
            this.EnviosDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EnviosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // EnviosDataGridView
            // 
            this.EnviosDataGridView.AccessibleName = "Table";
            this.EnviosDataGridView.AllowFiltering = true;
            this.EnviosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnviosDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.EnviosDataGridView.Location = new System.Drawing.Point(12, 104);
            this.EnviosDataGridView.Name = "EnviosDataGridView";
            this.EnviosDataGridView.Size = new System.Drawing.Size(1166, 450);
            this.EnviosDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.EnviosDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.EnviosDataGridView.TabIndex = 10;
            this.EnviosDataGridView.Text = "sfDataGrid1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(1046, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 39);
            this.button1.TabIndex = 11;
            this.button1.Text = "Setar Entregue";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // entregasDespachadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1190, 566);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EnviosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "entregasDespachadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entregas Realizadas";
            this.Load += new System.EventHandler(this.entregasAfazer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EnviosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid EnviosDataGridView;
        private System.Windows.Forms.Button button1;
    }
}