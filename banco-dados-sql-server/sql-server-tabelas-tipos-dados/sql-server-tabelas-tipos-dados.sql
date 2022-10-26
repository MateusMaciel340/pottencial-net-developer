/* [1.4]: Criando nossa tabela */

SELECT * FROM "Clientes";

/* [1.5]: Ordenando os resultados */

SELECT * FROM "Clientes"
ORDER BY Sobrenome;

SELECT * FROM "Clientes"
ORDER BY Sobrenome DESC;

SELECT * FROM "Clientes"
ORDER BY Nome, Sobrenome;

/* [1.6]: Selecionando colunas */

SELECT Nome, Sobrenome, Email  FROM "Clientes"
ORDER BY Nome, Sobrenome;

/* [1.7]: Utilizando o Where */

SELECT * FROM "Clientes"
WHERE Nome = 'Brian' AND Sobrenome = 'Welcker' 
ORDER BY Nome, Sobrenome;

SELECT * FROM "Clientes"
WHERE Nome = 'Brian' OR Sobrenome = 'Welcker' 
ORDER BY Nome, Sobrenome;

SELECT * FROM "Clientes"
WHERE AceitaComunicados = 1
ORDER BY Nome, Sobrenome;

/* [1.8]: Utilizando o LIKE  */

SELECT * FROM "Clientes"
WHERE Nome LIKE 'G%'
ORDER BY Nome, Sobrenome;

SELECT * FROM "Clientes"
WHERE Nome LIKE '%G%'
ORDER BY Nome, Sobrenome;

/* [1.9]: Realizando um INSERT */

INSERT INTO "Clientes" 
(Nome, Sobrenome, Email, AceitaComunicados, DataCadastro)
VALUES ('Mateus', 'Maciel', 'mateus@gmail.com', 1, GETDATE());

SELECT * FROM "Clientes"
WHERE Nome = 'Mateus';

/* [1.10]: Insert omitindo as colunas */

INSERT INTO "Clientes" VALUES 
('Mateus1', 'Maciel1', 'maciel@gmail.com', 1, GETDATE());

SELECT * FROM "Clientes"
WHERE Nome = 'Mateus1';

/* [1.12]: Realizando um Update */

SELECT * FROM "Clientes" WHERE Id = 773;

UPDATE "Clientes" 
SET Email = 'emailatualizado@email.com',
AceitaComunicados = 0
WHERE Id = 773;

/* [1.13]: Cuidados com o Update */

SELECT * FROM "Clientes";

BEGIN TRAN 
ROLLBACK;

UPDATE "Clientes" 
SET Email = 'emailatualizado@email.com',
AceitaComunicados = 0,
Sobrenome = 'Maciel';

/* [1.14]: Deletando um registro */

SELECT * FROM "Clientes" WHERE Nome = 'Mateus';

DELETE Clientes WHERE Id = 772;

/* [1.16]: Criando uma tabela */

CREATE TABLE ProdutosDois (
    Id int IDENTITY (1,1) NOT NULL,
    Nome VARCHAR(255) NOT NULL,
    Cor VARCHAR(50) NULL,
    Preco DECIMAL(13, 2) NOT NULL,
    Tamanho VARCHAR(5) NULL, 
    Genero CHAR(1) NULL
);

SELECT * FROM "ProdutosDois";