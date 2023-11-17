using SISTEMA.INTEGRADO.V1._0.DAO;
using SistemaIntegradoV1._0.VIEW.Cadastro.cadastrosProdutoViews;
using Syncfusion.Windows.Forms.Grid;
using Syncfusion.WinForms.DataGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Drawing.Charts;
using System.IO;

namespace SistemaIntegradoV1._0
{
    public partial class FrmListagemProduto : Form
    {
        public bool doubleClick { get; set; }

        public FrmListagemProduto()
        {
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            Cursor.Current = Cursors.Default;
        }

        private void tbsCadastroProdruto_Click(object sender, EventArgs e)
        {
            FrmProduto tela = new FrmProduto();
            tela.ShowDialog();

            carregaGrid();
        }

        public void carregaGrid()
        {
            using (ConnectionString context = new ConnectionString())
            {

                var query = (from produto in context.Produto
                             select new
                             {
                                 idProduto = produto.IdProduto,
                                 Nome = produto.Nome,
                                 preco = produto.PrecoUnitario,
                                 isAtivo = produto.isAtivo
                             }).ToList();

                ProdutosDataGridView.DataSource = query;
                registrosLabel.Text = "Registros Encontrados: " + Convert.ToString(context.Produto.Count());

            }
        }
        public void constroiGrid()
        {
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "idProduto", HeaderText = "ID Produto", Visible = true, Width = 0 });
            ProdutosDataGridView.Columns.Add(new GridTextColumn() { MappingName = "Nome", HeaderText = "Produto", Visible = true });
            ProdutosDataGridView.Columns.Add(new GridNumericColumn() { MappingName = "preco", HeaderText = "Preço", Visible = true, Width = 200 });
            ProdutosDataGridView.Columns.Add(new GridCheckBoxColumn() { MappingName = "isAtivo", HeaderText = "Ativo", Visible = true, Width = 200 });

            ProdutosDataGridView.Columns["preco"].Format = "{0:C}";

