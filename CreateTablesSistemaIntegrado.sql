CREATE DATABASE DB_SISTEMA_INTEGRADO;
GO

USE DB_SISTEMA_INTEGRADO;
GO

CREATE TABLE [Usuario](
	[Login] VARCHAR(30),
	[Senha] VARCHAR(30),
	PRIMARY KEY ([Login])
);

ALTER TABLE Usuario ADD [EstaAtivo] BIT NOT NULL DEFAULT 1;
CREATE TABLE [Produto] (
  [IdProduto] INT NOT NULL IDENTITY(1,1),
  [Nome] VARCHAR(200),
  [PrecoUnitario] FLOAT,	
  [isAtivo] bit
  PRIMARY KEY ([IdProduto])
);

CREATE TABLE [TipoMateria](
	[NomeTipo] VARCHAR(100),
	[Codigo] VARCHAR(2),
	PRIMARY KEY ([Codigo])
);

CREATE TABLE [MateriaPrima] (
  [idMateriaPrima] INT NOT NULL IDENTITY(1,1),
  [CodigoMp] VARCHAR(15),
  [Nome] VARCHAR(200),
  [isAtivo] bit,
  [CodigoTipo] VARCHAR(2),
  PRIMARY KEY ([idMateriaPrima]),
  FOREIGN KEY ([CodigoTipo])
	REFERENCES [TipoMateria]([Codigo])
);

CREATE TABLE [EstoqueMateriaPrima] (
  [IdMateriaPrima] INT NOT NULL,
  [NomeMp] VARCHAR(200),
  [Quantidade] INT NOT NULL,
  PRIMARY KEY([IdMateriaPrima]),
  CONSTRAINT [FK_EstoqueMateriaPrima.IdMateriaPrima]
    FOREIGN KEY ([IdMateriaPrima])
      REFERENCES [MateriaPrima]([idMateriaPrima])
);

CREATE TABLE [MateriasUsadasNoProduto] (
  [idMateriaPrima] INT NOT NULL,
   [NomeMp] VARCHAR(200),
  [idProduto] INT NOT NULL,
  [NomeProduto] VARCHAR(30),
  [Quantidade] INT,
  PRIMARY KEY ([idProduto],[idMateriaPrima]),

  CONSTRAINT [FK_MateriaPrimaUsadas.idMateriaPrima]
    FOREIGN KEY ([idMateriaPrima])
      REFERENCES [MateriaPrima]([idMateriaPrima])
);

CREATE TABLE [Cliente] (
  [CpfCliente] VARCHAR(25) NOT NULL ,
  [Nome] VARCHAR(150),
  [Rua] VARCHAR(30) NOT NULL,
  [Bairro] VARCHAR(30) NOT NULL,
  [Num] INT NOT NULL,
  [Complemento] VARCHAR(20),
  [Estado] VARCHAR(40),
  [Municipio] VARCHAR(40),
  [isAtivo] bit
  PRIMARY KEY ([CpfCliente])
);

CREATE TABLE [Orcamento] (
  [CpfCliente] VARCHAR(25) NOT NULL ,
  [idProduto] INT NOT NULL,
  [QuantProduto] INT,
  [ValorTotal] FLOAT,
  [DataOrcamento] DATE NOT NULL,
  [DataAceito] DATE,
  [DataRejeitado] DATE,
  [idOrcamento] INT NOT NULL IDENTITY(1,1),
  [statusCliente] VARCHAR(20),
  [statusEntrega] VARCHAR(20),
  [formaPagamento] VARCHAR(30),
  PRIMARY KEY ([idOrcamento]),
  CONSTRAINT [FK_Orcamento.idProduto]
    FOREIGN KEY ([idProduto])
      REFERENCES [Produto]([IdProduto]),
  CONSTRAINT [FK_Orcamento.CpfCliente]
    FOREIGN KEY ([CpfCliente])
      REFERENCES [Cliente]([CpfCliente])
);
ALTER TABLE Orcamento ADD [PodeSerEntregue] BIT

CREATE TABLE [Endereco](
  [IdEndereco] INT NOT NULL IDENTITY(1,1),
  [idOrcamento] INT NOT NULL,
  [Rua] VARCHAR(30) NOT NULL,
  [Bairro] VARCHAR(30) NOT NULL,
  [Num] INT NOT NULL,
  [Complemento] VARCHAR(20),
  [Estado] VARCHAR(40),
  [Municipio] VARCHAR(40),
  PRIMARY KEY ([IdEndereco]),
  FOREIGN KEY ([idOrcamento])
      REFERENCES [Orcamento]([idOrcamento])
);

CREATE TABLE [PedidoCompraSuprimento] (
  [IdPedidoCompra] INT NOT NULL IDENTITY(1,1),
  [IdMateriaPrima] INT  NOT NULL,
  [Fornecedor] VARCHAR(100),
  [DataPedido] DATE,
  [DataCompra] DATE,
  [Quantidade] INT,
  [PrecoUnit] FLOAT,
  [PrecoTotal] FLOAT,
  [PrazoEntrega] DATE,
  [CondicaoPagamento] VARCHAR(30),
  [IsPedidoAceito] bit,
  [IsEntregue] bit
  PRIMARY KEY ([IdPedidoCompra]),
  CONSTRAINT [FK_PedidoCompraSuprimento.IdMateriaPrima]
    FOREIGN KEY ([IdMateriaPrima])
      REFERENCES [MateriaPrima]([idMateriaPrima])
);

