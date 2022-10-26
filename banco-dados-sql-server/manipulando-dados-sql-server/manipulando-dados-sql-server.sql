/* [1.1]: Introdução */
SELECT * FROM "Produtos";

/* [1.2]: Usando o COUNT */
SELECT COUNT(*) QuantidadeProdutos FROM "Produtos";

SELECT COUNT(*) QuantidadeProdutosTamanhoM FROM "Produtos" WHERE Tamanho= 'M';

/* [1.3]: Usando o SUM */

SELECT SUM(Preco) PrecoTotal FROM "Produtos";

SELECT SUM(Preco) PrecoTotalProdutosTamanhoM FROM "Produtos" WHERE Tamanho = 'M';

/* [1.4]: Usando o MIN, MAX e AVG */

SELECT MAX(Preco) ProdutoMaisCaro FROM "Produtos";

SELECT MAX(Preco) ProdutoMaisCaroTamanhoM FROM "Produtos" WHERE Tamanho = 'M';

SELECT MIN(Preco) ProdutoMaisBarato FROM "Produtos";

SELECT MIN(Preco) ProdutoMaisBaratoTamanhoM FROM "Produtos" WHERE Tamanho = 'M';

SELECT AVG(Preco) FROM "Produtos"; /* Média dos Produtos */

/* [1.5]: Concatenando colunas */

SELECT 
    'Nome: ' + Nome + ', Cor: ' + Cor + ', Gênero: ' + Genero NomeCorProdutoGenero
FROM "Produtos";

/* [1.6]: Upper e Lower */

SELECT 
    'Nome: ' + Nome + ', Cor: ' + Cor + ', Gênero: ' + Genero NomeCorProdutoGenero,
    UPPER(Nome) Nome,
    LOWER(Cor) Cor
FROM "Produtos";

/* [1.7]: Adicionando uma nova coluna */

SELECT * FROM "Produtos";

ALTER TABLE "Produtos"
add DataCadastro DATETIME2;

ALTER TABLE "Produtos"
DROP COLUMN DataCadastro;

UPDATE "Produtos" SET DataCadastro = GETDATE();

/* [1.8]: Formatando uma data */

SELECT 
    'Nome: ' + Nome + ', Cor: ' + Cor + ', Gênero: ' + Genero NomeProdutoCompleto,
    UPPER(Nome) Nome,
    LOWER(Cor) Cor,
    FORMAT(DataCadastro, 'dd-MM-yyyy HH:mm') Data
FROM "Produtos";

/* [1.9]: Entendendo o Group By */

SELECT
    Tamanho,
    COUNT(*) Quantidade
FROM "Produtos"
WHERE Tamanho <> ''
GROUP BY Tamanho
ORDER BY Quantidade DESC;

SELECT * FROM "Produtos";

/* [1.9]: Primary Key e Foreign Key */
/* [1.10]: Criando a tabela de Endereços com Foreign Key */

CREATE TABLE Enderecos (
    Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
    IdCliente int NULL,
    Rua VARCHAR(255) NULL,
    Bairro VARCHAR(255) NULL,
    Cidade VARCHAR(255) NULL,
    Estado CHAR(2) NULL,

    CONSTRAINT FK_Enderecos_Clientes FOREIGN KEY (idCliente)
    REFERENCES Clientes(Id)
);

SELECT * FROM "Clientes";

INSERT INTO "Enderecos" VALUES (4, 'Rua Teste', 'Bairro Teste', 'Cidade Teste', 'CE');

SELECT * FROM "Clientes" WHERE Id = 4;
SELECT * FROM "Enderecos" WHERE IdCliente = 4;

/* [1.11]: Realizando um JOIN */

SELECT * FROM "Clientes"
INNER JOIN "Enderecos" ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4;

SELECT 
    Clientes.Nome, Clientes.Sobrenome, Enderecos.Cidade, Enderecos.Estado
FROM "Clientes"
INNER JOIN "Enderecos" ON Clientes.Id = Enderecos.IdCliente
WHERE Clientes.Id = 4;

SELECT 
    C.Nome, C.Sobrenome, E.Cidade, E.Estado
FROM "Clientes" C
INNER JOIN "Enderecos" E ON C.Id = E.IdCliente
WHERE C.Id = 4;