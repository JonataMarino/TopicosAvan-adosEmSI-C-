using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoEmSala1
{
	class Cliente
	{
		public int Id { get; set; }
		public string Nome { get; set; }
		public string telefone { get; set;}
		public string NomePai { get; set;}
		public string NomeMae { get; set;}
		public Endereco Endereco { get; set;}

		public override string ToString()
		{
			return "\nID: " + Id +
				"\nNome: " + Nome +
				"\nTelefone: " + telefone +
				"\nNome do Pai: " + NomePai +
				"\nNome da Mae: " + NomeMae +
				"\nEndereço: " + Endereco;

		}
	}
}
