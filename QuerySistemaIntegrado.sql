CREATE DATABASE DB_SISTEMA_INTEGRADO;
GO

USE DB_SISTEMA_INTEGRADO;
GO

SELECT * FROM EstoqueProdutoAcabado
CREATE TABLE [MateriaPrima] (
  [idMateriaPrima] INT NOT NULL IDENTITY(1,1),
  [CodigoMp] VARCHAR(15),
  [Nome] VARCHAR(50),
  PRIMARY KEY ([idMateriaPrima])
);

CREATE TABLE [Produto] (
  [IdProduto] INT NOT NULL IDENTITY(1,1),
  [Nome] VARCHAR(30),
  [PrecoUnitario] FLOAT,
  PRIMARY KEY ([IdProduto])
);

CREATE TABLE [EstoqueMateriaPrima] (
  [IdMateriaPrima] INT NOT NULL,
  [NomeMp] VARCHAR(30),
  [Quantidade] INT NOT NULL,
  PRIMARY KEY([IdMateriaPrima]),
  CONSTRAINT [FK_EstoqueMateriaPrima.IdMateriaPrima]
    FOREIGN KEY ([IdMateriaPrima])
      REFERENCES [MateriaPrima]([idMateriaPrima])
);

CREATE TABLE [MateriasUsadasNoProduto] (
  [idMateriaPrima] INT NOT NULL,
   [NomeMp] VARCHAR(30),
  [idProduto] INT NOT NULL,
  [NomeProduto] VARCHAR(30),
  [Quantidade] INT,
  PRIMARY KEY ([idProduto],[idMateriaPrima]),

  CONSTRAINT [FK_MateriaPrimaUsadas.idMateriaPrima]
    FOREIGN KEY ([idMateriaPrima])
      REFERENCES [MateriaPrima]([idMateriaPrima])
);

SELECT * FROM PedidoCompraSuprimento

SELECT * FROM MateriasUsadasNoProduto
CREATE TABLE [Cliente] (
  [CpfCliente] VARCHAR(25) NOT NULL ,
  [Nome] VARCHAR(30),
  [Rua] VARCHAR(30) NOT NULL,
  [Bairro] VARCHAR(30) NOT NULL,
  [Num] INT NOT NULL,
  PRIMARY KEY ([CpfCliente])
);

CREATE TABLE [Orcamento] (
  [CpfCliente] VARCHAR(25) NOT NULL ,
  [idProduto] INT NOT NULL,
  [QuantProduto] INT,
  [ValorTotal] FLOAT,
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

CREATE TABLE [PedidoCompraSuprimento] (
  [IdPedidoCompra] INT NOT NULL IDENTITY(1,1),
  [IdMateriaPrima] INT  NOT NULL,
  [Fornecedor] VARCHAR(100),
  [Quantidade] INT,
  [PrecoUnit] FLOAT,
  [PrecoTotal] FLOAT,
  [PrazoEntrega] DATE,
  [CondicaoPagamento] VARCHAR(30),
  [IsPedidoAceito] bit,
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
  [FaseAtual] VARCHAR(50),
  PRIMARY KEY ([IdOrdem]),
  CONSTRAINT [FK_OrdemProducao.IdProduto]
    FOREIGN KEY ([IdProduto])
      REFERENCES [Produto]([IdProduto])
);

CREATE TABLE [Entrega] (
  [IdOrcamento] INT NOT NULL,
  [DataEntrega] DATE,
  [IsEntregue] BIT,
  [IdEntrega] INT NOT NULL IDENTITY(1,1),
  [tipoEntrega] VARCHAR(50),
  PRIMARY KEY ([IdEntrega]),
  CONSTRAINT [FK_Entrega.IdOrcamento]
    FOREIGN KEY ([IdOrcamento])
      REFERENCES [Orcamento]([idOrcamento])
);

SELECT * FROM EstoqueProdutoAcabado
CREATE TABLE [EstoqueProdutoAcabado] (
  [IdProduto] INT NOT NULL,
  [NomeProduto] VARCHAR(30),
  [Quantidade] INT NOT NULL,
  PRIMARY KEY ([IdProduto]),
  CONSTRAINT [FK_EstoqueProdutoAcabado.IdProduto]
    FOREIGN KEY ([IdProduto])
      REFERENCES [Produto]([IdProduto])
);

