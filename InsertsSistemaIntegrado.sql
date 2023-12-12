USE DB_SISTEMA_INTEGRADO;
GO

INSERT INTO Cliente (CpfCliente, Nome, Rua, Bairro, Num, Complemento, Estado, Municipio, isAtivo)
VALUES 
('123,456,789-01', 'João Silva', 'Rua A', 'Bairro 1', 101, 'Casa 1', 'Minas Gerais (MG)', 'São Paulo', 1),
('224,567,890-12', 'Maria Oliveira', 'Rua B', 'Bairro 2', 202, 'Apartamento 2', 'Minas Gerais (MG)', 'Rio de Janeiro', 1),
('345,678,901-23', 'Carlos Pereira', 'Rua C', 'Bairro 3', 303, 'Casa 3', 'Minas Gerais (MG)', 'Belo Horizonte', 1),
('456,789,012-34', 'Ana Souza', 'Rua D', 'Bairro 4', 404, 'Apartamento 4', 'Minas Gerais (MG)', 'Porto Alegre', 1),
('567,890,123-45', 'Pedro Santos', 'Rua E', 'Bairro 5', 505, 'Casa 5', 'Minas Gerais (MG)', 'Salvador', 1),
('678,901,234-56', 'Juliana Lima', 'Rua F', 'Bairro 6', 606, 'Apartamento 6', 'Minas Gerais (MG)', 'Florianópolis', 1),
('789,012,345-67', 'Lucas Mendes', 'Rua G', 'Bairro 7', 707, 'Casa 7', 'Minas Gerais (MG)', 'Curitiba', 1),
('890,123,456-78', 'Fernanda Oliveira', 'Rua H', 'Bairro 8', 808, 'Apartamento 8', 'Minas Gerais (MG)', 'Recife', 1),
('901,234,567-89', 'Ricardo Santos', 'Rua I', 'Bairro 9', 909, 'Casa 9', 'Minas Gerais (MG)', 'Fortaleza', 1),
('022,345,678-90', 'Amanda Silva', 'Rua J', 'Bairro 10', 1010, 'Apartamento 10', 'Minas Gerais (MG)', 'Belém', 1),
('123,234,345-56', 'Gabriel Oliveira', 'Rua K', 'Bairro 11', 1111, 'Casa 11', 'Minas Gerais (MG)', 'São Luís', 1),
('234,345,456-67', 'Camila Pereira', 'Rua L', 'Bairro 12', 1212, 'Apartamento 12', 'Minas Gerais (MG)', 'Goiânia', 1),
('345,456,567-78', 'Diego Souza', 'Rua M', 'Bairro 13', 1313, 'Casa 13', 'Minas Gerais (MG)', 'Manaus', 1),
('456,567,678-89', 'Mariana Lima', 'Rua N', 'Bairro 14', 1414, 'Apartamento 14', 'Minas Gerais (MG)', 'Vitória', 1),
('567,678,789-90', 'Lucas Oliveira', 'Rua O', 'Bairro 15', 1515, 'Casa 15', 'Minas Gerais (MG)', 'João Pessoa', 1),
('678,789,901-23', 'Julia Santos', 'Rua P', 'Bairro 16', 1616, 'Apartamento 16', 'Minas Gerais (MG)', 'Porto Velho', 1),
('789,901,012-34', 'Matheus Mendes', 'Rua Q', 'Bairro 17', 1717, 'Casa 17', 'Minas Gerais (MG)', 'Palmas', 1),
('890,123,234-45', 'Laura Oliveira', 'Rua R', 'Bairro 18', 1818, 'Apartamento 18', 'Minas Gerais (MG)', 'Teresina', 1),
('901,234,345-56', 'Gustavo Pereira', 'Rua S', 'Bairro 19', 1919, 'Casa 19', 'Minas Gerais (MG)', 'Rio Branco', 1),
('012,345,456-67', 'Carolina Souza', 'Rua T', 'Bairro 20', 2020, 'Apartamento 20', 'Minas Gerais (MG)', 'Florianópolis', 1),
('123,456,567-78', 'Alexandre Lima', 'Rua U', 'Bairro 21', 2121, 'Casa 21', 'Minas Gerais (MG)', 'Salvador', 1),
('234,567,678-90', 'Isabela Oliveira', 'Rua V', 'Bairro 22', 2222, 'Apartamento 22', 'Minas Gerais (MG)', 'Porto Alegre', 1),
('345,678,789-01', 'Eduardo Santos', 'Rua W', 'Bairro 23', 2323, 'Casa 23', 'Minas Gerais (MG)', 'Curitiba', 1),
('456,789,901-12', 'Fernanda Mendes', 'Rua X', 'Bairro 24', 2424, 'Apartamento 24', 'Minas Gerais (MG)', 'Recife', 1),
('567,890,012-34', 'Roberto Oliveira', 'Rua Y', 'Bairro 25', 2525, 'Casa 25', 'Minas Gerais (MG)', 'Fortaleza', 1),
('678,901,123-45', 'Cristina Silva', 'Rua Z', 'Bairro 26', 2626, 'Apartamento 26', 'Minas Gerais (MG)', 'Belém', 1),
('789,012,234-56', 'Rafael Oliveira', 'Rua AA', 'Bairro 27', 2727, 'Casa 27', 'Minas Gerais (MG)', 'São Luís', 1),
('890,123,345-67', 'Daniela Pereira', 'Rua BB', 'Bairro 28', 2828, 'Apartamento 28', 'Minas Gerais (MG)', 'Goiânia', 1),
('901,234,456-78', 'Tiago Souza', 'Rua CC', 'Bairro 29', 2929, 'Casa 29', 'Minas Gerais (MG)', 'Manaus', 1),
('012,345,567-89', 'Beatriz Lima', 'Rua DD', 'Bairro 30', 3030, 'Apartamento 30', 'Minas Gerais (MG)', 'Vitória', 1),
('123,456,678-90', 'Felipe Oliveira', 'Rua EE', 'Bairro 31', 3131, 'Casa 31', 'Minas Gerais (MG)', 'João Pessoa', 1),
('234,567,789-01', 'Carla Santos', 'Rua FF', 'Bairro 32', 3232, 'Apartamento 32', 'Minas Gerais (MG)', 'Porto Velho', 1),
('456,779,012-34', 'Fernanda Oliveira', 'Rua HH', 'Bairro 34', 3434, 'Apartamento 34', 'Minas Gerais (MG)', 'Teresina', 1),
('567,89,123-45', 'Marcelo Pereira', 'Rua II', 'Bairro 35', 3535, 'Casa 35', 'Minas Gerais (MG)', 'Rio Branco', 1),
('678,901,234-54', 'Monica Souza', 'Rua JJ', 'Bairro 36', 3636, 'Apartamento 36', 'Minas Gerais (MG)', 'Florianópolis', 1),
('789,012,343-67', 'Roberto Lima', 'Rua KK', 'Bairro 37', 3737, 'Casa 37', 'Minas Gerais (MG)', 'Salvador', 1),
('890,122,456-78', 'Larissa Oliveira', 'Rua LL', 'Bairro 38', 3838, 'Apartamento 38', 'Minas Gerais (MG)', 'Porto Alegre', 1),
('900,234,567-89', 'Gabriel Santos', 'Rua MM', 'Bairro 39', 3939, 'Casa 39', 'Minas Gerais (MG)', 'Curitiba', 1),
('112,345,678-90', 'Aline Mendes', 'Rua NN', 'Bairro 40', 4040, 'Apartamento 40', 'Minas Gerais (MG)', 'Recife', 1),
('123,453,789-01', 'Ricardo Oliveira', 'Rua OO', 'Bairro 41', 4141, 'Casa 41', 'Minas Gerais (MG)', 'Fortaleza', 1),
('134,567,890-12', 'Patricia Silva', 'Rua PP', 'Bairro 42', 4242, 'Apartamento 42', 'Minas Gerais (MG)', 'Belém', 1),
('456,789,112-34', 'Isabela Souza', 'Rua RR', 'Bairro 44', 4444, 'Apartamento 44', 'Minas Gerais (MG)', 'Goiânia', 1),
('567,810,123-45', 'Felipe Lima', 'Rua SS', 'Bairro 45', 4545, 'Casa 45', 'Minas Gerais (MG)', 'Manaus', 1),
('678,901,234-55', 'Leticia Oliveira', 'Rua TT', 'Bairro 46', 4646, 'Apartamento 46', 'Minas Gerais (MG)', 'Vitória', 1),
('789,012,341-67', 'Marcos Santos', 'Rua UU', 'Bairro 47', 4747, 'Casa 47', 'Minas Gerais (MG)', 'João Pessoa', 1),
('890,113,456-78', 'Julia Mendes', 'Rua VV', 'Bairro 48', 4848, 'Apartamento 48', 'Minas Gerais (MG)', 'Porto Velho', 1),
('901,134,567-89', 'Guilherme Oliveira', 'Rua WW', 'Bairro 49', 4949, 'Casa 49', 'Minas Gerais (MG)', 'Palmas', 1),
('010,345,678-90', 'Mariana Pereira', 'Rua XX', 'Bairro 50', 5050, 'Apartamento 50', 'Minas Gerais (MG)', 'Teresina', 1);

