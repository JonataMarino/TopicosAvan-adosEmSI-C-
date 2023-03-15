using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ExercicoEmSala1
{
	internal class Endereco
	{
		public int Id { get; set; }
		public string Logradouro { get; set; }
		public string Bairro { get; set; }
		public int Numero { get; set; }
		public string Complemento { get; set; }
		public int Cep { get; set; }


		public override string ToString()
		{
			return "ID: " + Id +
				"\nLogradouro: " + Logradouro +
				"\nBairro: " + Bairro +
				"\nNúmero: " + Numero +
				"\nComplemento: " + Complemento +
				"\nCEP: " + Cep;

		}

	}
}
