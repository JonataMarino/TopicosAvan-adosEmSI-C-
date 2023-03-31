using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_27_03_2023
{
	public class Pessoa : IPessoa
	{
		public string Nome { get; set; }
		public int Idade { get; set; }
		public string Endereco { get; set; }

		public int retornaIdade()
		{
			this.Idade = Idade;
			return this.Idade;
			//throw new NotImplementedException();
		}
		public override string ToString()
		{
			return $"O indivíduo {Nome} tem {Idade} anos de idade! ";
		}
	}
}
