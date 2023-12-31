﻿namespace SistemaIntegradoV1._0
{
    partial class FrmListagemMateria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListagemMateria));
            this.MpDataGridView = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.registrosLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnCadastrarMateria = new System.Windows.Forms.ToolStripButton();
            this.tdbRefresh = new System.Windows.Forms.ToolStripButton();
            this.tbsExportExcel = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tsbDesativarMp = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.MpDataGridView)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MpDataGridView
            // 
            this.MpDataGridView.AccessibleName = "Table";
            this.MpDataGridView.AllowFiltering = true;
            this.MpDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MpDataGridView.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.Fill;
            this.MpDataGridView.Location = new System.Drawing.Point(0, 67);
            this.MpDataGridView.Name = "MpDataGridView";
            this.MpDataGridView.Size = new System.Drawing.Size(929, 439);
            this.MpDataGridView.Style.CellStyle.Font.Size = 10F;
            this.MpDataGridView.Style.HeaderStyle.Font.Bold = true;
            this.MpDataGridView.Style.HeaderStyle.Font.Size = 11F;
            this.MpDataGridView.TabIndex = 13;
            this.MpDataGridView.Text = "sfDataGrid1";
            this.MpDataGridView.CellDoubleClick += new Syncfusion.WinForms.DataGrid.Events.CellClickEventHandler(this.MpDataGridView_CellDoubleClick);
            this.MpDataGridView.DoubleClick += new System.EventHandler(this.MpDataGridView_DoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(64)))), ((int)(((byte)(69)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrosLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 496);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(929, 22);
            this.statusStrip1.TabIndex = 14;
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
            this.btnCadastrarMateria,
            this.tdbRefresh,
            this.tbsExportExcel,
            this.toolStripButton1,
            this.tsbDesativarMp});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(929, 69);
            this.toolStrip2.TabIndex = 23;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnCadastrarMateria
            // 
            this.btnCadastrarMateria.ForeColor = System.Drawing.Color.White;
            this.btnCadastrarMateria.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarMateria.Image")));
            this.btnCadastrarMateria.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCadastrarMateria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCadastrarMateria.Name = "btnCadastrarMateria";
            this.btnCadastrarMateria.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.btnCadastrarMateria.Size = new System.Drawing.Size(158, 66);
            this.btnCadastrarMateria.Text = "Cadastrar Matéria Prima";
            this.btnCadastrarMateria.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCadastrarMateria.Click += new System.EventHandler(this.tbsCadastroMateria_Click);
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
            // tbsExportExcel
            // 
            this.tbsExportExcel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tbsExportExcel.ForeColor = System.Drawing.Color.White;
            this.tbsExportExcel.Image = ((System.Drawing.Image)(resources.GetObject("tbsExportExcel.Image")));
            this.tbsExportExcel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tbsExportExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbsExportExcel.Margin = new System.Windows.Forms.Padding(0, 1, 30, 2);
            this.tbsExportExcel.Name = "tbsExportExcel";
            this.tbsExportExcel.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tbsExportExcel.Size = new System.Drawing.Size(120, 66);
            this.tbsExportExcel.Text = "Exportar P/ Excel";
            this.tbsExportExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbsExportExcel.Click += new System.EventHandler(this.tbsExportExcel_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ForeColor = System.Drawing.Color.White;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.toolStripButton1.Size = new System.Drawing.Size(138, 66);
            this.toolStripButton1.Text = "Editar Matéria Prima";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbDesativarMp
            // 
            this.tsbDesativarMp.ForeColor = System.Drawing.Color.White;
            this.tsbDesativarMp.Image = ((System.Drawing.Image)(resources.GetObject("tsbDesativarMp.Image")));
            this.tsbDesativarMp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDesativarMp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDesativarMp.Name = "tsbDesativarMp";
            this.tsbDesativarMp.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.tsbDesativarMp.Size = new System.Drawing.Size(156, 66);
            this.tsbDesativarMp.Text = "Desativar Matéria Prima";
            this.tsbDesativarMp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbDesativarMp.Click += new System.EventHandler(this.tsbDesativarMp_Click);
            // 
            // FrmListagemMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(929, 518);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MpDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListagemMateria";
            this.Text = "Cadastro de Matéria Prima";
            this.Load += new System.EventHandler(this.cadastroMateriaP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MpDataGridView)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.WinForms.DataGrid.SfDataGrid MpDataGridView;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel registrosLabel;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton btnCadastrarMateria;
        private System.Windows.Forms.ToolStripButton tdbRefresh;
        private System.Windows.Forms.ToolStripButton tsbDesativarMp;
        private System.Windows.Forms.ToolStripButton tbsExportExcel;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}