INSERT INTO [Produto] ([Nome], [PrecoUnitario], [isAtivo]) VALUES
('Teclado', 25.00, 1),
('Mouse', 15.00, 1),
('Monitor', 150.00, 1),
('Placa de Vídeo', 300.00, 1),
('Processador', 200.00, 1),
('Memória RAM', 50.00, 1),
('SSD', 80.00, 1),
('HDD', 60.00, 1),
('Placa Mãe', 100.00, 1),
('Gabinete', 70.00, 1),
('Fonte de Alimentação', 50.00, 1),
('Cooler', 20.00, 1),
('Cabo HDMI', 10.00, 1),
('Adaptador USB', 5.00, 1),
('Roteador', 60.00, 1),
('Webcam', 30.00, 1),
('Headset', 40.00, 1),
('Caixas de Som', 25.00, 1),
('Pendrive', 12.00, 1),
('Cartão de Memória', 18.00, 1),
('Cadeira Gamer', 150.00, 1),
('Mesa para Computador', 120.00, 1),
('Estabilizador', 35.00, 1),
('No-Break', 100.00, 1),
('Hub USB', 15.00, 1),
('Impressora', 80.00, 1),
('Scanner', 90.00, 1),
('Projetor', 200.00, 1),
('Cabo de Rede', 8.00, 1),
('Fone de Ouvido', 20.00, 1);

INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Eletrônicos','E');
INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Plásticos e Materiais Sintéticos','PM');
INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Metais e Componentes de Hardware','MH');
INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Vidro','V');
INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Cabos e Fios','CF');
INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Energia e Alimentação','EA');
INSERT INTO TipoMateria (NomeTipo,Codigo) VALUES('Periféricos e Acessórios','PA');
-- Eletrônicos (E)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('E-0001', 'Placa de Circuito Integrado', 1, 'E'),
('E-0002', 'Placa de Circuito Impresso', 1, 'E'),
('E-0003', 'Plástico ABS', 1, 'E'),
('E-0004', 'Circuitos de Memória', 1, 'E'),
('E-0005', 'Componentes de Resfriamento', 1, 'E'),
('E-0006', 'Cabo de Conexão', 1, 'E'),
('E-0007', 'Cobertura de Silicone para Fios', 1, 'E'),
('E-0008', 'Estrutura de Aço para Gabinetes', 1, 'E'),
('E-0009', 'Cristal Líquido para Monitores', 1, 'E'),
('E-0010', 'Componentes de Energia para Fontes', 1, 'E'),
('E-0011', 'Conectores de Rede', 1, 'E'),
('E-0012', 'Componentes de Áudio para Caixas de Som', 1, 'E'),
('E-0013', 'Materiais para Fones de Ouvido', 1, 'E'),
('E-0014', 'Materiais para Cadeiras Gamer', 1, 'E'),
('E-0015', 'Materiais para Mesas de Computador', 1, 'E'),
('E-0016', 'Painéis de LED para Monitores', 1, 'E'),
('E-0017', 'Componentes de Impressão para Impressoras', 1, 'E'),
('E-0018', 'Materiais para Roteadores', 1, 'E'),
('E-0019', 'Componentes de Digitalização para Scanners', 1, 'E'),
('E-0020', 'Lentes para Webcams', 1, 'E'),
('E-0021', 'Materiais para Projetores', 1, 'E'),
('E-0022', 'Materiais para Estabilizadores', 1, 'E'),
('E-0023', 'Baterias para No-Breaks', 1, 'E'),
('E-0024', 'Circuitos para Hubs USB', 1, 'E'),
('E-0025', 'Componentes de Conexão para Adaptadores', 1, 'E'),
('E-0026', 'Mídias de Armazenamento', 1, 'E'),
('E-0027', 'Materiais para Leitores de Cartão', 1, 'E'),
('E-0028', 'Componentes de Rede', 1, 'E'),
('E-0029', 'Fios de Energia', 1, 'E'),
('E-0030', 'Materiais para Limpeza', 1, 'E'),
('E-0031', 'Materiais para Capas de Dispositivos', 1, 'E'),
('E-0032', 'Componentes para Mouse sem Fio', 1, 'E'),
('E-0033', 'Componentes para Teclado sem Fio', 1, 'E'),
('E-0034', 'Circuitos para Hubs USB 3.0', 1, 'E'),
('E-0035', 'Componentes de Teclados Mecânicos', 1, 'E'),
('E-0036', 'Cabos de Áudio de Alta Qualidade', 1, 'E'),
('E-0037', 'Componentes de Conexão Bluetooth', 1, 'E'),
('E-0038', 'Materiais para Capas de Tablets', 1, 'E'),
('E-0039', 'Plástico para Mousepads', 1, 'E'),
('E-0040', 'Componentes para Adaptadores VGA-DVI', 1, 'E'),
('E-0041', 'Componentes para Adaptadores HDMI-VGA', 1, 'E'),
('E-0042', 'Mídias Graváveis', 1, 'E'),
('E-0043', 'Materiais para Microfones', 1, 'E'),
('E-0044', 'Materiais para Caixas de Som', 1, 'E'),
('E-0045', 'Materiais para Headsets', 1, 'E'),
('E-0046', 'Componentes para Projetos de Circuitos', 1, 'E'),
('E-0047', 'Materiais para Produtos Eletrônicos', 1, 'E');