            using (ConnectionString context = new ConnectionString())
            {
                var query = (from produto in context.Produto
                             where produto.isAtivo == true
                             select new
                             {
                                 idProduto = produto.IdProduto,
                                 Nome = produto.Nome,
                                 preco = produto.PrecoUnitario,
                                 isAtivo = produto.isAtivo
                             }).ToList();
                ProdutosDataGridView.DataSource = query;
            }
        }

        private void cadastroProduto_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            constroiGrid();
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void tdbRefresh_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            carregaGrid();
            Cursor.Current = Cursors.Default;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void ProdutosDataGridView_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                var linhaSelecionada = ProdutosDataGridView.SelectedItem;

                int idProduto = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idProduto").GetValue(linhaSelecionada, null));

                Produto produtoSeleciondo = context.Produto.FirstOrDefault(x => x.IdProduto.Equals(idProduto));
                List<MateriasUsadasNoProduto> mpUsadas = context.MateriasUsadasNoProduto.Where(x => x.idProduto.Equals(produtoSeleciondo.IdProduto)).ToList();

                FrmDetalhes tela = new FrmDetalhes(mpUsadas, produtoSeleciondo);
                tela.ShowDialog();
            }
        }

        private void tbsDesativaProduto_Click(object sender, EventArgs e)
        {
            if (ProdutosDataGridView.SelectedItems.Count > 0)
            {
                var linhaSelecionada = ProdutosDataGridView.SelectedItem;

                int idProduto = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idProduto").GetValue(linhaSelecionada, null));

                using (ConnectionString context = new ConnectionString())
                {
                    Produto produtoParaInativar = context.Produto.FirstOrDefault(v => v.IdProduto.Equals(idProduto));
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show("Tem Certeza que deseja inativar " + produtoParaInativar.Nome + "?", "Atenção", buttons, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {
                        if (ProdutosDataGridView.SelectedItems.Count > 0)
                        {
                            linhaSelecionada = ProdutosDataGridView.SelectedItem;

                            idProduto = Convert.ToInt32(linhaSelecionada.GetType().GetProperty("idProduto").GetValue(linhaSelecionada, null));

                            Produto produtoaParaInativar = context.Produto.FirstOrDefault(v => v.IdProduto.Equals(idProduto));
                            if (produtoParaInativar != null)
                            {
                                produtoaParaInativar.isAtivo = false;
                                context.Entry<Produto>(produtoaParaInativar).State = EntityState.Modified;
                                context.SaveChanges();
                                carregaGrid();
                            }
                        }
                    }
                    else
                    {
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        DialogResult resul = MessageBox.Show("Selecione o produto que deseja inativar", "Nenhuma linha selecionada", button, MessageBoxIcon.Asterisk);
                    }
                }
            }
        }

        private void tbsExportExcel_Click(object sender, EventArgs e)
        {
            using (ConnectionString context = new ConnectionString())
            {
                try
                {

                    List<Produto> produtos = context.Produto.ToList();
                    if (!Directory.Exists(Directory.GetCurrentDirectory()+"\\Arquivos"))
                    {
                        Directory.CreateDirectory(Directory.GetCurrentDirectory()+"\\Arquivos");
                    }

                    using (SpreadsheetDocument spreadSheet = SpreadsheetDocument.Create(Directory.GetCurrentDirectory()+"\\Arquivos\\IntegradoProdutos.xlsx", SpreadsheetDocumentType.Workbook))
                    {
                        WorkbookPart workBookPart = spreadSheet.AddWorkbookPart();
                        workBookPart.Workbook = new Workbook();

                        Sheets sheets = spreadSheet.WorkbookPart.Workbook.AppendChild<Sheets>(new Sheets());

                        WorksheetPart worksheetPart = workBookPart.AddNewPart<WorksheetPart>();
                        Worksheet workSheet = new Worksheet();
                        SheetData sheetData = new SheetData();

                        Sheet sheet = new Sheet()
                        {
                            Id = spreadSheet.WorkbookPart.
                            GetIdOfPart(worksheetPart),
                            SheetId = 1,
                            Name = "Produtos"
                        };
                        int contador = 0;
                        sheets.Append(sheet);
                        foreach (Produto item in produtos)
                        {
                            Row row = new Row();
                            if (contador == 0)
                            {
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString("ID")) });
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString("Nome")) });
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString("Preço Unitário")) });
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString("Está Ativo?")) });
                            }
                            else
                            {
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.IdProduto)) });
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.Nome)) });
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.PrecoUnitario)) });
                                row.Append(new Cell() { DataType = CellValues.String, CellValue = new CellValue(Convert.ToString(item.isAtivo)) });
                            }
                            contador++;
                            sheetData.AppendChild(row);
                        }
                        workSheet.AppendChild(sheetData);
                        worksheetPart.Worksheet = workSheet;
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        DialogResult resul = MessageBox.Show("Arquivo gerado com sucesso!", "Sucesso", button, MessageBoxIcon.Information);
                    }
                }
                catch (Exception)
                {
                    MessageBoxButtons button = MessageBoxButtons.OK;
                    DialogResult resul = MessageBox.Show("Erro ao gerar o arquivo", "Erro", button, MessageBoxIcon.Error);
                }
            }
        }

        private void tbsImportarExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"c:\\";
            ofd.Filter = "excel files (*.csv)|*.csv";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int contador = 0;

                string filePath = ofd.FileName;

                string extension = System.IO.Path.GetExtension(filePath);
                Stream fileStream = ofd.OpenFile();

                StreamReader reader = new StreamReader(fileStream);
                if (extension == ".csv")
                {
                    using (ConnectionString context = new ConnectionString())
                    {
                        bool estaVazio = false;
                        string linha;
                        String[] element;
                        while ((linha = reader.ReadLine()) != null)
                        {
                            if (contador>0)
                            {
                                Produto produto = new Produto();
                                EstoqueProdutoAcabado estoque = new EstoqueProdutoAcabado();
                                element = linha.Split(';');
                                if (!string.IsNullOrEmpty(element[0]) && !string.IsNullOrEmpty(element[1]))
                                {
                                    produto.Nome = element[0];
                                    produto.PrecoUnitario =Convert.ToDouble(element[1]);
                                    produto.isAtivo = true;
                                    context.Produto.Add(produto);
                                    context.SaveChanges();
                                    estoque.IdProduto = produto.IdProduto;
                                    estoque.NomeProduto = produto.Nome;
                                    estoque.Quantidade = 0;
                                    context.EstoqueProdutoAcabado.Add(estoque);
                                    context.SaveChanges();
                                }

                            }
                            contador++;
                        }
                        MessageBoxButtons button = MessageBoxButtons.OK;
                        DialogResult resul = MessageBox.Show("Novos produtos cadastrados com sucesso!", "Sucesso", button, MessageBoxIcon.Information);
                    }
                }
            }
        }
    }
}
