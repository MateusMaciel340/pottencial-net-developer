using heranca_polimorfismo.Models;

// [1.2]: Herança na prática

Aluno aluno = new Aluno();

aluno.Nome = "Mateus";
aluno.Idade = 20;
aluno.Email = "mateus@gmail.com";
aluno.Nota = 7.8;
aluno.Apresentar();

Console.WriteLine("------------------");

// [1.5]: Polimorfismo em tempo de execução

Professor professor = new Professor();
professor.Nome = "João";
professor.Idade = 34;
professor.Salario = 3200;
professor.Apresentar();