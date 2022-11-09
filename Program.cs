using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "marlon", sobrenome: "Wesley");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso CursoDeInglês = new Curso();
CursoDeInglês.Nome = "Ingles";
CursoDeInglês.Alunos = new List<Pessoa>();

CursoDeInglês.AdicionarAluno(p1);
CursoDeInglês.AdicionarAluno(p2);
CursoDeInglês.ListarAlunos();











































// Pessoa p1 = new Pessoa();
// p1.Nome = "marlon";
// p1.Sobrenome = "Wesley";
// p1.Idade = 39;
// p1.Apresentar();
