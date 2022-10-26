DROP TABLE IF EXISTS dbo.Produtos

CREATE TABLE Produtos (
	Id int IDENTITY(1,1) PRIMARY KEY NOT NULL,
	Nome varchar(255) NOT NULL,
	Cor varchar(50) NULL,
	Preco decimal(13, 2) NOT NULL,
	Tamanho varchar(5) NULL,
	Genero char(1) NULL
)

INSERT INTO Produtos VALUES ('Mountain Bike Socks, M','Branco','9.50','M','U')
INSERT INTO Produtos VALUES ('Mountain Bike Socks, L','Branco','9.50','G','U')
INSERT INTO Produtos VALUES ('AWC Logo Cap','Colorido','8.99','','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, S','Colorido','49.99','P','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, M','Colorido','49.99','M','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, L','Colorido','49.99','G','U')
INSERT INTO Produtos VALUES ('Long-Sleeve Logo Jersey, XL','Colorido','49.99','GG','U')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, S','Preto','59.99','P','M')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, M','Preto','59.99','M','M')
INSERT INTO Produtos VALUES ('Mens Sports Shorts, L','Preto','59.99','G','M')