-- Plásticos e Materiais Sintéticos (PM)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('PM-0001', 'Plástico ABS', 1, 'PM'),
('PM-0002', 'Metal para Componentes', 1, 'PM'),
('PM-0003', 'Plástico para Carcaças de Periféricos', 1, 'PM');

-- Metais e Componentes de Hardware (MH)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('MH-0001', 'Metal para Componentes', 1, 'MH'),
('MH-0002', 'Estrutura de Aço para Gabinetes', 1, 'MH');

-- Vidro (V)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('V-0001', 'Painéis de Vidro para Monitores', 1, 'V');

-- Cabos e Fios (CF)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('CF-0001', 'Cabo de Conexão', 1, 'CF'),
('CF-0002', 'Fios de Energia', 1, 'CF');

-- Energia e Alimentação (EA)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('EA-0001', 'Cobertura de Silicone para Fios', 1, 'EA'),
('EA-0002', 'Baterias para No-Breaks', 1, 'EA');

-- Periféricos e Acessórios (PA)
INSERT INTO [MateriaPrima] ([CodigoMp], [Nome], [isAtivo], [CodigoTipo]) VALUES
('PA-0001', 'Conectores de Rede', 1, 'PA'),
('PA-0002', 'Componentes de Áudio para Caixas de Som', 1, 'PA'),
('PA-0003', 'Materiais para Cadeiras Gamer', 1, 'PA');

-- Continue para outros tipos de materiais, se necessário...


INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (1, 'Placa de Circuito Integrado', 1, 'Teclado', 2),
       (2, 'Placa de Circuito Impresso', 1, 'Teclado', 1),
       (3, 'Plástico ABS', 1, 'Teclado', 1);

-- Mouse
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (4, 'Metal para Componentes', 2, 'Mouse', 2),
       (5, 'Painéis de Vidro para Monitores', 2, 'Mouse', 1),
       (6, 'Circuitos de Memória', 2, 'Mouse', 1);

-- Monitor
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (7, 'Componentes de Resfriamento', 3, 'Monitor', 2),
       (8, 'Cabo de Conexão', 3, 'Monitor', 1),
       (9, 'Cobertura de Silicone para Fios', 3, 'Monitor', 1);

-- Placa de Vídeo
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (10, 'Estrutura de Aço para Gabinetes', 4, 'Placa de Vídeo', 2),
       (11, 'Cristal Líquido para Monitores', 4, 'Placa de Vídeo', 1),
       (12, 'Plástico para Carcaças de Periféricos', 4, 'Placa de Vídeo', 1);

-- Processador
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (13, 'Componentes de Energia para Fontes', 5, 'Processador', 2),
       (14, 'Conectores de Rede', 5, 'Processador', 1),
       (15, 'Componentes de Áudio para Caixas de Som', 5, 'Processador', 1);

