namespace SistemaIntegradoV1._0
{
    partial class cadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroCliente));
            this.ClientesDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrarCliente = new System.Windows.Forms.ToolStripButton();
            this.tsbCancelaCadastro = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tbsReativarCliente = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            this.comboBoxFiltros = new Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ClientesDataGridView
            // 
            this.ClientesDataGridView.AccessibleName = "Table";
            this.ClientesDataGridView.AllowFiltering = true;
            this.ClientesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientesDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.ClientesDataGridView.Location = new System.Drawing.Point(0, 65);
            this.ClientesDataGridView.Name = "ClientesDataGridView";
            this.ClientesDataGridView.Size = new System.Drawing.Size(891, 460);
            this.ClientesDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.ClientesDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.ClientesDataGridView.TabIndex = 11;
            this.ClientesDataGridView.Text = "sfDataGrid1";
            this.ClientesDataGridView.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.ClientesDataGridView_CellDoubleClick);
            this.ClientesDataGridView.Click += new System.EventHandler(this.ClientesDataGridView_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 515);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(891, 22);
            this.statusStrip1.TabIndex = 12;
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
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.toolStrip2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCadastrarCliente,
            this.tsbCancelaCadastro,
            this.tsbEditar,
            this.tbsReativarCliente,
            this.tdbRefresh,
            this.comboBoxFiltros});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(891, 69);
            this.toolStrip2.TabIndex = 24;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCliente.Image")));
            this.btnCadastrarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastrarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.btnCadastrarCliente.Size = new System.Drawing.Size(121, 66);
            this.btnCadastrarCliente.Text = "Cadastrar Cliente";
            this.btnCadastrarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarCliente.Click += new System.EventHandler(this.btnCadastrarCliente_Click);
            // 
            // tsbCancelaCadastro
            // 
            this.tsbCancelaCadastro.ForeColor = System.Drawing.Color.White;
            this.tsbCancelaCadastro.Image = ((System.Drawing.Image)(resources.GetObject("tsbCancelaCadastro.Image")));
            this.tsbCancelaCadastro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbCancelaCadastro.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCancelaCadastro.Name = "tsbCancelaCadastro";
            this.tsbCancelaCadastro.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tsbCancelaCadastro.Size = new System.Drawing.Size(127, 66);
            this.tsbCancelaCadastro.Text = "Cancelar Cadastro";
            this.tsbCancelaCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbCancelaCadastro.Click += new System.EventHandler(this.tsbCancelaCadastro_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.ForeColor = System.Drawing.Color.White;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tsbEditar.Size = new System.Drawing.Size(101, 66);
            this.tsbEditar.Text = "Editar Cliente";
            this.tsbEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tbsReativarCliente
            // 
            this.tbsReativarCliente.ForeColor = System.Drawing.Color.White;
            this.tbsReativarCliente.Image = ((System.Drawing.Image)(resources.GetObject("tbsReativarCliente.Image")));
            this.tbsReativarCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsReativarCliente.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsReativarCliente.Name = "tbsReativarCliente";
            this.tbsReativarCliente.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsReativarCliente.Size = new System.Drawing.Size(113, 66);
            this.tbsReativarCliente.Text = "Reativar Cliente";
            this.tbsReativarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsReativarCliente.Click += new System.EventHandler(this.tbsReativarCliente_Click);
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
            // comboBoxFiltros
            // 
            this.comboBoxFiltros.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.comboBoxFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.comboBoxFiltros.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.comboBoxFiltros.Margin = new System.Windows.Forms.Padding(1, 5, 20, 0);
            this.comboBoxFiltros.MaxLength = 32767;
            this.comboBoxFiltros.Name = "comboBoxFiltros";
            this.comboBoxFiltros.Size = new System.Drawing.Size(121, 64);
            this.comboBoxFiltros.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltros_SelectedIndexChanged);
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(891, 537);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ClientesDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "cadastroCliente";
            this.Text = "Cadastro de Cliente";
            this.Load += new System.EventHandler(this.cadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientesDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid ClientesDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCadastrarCliente;
        private System.Windows.Forms.ToolStripButton tsbCancelaCadastro;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tbsReativarCliente;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
        private Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx comboBoxFiltros;
    }
}