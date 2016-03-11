CREATE TABLE [dbo].[Carros]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[IdCategoria] INT NOT NULL,
	[IdMarca] INT NOT NULL,
	[IdTipo] INT NOT NULL,
	[Modelo] NVARCHAR(50) NOT NULL,
	[Ano] INT NOT NULL, 
    [Preco] DECIMAL(18, 2) NOT NULL, 
    [Proprietario] NVARCHAR(50) NOT NULL, 
    [Placa] NVARCHAR(8) NOT NULL, 
    [Cor] NVARCHAR(30) NOT NULL, 
    [Observacoes] NVARCHAR(MAX) NOT NULL, 
    [DataAquisicao] DATETIME NOT NULL, 
    [Foto] NVARCHAR(MAX) NOT NULL, 
    CONSTRAINT [FK_Carros_Marca] FOREIGN KEY ([IdMarca]) REFERENCES [Marca]([Id]), 
    CONSTRAINT [FK_Carros_Tipo] FOREIGN KEY ([IdTipo]) REFERENCES [Tipo]([Id]), 
    CONSTRAINT [FK_Carros_Categoria] FOREIGN KEY ([IdCategoria]) REFERENCES [Categoria]([Id])
)