-- Memória RAM
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (16, 'Materiais para Fones de Ouvido', 6, 'Memória RAM', 2),
       (17, 'Materiais para Cadeiras Gamer', 6, 'Memória RAM', 1),
       (18, 'Materiais para Mesas de Computador', 6, 'Memória RAM', 1);

-- SSD
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (19, 'Painéis de Vidro para Monitores', 7, 'SSD', 2),
       (20, 'Componentes de Resfriamento', 7, 'SSD', 1),
       (21, 'Circuitos de Memória', 7, 'SSD', 1);

-- HDD
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (22, 'Componentes de Energia para Fontes', 8, 'HDD', 2),
       (23, 'Conectores de Rede', 8, 'HDD', 1),
       (24, 'Componentes de Áudio para Caixas de Som', 8, 'HDD', 1);

-- Placa Mãe
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (25, 'Componentes para Mouse sem Fio', 9, 'Placa Mãe', 2),
       (26, 'Componentes para Teclado sem Fio', 9, 'Placa Mãe', 1),
       (27, 'Circuitos para Hubs USB 3.0', 9, 'Placa Mãe', 1);

-- Gabinete
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (28, 'Componentes de Teclados Mecânicos', 10, 'Gabinete', 2),
       (29, 'Cabos de Áudio de Alta Qualidade', 10, 'Gabinete', 1),
       (30, 'Componentes de Conexão Bluetooth', 10, 'Gabinete', 1);
	   -- Fonte de Alimentação
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (31, 'Componentes para Projetos de Circuitos', 11, 'Fonte de Alimentação', 2),
       (32, 'Materiais para Produtos Eletrônicos', 11, 'Fonte de Alimentação', 1),
       (33, 'Cabos de Áudio de Alta Qualidade', 11, 'Fonte de Alimentação', 1);

-- Cooler
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (34, 'Componentes de Conexão Bluetooth', 12, 'Cooler', 2),
       (35, 'Materiais para Capas de Tablets', 12, 'Cooler', 1),
       (36, 'Plástico para Mousepads', 12, 'Cooler', 1);

-- Cabo HDMI
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (37, 'Componentes para Adaptadores VGA-DVI', 13, 'Cabo HDMI', 2),
       (38, 'Componentes para Adaptadores HDMI-VGA', 13, 'Cabo HDMI', 1),
       (39, 'Mídias Graváveis', 13, 'Cabo HDMI', 1);

-- Adaptador USB
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (40, 'Materiais para Microfones', 14, 'Adaptador USB', 2),
       (41, 'Materiais para Caixas de Som', 14, 'Adaptador USB', 1),
       (42, 'Materiais para Headsets', 14, 'Adaptador USB', 1);

-- Roteador
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (43, 'Componentes para Projetos de Circuitos', 15, 'Roteador', 2),
       (44, 'Materiais para Produtos Eletrônicos', 15, 'Roteador', 1),
       (45, 'Circuitos para Hubs USB', 15, 'Roteador', 1);

-- E assim por diante...
-- Webcam
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (46, 'Materiais para Projetos de Circuitos', 16, 'Webcam', 2),
       (47, 'Materiais para Produtos Eletrônicos', 16, 'Webcam', 1),
       (48, 'Cabos de Áudio de Alta Qualidade', 16, 'Webcam', 1);

-- Headset
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (49, 'Componentes de Conexão Bluetooth', 17, 'Headset', 2),
       (50, 'Materiais para Capas de Tablets', 17, 'Headset', 1),
       (48, 'Plástico para Mousepads', 17, 'Headset', 1);

	   SELECT * FROM MateriaPrima
	   select * from MateriasUsadasNoProduto
-- Caixas de Som
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (43, 'Componentes para Adaptadores VGA-DVI', 18, 'Caixas de Som', 2),
       (48, 'Componentes para Adaptadores HDMI-VGA', 18, 'Caixas de Som', 1),
       (20, 'Mídias Graváveis', 18, 'Caixas de Som', 1);

-- Pendrive
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (3, 'Plástico ABS', 19, 'Pendrive', 2),
       (2, 'Placa de Circuito Impresso', 19, 'Pendrive', 1),
       (6, 'circuitos de memória', 19, 'Pendrive', 1);

	   SELECT * FROM MateriaPrima
-- Cartão de Memória
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES (3, 'Plástico ABS', 20, 'Cartão de Memória', 2),
       (49, 'Componentes para Projetos de Circuitos', 20, 'Cartão de Memória', 1),
       (29, 'Mídias de Armazenamento', 20, 'Cartão de Memória', 1);

