using comentarios_boas_praticas.Models;

// 9 - [1.2]: Comentários de linha única

// Instância da classe pessoa
Pessoa pessoa = new Pessoa();

// Atribui o nome e idade para pessoa
pessoa.Nome = "Mateus";
pessoa.Idade = 21;

// Faz a pessoa se apresentar
pessoa.Apresentar();

// 9 - [1.3]: Comentários de múltiplas linhas

/*
 * 1 - Instância da classe pessoa
 * 2 - Atribui o nome e idade para pessoa
 * 3 - Faz a pessoa se apresentar
 */

/* Imagine o código acima escrito aqui */

// 9 - [1.5]: Comentários nos métodos
Calculadora calc = new Calculadora();

calc.Somar(2, 3);
calc.Subtrair(10, 2);