namespace SistemaIntegradoV1._0
{
    partial class ordemsEmAprovacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ordemsEmAprovacao));
            this.ordemDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ordemDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ordemDataGridView
            // 
            this.ordemDataGridView.AccessibleName = "Table";
            this.ordemDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordemDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.ordemDataGridView.Location = new System.Drawing.Point(12, 63);
            this.ordemDataGridView.Name = "ordemDataGridView";
            this.ordemDataGridView.Size = new System.Drawing.Size(918, 445);
            this.ordemDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.ordemDataGridView.TabIndex = 12;
            this.ordemDataGridView.Text = "sfDataGrid1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(703, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(227, 45);
            this.button1.TabIndex = 13;
            this.button1.Text = "Mandar produto para produção";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ordemsEmAprovacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(942, 520);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ordemDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ordemsEmAprovacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordens em aprovação";
            this.Load += new System.EventHandler(this.ordemsEmAprovacao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordemDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid ordemDataGridView;
        private System.Windows.Forms.Button button1;
    }
}