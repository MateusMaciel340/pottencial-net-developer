/* [1.2]: Constraint NOT NULL */

SELECT * FROM Produtos;

INSERT INTO "Produtos" (Nome, Tamanho, Genero, DataCadastro)
VALUES ('Nome', 'G', 'M', GETDATE());

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Nome', 10, 'G', 'M', GETDATE());

/* [1.3]: Constraint UNIQUE */

SELECT * FROM Produtos;

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Produto Teste', 10, 'G', 'M', GETDATE());

ALTER TABLE "Produtos" ADD UNIQUE (Nome);

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Mountain Bike Socks, M', 10, 'G', 'M', GETDATE());

/* [1.4]: Constraint CHECK */

SELECT * FROM "Produtos";

ALTER TABLE "Produtos"
ADD CONSTRAINT CHK_ColunaGenero CHECK(Genero = 'U' OR Genero = 'M' 0R Genero = 'F');

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero, DataCadastro)
VALUES ('Mountain Bike Socks, M', 10, 'G', 'Z', GETDATE());

/* [1.5]: Constraint DEFAULT */

SELECT * FROM "Produtos";

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero)
VALUES ('Mountain Bike Socks, M At', 10, 'G', 'U');

ALTER TABLE "Produtos"
ADD DEFAULT GETDATE() FOR DataCadastro;

/* [1.6]: Apagando uma Constraint */

SELECT * FROM "Produtos";

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero)
VALUES ('Mountain Bike Socks, M At3', 10, 'G', 'U');

ALTER TABLE "Produtos"
DROP CONSTRAINT UQ_Produtos_7D8FE3B2D9894E32;

/* [1.7]: Introdução Stored Procedure */

CREATE PROCEDURE InserirNovoProduto
@Nome varchar(255), @Cor varchar(50), @Preco decimal, @Tamanho varchar(5)
@Genero char(1)

AS 

INSERT INTO "Produtos" (Nome, Preco, Tamanho, Genero)
VALUES (@Nome, @Cor, @Preco @Tamanho, @Genero);

/* [1.8]: Chamando nossa Stored Procedure */

EXEC InserirNovoProduto
@Nome = 'NOVO PRODUTO PROCEDURE',
@Cor = 'COLORIDO',
@Preco = 58, 
@Tamanho = 'G',
@Genero = 'U'

/* [1.9]: Stored Procedure com select */

SELECT * FROM "Produtos" WHERE Tamanho = 'M';

CREATE PROCEDURE ObterProdutosTamanho
@TamanhoProduto VARCHAR(5)

AS 

SELECT * FROM "Produtos" WHERE Tamanho = @TamanhoProduto;

EXEC ObterProdutosTamanho 'G';

/* ------------------------------------------------------ */

CREATE PROCEDURE ObterTodosProdutos

AS 

SELECT * FROM "Produtos"

EXEC ObterProdutosTamanho 'G';

/* [1.10]: Functions */

SELECT 
    Nome, 
    Preco,
    FORMAT(Preco - Preco / 100 * 10, 'N2')
FROM "Produtos" WHERE Tamanho = 'M';


CREATE FUNCTION CalcularDesconto(
    @Preco DECIMAL (13, 2),
    @Porcentagem INT
) RETURNS DECIMAL(13, 2)

BEGIN 
    @Preco - @Preco / 100 * @Porcentagem
END

SELECT 
    Nome, 
    Preco,
    dbo.CalcularDesconto(Preco, 10) PrecoComDesconto
FROM "Produtos" WHERE Tamanho = 'M';