-- E assim por diante...
-- Cadeira Gamer
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (1, 'Placa de Circuito Integrado', 21, 'Cadeira Gamer', 2),
    (2, 'Placa de Circuito Impresso', 21, 'Cadeira Gamer', 1),
    (3, 'Plástico ABS', 21, 'Cadeira Gamer', 1);

-- Mesa para Computador
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (4, 'Metal para Componentes', 22, 'Mesa para Computador', 2),
    (5, 'Painéis de Vidro para Monitores', 22, 'Mesa para Computador', 1),
    (6, 'Circuitos de Memória', 22, 'Mesa para Computador', 1);

-- Estabilizador
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (7, 'Componentes de Resfriamento', 23, 'Estabilizador', 2),
    (8, 'Cabo de Conexão', 23, 'Estabilizador', 1),
    (9, 'Cobertura de Silicone para Fios', 23, 'Estabilizador', 1);

-- No-Break
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (10, 'Estrutura de Aço para Gabinetes', 24, 'No-Break', 2),
    (11, 'Cristal Líquido para Monitores', 24, 'No-Break', 1),
    (12, 'Plástico para Carcaças de Periféricos', 24, 'No-Break', 1);

-- E assim por diante...
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (13, 'Componentes de Energia para Fontes', 25, 'Hub USB', 2),
    (14, 'Conectores de Rede', 25, 'Hub USB', 1),
    (15, 'Componentes de Áudio para Caixas de Som', 25, 'Hub USB', 1);

-- Impressora
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (16, 'Materiais para Fones de Ouvido', 26, 'Impressora', 2),
    (17, 'Materiais para Cadeiras Gamer', 26, 'Impressora', 1),
    (18, 'Materiais para Mesas de Computador', 26, 'Impressora', 1);

-- Scanner
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (19, 'Painéis de LED para Monitores', 27, 'Scanner', 2),
    (20, 'Componentes de Impressão para Impressoras', 27, 'Scanner', 1),
    (21, 'Materiais para Roteadores', 27, 'Scanner', 1);

-- Projetor
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (22, 'Componentes de Digitalização para Scanners', 28, 'Projetor', 2),
    (23, 'Lentes para Webcams', 28, 'Projetor', 1),
    (24, 'Materiais para Projetores', 28, 'Projetor', 1);

-- Cabo de Rede
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (25, 'Materiais para Estabilizadores', 29, 'Cabo de Rede', 2),
    (26, 'Baterias para No-Breaks', 29, 'Cabo de Rede', 1),
    (27, 'Circuitos para Hubs USB', 29, 'Cabo de Rede', 1);

-- Fone de Ouvido
-- Substitua os valores a seguir com os IDs e nomes de matérias-primas corretos
INSERT INTO [MateriasUsadasNoProduto] ([idMateriaPrima], [NomeMp], [idProduto], [NomeProduto], [Quantidade]) 
VALUES 
    (28, 'Componentes de Conexão para Adaptadores', 30, 'Fone de Ouvido', 2),
    (29, 'Mídias de Armazenamento', 30, 'Fone de Ouvido', 1),
    (30, 'Materiais para Leitores de Cartão', 30, 'Fone de Ouvido', 1);

