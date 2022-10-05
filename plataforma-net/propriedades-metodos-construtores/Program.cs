using propriedades_metodos_construtores.Models;

// [1.4]: Criando um método

/* Pessoa pessoa = new Pessoa();
pessoa.Nome = "Mateus";

// [1.9]: Propriedades somente leitura
pessoa.Sobrenome = "Maciel";

pessoa.Idade = 21;

// [1.8] Modificadores de acesso

pessoa._nome;

pessoa.Apresentar(); */

// [1.14]: Implementando o método de listar alunos

/* Pessoa pessoa = new Pessoa();
pessoa.Nome = "Mateus";
pessoa.Sobrenome = "Maciel";

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Marcelo";
pessoa1.Sobrenome = "Nunes";

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa);
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.ListarAlunos();  */

// [1.15]: Trabalhando com construtores

Pessoa pessoa = new Pessoa("Mateus", "Maciel");

// [1.16]: Implementando construtor
Pessoa pessoa1 = new Pessoa(nome: "Marcelo", sobrenome: "Nunes Silva");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Inglês";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(pessoa);
cursoDeIngles.AdicionarAluno(pessoa1);
cursoDeIngles.ListarAlunos(); 