using Primeiro;
using System;
using System.Collections.Generic;
using System.Text;
using CsharpIntro;
using Interface;
using Enum;

// estruturas namespaces, classes, interface, enum
//namespace  - serve para organizar classes
namespace CsharpIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//enum - local e indice
			var pessoa1 = (Pessoas)0;
			Pessoas pessoa2 = Pessoas.João;
			Pessoas pessoa3 = (Pessoas)4;

			//variavel e instanciando objetos
			Pessoa person = new Pessoa();
			person.Nome = "Gabriel";
			person.Idade = 18;
			person.Estado = "MG";

			var person2 = new Pessoa();
			person2.Nome = "Julia";
			person2.Idade = 23;
			person2.Estado = "GO";

			//interface
			Animal animal = new Animal();
			animal.Nome = "Rex";
			animal.NomeDono = "Pedro";
			animal.Especie = "Cachorro";

			//instanciar classes e breakpoints
			var classe = new Classe();
			var classe2 = new Segundo.Classe();

			Console.WriteLine(pessoa3);
		}
	}
}