CREATE TABLE [Transacao] (
  [IdPedidoReceber] INT,
  [ValorReceber] FLOAT,
  [Situacao] VARCHAR(15),
  [ValorPago] FLOAT,
  [IdTransacao] INT NOT NULL IDENTITY(1,1),
  [idPedidoPagar] INT,
  PRIMARY KEY ([IdTransacao]),
  CONSTRAINT [FK_Transacao.IdPedidoReceber]
    FOREIGN KEY ([IdPedidoReceber])
      REFERENCES [Orcamento]([idOrcamento]),
  CONSTRAINT [FK_Transacao.idPedidoPagar]
    FOREIGN KEY ([idPedidoPagar])
      REFERENCES [PedidoCompraSuprimento]([IdPedidoCompra])
);

CREATE TABLE [OrdemProducao] (
  [IdOrdem] INT NOT NULL IDENTITY(1,1),
  [IdProduto] INT NOT NULL,
  [QtdAproduzir] INT,
  [DataPedido] DATE,
  [DataEnviado] DATE,
  [DataFinalizado] DATE,
  [FaseAtual] VARCHAR(50),
  [IdOrcamento] INT,
  PRIMARY KEY ([IdOrdem]),
  CONSTRAINT [FK_OrdemProducao.IdProduto]
    FOREIGN KEY ([IdProduto])
      REFERENCES [Produto]([IdProduto])
);

CREATE TABLE [Entrega] (
  [IdOrcamento] INT NOT NULL,
  [DataEntrega] DATE,
  [DataEnviado] DATE,
  [DataEntregue] DATE,
  [IsEntregue] BIT,
  [IdEntrega] INT NOT NULL IDENTITY(1,1),
  [tipoEntrega] VARCHAR(50),
  PRIMARY KEY ([IdEntrega]),
  CONSTRAINT [FK_Entrega.IdOrcamento]
    FOREIGN KEY ([IdOrcamento])
      REFERENCES [Orcamento]([idOrcamento])
);

CREATE TABLE [EstoqueProdutoAcabado] (
  [IdProduto] INT NOT NULL,
  [NomeProduto] VARCHAR(200),
  [Quantidade] INT NOT NULL,
  PRIMARY KEY ([IdProduto]),
  CONSTRAINT [FK_EstoqueProdutoAcabado.IdProduto]
    FOREIGN KEY ([IdProduto])
      REFERENCES [Produto]([IdProduto])
); 

CREATE TABLE [Acessos](
	[IdAcesso] INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Login] Varchar(30),
	[CodAcesso] VARCHAR(5),
    FOREIGN KEY ([Login])
      REFERENCES [Usuario]([Login]),
);

DECLARE @dtInicial DATE = '2023-11-01';
DECLARE @dtFinal DATE = '2023-11-30';
SELECT 
    O.idOrcamento AS NumOrcamento,		
    O.CpfCliente AS CpfCliente,
    C.Nome AS NomeCliente,
	P.IdProduto AS CodProduto,
    P.Nome AS DescricaoProduto,
    P.PrecoUnitario,
    E.DataEnviado,
    E.IsEntregue,
    O.ValorTotal,
	F.FaseAtual
FROM Orcamento O
    INNER JOIN Cliente C ON C.CpfCliente = O.CpfCliente 
    INNER JOIN Produto P ON P.IdProduto = O.idProduto
    LEFT JOIN Entrega E ON E.IdOrcamento = O.idOrcamento
	LEFT JOIN OrdemProducao F ON F.IdOrcamento = O.idOrcamento
WHERE
    O.DataOrcamento BETWEEN @dtInicial AND @dtFinal;


CREATE VIEW RelatorioOrcamentos AS (
	SELECT 
    O.idOrcamento AS NumOrcamento,		
    O.CpfCliente AS CpfCliente,
	O.DataOrcamento,
	O.statusCliente,
    C.Nome AS NomeCliente,
	P.IdProduto AS CodProduto,
    P.Nome AS DescricaoProduto,
    P.PrecoUnitario,
    E.DataEnviado,
    E.IsEntregue,
	E.DataEntregue,
    O.ValorTotal,
	F.FaseAtual,
	F.DataFinalizado,
	F.IdOrdem
FROM Orcamento O
    INNER JOIN Cliente C ON C.CpfCliente = O.CpfCliente 
    INNER JOIN Produto P ON P.IdProduto = O.idProduto
    LEFT JOIN Entrega E ON E.IdOrcamento = O.idOrcamento
	LEFT JOIN OrdemProducao F ON F.IdOrcamento = O.idOrcamento
)
SELECT * FROM RelatorioOrcamentos