-- Tabela de EstoqueMateriaPrima
INSERT INTO [EstoqueMateriaPrima] ([IdMateriaPrima], [NomeMp], [Quantidade]) 
VALUES (1, 'Placa de Circuito Integrado', 100),
       (2, 'Placa de Circuito Impresso', 100),
       (3, 'Plástico ABS', 200),
       (4, 'Metal para Componentes', 150),
       (5, 'Painéis de Vidro para Monitores', 80),
       (6, 'Circuitos de Memória', 120),
       (7, 'Componentes de Resfriamento', 100),
       (8, 'Cabo de Conexão', 300),
       (9, 'Cobertura de Silicone para Fios', 250),
       (10, 'Estrutura de Aço para Gabinetes', 100),
       (11, 'Cristal Líquido para Monitores', 120),
       (12, 'Plástico para Carcaças de Periféricos', 150),
       (13, 'Componentes de Energia para Fontes', 100),
       (14, 'Conectores de Rede', 200),
       (15, 'Componentes de Áudio para Caixas de Som', 150),
       (16, 'Materiais para Fones de Ouvido', 200),
       (17, 'Materiais para Cadeiras Gamer', 80),
       (18, 'Materiais para Mesas de Computador', 100),
       (19, 'Painéis de LED para Monitores', 80),
       (20, 'Componentes de Impressão para Impressoras', 120),
       (21, 'Materiais para Roteadores', 150),
       (22, 'Componentes de Digitalização para Scanners', 100),
       (23, 'Lentes para Webcams', 120),
       (24, 'Materiais para Projetores', 150),
       (25, 'Materiais para Estabilizadores', 200),
       (26, 'Baterias para No-Breaks', 100),
       (27, 'Circuitos para Hubs USB', 300),
       (28, 'Componentes de Conexão para Adaptadores', 250),
       (29, 'Mídias de Armazenamento', 100),
       (30, 'Materiais para Leitores de Cartão', 150),
       (31, 'Componentes de Rede', 200),
       (32, 'Fios de Energia', 250),
       (33, 'Materiais para Limpeza', 200),
       (34, 'Materiais para Capas de Dispositivos', 150),
       (35, 'Componentes para Mouse sem Fio', 100),
       (36, 'Componentes para Teclado sem Fio', 120),
       (37, 'Circuitos para Hubs USB 3.0', 150),
       (38, 'Componentes de Teclados Mecânicos', 80),
       (39, 'Cabos de Áudio de Alta Qualidade', 100),
       (40, 'Componentes de Conexão Bluetooth', 80),
       (41, 'Materiais para Capas de Tablets', 120),
       (42, 'Plástico para Mousepads', 150),
       (43, 'Componentes para Adaptadores VGA-DVI', 100),
       (44, 'Componentes para Adaptadores HDMI-VGA', 150),
       (45, 'Mídias Graváveis', 200),
       (46, 'Materiais para Microfones', 250),
       (47, 'Materiais para Caixas de Som', 300),
       (48, 'Materiais para Headsets', 200),
       (49, 'Componentes para Projetos de Circuitos', 150),
       (50, 'Materiais para Produtos Eletrônicos', 100);

-- Tabela de EstoqueProdutoAcabado
INSERT INTO [EstoqueProdutoAcabado] ([IdProduto], [NomeProduto], [Quantidade]) 
VALUES (1, 'Teclado', 200),
       (2, 'Mouse', 150),
       (3, 'Monitor', 80),
       (4, 'Placa de Vídeo', 120),
       (5, 'Processador', 100),
       (6, 'Memória RAM', 150),
       (7, 'SSD', 200),
       (8, 'HDD', 150),
       (9, 'Placa Mãe', 100),
       (10, 'Gabinete', 150),
       (11, 'Fonte de Alimentação', 100),
       (12, 'Cooler', 200),
       (13, 'Cabo HDMI', 300),
       (14, 'Adaptador USB', 250),
       (15, 'Roteador', 100),
       (16, 'Webcam', 120),
       (17, 'Headset', 150),
       (18, 'Caixas de Som', 200),
       (19, 'Pendrive', 150),
       (20, 'Cartão de Memória', 100),
       (21, 'Cadeira Gamer', 120),
       (22, 'Mesa para Computador', 80),
       (23, 'Estabilizador', 100),
       (24, 'No-Break', 150),
       (25, 'Hub USB', 200),
       (26, 'Impressora', 250),
       (27, 'Scanner', 300),
       (28, 'Projetor', 200),
       (29, 'Cabo de Rede', 150),
       (30, 'Fone de Ouvido', 100);

--INSERT INTO [TipoAcesso] ([CodTipoAcesso],[TipoAcesso]) VALUES('ADM','Administrador');
INSERT INTO [Usuario] ([Login],[Senha])VALUES('pedro.oliveira','qHglmt4xG9LGmYUgcgEqbA==');
	   
--INSERT INTO [TipoAcesso]([CodTipoAcesso],[TipoAcesso])VALUES('VEN','Vendas')
--INSERT INTO [TipoAcesso]([CodTipoAcesso],[TipoAcesso])VALUES('FIN','Financeiro')
--INSERT INTO [TipoAcesso]([CodTipoAcesso],[TipoAcesso])VALUES('SUP','Suprimentos')
--INSERT INTO [TipoAcesso]([CodTipoAcesso],[TipoAcesso])VALUES('FAB','Fabricação')

INSERT INTO [Acessos]([Login],[CodAcesso])VALUES('pedro.oliveira','ADM');