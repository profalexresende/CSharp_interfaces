// See https://aka.ms/new-console-template for more information
// Utilizando a interface para referenciar objetos de diferentes classes
using interfaces;

IPessoa pessoa1 = new Cliente { Nome = "João" };
pessoa1.Apresentar();

IPessoa pessoa2 = new Funcionario { Nome = "Maria" };
pessoa2.Apresentar();
