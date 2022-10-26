-- Cria��o da tabela
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NULL,
	[Sobrenome] [varchar](255) NULL,
	[Email] [varchar](255) NULL,
	[AceitaComunicados] [bit] NULL,
	[DataCadastro] [datetime2](7) NULL
) ON [PRIMARY]
GO

-- Inser��o de dados
INSERT INTO Clientes VALUES ('Ken','S�nchez','email@email.com',0,'Jan  7 2009 12:00AM')
INSERT INTO Clientes VALUES ('Terri','Duffy','email@email.com',1,'Jan 24 2008 12:00AM')
INSERT INTO Clientes VALUES ('Roberto','Tamburello','email@email.com',0,'Nov  4 2007 12:00AM')
INSERT INTO Clientes VALUES ('Rob','Walters','email@email.com',0,'Nov 28 2007 12:00AM')
INSERT INTO Clientes VALUES ('Gail','Erickson','email@email.com',0,'Dec 30 2007 12:00AM')
INSERT INTO Clientes VALUES ('Jossef','Goldberg','email@email.com',0,'Dec 16 2013 12:00AM')
INSERT INTO Clientes VALUES ('Dylan','Miller','email@email.com',2,'Feb  1 2009 12:00AM')
INSERT INTO Clientes VALUES ('Diane','Margheim','email@email.com',0,'Dec 22 2008 12:00AM')
INSERT INTO Clientes VALUES ('Gigi','Matthew','email@email.com',0,'Jan  9 2009 12:00AM')
INSERT INTO Clientes VALUES ('Michael','Raheem','email@email.com',2,'Apr 26 2009 12:00AM')