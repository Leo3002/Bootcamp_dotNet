using PropriedadesMetodosConstrutores.Models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = new Pessoa(nome: "eduardo", sobrenome: "Neves");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();
cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();

// Pessoa p1 = new Pessoa();

// p1.Nome = "Lucas";
// p1.Sobrenome = "Leonette";
// p1.Idade = 20;
// p1.Apresentar();
