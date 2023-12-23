using HerancaPolimorfismo.Interfaces;
using HerancaPolimorfismo.Models;

// Aluno a1 = new Aluno();
// a1.Nome = "Leonardo";
// a1.Idade = 20;
// a1.Email = "teste@teste.com";
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor();
// p1.Nome = "Eduardo";
// p1.Idade = 30;
// p1.Salario = 1000;
// p1.Apresentar();

// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

// Computador c = new Computador();
// Console.WriteLine(c.ToString());

ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3, 9));

